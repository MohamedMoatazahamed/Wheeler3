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
    /// Interaction logic for sign_up.xaml
    /// </summary>
    public partial class sign_up : Page
    {
        MovesEntities db=new MovesEntities();
        public sign_up()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            User1 user1 = new User1();
            var test = db.User1.FirstOrDefault(x => x.Email == EmailTextBox.Text);
            if (test == null) 
            {

                if (PasswordBox.Text == ConfirmPasswordBox.Text)
                {
                    user1.Name = NameTextBox.Text;
                    user1.Email = EmailTextBox.Text;
                    user1.Password = PasswordBox.Text;
                    db.User1.Add(user1);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("eroro password not found");
                }
            
            }
            else
            {
                MessageBox.Show(" email register");
            }

            

        }
    }
}
