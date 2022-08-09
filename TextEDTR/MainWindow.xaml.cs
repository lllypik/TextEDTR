using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        private void FontBoldExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (textBox.FontWeight == FontWeights.Normal)
                textBox.FontWeight = FontWeights.Bold;
            else textBox.FontWeight = FontWeights.Normal;
        }

        //Обработка наклона шрифта
        private void FontItalicExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (textBox.FontStyle == FontStyles.Normal)
                textBox.FontStyle = FontStyles.Italic;
            else textBox.FontStyle = FontStyles.Normal;
        }
       
        //Обработка подчеркивания шрифта
        private void FontUnderlineExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (textBox.TextDecorations.Count == 0)
                textBox.TextDecorations.Add(TextDecorations.Underline);
            else textBox.TextDecorations.Remove(TextDecorations.Underline[0]);
        }
        
        //Обработка цвета шрифта (черный)
        private void FontColorBlackExecuted(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }
        
        //Обработка цвета шрифта (красный)
        private void FontColorRedExecuted (object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }

        // Открытие файла 
        private void OpenExecuted(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog()==true)     textBox.Text = File.ReadAllText(openFileDialog.FileName);
        }

        //Сохранение файла
        private void SaveExecuted(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true) File.WriteAllText(saveFileDialog.FileName, textBox.Text);
        }

        //Закрытие программы 
        private void CloseExecuted (object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
