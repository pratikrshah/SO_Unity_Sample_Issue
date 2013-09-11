using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _05_ViewFist_UC_Unity_Working
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //Step 1 - One Time - Creating an instance of the container
            UnityContainer unity = new UnityContainer();

            //Step 2 - Registeration
            unity.RegisterType<IMainWindowViewModel, MainWindowViewModel>();
            unity.RegisterType<IUC1ViewModel, UC1ViewModel>();
            unity.RegisterType<IUC2ViewModel, UC2ViewModel>();

            //Step 3 - Creating an Instance
            MainWindowViewModel mwvm = unity.Resolve<MainWindowViewModel>();
            UC1ViewModel uc1vm = unity.Resolve<UC1ViewModel>();
            UC2ViewModel uc2vm = unity.Resolve<UC2ViewModel>();

            //MainWindow mw = new MainWindow(mwvm);
            MainWindow mw = unity.Resolve<MainWindow>();

            mw.Show();
        }
    }
}
