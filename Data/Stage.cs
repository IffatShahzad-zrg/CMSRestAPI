using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Stage
{
    public int SysStagelId { get; set; }

    public int RoutingId { get; set; }

    public int StageNo { get; set; }

    public int? ExpReviewTimeinMinutes { get; set; }

    public string? RouteToDepartment { get; set; }

    public string? RouteToUser { get; set; }

    public bool IsEscalationEnabled { get; set; }

    public int? TotalEscalationLevels { get; set; }

    public string? StageTat { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? AutoRoute { get; set; }

    public string? StageTatdefineby { get; set; }

    public bool? ExtendedRouting { get; set; }

    public string? ExtendedRoutingBy { get; set; }

    public string? EscalationRule { get; set; }
}
