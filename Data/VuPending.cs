using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class VuPending
{
    public long ComplaintId { get; set; }

    public string JobStatus { get; set; } = null!;

    public DateTime ActionOn { get; set; }

    public string? PendingNotes { get; set; }
}
