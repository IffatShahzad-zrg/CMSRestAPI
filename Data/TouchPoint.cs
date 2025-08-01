using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class TouchPoint
{
    public int SysTpid { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string Activity { get; set; } = null!;

    public string Crn { get; set; } = null!;

    public string? CallRefId { get; set; }

    public string? AgentId { get; set; }

    public string? Identifier { get; set; }

    public bool IsAlert { get; set; }

    public string? Description { get; set; }

    public string? AdditionalInfo1 { get; set; }

    public string? AdditionalInfo2 { get; set; }

    public string? AdditionalInfo3 { get; set; }

    public string? AdditionalInfo4 { get; set; }

    public string? AdditionalInfo5 { get; set; }

    public long? ItemId { get; set; }

    public string? ItemType { get; set; }

    public string? UserName { get; set; }

    public string? DepartmentName { get; set; }
}
