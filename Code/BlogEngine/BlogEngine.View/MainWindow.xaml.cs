using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls.Ribbon;
using BlogEngine.Common.Command;
using BlogEngine.View.Annotations;
using BlogEngine.ViewModel;

namespace BlogEngine.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindowViewModel Vm = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Vm;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Vm.Dispose();
        }
    }
}
