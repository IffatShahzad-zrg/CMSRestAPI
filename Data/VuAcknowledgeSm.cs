using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class VuAcknowledgeSm
{
    public DateTime? Date { get; set; }

    public int Smsid { get; set; }

    public string? SubmissionDate { get; set; }

    public string? SubmissionTime { get; set; }

    public string? SentDate { get; set; }

    public string? SentTime { get; set; }

    public string? LastTried { get; set; }

    public string Sent { get; set; } = null!;
}
