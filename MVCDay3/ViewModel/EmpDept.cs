using MVCDay3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDay3.ViewModel
{
    public class EmpDept
    {
       public Employee emp { get; set; }
       public Department dept { get; set; }
    }
}