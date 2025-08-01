using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class VuCategoryTopWeek
{
    public string Category { get; set; } = null!;

    public int? CategoryCount { get; set; }

    public DateTime? CreatedOn { get; set; }
}
