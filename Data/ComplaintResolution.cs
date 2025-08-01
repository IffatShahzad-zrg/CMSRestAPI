using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ComplaintResolution
{
    public int SysResolutionId { get; set; }

    public long? ComplaintId { get; set; }

    public DateTime? VisitDate { get; set; }

    public string? VisitBy { get; set; }

    public string? VisitTime { get; set; }

    public string? HostedBy { get; set; }

    public string? Diagnostics { get; set; }

    public string? ErrorSource { get; set; }

    public string? Attachments { get; set; }

    public string? Resolution { get; set; }

    public string? HoursSpend { get; set; }

    public string? AnyInfoGivenToClient { get; set; }

    public string? AnyInfoGivenByClient { get; set; }

    public string? RecomendedToClient { get; set; }

    public bool? OkToClose { get; set; }
}
