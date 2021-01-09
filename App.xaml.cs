using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace padd
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {

        public static String message;

        protected override void OnStartup(StartupEventArgs e) {
            foreach (var message in e.Args) {
                var win = new padd.MainWindow(message);
                win.Show();
            }

            if (e.Args.Length == 0) {
                var win = new padd.MainWindow("");
                win.Show();
            }
        }
    }
}
