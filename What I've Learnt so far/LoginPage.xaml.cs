using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace What_I_ve_Learnt_so_far
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public async void Mes(string message)
        {
            var mes = new ContentDialog()
            {
                Title = "Hello",
                Content = message,
                CloseButtonText = "ok"
            };
            await mes.ShowAsync();
        }
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void Click_Reg(object sender, RoutedEventArgs e)
        {
            Mes(txtName.Text+" has registered successfully!");
        }

        private void Click_Clr(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPw.Password = "";
            txtPw2.Password = "";
            Mes("Clearing");
        }
    }
}
