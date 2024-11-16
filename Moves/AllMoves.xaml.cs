using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for AllMoves.xaml
    /// </summary>
    public partial class AllMoves : Page
    {
        MovesEntities db = new MovesEntities();
        public AllMoves()
        {
            InitializeComponent();
            //var studList = db.User1.Include(x => x.Mov)
            // .Select(s => new { s.Id,s., s.Name, })
            // .ToList();
            //deta.ItemsSource = studList;
            deta.ItemsSource =db.Move1.Select(s => new { s.Id, s.Name, s.Category }).ToList();
        }
        private void search_Click(object sender, RoutedEventArgs e)
        {
            var selection = thecombo.SelectionBoxItem.ToString();
            var dep = db.Move1.Where(x => x.Category == selection).Select(s => new { s.Id, s.Name, s.Category }).ToList();
            if (dep != null )
            {
                deta.ItemsSource = dep.ToList();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int fromid = int.Parse(Po.Text);
          var id1 = db.Move1.FirstOrDefault(x => x.Id == fromid);
           if (id1 != null)
            {
                deatailsmove deatailsmove = new deatailsmove(id1.Id);
                this.NavigationService.Navigate(deatailsmove);
            }
        }
    }
}
