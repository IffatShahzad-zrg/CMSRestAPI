using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class EmailAddress
{
    public int SysEmailAddId { get; set; }

    public string EmailGroupName { get; set; } = null!;

    public string EmailAddress1 { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public string? DivisionName { get; set; }

    public virtual Division? DivisionNameNavigation { get; set; }
}
