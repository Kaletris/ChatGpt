using ChatGpt.Data;
using Microsoft.AspNetCore.Mvc;

namespace ChatGpt.Controllers;

[ApiController]
[Route("messages")]
public class MessagesController : ControllerBase
{
    private readonly MessagingContext _context;

    public MessagesController(MessagingContext context)
    {
        _context = context;
    }

    [HttpGet]
    public List<Message> GetMessages()
    {
        return _context.Messages.ToList();
    }

    [HttpPost]
    public void CreateMessage([FromBody] string text, string? sender)
    {
        var message = new Message
        {
            Text = text,
            Time = DateTime.Now
        };

        if (sender != null) message.Sender = sender;

        _context.Add(message);
        _context.SaveChanges();
    }

    [HttpPut("{id}")]
    public ActionResult EditMessage(int id, [FromBody] string text)
    {
        var message = _context.Messages.Find(id);
        if (message == null) return BadRequest("Message doesn't exist.");
        message.Text = text;
        message.Edited = true;
        _context.SaveChanges();
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteMessage(int id)
    {
        var message = _context.Messages.Find(id);
        if (message == null) return BadRequest("Message doesn't exist.");

        _context.Messages.Remove(message);
        _context.SaveChanges();
        return Ok();
    }

    [HttpPatch("{id}")]
    public ActionResult PatchMessage(int id, [FromBody] string text)
    {
        var message = _context.Messages.Find(id);
        if (message == null) return BadRequest("Message doesn't exist.");
        message.Text = text;
        message.Edited = true;
        _context.SaveChanges();
        return Ok();
    }

    [HttpOptions]
    public ActionResult IsOk()
    {
        return Ok();
    }
}