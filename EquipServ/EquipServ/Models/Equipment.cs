using System;
using System.Collections.Generic;

namespace EquipServ.Models;

public partial class Equipment
{
    public int EquipmentId { get; set; }

    public string EquipmentName { get; set; } = null!;

    public virtual ICollection<DetailEquipment> DetailEquipments { get; set; } = new List<DetailEquipment>();

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
