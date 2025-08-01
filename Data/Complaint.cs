using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Complaint
{
    public long SysComplaintId { get; set; }

    public long ComplaintId { get; set; }

    public string Crn { get; set; } = null!;

    public string? ContactPerson { get; set; }

    public string? ContactNumber { get; set; }

    public string? ContactEmail { get; set; }

    public string? ComplaintArea { get; set; }

    public string? ComplaintRegion { get; set; }

    public string? ComplaintSource { get; set; }

    public string ComplaintType { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string ComplaintItem { get; set; } = null!;

    public string Priority { get; set; } = null!;

    public string JobStatus { get; set; } = null!;

    public bool? AutoRoute { get; set; }

    public string RoutedToDepartment { get; set; } = null!;

    public string? RoutedToUser { get; set; }

    public string? Notes { get; set; }

    public bool? IsNonGenuine { get; set; }

    public string? CustomerEmotions { get; set; }

    public string? ActivityCode1 { get; set; }

    public string? ActivityCode2 { get; set; }

    public string? ActivityCode3 { get; set; }

    public string? ActivityCode4 { get; set; }

    public string? ActivityCode5 { get; set; }

    public string? CallRefId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? RoutedOn { get; set; }

    public string? RoutedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsAccepted { get; set; }

    public DateTime? AcceptedOn { get; set; }

    public string? AcceptedBy { get; set; }

    public bool? IsTimeout { get; set; }

    public string? AdditionalInfo1 { get; set; }

    public string? AdditionalInfo2 { get; set; }

    public string? AdditionalInfo3 { get; set; }

    public string? AdditionalInfo4 { get; set; }

    public string? AdditionalInfo5 { get; set; }

    public string? AdditionalInfo6 { get; set; }

    public string? AdditionalInfo7 { get; set; }

    public string? AdditionalInfo8 { get; set; }

    public string? AdditionalInfo9 { get; set; }

    public string? AdditionalInfo10 { get; set; }

    public int TotalStages { get; set; }

    public DateTime TotalResolutionTime { get; set; }

    public int CurrentStage { get; set; }

    public DateTime StageResolutionTime { get; set; }

    public string StageStatus { get; set; } = null!;

    public int TotalEscalationLevels { get; set; }

    public int CurrentEscalationLevel { get; set; }

    public DateTime? ClosedOn { get; set; }

    public string? ClosedBy { get; set; }

    public DateTime? StageCompletionOn { get; set; }

    public string? StageCompletionBy { get; set; }

    public int RoutingId { get; set; }

    public string? Attachments { get; set; }

    public DateTime? StageEscalationTime { get; set; }

    public bool? IsEscalationComplete { get; set; }

    public string? ResolutionProvided { get; set; }

    public string? FollowUp { get; set; }

    public byte[]? AttachmentsData { get; set; }

    public string? Emailto { get; set; }

    public string? Emailcc { get; set; }

    public string? Accountnum { get; set; }

    public string? Cardnum { get; set; }

    public int? ComplaintRating { get; set; }

    public string? CustomerCode { get; set; }

    public virtual Priority PriorityNavigation { get; set; } = null!;
}
