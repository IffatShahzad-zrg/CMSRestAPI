using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Queue
{
    public int SysQueueId { get; set; }

    public string QueueName { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }
}
