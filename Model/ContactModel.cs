﻿namespace SocietyManagementApi.Model
{
    public class ContactModel
    {
        public int ID { get; set; } 
        public string Name { get; set; } 
        public string Email { get; set; } 
        public string Subject { get; set; }
        public string Message { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Timestamp of submission
    }
}
