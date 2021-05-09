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

namespace Midterm_Aftaabuddin_Syed
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

        static Random r = new Random();
        int number = r.Next(1, 11);
        int guessNum;
        int attempts = 5;

        private void btn_click(object sender, RoutedEventArgs e)
        {
            guessNum = Convert.ToInt32(txtNumber.Text);
            lblOutput.Content = number;
            gameOutput.Content = "";
            lblAttempt.Content = attempts;
            if (attempts == 0)
            {
                gameOutput.Content = "You lost :(";
            } else if (guessNum == number) {
                gameOutput.Content = "You guessed the number right! \n It took you " + (5-attempts) + " tries to get it right!";
            } else
            {
                --attempts;
                gameOutput.Content = "Try Again.";
            }
        }
    }
}
