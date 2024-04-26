using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int randomNumber;

        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
            randomNumber = random.Next(1, 16);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(invulveld.Text, out int enteredNumber))
            {
                if (enteredNumber == randomNumber)
                {
                    MessageBox.Show("Congratulations! You guessed the correct number.");
                    Close();
                }
                else if (enteredNumber < randomNumber)
                {
                    MessageBox.Show("Sorry, the number is higher. Try again.");
                }
                else
                {
                    MessageBox.Show("Sorry, the number is lower. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
