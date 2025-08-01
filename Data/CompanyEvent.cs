using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class CompanyEvent
{
    public int SysCompanyEventId { get; set; }

    public string? EventHeading { get; set; }

    public byte[]? EventImage { get; set; }

    public string EventInfo { get; set; } = null!;
}
