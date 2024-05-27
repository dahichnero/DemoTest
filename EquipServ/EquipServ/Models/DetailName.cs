using System;
using System.Collections.Generic;

namespace EquipServ.Models;

public partial class DetailName
{
    public int DetailId { get; set; }

    public string DetailName1 { get; set; } = null!;

    public virtual ICollection<DetailEquipment> DetailEquipments { get; set; } = new List<DetailEquipment>();
}
