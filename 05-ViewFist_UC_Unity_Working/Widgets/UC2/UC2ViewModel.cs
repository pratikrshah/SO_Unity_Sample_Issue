using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ViewFist_UC_Unity_Working
{
    public class UC2ViewModel : IUC2ViewModel
    {
        public string LastName { get; set; }

        public UC2ViewModel()
        {
            LastName = "Shah coming from User Control 2";
        }
    }
}