using System.ComponentModel;
using System.IO;
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

namespace Viragok_TZs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Flower> viraaag = new List<Flower>();
        public MainWindow()
        {
            InitializeComponent();
            using StreamReader sr = new StreamReader(
                path: @"..\..\..\src\flowers.txt",
                encoding: System.Text.Encoding.UTF8
                );
            while (!sr.EndOfStream)
            {
                viraaag.Add(new Flower(sr.ReadLine()));
            }
            sr.Close();

            foreach (var item in viraaag)
            {
                viragnev.Items.Add(item.Fajta);
                
                viragar.Items.Add(item.Ar);
                viragszin.Items.Add(item.Szine);
                
            }

            //abc sorrendbe rendezés próbálkozás de nem működik
            viragnev.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Ascending));
        }

        private void torles_Click(object sender, RoutedEventArgs e)
        {
            if (viragnev.SelectedItem != null)
            {
                viragnev.Items.Remove(viragnev.SelectedItem);
            }
            if (viragar.SelectedItem != null)
            {
                viragar.Items.Remove(viragar.SelectedItem);
            }
            if (viragszin.SelectedItem != null)
            {
                viragszin.Items.Remove(viragszin.SelectedItem);
            }
        }

        private void masolas_Click(object sender, RoutedEventArgs e)
        {
            if (viragnev.SelectedItem!=null)
            {
                viragmasolas.Items.Add(viragnev.SelectedItem);
            }
        }
    }
}