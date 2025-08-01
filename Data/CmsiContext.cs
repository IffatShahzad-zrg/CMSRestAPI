using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CMSRestAPI.Data;

public partial class CmsiContext : DbContext
{
    public CmsiContext()
    {
    }

    public CmsiContext(DbContextOptions<CmsiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActivityCode> ActivityCodes { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<BadLoginAttempt> BadLoginAttempts { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<CompanyEvent> CompanyEvents { get; set; }

    public virtual DbSet<Complaint> Complaints { get; set; }

    public virtual DbSet<ComplaintAttachment> ComplaintAttachments { get; set; }

    public virtual DbSet<ComplaintCategory> ComplaintCategories { get; set; }

    public virtual DbSet<ComplaintClosed> ComplaintCloseds { get; set; }

    public virtual DbSet<ComplaintDeclined> ComplaintDeclineds { get; set; }

    public virtual DbSet<ComplaintDetail> ComplaintDetails { get; set; }

    public virtual DbSet<ComplaintDone> ComplaintDones { get; set; }

    public virtual DbSet<ComplaintInitiated> ComplaintInitiateds { get; set; }

    public virtual DbSet<ComplaintItem> ComplaintItems { get; set; }

    public virtual DbSet<ComplaintPending> ComplaintPendings { get; set; }

    public virtual DbSet<ComplaintResolution> ComplaintResolutions { get; set; }

    public virtual DbSet<ComplaintStage> ComplaintStages { get; set; }

    public virtual DbSet<ComplaintType> ComplaintTypes { get; set; }

    public virtual DbSet<Complaintdetailsbkp> Complaintdetailsbkps { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Crmuser> Crmusers { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DepartmentQueueRelation> DepartmentQueueRelations { get; set; }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<EAlertsProcessing> EAlertsProcessings { get; set; }

    public virtual DbSet<Ealert> Ealerts { get; set; }

    public virtual DbSet<EalertTatexpire> EalertTatexpires { get; set; }

    public virtual DbSet<Eform> Eforms { get; set; }

    public virtual DbSet<EformCategory> EformCategories { get; set; }

    public virtual DbSet<EformDetail> EformDetails { get; set; }

    public virtual DbSet<EformItem> EformItems { get; set; }

    public virtual DbSet<EformType> EformTypes { get; set; }

    public virtual DbSet<EmailAddress> EmailAddresses { get; set; }

    public virtual DbSet<EmailGroup> EmailGroups { get; set; }

    public virtual DbSet<JobStatus> JobStatuses { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<OffEscalationDay> OffEscalationDays { get; set; }

    public virtual DbSet<Prefrence> Prefrences { get; set; }

    public virtual DbSet<Priority> Priorities { get; set; }

    public virtual DbSet<Queue> Queues { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<ReminderVu> ReminderVus { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    public virtual DbSet<Routing> Routings { get; set; }

    public virtual DbSet<RoutingsExtendedDefination> RoutingsExtendedDefinations { get; set; }

    public virtual DbSet<RoutingsExtendedDetail> RoutingsExtendedDetails { get; set; }

    public virtual DbSet<RptTicketDetailsDaily> RptTicketDetailsDailies { get; set; }

    public virtual DbSet<RptTicketDetailsDailyClosed> RptTicketDetailsDailyCloseds { get; set; }

    public virtual DbSet<RptTicketDetailsDailyPending> RptTicketDetailsDailyPendings { get; set; }

    public virtual DbSet<Sambacomplaint> Sambacomplaints { get; set; }

    public virtual DbSet<ServicesEscalationDetail> ServicesEscalationDetails { get; set; }

    public virtual DbSet<ShowComplaintsView> ShowComplaintsViews { get; set; }

    public virtual DbSet<SmsforManagement> SmsforManagements { get; set; }

    public virtual DbSet<Smsgroup> Smsgroups { get; set; }

    public virtual DbSet<Smsnumber> Smsnumbers { get; set; }

    public virtual DbSet<SortAlias> SortAliases { get; set; }

    public virtual DbSet<SortField> SortFields { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    public virtual DbSet<Stage> Stages { get; set; }

    public virtual DbSet<StageEscalation> StageEscalations { get; set; }

    public virtual DbSet<StageStatus> StageStatuses { get; set; }

    public virtual DbSet<StartupEvent> StartupEvents { get; set; }

    public virtual DbSet<Station> Stations { get; set; }

    public virtual DbSet<SystemActivityLog> SystemActivityLogs { get; set; }

    public virtual DbSet<TblAttachmentDetail> TblAttachmentDetails { get; set; }

    public virtual DbSet<TblComplaintsSave> TblComplaintsSaves { get; set; }

    public virtual DbSet<TblControl> TblControls { get; set; }

    public virtual DbSet<TblEscalationOffDay> TblEscalationOffDays { get; set; }

    public virtual DbSet<Tblclient> Tblclients { get; set; }

    public virtual DbSet<TouchPoint> TouchPoints { get; set; }

    public virtual DbSet<UserActivityLog> UserActivityLogs { get; set; }

    public virtual DbSet<UserPermission> UserPermissions { get; set; }

    public virtual DbSet<UserRoleRelation> UserRoleRelations { get; set; }

    public virtual DbSet<VuCategoryTop> VuCategoryTops { get; set; }

    public virtual DbSet<VuCategoryTopWeek> VuCategoryTopWeeks { get; set; }

    public virtual DbSet<VuClosed> VuCloseds { get; set; }

    public virtual DbSet<VuCompanyEvent> VuCompanyEvents { get; set; }

    public virtual DbSet<VuComplainDetailNew> VuComplainDetailNews { get; set; }

    public virtual DbSet<VuComplaintId> VuComplaintIds { get; set; }

    public virtual DbSet<VuComplaintObservation> VuComplaintObservations { get; set; }

    public virtual DbSet<VuDecline> VuDeclines { get; set; }

    public virtual DbSet<VuDone> VuDones { get; set; }

    public virtual DbSet<VuInitiated> VuInitiateds { get; set; }

    public virtual DbSet<VuPending> VuPendings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.0.25;Database=CMSi;User Id=sa;Password=zrg123++;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActivityCode>(entity =>
        {
            entity.HasKey(e => new { e.ActivityCode1, e.ActivityCodeType }).HasName("PK_ActivityCodes_1");

            entity.Property(e => e.ActivityCode1)
                .HasMaxLength(100)
                .HasColumnName("ActivityCode");
            entity.Property(e => e.ActivityCodeType).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysActivityCodeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysActivityCodeID");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.AreaName);

            entity.Property(e => e.AreaName).HasMaxLength(30);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysAreaId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysAreaID");
        });

        modelBuilder.Entity<BadLoginAttempt>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.LoginName).HasMaxLength(100);
            entity.Property(e => e.Time).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityName);

            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DivisionName).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Province).HasMaxLength(30);
            entity.Property(e => e.SysCityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysCityID");

            entity.HasOne(d => d.DivisionNameNavigation).WithMany(p => p.Cities)
                .HasForeignKey(d => d.DivisionName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cities_Divisions");
        });

        modelBuilder.Entity<CompanyEvent>(entity =>
        {
            entity.HasKey(e => e.SysCompanyEventId);

            entity.Property(e => e.SysCompanyEventId).HasColumnName("SysCompanyEventID");
            entity.Property(e => e.EventHeading).HasMaxLength(50);
            entity.Property(e => e.EventImage).HasColumnType("image");
            entity.Property(e => e.EventInfo).HasMaxLength(200);
        });

        modelBuilder.Entity<Complaint>(entity =>
        {
            entity.Property(e => e.ComplaintId)
                .ValueGeneratedNever()
                .HasColumnName("ComplaintID");
            entity.Property(e => e.AcceptedOn).HasColumnType("datetime");
            entity.Property(e => e.CallRefId).HasColumnName("CallRefID");
            entity.Property(e => e.ClosedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crn)
                .HasMaxLength(30)
                .HasColumnName("CRN");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Priority).HasMaxLength(30);
            entity.Property(e => e.RoutedOn).HasColumnType("datetime");
            entity.Property(e => e.RoutingId).HasColumnName("RoutingID");
            entity.Property(e => e.StageCompletionOn).HasColumnType("datetime");
            entity.Property(e => e.StageEscalationTime).HasColumnType("datetime");
            entity.Property(e => e.StageResolutionTime).HasColumnType("datetime");
            entity.Property(e => e.SysComplaintId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysComplaintID");
            entity.Property(e => e.TotalResolutionTime).HasColumnType("datetime");

            entity.HasOne(d => d.PriorityNavigation).WithMany(p => p.Complaints)
                .HasForeignKey(d => d.Priority)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Complaints_Priorities");
        });

        modelBuilder.Entity<ComplaintAttachment>(entity =>
        {
            entity.HasKey(e => e.SysAttachmentId);

            entity.Property(e => e.SysAttachmentId).HasColumnName("SysAttachmentID");
            entity.Property(e => e.AttachedBy).HasMaxLength(30);
            entity.Property(e => e.AttachedOn).HasColumnType("datetime");
            entity.Property(e => e.Attachment).HasColumnType("image");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
        });

        modelBuilder.Entity<ComplaintCategory>(entity =>
        {
            entity.HasKey(e => new { e.ComplaintType, e.Category });

            entity.Property(e => e.ComplaintType).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysCategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysCategoryID");
        });

        modelBuilder.Entity<ComplaintClosed>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ComplaintClosed");

            entity.Property(e => e.ActionOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
        });

        modelBuilder.Entity<ComplaintDeclined>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ComplaintDeclined");

            entity.Property(e => e.ActionOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
        });

        modelBuilder.Entity<ComplaintDetail>(entity =>
        {
            entity.HasKey(e => e.SysDetailId);

            entity.Property(e => e.SysDetailId).HasColumnName("SysDetailID");
            entity.Property(e => e.ActionOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.Waitingtime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ComplaintDone>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ComplaintDone");

            entity.Property(e => e.ActionOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
        });

        modelBuilder.Entity<ComplaintInitiated>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ComplaintInitiated");

            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
        });

        modelBuilder.Entity<ComplaintItem>(entity =>
        {
            entity.HasKey(e => new { e.ComplaintType, e.Category, e.ComplaintItem1 });

            entity.Property(e => e.ComplaintType).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.ComplaintItem1)
                .HasMaxLength(150)
                .HasColumnName("ComplaintItem");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DivisionName).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Nature).HasMaxLength(50);
            entity.Property(e => e.RuleId).HasColumnName("RuleID");
            entity.Property(e => e.SysComplaintItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysComplaintItemID");

            entity.HasOne(d => d.ComplaintTypeNavigation).WithMany(p => p.ComplaintItems)
                .HasForeignKey(d => d.ComplaintType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComplaintItems_ComplaintTypes");

            entity.HasOne(d => d.DivisionNameNavigation).WithMany(p => p.ComplaintItems)
                .HasForeignKey(d => d.DivisionName)
                .HasConstraintName("FK_ComplaintItems_Divisions");
        });

        modelBuilder.Entity<ComplaintPending>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ComplaintPending");

            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
        });

