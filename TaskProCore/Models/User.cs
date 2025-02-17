﻿using System;

namespace TaskProCore.Models;

public class User : Entity
{
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public string Role { get; set; }
    
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;
}