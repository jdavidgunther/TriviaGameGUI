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

namespace TriviaGame
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

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string guess;
            string answer = "8";

            guess = Answer.Text;

            if (guess == answer)
            {
                Result.Text = "Correct";
            }
            else
            {
                Result.Text = "Incorrect";
            }
        }
    }
}
