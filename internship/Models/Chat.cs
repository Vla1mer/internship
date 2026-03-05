namespace internship.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CreatorId { get; set; }
        public DateTime CreatedAt { get; set; }

        public User Creator { get; set; } = null!;
        public ICollection<ChatMember> ChatMembers { get; set; } = [];
        public ICollection<Message> Messages { get; set; } = [];
    }
}
