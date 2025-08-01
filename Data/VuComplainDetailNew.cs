using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class VuComplainDetailNew
{
    public long ComplaintId { get; set; }

    public DateTime Date { get; set; }

    public string ComplaintTypeName { get; set; } = null!;

    public string ServiceName { get; set; } = null!;

    public bool? IsCustomer { get; set; }

    public string? Customer { get; set; }

    public string? MobileNo { get; set; }

    public string PriorityName { get; set; } = null!;

    public string CreatorUser { get; set; } = null!;

    public string ComplaintCatName { get; set; } = null!;

    public string ComplaintStatus { get; set; } = null!;

    public DateTime? LastProcessedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public int EscalateLevel { get; set; }

    public string RoutedToDepartment { get; set; } = null!;

    public DateTime? RoutedOn { get; set; }

    public bool? IsAccepted { get; set; }

    public string? Accepter { get; set; }

    public DateTime? AcceptedOn { get; set; }

    public string? Division { get; set; }

    public string? StationCity { get; set; }

    public string? StationName { get; set; }

    public string? StationAddress { get; set; }

    public string? StationVision { get; set; }

    public DateTime TatburstTime { get; set; }

    public DateTime? ComplaintDueDate { get; set; }

    public string? Description { get; set; }

    public bool? EscalationCycleCompleted { get; set; }

    public int ComplaintStatusInitiatedPending { get; set; }

    public int ComplaintStatusDoneClosed { get; set; }

    public int ComplaintStatusDeclined { get; set; }

    public string? ClosingRemarks { get; set; }

    public string? Descri { get; set; }

    public string? Size { get; set; }

    public int? Quantity { get; set; }

    public string? Nic { get; set; }

    public string? DeliveryAdress { get; set; }

    public string? EmailAddress { get; set; }

    public string? AlternateNumber { get; set; }
}
