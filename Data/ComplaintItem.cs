using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ComplaintItem
{
    public int SysComplaintItemId { get; set; }

    public string ComplaintType { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string ComplaintItem1 { get; set; } = null!;

    public string? ComplaintItemDescription { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public int? RuleId { get; set; }

    public string? Nature { get; set; }

    public string? DivisionName { get; set; }

    public virtual ComplaintType ComplaintTypeNavigation { get; set; } = null!;

    public virtual Division? DivisionNameNavigation { get; set; }
}
