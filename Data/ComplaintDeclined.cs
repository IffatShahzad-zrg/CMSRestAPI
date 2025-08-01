using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ComplaintDeclined
{
    public DateTime ActionOn { get; set; }

    public string JobStatus { get; set; } = null!;

    public string? Notes { get; set; }

    public long ComplaintId { get; set; }
}
