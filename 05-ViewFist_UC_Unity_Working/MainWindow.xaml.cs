using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _05_ViewFist_UC_Unity_Working
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IMainWindowViewModel mw_vm)
        {
            InitializeComponent();

            ViewModel = mw_vm;
        }

        public IMainWindowViewModel ViewModel
        {
            get
            {
                return (IMainWindowViewModel)DataContext;
            }
            set
            {
                DataContext = value;
            }
        }
    }
}
