using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AppUpdateVersion
{
    public Guid VersionId { get; set; }

    public string? AndroidVersionCode { get; set; }

    public string? AndroidPlayStoreUrl { get; set; }

    public string? IosversionCode { get; set; }

    public string? IosappStoreUrl { get; set; }

    public DateTime? AndroidUpdateDate { get; set; }

    public DateTime? IosupdateDate { get; set; }

    public bool? IsForceUpdate { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }
}
