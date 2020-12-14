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

namespace CS_ASP_010
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
                        int i;

                        i = "125"
            */
            /*
            long j = 2000000000000;
            
            int i;
            
            i = (int) j;

            labelAnswer.Content = i;
            */

            // double j = 2.55;
            //int i = (int) j;
            //labelAnswer.Content = i;


            string userInput = textBoxInput.Text;

            double numOne = double.Parse(userInput);

            double anwswer = numOne + 64;

            labelAnswer.Content = anwswer;

        }
    }
}
