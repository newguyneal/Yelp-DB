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



namespace YelpDatabaseFinalProject
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    /// 
    class Business{
    
    public string Empty { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Avg { get; set; }
    public string Reviews { get; set; }

}


    public partial class Business_Search : UserControl
    {
        public Business_Search()
        {
            InitializeComponent();
            
        }

        private void update_button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            searchResultListView.Items.Add(new Business() { Empty = "", Name = "Taco Bell", City = "Pullman", State = "WA", Zip = "99163", Avg = "2.8", Reviews = "20" });
            searchResultListView.Items.Add(new Business() { Empty = "", Name = "Porchlight", City = "Pullman", State = "WA", Zip = "99163", Avg = "4.8", Reviews = "50" });
            searchResultListView.Items.Add(new Business() { Empty = "", Name = "Coug Country", City = "Pullman", State = "WA", Zip = "99163", Avg = "3.8", Reviews = "60" });

        }

        private void searchResultListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(searchResultListView.SelectedItems.Count > 0)
            {
                var selectedItem = (Business) searchResultListView.SelectedItem;

                MessageBox.Show("This is the business col: " + selectedItem.Name);

                //Selected item event, Make this in xaml by using the selection changed event

                var resultsWin = new ReviewResultsWindow();
                resultsWin.Show();
                resultsWin.Topmost = true;

            }
            
            
        }
    }
}
