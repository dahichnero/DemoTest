using System;
using System.Collections.Generic;

namespace EquipServ.Models;

public partial class DetailEquipment
{
    public int DetailEquipmentId { get; set; }

    public int Equipment { get; set; }

    public int Detail { get; set; }

    public virtual DetailName DetailNavigation { get; set; } = null!;

    public virtual Equipment EquipmentNavigation { get; set; } = null!;
}
