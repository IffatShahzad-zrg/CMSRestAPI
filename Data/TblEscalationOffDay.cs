using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class TblEscalationOffDay
{
    public int EscOffId { get; set; }

    public string EscOffType { get; set; } = null!;

    public string EscOffValue { get; set; } = null!;

    public string? EscOffDesc { get; set; }

    public bool? EscOffActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }
}
