using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class RptTicketDetailsDaily
{
    public DateTime Date { get; set; }

    public string ComplaintType { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string ComplaintItem { get; set; } = null!;

    public string? ComplaintSource { get; set; }

    public string Crn { get; set; } = null!;

    public long ComplaintId { get; set; }

    public string JobStatus { get; set; } = null!;

    public string Priority { get; set; } = null!;

    public int TotalStages { get; set; }

    public int CurrentStage { get; set; }

    public string? Notes { get; set; }

    public string? Title { get; set; }

    public string? OfficeName { get; set; }

    public DateTime? ClosedOn { get; set; }

    public DateTime TotalResolutionTime { get; set; }

    public int CurrentEscalationLevel { get; set; }

    public DateTime StageResolutionTime { get; set; }

    public string? ActivityCode1 { get; set; }

    public string? ActivityCode2 { get; set; }

    public string? ActivityCode3 { get; set; }

    public string? ActivityCode4 { get; set; }

    public string? ActivityCode5 { get; set; }

    public string RoutedToDepartment { get; set; } = null!;

    public string StageStatus { get; set; } = null!;

    public string? RoutedToUser { get; set; }

    public string? Resolution { get; set; }

    public string? CreatedBy { get; set; }
}
