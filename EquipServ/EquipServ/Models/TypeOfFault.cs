using System;
using System.Collections.Generic;

namespace EquipServ.Models;

public partial class TypeOfFault
{
    public int TypeOfFaultId { get; set; }

    public string TypeOfFaultName { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
