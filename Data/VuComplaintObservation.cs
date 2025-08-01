using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class VuComplaintObservation
{
    public long ComplaintId { get; set; }

    public string InitiatedJobStatus { get; set; } = null!;

    public DateTime InitiatedActionOn { get; set; }

    public string? InitiatedNotes { get; set; }

    public string? DeclineJobStatus { get; set; }

    public DateTime? DeclineActionOn { get; set; }

    public string? DeclineNotes { get; set; }

    public string? DoneJobStatus { get; set; }

    public DateTime? DoneActionOn { get; set; }

    public string? DoneNotes { get; set; }

    public string? ClosedJobStatus { get; set; }

    public DateTime? ClosedActionOn { get; set; }

    public string? ClosedNotes { get; set; }
}
