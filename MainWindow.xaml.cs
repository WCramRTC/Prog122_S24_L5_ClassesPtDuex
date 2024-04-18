using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_S24_L5_ClassesPtDuex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create an instance of an amazon order
            AmazonOrder order1 = new AmazonOrder("123478", "Will Cram", .1m);
            // Add 3 products
            // listName.Add(Product)
            order1.Products.Add(new Product("Eternal Sunshine of a Spotless Mind", "Michele Gondry", 10, 14.00m));
            order1.Products.Add(new Product("El Dorado", "Howard Hawks", 10, 17.00m));
            order1.Products.Add(new Product("Robocop", "Paul Verrhoven", 10, 13.00m));

            rtbDisplay.Text = "";
            foreach (Product product in order1.Products)
            {
                rtbDisplay.Text += $"Title: {product.Title}" +
                    $"\nDirector: {product.Director}\n\n";
            }

            MessageBox.Show(order1.TotalPrice().ToString("c"));

            // Write the code to calculate the products
            // Display the final price with a single method call


        }

        public void ProductExample()
        {
            Product charlesMovie = new Product("El Darado", "Howard Hawks");

            charlesMovie.Title = "Mallrats"; // <---- Mallrats is value
            //MessageBox.Show(charlesMovie.Title);

            try
            {
                charlesMovie.Price = -5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    } // class

} // namespace