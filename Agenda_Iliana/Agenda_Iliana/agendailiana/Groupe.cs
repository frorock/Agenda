using System;
using System.Collections.Generic;

namespace Agenda_Iliana.agendailiana;

public partial class Groupe
{
    public string FriendId { get; set; } = null!;

    public bool? Friend { get; set; }

    public bool? Family { get; set; }

    public bool? Office { get; set; }
}
