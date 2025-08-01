using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class EformItem
{
    public int SysEformItemId { get; set; }

    public string EformType { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string EformItem1 { get; set; } = null!;

    public string? EformItemDescription { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual EformCategory EformCategory { get; set; } = null!;
}
