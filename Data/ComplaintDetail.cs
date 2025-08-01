using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ComplaintDetail
{
    public long SysDetailId { get; set; }

    public long ComplaintId { get; set; }

    public DateTime ActionOn { get; set; }

    public string ActionBy { get; set; } = null!;

    public string? ActionDepartment { get; set; }

    public string Action { get; set; } = null!;

    public string JobStatus { get; set; } = null!;

    public int StageNo { get; set; }

    public string StageStatus { get; set; } = null!;

    public string? ActivityCode { get; set; }

    public string? UserName { get; set; }

    public string? DepartmentName { get; set; }

    public string? Notes { get; set; }

    public DateTime? Waitingtime { get; set; }

    public string? IsHighPriority { get; set; }

    public string? CustomerEmotions { get; set; }

    public string? NotesType { get; set; }

    public string? ActionType { get; set; }

    public string? ResolutionProvided { get; set; }

    public string? FollowUps { get; set; }

    public string? CallBackNotes { get; set; }

    public string? CallRefId { get; set; }

    public string? Attachments { get; set; }

    public byte[]? AttachmentsData { get; set; }
}
