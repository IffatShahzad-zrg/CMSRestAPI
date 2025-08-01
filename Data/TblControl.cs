using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class TblControl
{
    public int ControlId { get; set; }

    public int MyControlId { get; set; }

    public int ControlIndex { get; set; }

    public string ControlName { get; set; } = null!;

    public string CodeFileName { get; set; } = null!;

    public string ControlType { get; set; } = null!;

    public string? Description { get; set; }

    public int ScreenId { get; set; }

    public string LoadingOrder { get; set; } = null!;

    public string ContainerName { get; set; } = null!;

    public bool? IsActive { get; set; }
}
