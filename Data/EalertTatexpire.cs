using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class EalertTatexpire
{
    public int Id { get; set; }

    public long ComplaintId { get; set; }

    public string Event { get; set; } = null!;

    public DateTime AlertGenerationDate { get; set; }

    public int Stage { get; set; }

    public bool Sent { get; set; }
}
