namespace internship.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int ChatId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public Chat Chat { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
