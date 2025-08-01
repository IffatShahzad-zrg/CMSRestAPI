using CMSRestAPI.Data;
using CMSRestAPI.Interfaces;
using CMSRestAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using static Azure.Core.HttpHeader;

namespace CMSRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {      

        private readonly IEmailSender _emailSender;
        private readonly CmsiContext _dbContext;
        private readonly SmsContext _smsDBContext;
        private readonly AppSettings _appSettings;

        public TicketController(
            CmsiContext context,
            SmsContext smsDBContext,
            IEmailSender emailSender,
            IOptions<AppSettings> appSetting)
        {
            _dbContext = context;
            _smsDBContext = smsDBContext;
            _emailSender = emailSender;
            _appSettings = appSetting.Value;
        }

        [HttpGet("sayHello")]
        public string sayHello()
        {
            return "ZRG International Pvt. Ltd.";
        }

       
        [HttpGet("GetTicketStatus")] 
        public string GetTicketStatus(int ticketid)
        {
             try
            {
                //////logger.logActivity(fileName, "GetTicketStatus", "GetTicketStatus API called with TicketId: " + ticketid);
                string? ComplaintStatus = _dbContext.Complaints.Where(c => c.ComplaintId == ticketid).Select(c => c.JobStatus).FirstOrDefault();



                if (ComplaintStatus == "" || ComplaintStatus == null)
                {
                    ////logger.logActivity(fileName, "GetTicketStatus", "Ticket ID does not exist: " + ticketid);

                    return "Ticket ID does not exist";
                }
                else
                {
                    //string str = JsonConvert.SerializeObject(ComplaintStatus);
                    ////logger.logActivity(fileName, "GetTicketStatus", "JobStatus returned for the ticketid: " + ticketid + " is " + ComplaintStatus);
                    return ComplaintStatus;
                }

            }
            catch (Exception ex)
            {
                ////logger.catchFunc(fileName, "GetTicketStatus", ex);
                return "Exception: " + ex.Message;
            }

        }
       
