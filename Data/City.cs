using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class City
{
    public int SysCityId { get; set; }

    public string CityName { get; set; } = null!;

    public string DivisionName { get; set; } = null!;

    public string? Province { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual Division DivisionNameNavigation { get; set; } = null!;

    public virtual ICollection<Station> Stations { get; set; } = new List<Station>();
}
