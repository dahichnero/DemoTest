using System;
using System.Collections.Generic;

namespace EquipServ.Models;

public partial class Announce
{
    public int AnnounceId { get; set; }

    public string AnnounceName { get; set; } = null!;

    public virtual ICollection<RequestAnnounce> RequestAnnounces { get; set; } = new List<RequestAnnounce>();
}
