using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementApp.Models
{
    public class User : IdentityUser
    {
        public List<Task> Tasks { get; set; }
    }
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string TaskDescription { get; set; }
        public string Status { get; set; } = "Incomplete";
        [ForeignKey("User")]
        [MaxLength(450)]
        public string UserId { get; set; }
        public User User { get; set; }
        public Task()
        {

        }
    }
}
