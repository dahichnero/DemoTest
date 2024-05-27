using System;
using System.Collections.Generic;

namespace EquipServ.Models;

public partial class TypeClient
{
    public int TypeClientId { get; set; }

    public string TypeClientName { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
