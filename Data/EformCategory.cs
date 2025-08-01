using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class EformCategory
{
    public int SysCategoryId { get; set; }

    public string EformType { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string? CategoryDescription { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<EformItem> EformItems { get; set; } = new List<EformItem>();

    public virtual EformType EformTypeNavigation { get; set; } = null!;
}
