using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Moves
{
    /// <summary>
    /// Interaction logic for deatailsmove.xaml
    /// </summary>
    public partial class deatailsmove : Page
    {
        MovesEntities db = new MovesEntities(); 
        int id0;

        public deatailsmove(int id)
        {
            InitializeComponent();
            this.id0 = id;

            var movie = db.Move1.FirstOrDefault(m => m.Id == id0);

            if (movie != null)
            {
                user movieDetails = new user
                {
                    Name = movie.Name,
                    Category = movie.Category,
                    Producer = movie.Producer,
                    Year = movie.Year.ToString()
                };

             
                this.DataContext = movieDetails;
            }
            else
            {
                MessageBox.Show("Movie not found.");
            }
        }

        public class user
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public string Producer { get; set; }
            public string Year { get; set; }
        }
    }
}
