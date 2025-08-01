using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class DepartmentQueueRelation
{
    public int SysDqid { get; set; }

    public string Department { get; set; } = null!;

    public string Queue { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }
}
