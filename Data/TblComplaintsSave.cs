using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class TblComplaintsSave
{
    public int Id { get; set; }

    public string CompType { get; set; } = null!;

    public string CompCategory { get; set; } = null!;

    public string CompSubCategory { get; set; } = null!;

    public string Priority { get; set; } = null!;

    public string? Division { get; set; }

    public string? City { get; set; }

    public string? StationName { get; set; }

    public string? Address { get; set; }

    public string? Vision { get; set; }

    public string? ComplianDetail { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public bool? IsLaunch { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public string? MailTo { get; set; }

    public string? Cc { get; set; }
}
