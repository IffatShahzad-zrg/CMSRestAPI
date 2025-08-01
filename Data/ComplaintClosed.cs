using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ComplaintClosed
{
    public DateTime ActionOn { get; set; }

    public string JobStatus { get; set; } = null!;

    public string? Notes { get; set; }

    public long ComplaintId { get; set; }
}
