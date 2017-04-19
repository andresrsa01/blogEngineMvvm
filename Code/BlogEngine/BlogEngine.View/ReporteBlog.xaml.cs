using BlogEngine.Report;
using System;
using System.Windows.Controls;
using System.Windows.Forms.Integration;

namespace BlogEngine.View
{
    /// <summary>
    /// Interaction logic for ReporteBlog.xaml
    /// </summary>
    public partial class ReporteBlog : Page
    {
        private readonly Reporte _mainForm = new Reporte();
        WindowsFormsHost _windowsFormHost;
        public ReporteBlog()
        {
            InitializeComponent();
            AddWindowsForm();
        }

        private void AddWindowsForm()
        {
            _windowsFormHost = new WindowsFormsHost();
            HostStackPanel.Children.Add(_windowsFormHost);
            _mainForm.TopLevel = false;
            _windowsFormHost.Child = _mainForm;
        }
    }
}
