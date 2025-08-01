using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class EmailGroup
{
    public int SysEmailGroupId { get; set; }

    public string EmailGroupName { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }
}
