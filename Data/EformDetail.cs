using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class EformDetail
{
    public long SysDetailId { get; set; }

    public long EformId { get; set; }

    public DateTime ActionOn { get; set; }

    public string ActionBy { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string JobStatus { get; set; } = null!;

    public int StageNo { get; set; }

    public string StageStatus { get; set; } = null!;

    public string? ActivityCode { get; set; }

    public string? UserName { get; set; }

    public string? DepartmentName { get; set; }

    public string? Notes { get; set; }

    public string? AttachmentPath { get; set; }

    public virtual Eform Eform { get; set; } = null!;
}
