using System.Windows;
using task_5._2;

namespace task_10._1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InputLineOnClick(object sender, RoutedEventArgs e)
        {
            string[] arrayOfWords = Sentence.ToArray(textBox.Text);
            listBox.ItemsSource = arrayOfWords;
        }

        private void ReverceLineOnClick(object sender, RoutedEventArgs e)
        {
            secondTextBlock.Text = Sentence.ReverseSentence(secondTextBox.Text);
        }
    }
}
