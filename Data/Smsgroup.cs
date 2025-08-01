using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Smsgroup
{
    public int SysSmsgroupId { get; set; }

    public string SmsgroupName { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<Smsnumber> Smsnumbers { get; set; } = new List<Smsnumber>();
}
