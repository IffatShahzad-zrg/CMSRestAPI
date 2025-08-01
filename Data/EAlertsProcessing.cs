using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class EAlertsProcessing
{
    public int Id { get; set; }

    public string? Event { get; set; }

    public DateTime? LastExecution { get; set; }
}
