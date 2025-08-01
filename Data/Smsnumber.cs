using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Smsnumber
{
    public int SysSmsnumId { get; set; }

    public string SmsgroupName { get; set; } = null!;

    public string SmscellNo { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual Smsgroup SmsgroupNameNavigation { get; set; } = null!;
}
