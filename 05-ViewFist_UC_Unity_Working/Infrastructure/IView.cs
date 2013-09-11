using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ViewFist_UC_Unity_Working
{
    public interface IView
    {
        IViewModel ViewModel { get; set; }      //IViewModel Property
    }
}