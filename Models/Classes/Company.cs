using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppDemo.Models.Classes
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public String CompanyAdminUsername { get; set; }
        public string CompanyAdminPassword { get; set; }
        public String CompanyAdminPhone { get; set; }
        public string AdminFullName { get; set; }
        public Decimal BalanceIncreaseRateForVipMember { get; set; }
        public Decimal BalanceIncreaseRateForMember { get; set; }
        public string CurrentWorker { get; set; }
    }
}