using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Smsout
{
    public int Smsid { get; set; }

    public string? SentDate { get; set; }

    public string? LastTried { get; set; }

    public string? SubmissionDate { get; set; }

    public string? Phoneno { get; set; }

    public string? ToName { get; set; }

    public string? ToCompany { get; set; }

    public string? Text { get; set; }

    public bool? Sent { get; set; }

    public int? TryCount { get; set; }

    public string? SubmittedBy { get; set; }

    public string? SubmissionTime { get; set; }

    public string? SentTime { get; set; }

    public string? ReferenceNo { get; set; }

    public string? StationId { get; set; }

    public int? Priority { get; set; }

    public bool? Opted { get; set; }

    public string? ComId { get; set; }

    public string? Smstype { get; set; }

    public string? SmsserviceResponse { get; set; }
}
