using System;
using System.Collections.Generic;

namespace EquipServ.Models;

public partial class ExecutorRequest
{
    public int ExecutorReqId { get; set; }

    public int UserExecutor { get; set; }

    public int Request { get; set; }

    public virtual Request RequestNavigation { get; set; } = null!;

    public virtual User UserExecutorNavigation { get; set; } = null!;
}
