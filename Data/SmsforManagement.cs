using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class SmsforManagement
{
    public int SysSmsid { get; set; }

    public string ComplaintItem { get; set; } = null!;

    public string? JobStatus { get; set; }

    public string? Smsnumbers { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }
}
