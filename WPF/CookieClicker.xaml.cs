using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
    public partial class CookieClicker : Page
    {
        public CookieClicker()
        {
            InitializeComponent();
        }

        private void NotionButton_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://mercantec.notion.site/Cookie-Clicker-bc1b8e1add7e4eabbe9913dc4cb62553?pvs=4";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Der opstod en fejl ved åbning af linket: " + ex.Message);
            }
        }
    }
}