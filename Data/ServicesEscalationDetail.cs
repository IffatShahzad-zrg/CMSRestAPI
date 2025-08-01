using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ServicesEscalationDetail
{
    public long SysEscalationId { get; set; }

    public string ServiceType { get; set; } = null!;

    public long ServiceRefId { get; set; }

    public DateTime EscalationTime { get; set; }

    public bool EscalationCycleCompleted { get; set; }

    public int CurrentEscalationLevel { get; set; }

    public DateTime? ExpReviewTime { get; set; }
}
