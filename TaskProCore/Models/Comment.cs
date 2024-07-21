using System;
using TaskProCore.Models;

namespace TaskProCore.Entities;

public class Comment : Entity
{
    public string Content { get; set; }
    
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;

    public int TaskId { get; set; }
    
    public int UserId { get; set; }
    
}