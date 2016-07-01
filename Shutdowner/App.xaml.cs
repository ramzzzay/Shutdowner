using System;
using System.Windows;
using MahApps.Metro;

namespace Shutdowner
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 7 || DateTime.Now.Hour >= 20)
            {
                ThemeManager.ChangeAppStyle(Current,
                    ThemeManager.GetAccent("Crimson"),
                    ThemeManager.GetAppTheme("BaseDark"));
            }
            else
            {
                ThemeManager.ChangeAppStyle(Current,
                    ThemeManager.GetAccent("Green"),
                    ThemeManager.GetAppTheme("BaseLight"));
            }

            base.OnStartup(e);
        }
    }
}