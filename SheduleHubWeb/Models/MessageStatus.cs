﻿using System;
using System.Collections.Generic;

namespace SheduleHubWeb.Models;

public partial class MessageStatus
{
    public int IdStatus { get; set; }

    public string NameStatus { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();

    public virtual Student CreatedByNavigation { get; set; } = null!;

    public virtual Student? DeletedByNavigation { get; set; }
}
