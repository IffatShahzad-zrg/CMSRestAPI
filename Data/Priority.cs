using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Priority
{
    public int SysPriorityId { get; set; }

    public string Priority1 { get; set; } = null!;

    public string? Description { get; set; }

    public int ListLoadingOrder { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<Complaint> Complaints { get; set; } = new List<Complaint>();
}
