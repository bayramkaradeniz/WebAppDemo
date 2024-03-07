using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppDemo.Models.Classes
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberPhone { get; set; }
        public int CategoryId { get; set; }
        public decimal Balance { get; set; }
    }
}