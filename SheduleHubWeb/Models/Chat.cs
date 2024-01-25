using System;
using System.Collections.Generic;

namespace SheduleHubWeb.Models;

public partial class Chat
{
    public int IdChat { get; set; }

    public string NameChat { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();

    public virtual ICollection<ChatUser> ChatUsers { get; set; } = new List<ChatUser>();

    public virtual Student CreatedByNavigation { get; set; } = null!;

    public virtual Student? DeletedByNavigation { get; set; }

    public virtual ICollection<StudentGroup> StudentGroups { get; set; } = new List<StudentGroup>();
}
