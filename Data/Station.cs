using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Station
{
    public int SysStationId { get; set; }

    public string StationName { get; set; } = null!;

    public string? StationAddress { get; set; }

    public string CityName { get; set; } = null!;

    public string DivisionName { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual City CityNameNavigation { get; set; } = null!;

    public virtual Division DivisionNameNavigation { get; set; } = null!;
}
