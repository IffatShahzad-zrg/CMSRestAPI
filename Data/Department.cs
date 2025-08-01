using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Department
{
    public int SysDepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsRoutingEnabled { get; set; }

    public bool IsEscalationEnabled { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<Crmuser> Crmusers { get; set; } = new List<Crmuser>();
}
