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
using System.Windows.Shapes;

namespace YelpDatabaseFinalProject
{
    /// <summary>
    /// Interaction logic for ReviewResultsWindow.xaml
    /// </summary>
    public partial class ReviewResultsWindow : Window
    {
        public ReviewResultsWindow()
        {
            InitializeComponent();
            //TODO: What I would do is in the click event for the gridview in business search
            //preform the query. Since at that point you will know what business you need to access
            //Then pass the result of that query into the constructor
            //after the init component populate the grid and you're done

        }

        private void close_button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
