using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class StateInfo
{
    public int StateId { get; set; }

    public string? StateName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }
}
