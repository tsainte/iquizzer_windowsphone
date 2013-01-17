using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace iQuizzer
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask task = new WebBrowserTask();
            task.Uri =  new Uri("http://iquizzer.herokuapp.com/users/sign_up");
            task.Show();
        }
    }
}