using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class JobStatus
{
    public int SysJobStatusId { get; set; }

    public string JobStatus1 { get; set; } = null!;

    public string? Description { get; set; }

    public int ListLoadingOrder { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }
}
