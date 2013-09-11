using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ViewFist_UC_Unity_Working
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        #region Public Properties
        public IUC1ViewModel UC1VM { get; set; }
        public IUC2ViewModel UC2VM { get; set; }
        public string NNN { get; set; }
        #endregion

        private IUnityContainer _unity;

        public MainWindowViewModel(IUnityContainer unity)
        {
            NNN = "This value coming from MainWindowViewModel";
            //_unity = unity;                           If I uncomment these next 3 lines - then the solution works perfectly. 
            //UC1VM = _unity.Resolve<UC1ViewModel>();
            //UC2VM = _unity.Resolve<UC2ViewModel>();
        }
    }
}