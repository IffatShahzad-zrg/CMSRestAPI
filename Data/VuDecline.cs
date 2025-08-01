using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class VuDecline
{
    public long ComplaintId { get; set; }

    public string JobStatus { get; set; } = null!;

    public DateTime ActionOn { get; set; }

    public string? DeclineNotes { get; set; }
}
