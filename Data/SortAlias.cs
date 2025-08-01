using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class SortAlias
{
    public long ComplaintId { get; set; }

    public string Category { get; set; } = null!;

    public string ComplaintItem { get; set; } = null!;

    public string? ContactPerson { get; set; }

    public string Priority { get; set; } = null!;

    public string RoutedToDepartment { get; set; } = null!;

    public string? RoutedToUser { get; set; }

    public DateTime DueOn { get; set; }

    public DateTime CreatedOn { get; set; }

    public int Stage { get; set; }

    public DateTime StageTat { get; set; }

    public int Escalation { get; set; }
}
