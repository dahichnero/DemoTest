using System;
using System.Collections.Generic;

namespace EquipServ.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string ClientName { get; set; } = null!;

    public string ClientLastName { get; set; } = null!;

    public string ClientSurName { get; set; } = null!;

    public int TypeOfClient { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual TypeClient TypeOfClientNavigation { get; set; } = null!;
}
