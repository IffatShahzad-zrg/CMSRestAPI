using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class BadLoginAttempt
{
    public string? LoginName { get; set; }

    public DateTime? Time { get; set; }

    public string? Type { get; set; }
}
