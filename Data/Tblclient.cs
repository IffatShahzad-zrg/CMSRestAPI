using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Tblclient
{
    public int Sno { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? CompanyAddress { get; set; }

    public bool? Active { get; set; }
}
