using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Prefrence
{
    public string LoginName { get; set; } = null!;

    public int? RefreshInterval { get; set; }

    public int? PageSizeComplaints { get; set; }

    public int? PageSizeHistory { get; set; }

    public string? Sortingfield { get; set; }

    public string? SortingOrder { get; set; }

    public string? PrimaryOpenMenu { get; set; }
}
