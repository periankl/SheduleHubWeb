using System;
using System.Collections.Generic;

namespace SheduleHubWeb.Models;

public partial class Student
{
    public int IdStudent { get; set; }

    public string Email { get; set; } = null!;

    public string Pssword { get; set; } = null!;

    public string NameFirst { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public int? IdGroup { get; set; }

    public int? IdRole { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<Chat> ChatCreatedByNavigations { get; set; } = new List<Chat>();

    public virtual ICollection<Chat> ChatDeletedByNavigations { get; set; } = new List<Chat>();

    public virtual ICollection<ChatMessage> ChatMessageCreatedByNavigations { get; set; } = new List<ChatMessage>();

    public virtual ICollection<ChatMessage> ChatMessageDeletedByNavigations { get; set; } = new List<ChatMessage>();

    public virtual ICollection<ChatUser> ChatUsers { get; set; } = new List<ChatUser>();

    public virtual ICollection<Discipline> DisciplineCreatedByNavigations { get; set; } = new List<Discipline>();

    public virtual ICollection<Discipline> DisciplineDeletedByNavigations { get; set; } = new List<Discipline>();

    public virtual ICollection<Homework> HomeworkCreatedByNavigations { get; set; } = new List<Homework>();

    public virtual ICollection<Homework> HomeworkDeletedByNavigations { get; set; } = new List<Homework>();

    public virtual StudentGroup? IdGroupNavigation { get; set; }

    public virtual StudentRole? IdRoleNavigation { get; set; }

    public virtual ICollection<MessageStatus> MessageStatusCreatedByNavigations { get; set; } = new List<MessageStatus>();

    public virtual ICollection<MessageStatus> MessageStatusDeletedByNavigations { get; set; } = new List<MessageStatus>();

    public virtual ICollection<Shedule> SheduleCreatedByNavigations { get; set; } = new List<Shedule>();

    public virtual ICollection<Shedule> SheduleDeletedByNavigations { get; set; } = new List<Shedule>();

    public virtual ICollection<Speciality> SpecialityCreatedByNavigations { get; set; } = new List<Speciality>();

    public virtual ICollection<Speciality> SpecialityDeletedByNavigations { get; set; } = new List<Speciality>();

    public virtual ICollection<StudentGroup> StudentGroupCreatedByNavigations { get; set; } = new List<StudentGroup>();

    public virtual ICollection<StudentGroup> StudentGroupDeletedByNavigations { get; set; } = new List<StudentGroup>();

    public virtual ICollection<StudentRole> StudentRoleCreatedByNavigations { get; set; } = new List<StudentRole>();

    public virtual ICollection<StudentRole> StudentRoleDeletedByNavigations { get; set; } = new List<StudentRole>();
}
