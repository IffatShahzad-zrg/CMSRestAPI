using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class UserActivityLog
{
    public long SysActivityId { get; set; }

    public DateTime? ActivityOn { get; set; }

    public string? ActivityBy { get; set; }

    public string? Activity { get; set; }

    public string? Description { get; set; }
}
