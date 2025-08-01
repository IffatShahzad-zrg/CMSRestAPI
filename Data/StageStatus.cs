using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class StageStatus
{
    public int SysStageStatusId { get; set; }

    public string StageStatusType { get; set; } = null!;

    public string StageStatus1 { get; set; } = null!;

    public string? Description { get; set; }
}
