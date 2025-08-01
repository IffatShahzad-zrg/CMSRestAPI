using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class UserPermission
{
    public int SysUpid { get; set; }

    public string LoginName { get; set; } = null!;

    public bool Reports { get; set; }

    public bool ComDeck { get; set; }

    public bool Customer { get; set; }

    public bool NonCustomer { get; set; }

    public bool Accounts { get; set; }

    public bool TouchPoints { get; set; }

    public bool Pinmanagement { get; set; }

    public bool Faq { get; set; }

    public bool KnowledgeBase { get; set; }

    public bool Cms { get; set; }

    public bool Lms { get; set; }

    public bool EForms { get; set; }

    public bool Services { get; set; }

    public bool Messages { get; set; }

    public bool Other1 { get; set; }

    public bool Other2 { get; set; }

    public bool Other3 { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public bool Users { get; set; }

    public bool Departments { get; set; }

    public bool Roles { get; set; }

    public bool Permissions { get; set; }

    public bool ComplaintType { get; set; }

    public bool ComplaintCategory { get; set; }

    public bool ComplaintItems { get; set; }

    public bool Routings { get; set; }

    public bool Stages { get; set; }

    public bool ActivityCode { get; set; }

    public bool Areas { get; set; }

    public bool JobStatus { get; set; }

    public bool Priorities { get; set; }

    public bool Regions { get; set; }

    public bool Sources { get; set; }

    public bool CompanyEvents { get; set; }

    public bool StartupEvents { get; set; }

    public bool? IsSpecialPermission { get; set; }

    public bool? IsViewAll { get; set; }

    public bool? Resolution { get; set; }

    public bool? ResolutionEnabled { get; set; }

    public bool? Process { get; set; }
}
