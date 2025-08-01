using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class OffEscalationDay
{
    public int OffDaysId { get; set; }

    public string? OffDaysType { get; set; }

    public string? Value { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }
}
