using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ReminderVu
{
    public long ComplaintId { get; set; }

    public string Category { get; set; } = null!;

    public int TotalStages { get; set; }

    public string JobStatus { get; set; } = null!;

    public DateTime TotalResolutionTime { get; set; }

    public string? RoutedToUser { get; set; }

    public string RoutedToDepartment { get; set; } = null!;

    public string StageStatus { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string ComplaintItem { get; set; } = null!;

    public string ComplaintType { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? OfficeName { get; set; }

    public int CurrentStage { get; set; }

    public string? Notes { get; set; }

    public string? AdditionalInfo10 { get; set; }

    public string? Address { get; set; }

    public string Crn { get; set; } = null!;

    public string? AdditionalInfo8 { get; set; }

    public string? AdditionalInfo9 { get; set; }

    public string? ContactNumber { get; set; }
}
