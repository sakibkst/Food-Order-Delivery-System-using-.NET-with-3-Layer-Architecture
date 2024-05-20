using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class MonthlyIncome
    {
        public int id { get; set; }

        public string month { get; set; }

        public int income { get; set; }
    }
}
