using System;
using System.Collections.Generic;

namespace EquipServ.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Role { get; set; }

    public string Phone { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public virtual ICollection<ExecutorRequest> ExecutorRequests { get; set; } = new List<ExecutorRequest>();

    public virtual Role RoleNavigation { get; set; } = null!;
}
