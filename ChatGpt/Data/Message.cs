using Microsoft.EntityFrameworkCore;

namespace ChatGpt.Data;

public class Message
{
    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime Time { get; set; }
    public string Sender { get; set; } = "Anonymongus";
    public bool Edited { get; set; }
}

public class MessagingContext : DbContext
{
    public MessagingContext(DbContextOptions<MessagingContext> options) : base(options)
    {
    }

    public DbSet<Message> Messages { get; set; }
}