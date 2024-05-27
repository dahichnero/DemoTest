using System;
using System.Collections.Generic;

namespace EquipServ.Models;

public partial class RequestAnnounce
{
    public int ReqAnnounceId { get; set; }

    public int Request { get; set; }

    public int Announce { get; set; }

    public virtual Announce AnnounceNavigation { get; set; } = null!;

    public virtual Request RequestNavigation { get; set; } = null!;
}
