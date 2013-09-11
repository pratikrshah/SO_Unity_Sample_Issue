using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ViewFist_UC_Unity_Working
{
    public class UC1ViewModel : IUC1ViewModel
    {
        public string FirstName { get; set; }

        public UC1ViewModel()
        {
            FirstName = "Pratik coming from User Control 1";
        }
    }
}
