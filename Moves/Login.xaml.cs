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

namespace Moves
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        MovesEntities db=new MovesEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            forgetpassword forgetpassword=new forgetpassword(); 
            this.NavigationService.Navigate(forgetpassword);
        }

        private void LoginButton1_Click(object sender, RoutedEventArgs e)
        {
            sign_up sign_Up = new sign_up();
            this.NavigationService.Navigate(sign_Up);
        }

        private void LoginButton2_Click(object sender, RoutedEventArgs e)
        {
            if (email.Text == "Admin" && Password.Text == "Admin")
            {
               Admin admin = new Admin();
                this.NavigationService.Navigate(admin);

            }
            
            else
            {
                var Email1=db.User1.FirstOrDefault(x=>x.Email == email.Text && x.Password==Password.Text);
                if (Email1!= null)
                {
                    AllMoves allMoves = new AllMoves();
                    this.NavigationService.Navigate(allMoves);  
                }
                else
                {
                    MessageBox.Show("eror ");
                }

            }
            
        }
    }
}