        [HttpPost("TicketRegistration")]
        public string TicketRegistration(string ComplaintCategory, string ComplaintItem, string? LPGSize, string? LPGQuantity,
           string CRN, string FullName, string CustomerCardNumber, string? Fathername, string? Gender, string Address, string MobileNumber, string EmailAddress,
           string UserName, string? DOB, string? ComplaintSource, string? Department, string? Notes, int? Rating, string CustomerCity, string? StationName, string? FilePath)//,
        {
        
            try
            {
                //logger.logActivity(fileName, "TicketRegistration", "TicketRegistration API called with parameters, ComplaintCategory: " + ComplaintCategory +
                    //", ComplaintItem: " + ComplaintItem +
                    //", LPGSize: " + LPGSize + ", LPGQuantity: " + LPGQuantity + ", CRN: " + CRN + ", FullName: " + FullName + ", CustomerCardNumber: " + CustomerCardNumber +
                    //", Fathername: " + Fathername
                    // + ", Gender: " + Gender + ", Address: " + Address + ", MobileNumber: " + MobileNumber + ", EmailAddress: " + EmailAddress + ", UserName: " + UserName
                    //+ ", DOB: " + DOB + ", ComplaintSource: " + ComplaintSource + ", Department: " + Department + ", Notes: " + Notes + ", Rating: " + Rating +
                    //", CustomerCity: " + CustomerCity + ", StationName: " + StationName + ", FilePath: " + FilePath);

                String ComplaintStatus = "";

                
                bool ok = false;

                if (CRN == "" || string.IsNullOrEmpty(CRN))
                {
                    //logger.logActivity(fileName, "TicketRegistration", "Returning -- CRN not provided.");
                    return "CRN not provided.";
                }
                //logger.logActivity(fileName, "TicketRegistration", "Checking CRN in Contacts table");

                var dt = _dbContext.Contacts.Where(c => c.Crn == CRN).Select(c => c).ToList();


                if (dt == null || dt.Count == 0)
                {
                    //logger.logActivity(fileName, "TicketRegistration", "Contact not found");
                    ok = InsertContacts(CRN.Trim(), FullName, CustomerCardNumber, Fathername, Gender, Address, MobileNumber, EmailAddress, UserName, DOB, CustomerCity);


                    if (!ok)
                    {
                        //logger.logActivity(fileName, "TicketRegistration", "Returning -- Contact record not inserted due to invalid contact information.");
                        return "Contact record not inserted due to invalid contact information.";
                    }
                }
                else
                {
                    string? StageTAT = "", TotalTAT = "", RouteToDepart = "", RouteToUser = "", emailcc = "", CustCode = "", StationAddress = "", Division = "";
                    int TotalEscalationLevels = 0, RoutingId = 0, TotalStages = 0;

                    DateTime StageEscalationTime;
                    //logger.logActivity(fileName, "TicketRegistration", "Checking complaint item details");

                    var dtCompItems = _dbContext.ComplaintItems.Where(ci => ci.ComplaintType == "Complaints" && ci.Category == ComplaintCategory && ci.ComplaintItem1 == ComplaintItem)
                        .Select(ci => ci).ToList();
                  
                    if (dtCompItems.Count > 0 && dtCompItems.Count == 1)
                    {
                        
                        //logger.logActivity(fileName, "TicketRegistration", "Checking routing and stages details");

                        var Stageitems = _dbContext.Stages.Where(s => s.RoutingId == dtCompItems[0].RuleId && s.StageNo == 1).Select(s => s).ToList(); 
                        var RoutingItems = _dbContext.Routings.Where(r => r.RoutingId == dtCompItems[0].RuleId).Select(r => r).ToList(); 

                        Division = dtCompItems.FirstOrDefault()?.DivisionName?.ToString() ?? string.Empty;

                        if (Stageitems.Count > 0)
                        {
                            var dtStations = _dbContext.Stations.Where(s => s.StationName == StationName).Select(s => s).ToList();
                            
                            if (dtStations.Count == 0 || dtStations == null)
                            {
                                StationName = "Others";
                                StationAddress = "Others";
                                CustCode = "Others";
                            }

                            else
                            {
                                CustCode = dtStations[0].CustomerCode.ToString();
                                StationAddress = dtStations[0].StationAddress.ToString();
                            }

                            RouteToDepart = Stageitems[0].RouteToDepartment.ToString();
                            StageTAT = Stageitems[0].StageTat.ToString();
                            TotalTAT = RoutingItems[0].TotalStagesTat;
                            TotalStages = (int)RoutingItems[0].TotalStages;
                            RoutingId = RoutingItems[0].RoutingId;
                            TotalEscalationLevels = (int)Stageitems[0].TotalEscalationLevels;

                            var dtSE = _dbContext.StageEscalations.Where(se => se.EscalationRuleName == Stageitems[0].EscalationRule && se.EscalationLevel == 1).Select(se => se).ToList();

                            if (dtSE == null || dtSE.Count == 0)
                            {
                                //logger.logActivity(fileName, "TicketRegistration", "Returning -- EscalationRuleName not defined.");
                                return "EscalationRuleName not defined.";
                            }
                            else
                            {
                                StageEscalationTime = AddEscDays(dtSE[0].EscalationLevelTat.ToString(), false);
                                RouteToUser = GetEmailAddresses(dtSE[0].EmailGroupToName.ToString());
                                emailcc = GetEmailAddresses(dtSE[0].EmailGroupCcname.ToString());
                            }                            
                        }
                        else
                        {
                            //logger.logActivity(fileName, "TicketRegistration", "Returning -- Stages not defined.");
                            return "Stages not defined.";
                        }
                    }
                    else if(dtCompItems.Count > 1)
                    {
                        //logger.logActivity(fileName, "TicketRegistration", "Returning -- Multiple rows found for same category and complaintitem.");
                        return "Multiple rows found for same category and complaintitem.";
                    }
                    else
                    {
                        //logger.logActivity(fileName, "TicketRegistration", "Returning -- Category or Item not defined.");
                        return "Category or Item not defined.";
                    }


                    DateTime TotalResolutionTime = AddEscDays(TotalTAT, true);
                    DateTime StageResolutionTime = AddEscDays(StageTAT, true);

                    string LaunchComplaintFuncValue = LaunchComplaint(ComplaintCategory, ComplaintItem, LPGSize, LPGQuantity, CRN, 
                            FullName, MobileNumber, EmailAddress, Department,RouteToDepart, "backoffice", Notes, UserName, TotalStages,
                            TotalResolutionTime, StageResolutionTime, TotalEscalationLevels, StageEscalationTime,
                            RoutingId, CustomerCardNumber, RouteToUser, emailcc, CustCode, Rating, Division, CustomerCity, StationAddress, StationName, FilePath);

                    if (LaunchComplaintFuncValue.StartsWith("Success^"))
                    {
                        string ComplaintID = LaunchComplaintFuncValue.Split('^')[1].ToString().Split('=')[1].ToString();
                        ComplaintID = ComplaintID.Replace(" ", "");
                        //logger.logActivity(fileName, "TicketRegistration", "Returning -- Complaint launched successfully with complaintId: " + LaunchComplaintFuncValue.Split('^')[1]);

                        string EmailSubject = "Ticket - ID" + ComplaintID;
                        string EmailBody = ReturnEmailBodyForAddComplaints(TotalResolutionTime.ToString(), Address, MobileNumber, FullName, CRN, DateTime.Now.ToString(), ComplaintID, ComplaintCategory, ComplaintItem, EmailAddress, StationAddress, StationName, Notes, Division, CustomerCity, UserName);
                        if (RouteToUser != "")
                        {
                            SendEmail(RouteToUser, emailcc, EmailSubject, EmailBody, FilePath);
                        }
                        if (EmailAddress != "")
                        {
                            SendEmail(EmailAddress, "", EmailSubject, EmailBody, FilePath);
                        }
                        sendMsgToCustomerAndNonCustomer(ComplaintID, MobileNumber, ComplaintCategory, Division, FullName, TotalResolutionTime);

                        ComplaintStatus = "ComplaintID " + LaunchComplaintFuncValue.Split('^')[1] + " launched successfully";
                    }
                    else
                    {
                        //logger.logActivity(fileName, "TicketRegistration", "Returning -- Complaint not launched due to an error");
                        ComplaintStatus = "Complaint not launched, for details check error log";
                    }
                }

                //string str = JsonConvert.SerializeObject(ComplaintStatus);
                return ComplaintStatus;

            }
            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "TicketRegistration", ex);
                return "Exception: " + ex.Message;
            }

        }


        private string LaunchComplaint(string ComplaintCategory, string ComplaintItem, string LPGSize, string LPGQuantity, string CRN, 
                    string FullName, string MobileNumber, string EmailAddress, string Department,
                    string RouteToDepartment, string RouteToUser, string Notes, string UserName, int TotalStages,
                    DateTime TotalResolutionTime, DateTime StageResolutionTime, int TotalEscalationLevels, DateTime StageEscalationTime,
                    int RoutingID, string CustomerCardNumber, string emailto, string emailcc, string CustCode, int? Rating, string Division, string City,
                    string StationAddress, string StationName, string FilePath)
        {
            try
            {
                string LPGQuantitySize = "";

                if (ComplaintCategory.ToUpper() == "LPG")
                {
                    LPGQuantitySize = "Size: " + LPGSize + ", Quantity: " + LPGQuantity;
                    //logger.logActivity(fileName, "LaunchComplaint", "Complaint category is LPG, " + LPGQuantitySize);
                }

                int ComplaintID = InsertComplaint(CRN, FullName, MobileNumber, EmailAddress,
                    ComplaintCategory, ComplaintItem, RouteToDepartment, RouteToUser, Notes.Replace("'", "`"), UserName,
                    TotalStages, TotalResolutionTime, StageResolutionTime, TotalEscalationLevels, StageEscalationTime, RoutingID, CustomerCardNumber,
                    emailto, emailcc, CustCode, Rating, Division, City, StationAddress, StationName, FilePath);

                if (ComplaintCategory.ToUpper() == "LPG")
                {
                    //createLPG_PDF_From_WordDoc(ComplaintID);
                }

                if (ComplaintID == 0)
                {
                    return "Fail^ComplaintID = 0";
                }
                else
                {
                    if (InsertComplaintDetails(ComplaintID, UserName,Department, RouteToDepartment, UserName, Notes.Replace("'", "`"), FilePath))
                    {
                        if (FilePath != "")
                        {
                            if (!InsertAttachmentDetail(ComplaintID, FilePath))
                            {
                                //logger.logActivity(fileName, "LaunchComplaint", "Error in inserting attachment details");
                            }

                        }
                    }
                    else
                    {
                        return "Fail^ComplaintID = 0";
                    }

                    return "Success^ComplaintID = " + ComplaintID;
                }
            }
            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "LaunchComplaint", ex);
                return "Fail^ComplaintID = 0";
            }
        }

        private int InsertComplaint(string CRN, string FullName, string MobileNumber, string EmailAddress,
                                         string ComplaintCategory, string ComplaintItem,
                                         string RouteToDepartment, string RouteToUser, string Notes,
                                         string CreatedBy, int TotalStages,
                                         DateTime TotalResolutionTime, DateTime StageResolutionTime,
                                         int TotalEscalationLevels, DateTime StageEscalationTime,
                                         int RoutingID, string CustomerCardNumber, string emailto,
                                         string emailcc, string CustCode, int? Rating, string Division, string City, string StationAddress, string StationName, string FilePath)
        {
            try
            {
                string fileName = "";
                byte[]? imageBytes = null;
                if (FilePath != "")
                {
                    fileName = Path.GetFileName(new Uri(FilePath).AbsolutePath);
                    imageBytes = GetImageFromUrl(FilePath);

                    if (imageBytes == null)
                    {
                        imageBytes = Array.Empty<byte>();
                    }
                }
                var CompID = _dbContext.Complaints.Select(c => c.ComplaintId).DefaultIfEmpty(0).Max();

                CompID = CompID + 1;

                //logger.logActivity(fileName, "InsertComplaintPSO", "Inserting complaint into complaints table");

                using (_dbContext)
                {
                    Complaint newComplaint = new Complaint
                    {
                        ComplaintId = CompID,
                        Crn = CRN,
                        ContactPerson = FullName,
                        ContactNumber = MobileNumber,
                        ContactEmail = EmailAddress,
                        ComplaintSource = "Whatsapp",
                        ComplaintType = "Complaints",
                        Category = ComplaintCategory,
                        ComplaintItem = ComplaintItem,
                        Priority = "Medium",
                        JobStatus = "Initiated",
                        AutoRoute = true,
                        RoutedToDepartment = RouteToDepartment,
                        RoutedToUser = RouteToUser,
                        Notes = Notes,
                        CustomerEmotions = "",
                        ActivityCode1 = "Registered",
                        CreatedOn = DateTime.Now,
                        CreatedBy = CreatedBy,
                        TotalStages = TotalStages,
                        TotalResolutionTime = TotalResolutionTime,
                        CurrentStage = 0,
                        StageResolutionTime = StageResolutionTime,
                        StageStatus = "Initiated",
                        TotalEscalationLevels = TotalEscalationLevels,
                        CurrentEscalationLevel = 1,
                        RoutingId = RoutingID,
                        Attachments = fileName,
                        StageEscalationTime = StageEscalationTime,
                        IsEscalationComplete = false,
                        IsAccepted = false,
                        CustomerCode = CustCode,
                        ComplaintRating = Rating,
                        Emailto = emailto,
                        Emailcc = emailcc,
                        AdditionalInfo1 = Division,
                        AdditionalInfo2 = City,
                        AdditionalInfo3 = StationName,
                        AdditionalInfo4 = StationAddress,
                        AdditionalInfo5 = "CRM",
                        AttachmentsData = imageBytes,


                    };
                    _dbContext.Complaints.Add(newComplaint);

                    try
                    {
                        _dbContext.SaveChanges();
                        //logger.logActivity(fileName, "InsertComplaintPSO", "Complaint inserted into complaints table");
                        return (int)CompID;
                    }
                    catch (Exception ex)
                    {
                        //logger.logActivity(fileName, "InsertComplaintPSO", "Complaint not inserted");
                        return 0;

                    }

                }
            }
            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "InsertComplaintPSO", ex);
                return 0;
            }
        }

        private bool InsertComplaintDetails(long ComplaintID, string ActionBy, string Department, string ActionDept,string UserName, string Notes, string FilePath)
        {
            try
            {
                string fileName = "";
                byte[]? imageBytes = null;
                if (FilePath != "")
                {
                    fileName = Path.GetFileName(new Uri(FilePath).AbsolutePath);
                    imageBytes = GetImageFromUrl(FilePath);

                    if (imageBytes == null)
                    {
                        imageBytes = Array.Empty<byte>();
                    }
                }

                                
                //logger.logActivity(fileName, "InsertComplaintDetail", "Inserting data into complaintdetails table");

                using (_dbContext)
                {
                    ComplaintDetail newCompDetail = new ComplaintDetail
                    {
                        ComplaintId = ComplaintID,
                        ActionOn = DateTime.Now,
                        ActionBy = ActionBy,
                        ActionDepartment = ActionDept,
                        Action = "Complaint Launched",
                        JobStatus = "Initiated",
                        StageNo = 0,
                        StageStatus = "New",
                        ActivityCode = "Registered",
                        UserName = UserName,
                        DepartmentName = Department,
                        Notes = Notes,
                        Attachments = fileName,
                        Waitingtime = null,
                        IsHighPriority = "Medium",
                        CustomerEmotions = "",
                        AttachmentsData = null,

                    };
                    _dbContext.ComplaintDetails.Add(newCompDetail);

                    try
                    {
                        _dbContext.SaveChanges();
                        //logger.logActivity(fileName, "InsertComplaintPSO", "Complaint inserted into complaints table");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        //logger.logActivity(fileName, "InsertComplaintPSO", "Complaint not inserted");
                        return false;

                    }                           
                }
            }
            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "InsertComplaintDetail", ex);
                return false;
            }
        }

        private bool InsertContacts(string CRN, string FullName, string CustomerCardNumber, string FatherName, string Gender, string Address, string CellNo,
             string EmailAddress,string CreatedBy, string DOB, string CustomerCity)
        {
            try
            {
                //logger.logActivity(fileName, "InsertContacts", "Inserting into contacts table");
                              
                using (_dbContext)
                {
                    Contact newContact = new Contact
                    {
                        Crn = CRN,
                        Salutation = "",
                        Name = FullName,
                        Cnic = CustomerCardNumber,
                        FathersName = FatherName,
                        Priority = "Medium",
                        Age = 1,
                        Gender = Gender,
                        Address = Address,
                        PhoneNo = "",
                        CellNo = CellNo,
                        FaxNo = "",
                        EmailAddress = EmailAddress,
                        OfficeName = "",
                        Title = "",
                        OfficePhoneNo = "",
                        OfficeAddress = "",
                        IsActive =true,
                        Notes = "",
                        IsCustomer = true,
                        CreatedOn = DateTime.Now,
                        CreatedBy = CreatedBy,
                        Dob = DOB,
                        City = CustomerCity,
                        District = ""

                    };
                    _dbContext.Contacts.Add(newContact);

                    try
                    {
                        _dbContext.SaveChanges();
                        //logger.logActivity(fileName, "InsertContacts", "Contact inserted");
                        return true;
                        
                    }
                    catch (Exception ex)
                    {
                        //logger.logActivity(fileName, "InsertContacts", "Contact not inserted");
                        return false;
                        
                    }
                }
                
            }
            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "InsertContacts", ex);
                return false;
            }
        }

        private DateTime AddEscDays(string HoursToAdd, bool IsEscalationTime)
        {

            string[] Hours = HoursToAdd.Split(':');
            TimeSpan Interval = new TimeSpan(int.Parse(Hours[0]), int.Parse(Hours[1]), int.Parse(Hours[2]));
            HoursToAdd = Interval.Days.ToString();

            DateTime sd = DateTime.Now.Date;
            DateTime std = DateTime.Now;
            DateTime ed = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
            DateTime AddEnddate = new DateTime();
            DateTime TotalMinusDays = new DateTime();
            DateTime MediumDate = new DateTime();
            int MediumDateCount;
            int OffDaysCount = -1;
            int afterAddOffDays;

            if (IsEscalationTime)
            {
                MediumDate = sd.AddDays(int.Parse(HoursToAdd) + 1);
            }
            else
            {
                MediumDate = sd.AddDays(int.Parse(HoursToAdd));
            }

            OffDaysCount = CalcEscOffDays(sd, MediumDate);
            if (OffDaysCount == 0) return MediumDate;

            while (OffDaysCount != 0)
            {
                OffDaysCount = CalcEscOffDays(sd, MediumDate);
                if (OffDaysCount != 0)
                {
                    MediumDateCount = (int)(MediumDate - MediumDate.AddDays(OffDaysCount)).TotalDays;
                    AddEnddate = MediumDate.AddDays(OffDaysCount);

                    afterAddOffDays = CalcEscOffDays(MediumDate.AddDays(1), AddEnddate);
                    TotalMinusDays = AddEnddate.AddDays(afterAddOffDays);
                    if (afterAddOffDays == 0) return TotalMinusDays;
                    sd = TotalMinusDays;
                }

                MediumDate = sd;
            }
            return TotalMinusDays;
        }

        private int CalcEscOffDays(DateTime stDate, DateTime EndDate)
        {
            try
            {
                string Query = string.Empty;
                short totaldays = (short)(EndDate - stDate).TotalDays;
                int OffDaysCount = 0;
                   
                var dtEscOffWeekDays = _dbContext.TblEscalationOffDays.Where(e => e.EscOffType.ToUpper() == "DATE WISE" && e.EscOffActive == true).ToList();


                string OffDays = string.Empty;
                foreach (var item in dtEscOffWeekDays)
                {
                    string weekDay = ("" + item.EscOffValue).Trim();
                    if (!string.IsNullOrEmpty(weekDay))
                    {
                        OffDays += weekDay + ",";
                    }
                }

                string mmddStart = stDate.ToString("MMdd");
                string mmddEnd = EndDate.ToString("MMdd");
                string yyyymmddStart = stDate.ToString("yyyyMMdd");
                string yyyymmddEnd = EndDate.ToString("yyyyMMdd");

               

                if (OffDays.Trim() != "")
                {
                    var dtEscOffDates = _dbContext.TblEscalationOffDays
                   .Where(e => e.EscOffActive == true &&
                       (
                           (e.EscOffType.ToUpper() == "DATE WISE" && string.Compare(e.EscOffValue, mmddStart) >= 0 && string.Compare(e.EscOffValue, mmddEnd) <= 0)
                           ||
                           (e.EscOffType.ToUpper() == "DATE WITH YEAR" && string.Compare(e.EscOffValue, yyyymmddStart) >= 0 && string.Compare(e.EscOffValue, yyyymmddEnd) <= 0)
                       )
                   )
                   .ToList();
                    //Query = $"select * from TblEscalationOffDays where EscOffActive=1 and ((upper(escofftype)='DATE WISE' and escoffvalue between '{stDate.ToString("MMdd")}' and '{EndDate.ToString("MMdd")}') or (upper(escofftype)='DATE WITH YEAR' and escoffvalue between '{stDate.ToString("yyyyMMdd")}' and '{EndDate.ToString("yyyyMMdd")}'))";
                    //dtEscOffDates = ReturnSQLDataTable(Query);

                    foreach (var row in dtEscOffDates)
                    {
                        string EscOffDate = ("" + row.EscOffValue.ToString()).Trim();
                        string EscOffType = ("" + row.EscOffType.ToString()).Trim();

                        switch (EscOffType.ToUpper())
                        {
                            case "DATE WISE":
                                if (EscOffDate.Length == 4)
                                {
                                    EscOffDate = EscOffDate.Substring(0, 2) + "/" + EscOffDate.Substring(2, 2) + "/" + DateTime.Now.Year;
                                }
                                break;
                            case "DATE WITH YEAR":
                                if (EscOffDate.Length == 8)
                                {
                                    EscOffDate = EscOffDate.Substring(4, 2) + "/" + EscOffDate.Substring(6, 2) + "/" + EscOffDate.Substring(0, 4);
                                }
                                break;
                            default:
                                continue;
                        }

                        DateTime parsedDate;
                        if (DateTime.TryParse(EscOffDate, out parsedDate)) // Declare 'parsedDate' outside
                        {
                            if (!OffDays.ToLower().Contains(parsedDate.ToString("ddd").ToLower()))
                            {
                                OffDaysCount++;
                            }
                        }
                    }
                }
                else
                {
                   
                    OffDaysCount = _dbContext.TblEscalationOffDays
                        .Where(e => e.EscOffActive == true &&
                            (
                                (e.EscOffType.ToUpper() == "DATE WISE" &&
                                 string.Compare(e.EscOffValue, mmddStart) >= 0 &&
                                 string.Compare(e.EscOffValue, mmddEnd) <= 0)

                                ||

                                (e.EscOffType.ToUpper() == "DATE WITH YEAR" &&
                                 string.Compare(e.EscOffValue, yyyymmddStart) >= 0 &&
                                 string.Compare(e.EscOffValue, yyyymmddEnd) <= 0)
                            ))
                        .Count();
                    //Query = $"select count(*) as OffDatesCount from TblEscalationOffDays where EscOffActive=1 and ((upper(escofftype)='DATE WISE' and escoffvalue between '{stDate.ToString("MMdd")}' and '{EndDate.ToString("MMdd")}') or (upper(escofftype)='DATE WITH YEAR' and escoffvalue between '{stDate.ToString("yyyyMMdd")}' and '{EndDate.ToString("yyyyMMdd")}'))";

                   // OffDaysCount = dtEscOffDates.Rows[0]["OffDatesCount"]);
                }

                

                if (OffDays.Trim() != "")
                {
                    for (short i = 0; i <= totaldays; i++)
                    {
                        if (OffDays.ToLower().Contains(stDate.AddDays(i).ToString("ddd").ToLower()))
                        {
                            OffDaysCount++;
                        }
                    }
                }

                return OffDaysCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }
             
        private Boolean InsertAttachmentDetail(int ComplaintID, string FilePath)
        {
            try
            {
                string fileName = "";
                byte[]? imageBytes = null;
                if (FilePath != "")
                {
                    fileName = Path.GetFileName(new Uri(FilePath).AbsolutePath);
                    imageBytes = GetImageFromUrl(FilePath);

                    if (imageBytes == null)
                    {
                        imageBytes = Array.Empty<byte>();
                    }
                }

                using (_dbContext)
                {
                    TblAttachmentDetail newAttDetail = new TblAttachmentDetail
                     {
                        ComplaintId = ComplaintID,
                        AttachmentName = fileName,
                        AttachmentData = imageBytes,

                    };
                    _dbContext.TblAttachmentDetails.Add(newAttDetail);

                    try
                    {
                        _dbContext.SaveChanges();
                        //logger.logActivity(fileName, "InsertAttachmentDetail", "Data inserted into tblAttachmentDetail table");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        //logger.logActivity(fileName, "InsertAttachmentDetail", "AttachmentDetails data not inserted");
                        return false;

                    }                    
                }

            }
            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "InsertAttachmentDetail", ex);
                return false;
            }
        }

        private async void SendEmail(string RouteToUser, string emailcc, string EmailSubject, string EmailBody,string FilePath)
        {
            try
            {
                await _emailSender.SendEmailAsync(RouteToUser, emailcc, EmailSubject, EmailBody, FilePath);

                //logger.logActivity(fileName, "SendEmail", "Launching email sent To: " + EmailTO + " ,CC: " + EmailCC + ", Subject: " + EmailSubject);

            }
            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "SendEmail", ex);

            }

        }
        
        string[] nonCustomerNumber;

        public object RegexOptions { get; private set; }

        private void sendMsgToCustomerAndNonCustomer(string complaintID, string cellNo, string category, string division, string name, DateTime TAT)// ComplaintCategory, Division, FullName, TotalResolutionTime
        {
            try
            {
                //if chksmsto.Checked Then


                InsertSmsDetail(formatCellNumber(cellNo), "initiatedCustomer", complaintID, "Initiated-CST", category, division, name, cellNo, TAT);
                //End If

                if (nonCustomerNumber != null)
                {
                    foreach (string n in nonCustomerNumber)
                    {
                        InsertSmsDetail(n, "initiatedManagement", complaintID, "Initiated-MGT", category, division, name, cellNo, TAT);
                    }


                }
            }
            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "sendMsgToNonCustomer", ex);
            }
        }

        private string formatCellNumber(string input)
        {
            try
            {
                string first4Char = (input).Substring(0, 4);

                if (first4Char == "0092")
                    input = "0" + input.Substring(4);
                else if (first4Char.Substring(0, 3) == "+92")
                    input = "0" + input.Substring(3);

                else if (first4Char.Substring(0, 2) == "92")
                    input = "0" + input.Substring(2);

            }

            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "formatCellNumber", ex);
            }

            return input;
        }

        private Boolean InsertSmsDetail(String cellNo, string key, String complaintID, string SMSType, string category, string division, string name, string cell, DateTime TAT)
        {
            Boolean ExecutionResult = false;
            string msg = "";
            try
            {
                if (key == "initiatedManagement")
                    msg = "Ta'aluq T.ID # " + complaintID + " Status: Initiated Category: " + category + " DIV: " + division + " RO: [RO] " + " Customer:" + name + " Cell: " + cell + " TID Date: " + DateTime.Now.ToString() + " TAT: " + TAT;

                else if (key == "initiatedCustomer")
                    msg = "Dear " + name + ",Your ticket ID # " + complaintID + " has been successfully lodged and forwarded to the concerned department for further process. Thank you for your valuable feedback. PSO Ta`aluq Care 0800 - 03000 ";
                

                ExecutionResult = InsertComplaintSmsInfo(msg, cellNo, complaintID, SMSType);

            }
            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "InsertSmsDetail", ex);
            }
            return ExecutionResult;
        }

        private Boolean InsertComplaintSmsInfo(string sms, string phoneNumber, string referenceNO, string SMSType)
        {
            string qry = "";
            try
            {

                using (_smsDBContext)
                {
                    Smsout newSMSEntry = new Smsout
                    {
                        SentDate = DateTime.Now.ToString("dd'/'MM'/'yyyy"),
                        LastTried = "0",
                        SubmissionDate = DateTime.Now.ToString("dd'/'MM'/'yyyy hh:mm tt"),
                        Phoneno = phoneNumber,
                        ToName = "",
                        ToCompany = "PSO",
                        Text = sms,
                        Sent = false,
                        TryCount = 0,
                        SubmittedBy = "Whatsapp",
                        SubmissionTime = DateTime.Now.ToString("hh:mm tt"),
                        SentTime = DateTime.Now.ToString("hh:mm tt"),
                        ReferenceNo = referenceNO,
                        StationId = "0",
                        Priority = 5,
                        Opted = false,
                        ComId = "",
                        Smstype = SMSType,
                    };
                    _smsDBContext.Smsouts.Add(newSMSEntry);

                    try
                    {
                        _dbContext.SaveChanges();
                        //logger.logActivity(fileName, "InsertSmsDetail", "Launching SMS entry made for referenceNO: " + referenceNO);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        //logger.catchFunc(fileName, "InsertSmsDetail", ex);
                        return false;

                    }
                }
            
                
            }
            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "InsertSmsDetail", ex);
                return false;
            }
            
        }


        private string ReturnEmailBodyForAddComplaints(string TotalResolutionTime, string Address, string MobileNumber, string FullName, string CRN, string dDate, string ComplaintID, string ComplaintCategory, string ComplaintItem, string EmailAddress,
            string StationAddress, string StationName, string Notes, string Division, string CustomerCity, string UserName)
        {
            string TemplateContents = "";
            try
            {
                TemplateContents = GetFileContents(Path.Combine(_appSettings.TemplatesPath, "TicketRegistered.html"));

                TemplateContents = TemplateContents.Replace("[CLI]", MobileNumber);
                TemplateContents = TemplateContents.Replace("[CustomerName]", FullName);
                TemplateContents = TemplateContents.Replace("[Address]", Address);
                TemplateContents = TemplateContents.Replace("[OfficeAddress]", "");
                TemplateContents = TemplateContents.Replace("[Product]", "");
                TemplateContents = TemplateContents.Replace("[CNIC]", CRN);
                TemplateContents = TemplateContents.Replace("[HomePhone]", MobileNumber);
                TemplateContents = TemplateContents.Replace("[CellNo]", MobileNumber);
                TemplateContents = TemplateContents.Replace("[Status]", "Initiated");
                TemplateContents = TemplateContents.Replace("[ComplaintID]", ComplaintID);
                TemplateContents = TemplateContents.Replace("[Complaint]", "" + ComplaintItem);
                TemplateContents = TemplateContents.Replace("[SentOn]", dDate);
                TemplateContents = TemplateContents.Replace("[ComplaintCategory]", ComplaintCategory);
                TemplateContents = TemplateContents.Replace("[SentByName]", UserName);
                TemplateContents = TemplateContents.Replace("[StationName]", "" + StationName);
                TemplateContents = TemplateContents.Replace("[StationAddress]", "" + StationAddress);
                TemplateContents = TemplateContents.Replace("[Division]", Division);
                TemplateContents = TemplateContents.Replace("[Notes]", Notes);
                TemplateContents = TemplateContents.Replace("[Vision]", "CRM");
                TemplateContents = TemplateContents.Replace("[Priority]", "Medium");
                TemplateContents = TemplateContents.Replace("[Email]", EmailAddress);
                TemplateContents = TemplateContents.Replace("[LeadTime]", TotalResolutionTime);
                TemplateContents = TemplateContents.Replace("[City]", CustomerCity);
               
            }
            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "ReturnEmailBodyForAddComplaints", ex);
            }
            return TemplateContents;
        }

        private string GetFileContents(string FullPath)
        {
            string strContents = String.Empty;
            StreamReader objReader;
            try
            {
                objReader = new StreamReader(FullPath);
                strContents = objReader.ReadToEnd();
                objReader.Close();
            }
            catch (Exception ex)
            {

                //logger.catchFunc(fileName, "GetFileContents", ex);
            }
            return strContents;
        }

        private string GetEmailAddresses(string EmailGroupName)
        {
            try
            {
                return _dbContext?.EmailAddresses?.Where(e => e.EmailGroupName == EmailGroupName).Select(e => e.EmailAddress1).FirstOrDefault() ?? string.Empty;
            }
            catch (Exception ex)
            {
                //logger.catchFunc(fileName, "GetEmailAddresses", ex);
                return "";
            }
        }

        private byte[]? GetImageFromUrl(string url)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // Sanitize URL
                if (url.StartsWith("http:/", StringComparison.OrdinalIgnoreCase) && !url.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
                    url = url.Replace("http:/", "http://");
                else if (url.StartsWith("https:/", StringComparison.OrdinalIgnoreCase) && !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                    url = url.Replace("https:/", "https://");

                url = url.Replace("\"", "");

                using var client = new HttpClient();
                var response = client.GetAsync(url).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
                }
            }
            catch (Exception ex)
            {
                // Log error if needed
            }

            return null; // Return null on error or invalid URL
        }


    }
}
