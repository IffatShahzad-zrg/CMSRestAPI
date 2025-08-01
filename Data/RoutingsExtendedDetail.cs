using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class RoutingsExtendedDetail
{
    public int SysId { get; set; }

    public string? Keyword { get; set; }

    public string? ColumnName { get; set; }

    public string? Value { get; set; }

    public string? DisplayValue { get; set; }

    public string? RouteToDepartment { get; set; }

    public string? RouteToUser { get; set; }

    public virtual RoutingsExtendedDefination? RoutingsExtendedDefination { get; set; }
}
