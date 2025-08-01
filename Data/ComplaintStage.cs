using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ComplaintStage
{
    public int SysStagelId { get; set; }

    public string ComplaintType { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string ComplaintItem { get; set; } = null!;

    public int StageNo { get; set; }

    public int? ExpReviewTimeinMinutes { get; set; }

    public string RouteToDepartment { get; set; } = null!;

    public string RouteToUser { get; set; } = null!;

    public bool IsEscalationEnabled { get; set; }

    public int TotalEscalationLevels { get; set; }

    public int StageTat { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }
}
