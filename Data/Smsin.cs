using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Smsin
{
    public int Smsid { get; set; }

    public DateTime? SmsdateTime { get; set; }

    public string? Phoneno { get; set; }

    public string? Text { get; set; }

    public bool? Submitted { get; set; }

    public string? ReferenceNo { get; set; }

    public bool? Opted { get; set; }

    public DateTime? ProcessDateTime { get; set; }

    public int? Trycount { get; set; }
}
