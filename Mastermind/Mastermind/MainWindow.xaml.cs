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

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<string> availableColors = new List<string> { "Red", "Yellow", "Orange", "White", "Green", "Blue" };
        private List<string> secretCode = new List<string>();
        private int score;

        public MainWindow()
        {
            InitializeComponent();
            secretCode = GenerateRandomCode();
            PopulateComboBoxes();

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
        }

        private void CheckCode_Click(object sender, RoutedEventArgs e)
        {

        }

        private List<string> GenerateRandomCode()
        {
            Random random = new Random();
            List<string> code = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                string color = availableColors[random.Next(availableColors.Count)];
                code.Add(color);
            }
            return code;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Title = $"Mastermind Game - code: {string.Join(", ", secretCode)}";
        }

        private void PopulateComboBoxes()
        {
            ComboBox[] comboBoxes = { ComboBox1, ComboBox2, ComboBox3, ComboBox4 };
            for (int i = 0; i < comboBoxes.Length; i++)
            {
                comboBoxes[i].ItemsSource = availableColors;
            }
        }
    }
}
