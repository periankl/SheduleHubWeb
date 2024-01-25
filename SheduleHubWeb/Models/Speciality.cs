﻿using System;
using System.Collections.Generic;

namespace SheduleHubWeb.Models;

public partial class Speciality
{
    public int IdSpeciality { get; set; }

    public string NameSpeciality { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Student CreatedByNavigation { get; set; } = null!;

    public virtual Student? DeletedByNavigation { get; set; }

    public virtual ICollection<StudentGroup> StudentGroups { get; set; } = new List<StudentGroup>();
}
