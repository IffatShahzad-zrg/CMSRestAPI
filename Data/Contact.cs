using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Contact
{
    public int SysContactId { get; set; }

    public string Crn { get; set; } = null!;

    public string? Salutation { get; set; }

    public string Name { get; set; } = null!;

    public byte[]? Picture { get; set; }

    public string? Cnic { get; set; }

    public string? Priority { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? PhoneNo { get; set; }

    public string? CellNo { get; set; }

    public string? FaxNo { get; set; }

    public string? EmailAddress { get; set; }

    public string? OfficeName { get; set; }

    public string? Title { get; set; }

    public string? OfficePhoneNo { get; set; }

    public string? OfficeAddress { get; set; }

    public bool? IsActive { get; set; }

    public string? Notes { get; set; }

    public bool? IsCustomer { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public string? District { get; set; }

    public string? City { get; set; }

    public string? Dob { get; set; }

    public string? FathersName { get; set; }

    public string? Province { get; set; }
}
