using System;
using System.Collections.Generic;

namespace EquipServ.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public string CommentName { get; set; } = null!;

    public DateTime Date { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
