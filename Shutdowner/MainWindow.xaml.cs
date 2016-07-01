using System;
using System.Diagnostics;

namespace Shutdowner
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            OkBtn.Click += (sender, args) =>
            {
                var timer = TimeSpan.FromHours(Convert.ToInt32(TimeInput.Text));
                var shutdown = new ProcessStartInfo("shutdown.exe", $"-s -t {timer.TotalSeconds}")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                Process.Start(shutdown);
            };
            CancelBtn.Click += (sender, args) =>
            {
                var shutdown = new ProcessStartInfo("shutdown.exe", "-a")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                Process.Start(shutdown);
            };
        }
    }
}