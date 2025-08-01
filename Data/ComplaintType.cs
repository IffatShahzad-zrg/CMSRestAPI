using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ComplaintType
{
    public int SysComplaintTypeId { get; set; }

    public string ComplaintType1 { get; set; } = null!;

    public string? ComplaintTypeDescription { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<ComplaintItem> ComplaintItems { get; set; } = new List<ComplaintItem>();
}
