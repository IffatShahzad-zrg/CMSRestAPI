using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class RoutingsExtendedDefination
{
    public int SysId { get; set; }

    public string Keyword { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public virtual ICollection<RoutingsExtendedDetail> RoutingsExtendedDetails { get; set; } = new List<RoutingsExtendedDetail>();
}
