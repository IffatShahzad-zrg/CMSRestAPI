using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class TblAttachmentDetail
{
    public long AttachmentDtailId { get; set; }

    public long ComplaintId { get; set; }

    public string? AttachmentName { get; set; }

    public byte[]? AttachmentData { get; set; }
}
