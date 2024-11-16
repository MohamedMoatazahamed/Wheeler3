using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        MovesEntities db = new MovesEntities();
        public Admin()
        {
            InitializeComponent();
           gride.ItemsSource=db.Move1.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         Move1 move1=new Move1();
            var move23=db.Move1.FirstOrDefault(x=>x.Name==name.Text);
            if (move23 == null)
            {
                move1.Name=name.Text;
                move1.Producer = puducer.Text;
                move1.Category=cat.Text;
                move1.Year= int.Parse (year.Text);
                db.Move1.Add(move1);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("not Move");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var name1 = db.Move1.Remove(db.Move1.FirstOrDefault(x => x.Name == name.Text));
            db.SaveChanges();
            MessageBox.Show("move deleted");

        }
    }
}