        modelBuilder.Entity<ComplaintResolution>(entity =>
        {
            entity.HasKey(e => e.SysResolutionId);

            entity.ToTable("ComplaintResolution");

            entity.Property(e => e.SysResolutionId).HasColumnName("SysResolutionID");
            entity.Property(e => e.AnyInfoGivenByClient).HasMaxLength(250);
            entity.Property(e => e.AnyInfoGivenToClient).HasMaxLength(250);
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.Diagnostics).HasMaxLength(250);
            entity.Property(e => e.ErrorSource).HasMaxLength(30);
            entity.Property(e => e.HostedBy)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.HoursSpend).HasMaxLength(5);
            entity.Property(e => e.RecomendedToClient).HasMaxLength(100);
            entity.Property(e => e.Resolution).HasMaxLength(250);
            entity.Property(e => e.VisitBy).HasMaxLength(50);
            entity.Property(e => e.VisitDate).HasColumnType("datetime");
            entity.Property(e => e.VisitTime).HasMaxLength(10);
        });

        modelBuilder.Entity<ComplaintStage>(entity =>
        {
            entity.HasKey(e => new { e.ComplaintType, e.Category, e.ComplaintItem, e.StageNo }).HasName("PK_ComplaintStageDetails");

            entity.Property(e => e.ComplaintType).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.ComplaintItem).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RouteToDepartment).HasMaxLength(50);
            entity.Property(e => e.RouteToUser).HasMaxLength(30);
            entity.Property(e => e.StageTat).HasColumnName("StageTAT");
            entity.Property(e => e.SysStagelId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysStagelID");
        });

        modelBuilder.Entity<ComplaintType>(entity =>
        {
            entity.HasKey(e => e.ComplaintType1);

            entity.Property(e => e.ComplaintType1)
                .HasMaxLength(50)
                .HasColumnName("ComplaintType");
            entity.Property(e => e.ComplaintTypeDescription).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysComplaintTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysComplaintTypeID");
        });

        modelBuilder.Entity<Complaintdetailsbkp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("complaintdetailsbkp");

            entity.Property(e => e.ActionOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.SysDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysDetailID");
            entity.Property(e => e.Waitingtime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Crn);

            entity.Property(e => e.Crn)
                .HasMaxLength(30)
                .HasColumnName("CRN");
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.CellNo).HasMaxLength(20);
            entity.Property(e => e.City).HasMaxLength(20);
            entity.Property(e => e.Cnic)
                .HasMaxLength(20)
                .HasColumnName("CNIC");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.District).HasMaxLength(20);
            entity.Property(e => e.Dob)
                .HasMaxLength(20)
                .HasColumnName("DOB");
            entity.Property(e => e.EmailAddress).HasMaxLength(100);
            entity.Property(e => e.FathersName).HasMaxLength(60);
            entity.Property(e => e.FaxNo).HasMaxLength(20);
            entity.Property(e => e.Gender).HasMaxLength(6);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(60);
            entity.Property(e => e.OfficeAddress).HasMaxLength(250);
            entity.Property(e => e.OfficeName).HasMaxLength(50);
            entity.Property(e => e.OfficePhoneNo).HasMaxLength(20);
            entity.Property(e => e.PhoneNo).HasMaxLength(100);
            entity.Property(e => e.Picture).HasColumnType("image");
            entity.Property(e => e.Priority).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SysContactId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysContactID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Crmuser>(entity =>
        {
            entity.HasKey(e => e.LoginName);

            entity.ToTable("CRMUsers");

            entity.Property(e => e.LoginName).HasMaxLength(50);
            entity.Property(e => e.CellNo).HasMaxLength(20);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DepartmentName).HasMaxLength(50);
            entity.Property(e => e.DivisionName).HasMaxLength(50);
            entity.Property(e => e.EmailAddress).HasMaxLength(100);
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(6);
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(60);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PhoneNo).HasMaxLength(100);
            entity.Property(e => e.Picture).HasColumnType("image");
            entity.Property(e => e.SysUserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysUserID");
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.DepartmentNameNavigation).WithMany(p => p.Crmusers)
                .HasForeignKey(d => d.DepartmentName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CRMUsers_Departments");

            entity.HasOne(d => d.DivisionNameNavigation).WithMany(p => p.Crmusers)
                .HasForeignKey(d => d.DivisionName)
                .HasConstraintName("FK_CRMUsers_Divisions");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentName);

            entity.Property(e => e.DepartmentName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysDepartmentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysDepartmentID");
        });

        modelBuilder.Entity<DepartmentQueueRelation>(entity =>
        {
            entity.HasKey(e => new { e.Department, e.Queue });

            entity.ToTable("DepartmentQueueRelation");

            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Queue).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysDqid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysDQID");
        });

        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasKey(e => e.DivisionName);

            entity.Property(e => e.DivisionName).HasMaxLength(50);
            entity.Property(e => e.BmcontactNumber)
                .HasMaxLength(250)
                .HasColumnName("BMContactNumber");
            entity.Property(e => e.Bmname)
                .HasMaxLength(30)
                .HasColumnName("BMName");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysDivisionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysDivisionID");
        });

        modelBuilder.Entity<EAlertsProcessing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EAlertsProcessing_1");

            entity.ToTable("eAlertsProcessing");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Event).HasMaxLength(50);
            entity.Property(e => e.LastExecution).HasColumnType("datetime");
        });

        modelBuilder.Entity<Ealert>(entity =>
        {
            entity.HasKey(e => e.SysEventId).HasName("PK_E-Alerts");

            entity.ToTable("EAlerts");

            entity.Property(e => e.SysEventId).HasColumnName("SysEventID");
            entity.Property(e => e.EmailCc)
                .HasMaxLength(50)
                .HasColumnName("EmailCC");
            entity.Property(e => e.EmailTo).HasMaxLength(50);
            entity.Property(e => e.Events).HasMaxLength(50);
        });

        modelBuilder.Entity<EalertTatexpire>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EALertTATExpire");

            entity.Property(e => e.AlertGenerationDate).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.Event).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Stage).HasColumnName("stage");
        });

        modelBuilder.Entity<Eform>(entity =>
        {
            entity.Property(e => e.EformId)
                .ValueGeneratedNever()
                .HasColumnName("EformID");
            entity.Property(e => e.AcceptedBy).HasMaxLength(30);
            entity.Property(e => e.AcceptedOn).HasColumnType("datetime");
            entity.Property(e => e.ActivityCode).HasMaxLength(100);
            entity.Property(e => e.AdditionalInfo1).HasMaxLength(150);
            entity.Property(e => e.AdditionalInfo10).HasMaxLength(150);
            entity.Property(e => e.AdditionalInfo2).HasMaxLength(150);
            entity.Property(e => e.AdditionalInfo3).HasMaxLength(150);
            entity.Property(e => e.AdditionalInfo4).HasMaxLength(150);
            entity.Property(e => e.AdditionalInfo5).HasMaxLength(150);
            entity.Property(e => e.AdditionalInfo6).HasMaxLength(150);
            entity.Property(e => e.AdditionalInfo7).HasMaxLength(150);
            entity.Property(e => e.AdditionalInfo8).HasMaxLength(150);
            entity.Property(e => e.AdditionalInfo9).HasMaxLength(150);
            entity.Property(e => e.CallRefId)
                .HasMaxLength(20)
                .HasColumnName("CallRefID");
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.ClosedBy).HasMaxLength(30);
            entity.Property(e => e.ClosedOn).HasColumnType("datetime");
            entity.Property(e => e.ContactEmail).HasMaxLength(60);
            entity.Property(e => e.ContactNumber).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crn)
                .HasMaxLength(30)
                .HasColumnName("CRN");
            entity.Property(e => e.CustomerEmotions).HasMaxLength(50);
            entity.Property(e => e.EformArea).HasMaxLength(50);
            entity.Property(e => e.EformItem).HasMaxLength(150);
            entity.Property(e => e.EformRegion).HasMaxLength(50);
            entity.Property(e => e.EformSource).HasMaxLength(30);
            entity.Property(e => e.EformType).HasMaxLength(50);
            entity.Property(e => e.JobStatus).HasMaxLength(20);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Priority).HasMaxLength(30);
            entity.Property(e => e.RoutedBy).HasMaxLength(30);
            entity.Property(e => e.RoutedOn).HasColumnType("datetime");
            entity.Property(e => e.RoutedToDepartment).HasMaxLength(50);
            entity.Property(e => e.RoutedToUser).HasMaxLength(50);
            entity.Property(e => e.RoutingId).HasColumnName("RoutingID");
            entity.Property(e => e.StageCompletionBy).HasMaxLength(30);
            entity.Property(e => e.StageCompletionOn).HasColumnType("datetime");
            entity.Property(e => e.StageResolutionTime).HasColumnType("datetime");
            entity.Property(e => e.StageStatus).HasMaxLength(20);
            entity.Property(e => e.SysEformId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysEformID");
            entity.Property(e => e.TotalResolutionTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<EformCategory>(entity =>
        {
            entity.HasKey(e => new { e.EformType, e.Category });

            entity.Property(e => e.EformType).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.CategoryDescription).HasMaxLength(150);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysCategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysCategoryID");

            entity.HasOne(d => d.EformTypeNavigation).WithMany(p => p.EformCategories)
                .HasForeignKey(d => d.EformType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EformCategories_EformTypes");
        });

        modelBuilder.Entity<EformDetail>(entity =>
        {
            entity.HasKey(e => e.SysDetailId);

            entity.Property(e => e.SysDetailId).HasColumnName("SysDetailID");
            entity.Property(e => e.Action).HasMaxLength(25);
            entity.Property(e => e.ActionBy).HasMaxLength(30);
            entity.Property(e => e.ActionOn).HasColumnType("datetime");
            entity.Property(e => e.ActivityCode).HasMaxLength(100);
            entity.Property(e => e.DepartmentName).HasMaxLength(50);
            entity.Property(e => e.EformId).HasColumnName("EformID");
            entity.Property(e => e.JobStatus).HasMaxLength(20);
            entity.Property(e => e.StageStatus).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(50);

            entity.HasOne(d => d.Eform).WithMany(p => p.EformDetails)
                .HasForeignKey(d => d.EformId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EformDetails_Eforms");
        });

        modelBuilder.Entity<EformItem>(entity =>
        {
            entity.HasKey(e => new { e.EformType, e.Category, e.EformItem1 });

            entity.Property(e => e.EformType).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.EformItem1)
                .HasMaxLength(150)
                .HasColumnName("EformItem");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EformItemDescription).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysEformItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysEformItemID");

            entity.HasOne(d => d.EformCategory).WithMany(p => p.EformItems)
                .HasForeignKey(d => new { d.EformType, d.Category })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EformItems_EformCategories");
        });

        modelBuilder.Entity<EformType>(entity =>
        {
            entity.HasKey(e => e.EformType1);

            entity.Property(e => e.EformType1)
                .HasMaxLength(50)
                .HasColumnName("EformType");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EformTypeDescription).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysEformTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysEformTypeID");
        });

        modelBuilder.Entity<EmailAddress>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DivisionName).HasMaxLength(50);
            entity.Property(e => e.EmailAddress1)
                .HasMaxLength(60)
                .HasColumnName("EmailAddress");
            entity.Property(e => e.EmailGroupName).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysEmailAddId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysEmailAddID");

            entity.HasOne(d => d.DivisionNameNavigation).WithMany()
                .HasForeignKey(d => d.DivisionName)
                .HasConstraintName("FK_EmailAddresses_Divisions");
        });

        modelBuilder.Entity<EmailGroup>(entity =>
        {
            entity.HasKey(e => e.EmailGroupName);

            entity.Property(e => e.EmailGroupName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysEmailGroupId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysEmailGroupID");
        });

        modelBuilder.Entity<JobStatus>(entity =>
        {
            entity.HasKey(e => e.JobStatus1);

            entity.ToTable("JobStatus");

            entity.Property(e => e.JobStatus1)
                .HasMaxLength(20)
                .HasColumnName("JobStatus");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysJobStatusId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysJobStatusID");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.SysMessageId);

            entity.Property(e => e.SysMessageId).HasColumnName("sysMessageID");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Message1).HasColumnName("Message");
            entity.Property(e => e.MsgSubject).HasMaxLength(100);
            entity.Property(e => e.SentToUser).HasMaxLength(50);
        });

        modelBuilder.Entity<OffEscalationDay>(entity =>
        {
            entity.HasKey(e => e.OffDaysId);

            entity.Property(e => e.OffDaysId).HasColumnName("OffDaysID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OffDaysType).HasMaxLength(20);
            entity.Property(e => e.Value).HasMaxLength(50);
        });

        modelBuilder.Entity<Prefrence>(entity =>
        {
            entity.HasKey(e => e.LoginName).HasName("PK_Prefrences_1");

            entity.Property(e => e.LoginName).HasMaxLength(30);
            entity.Property(e => e.PrimaryOpenMenu).HasMaxLength(20);
            entity.Property(e => e.SortingOrder).HasMaxLength(20);
            entity.Property(e => e.Sortingfield).HasMaxLength(80);
        });

        modelBuilder.Entity<Priority>(entity =>
        {
            entity.HasKey(e => e.Priority1);

            entity.Property(e => e.Priority1)
                .HasMaxLength(30)
                .HasColumnName("Priority");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysPriorityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysPriorityID");
        });

        modelBuilder.Entity<Queue>(entity =>
        {
            entity.HasKey(e => e.QueueName);

            entity.ToTable("Queue");

            entity.Property(e => e.QueueName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysQueueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysQueueID");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionName);

            entity.Property(e => e.RegionName).HasMaxLength(30);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysRegionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysRegionID");
        });

        modelBuilder.Entity<ReminderVu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReminderVu");

            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crn)
                .HasMaxLength(30)
                .HasColumnName("CRN");
            entity.Property(e => e.Name).HasMaxLength(60);
            entity.Property(e => e.OfficeName).HasMaxLength(50);
            entity.Property(e => e.TotalResolutionTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleName);

            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RoleScreen).HasMaxLength(50);
            entity.Property(e => e.SysRoleId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysRoleID");
        });

        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity.HasKey(e => e.RoleName);

            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.Cms).HasColumnName("CMS");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EForms).HasColumnName("eForms");
            entity.Property(e => e.Faq).HasColumnName("FAQ");
            entity.Property(e => e.Lms).HasColumnName("LMS");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Pinmanagement).HasColumnName("PINManagement");
            entity.Property(e => e.SysRpid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysRPID");

            entity.HasOne(d => d.RoleNameNavigation).WithOne(p => p.RolePermission)
                .HasForeignKey<RolePermission>(d => d.RoleName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePermissions_Roles");
        });

        modelBuilder.Entity<Routing>(entity =>
        {
            entity.HasKey(e => e.SysRoutingId);

            entity.Property(e => e.SysRoutingId).HasColumnName("SysRoutingID");
            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailCc).HasColumnName("EmailCC");
            entity.Property(e => e.EmailTo).HasColumnName("EmailTO");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Region).HasMaxLength(50);
            entity.Property(e => e.RoutingId).HasColumnName("RoutingID");
            entity.Property(e => e.RoutingRule).HasMaxLength(185);
            entity.Property(e => e.ServiceType).HasMaxLength(15);
            entity.Property(e => e.Smsto).HasColumnName("SMSTo");
            entity.Property(e => e.SourceName).HasMaxLength(30);
            entity.Property(e => e.TotalStagesTat)
                .HasMaxLength(50)
                .HasColumnName("TotalStagesTAT");
        });

        modelBuilder.Entity<RoutingsExtendedDefination>(entity =>
        {
            entity.HasKey(e => new { e.Keyword, e.ColumnName });

            entity.ToTable("RoutingsExtendedDefination");

            entity.Property(e => e.Keyword).HasMaxLength(50);
            entity.Property(e => e.ColumnName).HasMaxLength(50);
            entity.Property(e => e.SysId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysID");
        });

        modelBuilder.Entity<RoutingsExtendedDetail>(entity =>
        {
            entity.HasKey(e => e.SysId);

            entity.Property(e => e.SysId).HasColumnName("SysID");
            entity.Property(e => e.ColumnName).HasMaxLength(50);
            entity.Property(e => e.DisplayValue).HasMaxLength(50);
            entity.Property(e => e.Keyword).HasMaxLength(50);
            entity.Property(e => e.RouteToDepartment).HasMaxLength(50);
            entity.Property(e => e.RouteToUser).HasMaxLength(50);
            entity.Property(e => e.Value).HasMaxLength(50);

            entity.HasOne(d => d.RoutingsExtendedDefination).WithMany(p => p.RoutingsExtendedDetails)
                .HasForeignKey(d => new { d.Keyword, d.ColumnName })
                .HasConstraintName("FK_RoutingsExtendedDetails_RoutingsExtendedDefination");
        });

        modelBuilder.Entity<RptTicketDetailsDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("rptTicketDetailsDaily");

            entity.Property(e => e.ClosedOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Crn)
                .HasMaxLength(30)
                .HasColumnName("CRN");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.OfficeName).HasMaxLength(50);
            entity.Property(e => e.Priority).HasMaxLength(30);
            entity.Property(e => e.Resolution).HasMaxLength(250);
            entity.Property(e => e.StageResolutionTime).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.TotalResolutionTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<RptTicketDetailsDailyClosed>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("rptTicketDetailsDailyClosed");

            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Crn)
                .HasMaxLength(30)
                .HasColumnName("CRN");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.OfficeName).HasMaxLength(50);
            entity.Property(e => e.Priority).HasMaxLength(30);
            entity.Property(e => e.Resolution).HasMaxLength(250);
            entity.Property(e => e.StageResolutionTime).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.TotalResolutionTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<RptTicketDetailsDailyPending>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("rptTicketDetailsDailyPending");

            entity.Property(e => e.ActionOn).HasColumnType("datetime");
            entity.Property(e => e.ClosedOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.Crn)
                .HasMaxLength(30)
                .HasColumnName("CRN");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LastNote).HasColumnName("Last Note");
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.OfficeName).HasMaxLength(50);
            entity.Property(e => e.Priority).HasMaxLength(30);
            entity.Property(e => e.Resolution).HasMaxLength(250);
            entity.Property(e => e.RoutedOn).HasColumnType("datetime");
            entity.Property(e => e.StageResolutionTime).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(50);
            entity.Property(e => e.TotalResolutionTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Sambacomplaint>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sambacomplaints");

            entity.Property(e => e.CaseTatendDate)
                .HasColumnType("datetime")
                .HasColumnName("CaseTATEndDate");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.Crn)
                .HasMaxLength(30)
                .HasColumnName("CRN");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Priority).HasMaxLength(30);
            entity.Property(e => e.TotalResolutionTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ServicesEscalationDetail>(entity =>
        {
            entity.HasKey(e => new { e.ServiceType, e.ServiceRefId });

            entity.Property(e => e.ServiceType).HasMaxLength(20);
            entity.Property(e => e.ServiceRefId).HasColumnName("ServiceRefID");
            entity.Property(e => e.EscalationTime).HasColumnType("datetime");
            entity.Property(e => e.ExpReviewTime).HasColumnType("datetime");
            entity.Property(e => e.SysEscalationId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysEscalationID");
        });

        modelBuilder.Entity<ShowComplaintsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ShowComplaintsView");

            entity.Property(e => e.AcceptedOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crn)
                .HasMaxLength(30)
                .HasColumnName("CRN");
            entity.Property(e => e.Name).HasMaxLength(60);
            entity.Property(e => e.OfficeName).HasMaxLength(50);
            entity.Property(e => e.Priority).HasMaxLength(30);
            entity.Property(e => e.RoutedOn).HasColumnType("datetime");
            entity.Property(e => e.TotalResolutionTime).HasColumnType("datetime");
            entity.Property(e => e.Waitingtime).HasColumnType("datetime");
        });

        modelBuilder.Entity<SmsforManagement>(entity =>
        {
            entity.HasKey(e => e.ComplaintItem);

            entity.ToTable("SMSForManagement");

            entity.Property(e => e.ComplaintItem).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.JobStatus).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Smsnumbers).HasColumnName("SMSNumbers");
            entity.Property(e => e.SysSmsid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysSMSID");
        });

        modelBuilder.Entity<Smsgroup>(entity =>
        {
            entity.HasKey(e => e.SmsgroupName);

            entity.ToTable("SMSGroups");

            entity.Property(e => e.SmsgroupName)
                .HasMaxLength(50)
                .HasColumnName("SMSGroupName");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysSmsgroupId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysSMSGroupID");
        });

        modelBuilder.Entity<Smsnumber>(entity =>
        {
            entity.HasKey(e => new { e.SmsgroupName, e.SmscellNo });

            entity.ToTable("SMSNumbers");

            entity.Property(e => e.SmsgroupName)
                .HasMaxLength(50)
                .HasColumnName("SMSGroupName");
            entity.Property(e => e.SmscellNo)
                .HasMaxLength(15)
                .HasColumnName("SMSCellNo");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysSmsnumId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysSMSNumID");

            entity.HasOne(d => d.SmsgroupNameNavigation).WithMany(p => p.Smsnumbers)
                .HasForeignKey(d => d.SmsgroupName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMSNumbers_SMSGroups");
        });

        modelBuilder.Entity<SortAlias>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SortAlias");

            entity.Property(e => e.ComplaintId).HasColumnName("Complaint ID");
            entity.Property(e => e.ComplaintItem).HasColumnName("Complaint Item");
            entity.Property(e => e.ContactPerson).HasColumnName("Contact Person");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("Created On");
            entity.Property(e => e.DueOn)
                .HasColumnType("datetime")
                .HasColumnName("Due on");
            entity.Property(e => e.Priority).HasMaxLength(30);
            entity.Property(e => e.RoutedToDepartment).HasColumnName("Routed To Department");
            entity.Property(e => e.RoutedToUser).HasColumnName("Routed To User");
            entity.Property(e => e.StageTat)
                .HasColumnType("datetime")
                .HasColumnName("Stage TAT");
        });

        modelBuilder.Entity<SortField>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SortField");

            entity.Property(e => e.Fields).HasMaxLength(128);
        });

        modelBuilder.Entity<Source>(entity =>
        {
            entity.HasKey(e => e.SourceName);

            entity.Property(e => e.SourceName).HasMaxLength(30);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysSourceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysSourceID");
        });

        modelBuilder.Entity<Stage>(entity =>
        {
            entity.HasKey(e => new { e.RoutingId, e.StageNo }).HasName("PK_Stages_1");

            entity.Property(e => e.RoutingId).HasColumnName("RoutingID");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EscalationRule).HasMaxLength(50);
            entity.Property(e => e.ExtendedRoutingBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.RouteToDepartment).HasMaxLength(50);
            entity.Property(e => e.RouteToUser).HasMaxLength(30);
            entity.Property(e => e.StageTat)
                .HasMaxLength(50)
                .HasColumnName("StageTAT");
            entity.Property(e => e.StageTatdefineby)
                .HasMaxLength(50)
                .HasColumnName("StageTATDefineby");
            entity.Property(e => e.SysStagelId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysStagelID");
        });

        modelBuilder.Entity<StageEscalation>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailGroupCcname)
                .HasMaxLength(50)
                .HasColumnName("EmailGroupCCName");
            entity.Property(e => e.EmailGroupToName).HasMaxLength(50);
            entity.Property(e => e.EscalationDefineBy).HasMaxLength(50);
            entity.Property(e => e.EscalationLevelTat)
                .HasMaxLength(50)
                .HasColumnName("EscalationLevelTAT");
            entity.Property(e => e.EscalationRuleName).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Smsnumbers).HasColumnName("SMSNumbers");
            entity.Property(e => e.SysStageEscalationId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysStageEscalationID");
        });

        modelBuilder.Entity<StageStatus>(entity =>
        {
            entity.HasKey(e => new { e.StageStatusType, e.StageStatus1 });

            entity.ToTable("StageStatus");

            entity.Property(e => e.StageStatusType).HasMaxLength(50);
            entity.Property(e => e.StageStatus1)
                .HasMaxLength(50)
                .HasColumnName("StageStatus");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.SysStageStatusId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysStageStatusID");
        });

        modelBuilder.Entity<StartupEvent>(entity =>
        {
            entity.HasKey(e => e.EventHeading);

            entity.Property(e => e.EventHeading).HasMaxLength(100);
            entity.Property(e => e.EventFooter).HasMaxLength(150);
            entity.Property(e => e.EventImageDown).HasColumnType("image");
            entity.Property(e => e.EventImageUp).HasColumnType("image");
            entity.Property(e => e.EventSubHeading).HasMaxLength(200);
            entity.Property(e => e.SysStartupEventId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysStartupEventID");
        });

        modelBuilder.Entity<Station>(entity =>
        {
            entity.HasKey(e => e.StationName);

            entity.Property(e => e.StationName).HasMaxLength(50);
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DivisionName).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysStationId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysStationID");

            entity.HasOne(d => d.CityNameNavigation).WithMany(p => p.Stations)
                .HasForeignKey(d => d.CityName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stations_Cities");

            entity.HasOne(d => d.DivisionNameNavigation).WithMany(p => p.Stations)
                .HasForeignKey(d => d.DivisionName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stations_Divisions");
        });

        modelBuilder.Entity<SystemActivityLog>(entity =>
        {
            entity.HasKey(e => e.SysActivityId);

            entity.ToTable("SystemActivityLog");

            entity.Property(e => e.SysActivityId).HasColumnName("SysActivityID");
            entity.Property(e => e.Activity).HasMaxLength(25);
            entity.Property(e => e.ActivityBy).HasMaxLength(30);
            entity.Property(e => e.ActivityOn).HasColumnType("datetime");
            entity.Property(e => e.ActivityType).HasMaxLength(15);
            entity.Property(e => e.Description).HasMaxLength(250);
        });

        modelBuilder.Entity<TblAttachmentDetail>(entity =>
        {
            entity.HasKey(e => e.AttachmentDtailId);

            entity.ToTable("tblAttachmentDetail");

            entity.Property(e => e.AttachmentDtailId).HasColumnName("AttachmentDtailID");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
        });

        modelBuilder.Entity<TblComplaintsSave>(entity =>
        {
            entity.ToTable("tblComplaintsSave");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.Cc)
                .HasMaxLength(200)
                .HasColumnName("CC");
            entity.Property(e => e.City).HasMaxLength(150);
            entity.Property(e => e.CompCategory).HasMaxLength(50);
            entity.Property(e => e.CompSubCategory).HasMaxLength(50);
            entity.Property(e => e.CompType).HasMaxLength(50);
            entity.Property(e => e.ComplianDetail).HasMaxLength(250);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Division).HasMaxLength(150);
            entity.Property(e => e.MailTo).HasMaxLength(200);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Priority).HasMaxLength(50);
            entity.Property(e => e.StationName).HasMaxLength(150);
            entity.Property(e => e.Vision).HasMaxLength(150);
        });

        modelBuilder.Entity<TblControl>(entity =>
        {
            entity.HasKey(e => e.ControlId).HasName("PK_tblDepartmentControlMap");

            entity.ToTable("tblControls");

            entity.Property(e => e.ControlId).HasColumnName("ControlID");
            entity.Property(e => e.CodeFileName).HasMaxLength(50);
            entity.Property(e => e.ContainerName).HasMaxLength(50);
            entity.Property(e => e.ControlName).HasMaxLength(50);
            entity.Property(e => e.ControlType).HasMaxLength(15);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.LoadingOrder)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MyControlId).HasColumnName("MyControlID");
            entity.Property(e => e.ScreenId).HasColumnName("ScreenID");
        });

        modelBuilder.Entity<TblEscalationOffDay>(entity =>
        {
            entity.HasKey(e => new { e.EscOffType, e.EscOffValue }).HasName("PK_TblEsclationOffDays");

            entity.Property(e => e.EscOffType).HasMaxLength(25);
            entity.Property(e => e.EscOffValue).HasMaxLength(25);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EscOffDesc).HasMaxLength(100);
            entity.Property(e => e.EscOffId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EscOffID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Tblclient>(entity =>
        {
            entity.HasKey(e => e.CompanyName);

            entity.ToTable("tblclients");

            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.CompanyAddress).HasMaxLength(250);
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TouchPoint>(entity =>
        {
            entity.HasKey(e => e.SysTpid);

            entity.Property(e => e.SysTpid).HasColumnName("SysTPID");
            entity.Property(e => e.Activity).HasMaxLength(50);
            entity.Property(e => e.AdditionalInfo1).HasMaxLength(20);
            entity.Property(e => e.AdditionalInfo2).HasMaxLength(20);
            entity.Property(e => e.AdditionalInfo3).HasMaxLength(20);
            entity.Property(e => e.AdditionalInfo4).HasMaxLength(20);
            entity.Property(e => e.AdditionalInfo5).HasMaxLength(20);
            entity.Property(e => e.AgentId)
                .HasMaxLength(5)
                .HasColumnName("AgentID");
            entity.Property(e => e.CallRefId)
                .HasMaxLength(20)
                .HasColumnName("CallRefID");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Crn)
                .HasMaxLength(30)
                .HasColumnName("CRN");
            entity.Property(e => e.DepartmentName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Identifier).HasMaxLength(50);
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemType).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<UserActivityLog>(entity =>
        {
            entity.HasKey(e => e.SysActivityId);

            entity.ToTable("UserActivityLog");

            entity.Property(e => e.SysActivityId).HasColumnName("SysActivityID");
            entity.Property(e => e.Activity).HasMaxLength(25);
            entity.Property(e => e.ActivityBy).HasMaxLength(30);
            entity.Property(e => e.ActivityOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
        });

        modelBuilder.Entity<UserPermission>(entity =>
        {
            entity.HasKey(e => e.LoginName);

            entity.Property(e => e.LoginName).HasMaxLength(50);
            entity.Property(e => e.Cms).HasColumnName("CMS");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EForms).HasColumnName("eForms");
            entity.Property(e => e.Faq).HasColumnName("FAQ");
            entity.Property(e => e.Lms).HasColumnName("LMS");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.Pinmanagement).HasColumnName("PINManagement");
            entity.Property(e => e.SysUpid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysUPID");
        });

        modelBuilder.Entity<UserRoleRelation>(entity =>
        {
            entity.HasKey(e => new { e.LoginName, e.RoleName });

            entity.ToTable("UserRoleRelation");

            entity.Property(e => e.LoginName).HasMaxLength(50);
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(30);
            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            entity.Property(e => e.SysUrid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysURID");

            entity.HasOne(d => d.RoleNameNavigation).WithMany(p => p.UserRoleRelations)
                .HasForeignKey(d => d.RoleName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoleRelation_Roles");
        });

        modelBuilder.Entity<VuCategoryTop>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VuCategoryTop");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VuCategoryTopWeek>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VuCategoryTopWeek");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VuClosed>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuClosed");

            entity.Property(e => e.ActionOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
        });

        modelBuilder.Entity<VuCompanyEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VuCompanyEvents");

            entity.Property(e => e.EventHeading).HasMaxLength(50);
            entity.Property(e => e.EventImage).HasColumnType("image");
            entity.Property(e => e.EventInfo).HasMaxLength(200);
            entity.Property(e => e.SysCompanyEventId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SysCompanyEventID");
        });

        modelBuilder.Entity<VuComplainDetailNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuComplainDetailNew");

            entity.Property(e => e.AcceptedOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintCatName).HasColumnName("ComplaintCat_Name");
            entity.Property(e => e.ComplaintDueDate)
                .HasColumnType("datetime")
                .HasColumnName("Complaint_DueDate");
            entity.Property(e => e.ComplaintId).HasColumnName("Complaint_id");
            entity.Property(e => e.ComplaintStatusDoneClosed).HasColumnName("ComplaintStatus_DoneClosed");
            entity.Property(e => e.ComplaintStatusInitiatedPending).HasColumnName("ComplaintStatus_InitiatedPending");
            entity.Property(e => e.ComplaintTypeName).HasColumnName("ComplaintType_Name");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DeliveryAdress).HasMaxLength(200);
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.LastProcessedOn).HasColumnType("datetime");
            entity.Property(e => e.Nic).HasColumnName("NIC");
            entity.Property(e => e.PriorityName).HasMaxLength(30);
            entity.Property(e => e.RoutedOn).HasColumnType("datetime");
            entity.Property(e => e.TatburstTime)
                .HasColumnType("datetime")
                .HasColumnName("TATBurstTime");
        });

        modelBuilder.Entity<VuComplaintId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VuComplaintID");

            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.EformId).HasColumnName("EformID");
        });

        modelBuilder.Entity<VuComplaintObservation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuComplaintObservation");

            entity.Property(e => e.ClosedActionOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
            entity.Property(e => e.DeclineActionOn).HasColumnType("datetime");
            entity.Property(e => e.DoneActionOn).HasColumnType("datetime");
            entity.Property(e => e.InitiatedActionOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VuDecline>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuDecline");

            entity.Property(e => e.ActionOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
        });

        modelBuilder.Entity<VuDone>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuDone");

            entity.Property(e => e.ActionOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
        });

        modelBuilder.Entity<VuInitiated>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuInitiated");

            entity.Property(e => e.ActionOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
        });

        modelBuilder.Entity<VuPending>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuPending");

            entity.Property(e => e.ActionOn).HasColumnType("datetime");
            entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
