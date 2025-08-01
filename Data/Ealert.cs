using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Ealert
{
    public int SysEventId { get; set; }

    public string Events { get; set; } = null!;

    public string EmailTo { get; set; } = null!;

    public string? EmailCc { get; set; }

    public bool Active { get; set; }
}
