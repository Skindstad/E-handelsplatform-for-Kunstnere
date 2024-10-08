﻿namespace EhandelsplatformforKunstnere.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public ICollection<Post> Posts { get; set; } = [];
    }
}
