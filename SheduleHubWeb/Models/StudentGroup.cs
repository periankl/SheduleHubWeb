﻿using System;
using System.Collections.Generic;

namespace SheduleHubWeb.Models;

public partial class StudentGroup
{
    public int IdGroup { get; set; }

    public string NameGroup { get; set; } = null!;

    public int IdSpeciality { get; set; }

    public int CourseNum { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int? IdChat { get; set; }

    public virtual Student CreatedByNavigation { get; set; } = null!;

    public virtual Student? DeletedByNavigation { get; set; }

    public virtual Chat? IdChatNavigation { get; set; }

    public virtual Speciality IdSpecialityNavigation { get; set; } = null!;

    public virtual ICollection<Shedule> Shedules { get; set; } = new List<Shedule>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
