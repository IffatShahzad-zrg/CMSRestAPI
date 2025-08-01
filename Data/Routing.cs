using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Routing
{
    public int SysRoutingId { get; set; }

    public int RoutingId { get; set; }

    public string ServiceType { get; set; } = null!;

    public string? SourceName { get; set; }

    public string? Region { get; set; }

    public string? Area { get; set; }

    public bool? IsActive { get; set; }

    public int? TotalStages { get; set; }

    public string? TotalStagesTat { get; set; }

    public bool? AutoRoute { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public string? RoutingRule { get; set; }

    public string? EmailTo { get; set; }

    public string? EmailCc { get; set; }

    public string? Smsto { get; set; }
}
