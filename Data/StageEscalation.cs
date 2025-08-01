using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class StageEscalation
{
    public int SysStageEscalationId { get; set; }

    public int EscalationLevel { get; set; }

    public string EscalationLevelTat { get; set; } = null!;

    public string? EmailGroupToName { get; set; }

    public string? EmailGroupCcname { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? AutoRoute { get; set; }

    public string? EscalationDefineBy { get; set; }

    public string? EscalationRuleName { get; set; }

    public string? Smsnumbers { get; set; }
}
