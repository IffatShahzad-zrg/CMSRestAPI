using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Message
{
    public int SysMessageId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string SentToUser { get; set; } = null!;

    public string? MsgSubject { get; set; }

    public string? Message1 { get; set; }

    public bool? IsRead { get; set; }

    public string? Attachment { get; set; }
}
