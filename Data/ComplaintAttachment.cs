using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ComplaintAttachment
{
    public int SysAttachmentId { get; set; }

    public long? ComplaintId { get; set; }

    public DateTime? AttachedOn { get; set; }

    public string? AttachedBy { get; set; }

    public byte[]? Attachment { get; set; }

    public string? Notes { get; set; }
}
