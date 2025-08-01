using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class StartupEvent
{
    public int SysStartupEventId { get; set; }

    public string EventHeading { get; set; } = null!;

    public string EventSubHeading { get; set; } = null!;

    public byte[] EventImageUp { get; set; } = null!;

    public string EventDetailsUp { get; set; } = null!;

    public byte[] EventImageDown { get; set; } = null!;

    public string EventDetailDown { get; set; } = null!;

    public string EventFooter { get; set; } = null!;
}
