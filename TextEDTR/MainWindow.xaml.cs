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

namespace TextEDTR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Обратботка типа шрифта
        private void fontList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBox != null)
            {
                string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
                textBox.FontFamily = new FontFamily(fontName);
            }
        }
        //Обработка размера шрифта
        private void fontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBox != null)
            {
                double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
                textBox.FontSize = fontSize;
            }
        }
        //Обработка толщины шрифта
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight == FontWeights.Normal)
                textBox.FontWeight = FontWeights.Bold;
            else textBox.FontWeight = FontWeights.Normal;
        }
        //Обработка наклона шрифта
        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontStyle == FontStyles.Normal)
                textBox.FontStyle = FontStyles.Italic;
            else textBox.FontStyle = FontStyles.Normal;
        }
        //Обработка подчеркивания шрифта
        private void ToggleButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.TextDecorations.Count == 0)
                textBox.TextDecorations.Add(TextDecorations.Underline);
            else textBox.TextDecorations.Remove(TextDecorations.Underline[0]);
        }
        //Обработка цвета шрифта (черный)
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }
        //Обработка цвета шрифта (красный)
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }
    }
}
