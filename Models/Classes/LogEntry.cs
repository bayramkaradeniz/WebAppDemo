using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppDemo.Models.Classes
{
    public class LogEntry
    {
        [Key]
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Description { get; set; }
    }
}