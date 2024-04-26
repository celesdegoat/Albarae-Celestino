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
            randomNumber = random.Next(1, 20);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(invulveld.Text, out int testnumber);

            if (testnumber > 20 || testnumber < 1)
            {
                MessageBox.Show("Please enter a number between 1-20"); // als je een getal hoger doet als 20
            }

                else if (int.TryParse(invulveld.Text, out int enteredNumber))
                {
                    if (enteredNumber == randomNumber)
                    {
                        MessageBox.Show("Congratulations! You guessed the correct number."); // als je het goed hebt krijg je deze message
                        Close();
                    }
                    else if (enteredNumber < randomNumber)
                    {
                        MessageBox.Show("Sorry, the number is higher. Try again."); // als het getal hoger is dan de randomnumer dan showt die een message.
                    }
                    else
                    {
                        MessageBox.Show("Sorry, the number is lower. Try again."); // als het getal lager is dan de randomnumer dan showt die een message.
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number."); // als je onzin typt komt deze message
                }
            }
        }
    }
