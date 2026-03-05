using System;

namespace internship.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public DateOnly? Birthday { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Chat> CreatedChats { get; set; } = [];
        public ICollection<ChatMember> ChatMembers { get; set; } = [];
        public ICollection<Message> Messages { get; set; } = [];
    }
}
