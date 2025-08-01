using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ComplaintPending
{
    public DateTime? Date { get; set; }

    public string? JobStatus { get; set; }

    public string? Notes { get; set; }

    public long ComplaintId { get; set; }
}
