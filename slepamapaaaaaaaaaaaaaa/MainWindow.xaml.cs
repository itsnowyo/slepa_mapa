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

namespace slepamapaaaaaaaaaaaaaa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
  public partial class MainWindow : Window
        {
            List<string> mesta = new List<string>()
        {
            "Praha",
            "Brno",
            "Ostrava"
        };

            Random rnd = new Random();
            string aktivniMesto;

            public MainWindow()
            {
                InitializeComponent();
                NovaOtazka();
            }

            void NovaOtazka()
            {
                aktivniMesto = mesta[rnd.Next(mesta.Count)];
                txtMesto.Text = "Najdi město: " + aktivniMesto;
            }

            private void Mapa_MouseDown(object sender, MouseButtonEventArgs e)
            {
                Point p = e.GetPosition(mapa);

                MessageBox.Show("X: " + p.X + " Y: " + p.Y);
            }

            private void City_Click(object sender, RoutedEventArgs e)
            {
                Button btn = sender as Button;
                string kliknuteMesto = btn.Content.ToString();

                if (kliknuteMesto == aktivniMesto)
                {
                    MessageBox.Show("Správně!");
                }
                else
                {
                    MessageBox.Show("Špatně!");
                }

                NovaOtazka();
            }
        }

    }