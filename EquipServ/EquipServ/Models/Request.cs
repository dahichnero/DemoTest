using System;
using System.Collections.Generic;

namespace EquipServ.Models;

public partial class Request
{
    public int RequestId { get; set; }

    public string SerialNumber { get; set; } = null!;

    public DateOnly Date { get; set; }

    public int Equipment { get; set; }

    public int TypeOfFault { get; set; }

    public string? Description { get; set; }

    public int Client { get; set; }

    public int Status { get; set; }

    public int? Comment { get; set; }

    public DateOnly Srok { get; set; }

    public virtual Client ClientNavigation { get; set; } = null!;

    public virtual Comment? CommentNavigation { get; set; }

    public virtual Equipment EquipmentNavigation { get; set; } = null!;

    public virtual ICollection<ExecutorRequest> ExecutorRequests { get; set; } = new List<ExecutorRequest>();

    public virtual ICollection<RequestAnnounce> RequestAnnounces { get; set; } = new List<RequestAnnounce>();

    public virtual Status StatusNavigation { get; set; } = null!;

    public virtual TypeOfFault TypeOfFaultNavigation { get; set; } = null!;
}
