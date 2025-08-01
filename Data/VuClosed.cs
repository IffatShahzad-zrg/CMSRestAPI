using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class VuClosed
{
    public long ComplaintId { get; set; }

    public string JobStatus { get; set; } = null!;

    public DateTime ActionOn { get; set; }

    public string? ClosedNotes { get; set; }
}
