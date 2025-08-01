using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ShowComplaintsView
{
    public long ComplaintId { get; set; }

    public DateTime? Waitingtime { get; set; }

    public string Category { get; set; } = null!;

    public string Priority { get; set; } = null!;

    public int TotalStages { get; set; }

    public string JobStatus { get; set; } = null!;

    public DateTime TotalResolutionTime { get; set; }

    public string? RoutedToUser { get; set; }

    public string RoutedToDepartment { get; set; } = null!;

    public int CurrentEscalationLevel { get; set; }

    public string StageStatus { get; set; } = null!;

    public int StageNo { get; set; }

    public string Crn { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ComplaintItem { get; set; } = null!;

    public DateTime? AcceptedOn { get; set; }

    public string ComplaintType { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime? RoutedOn { get; set; }

    public string? OfficeName { get; set; }
}
