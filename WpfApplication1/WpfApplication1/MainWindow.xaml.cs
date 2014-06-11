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

namespace WpfApplication1
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

        private void RichTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(Insert_Box.Document.ContentStart, Insert_Box.Document.ContentEnd);
            Clipboard.SetText(textRange.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(UpdateBox.Document.ContentStart, UpdateBox.Document.ContentEnd);
            Clipboard.SetText(textRange.Text);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(Delete_Box.Document.ContentStart, Delete_Box.Document.ContentEnd);
            Clipboard.SetText(textRange.Text);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(GetBox.Document.ContentStart, GetBox.Document.ContentEnd);
            Clipboard.SetText(textRange.Text);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(ComboBox.Document.ContentStart, ComboBox.Document.ContentEnd);
            Clipboard.SetText(textRange.Text);
        }
    }
}
