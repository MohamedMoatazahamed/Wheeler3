using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for forgetpassword.xaml
    /// </summary>
    public partial class forgetpassword : Page
    {
        MovesEntities movesEntities=new MovesEntities();
        public forgetpassword()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
       User1 user1  = new User1();
             var test   =movesEntities.User1.FirstOrDefault(x=>x.Email==EmailTextBox.Text);
            if (test != null)
            {
            user1.Password=new1.Text;
               movesEntities.User1.AddOrUpdate(user1);
               movesEntities.SaveChanges(); 

            }
            else
            {
                MessageBox.Show("email not found");
            }
 

        }
    }
}
