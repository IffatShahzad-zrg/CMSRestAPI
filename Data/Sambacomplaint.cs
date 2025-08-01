using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Sambacomplaint
{
    public string Crn { get; set; } = null!;

    public string? ContactPerson { get; set; }

    public string? AccountNo { get; set; }

    public string? LoggingChannel { get; set; }

    public string? ComplaintSource { get; set; }

    public string Priority { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Category { get; set; } = null!;

    public long ComplaintId { get; set; }

    public string ComplaintType { get; set; } = null!;

    public string? AssignedToUserAndDpt { get; set; }

    public string JobStatus { get; set; } = null!;

    public string? NoOfDays { get; set; }

    public DateTime? CaseTatendDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? ClosureType { get; set; }

    public int CurrentStage { get; set; }

    public DateTime TotalResolutionTime { get; set; }

    public bool? IsCustomer { get; set; }

    public int CurrentEscalationLevel { get; set; }

    public string? RoutedToUser { get; set; }

    public string ComplaintItem { get; set; } = null!;
}
