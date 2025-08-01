using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Division
{
    public int SysDivisionId { get; set; }

    public string DivisionName { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public string? Bmname { get; set; }

    public string? BmcontactNumber { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<ComplaintItem> ComplaintItems { get; set; } = new List<ComplaintItem>();

    public virtual ICollection<Crmuser> Crmusers { get; set; } = new List<Crmuser>();

    public virtual ICollection<Station> Stations { get; set; } = new List<Station>();
}
