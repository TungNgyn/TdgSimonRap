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

namespace TdgSimonRap
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var names = new List<string> { ":D", "T__T", "ö.ö", ":)", ":(", "D:", ":P", ":Ü", ":O", ";)", ":f", ":3", ":/", "C:", ":I" };
            var rnd = new Random(); 

            int index = rnd.Next(names.Count);
            var name = names[index];

            Label1.Content = name;



        }

    }
}
