using System.Windows;

namespace AppMainWindow
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Dodaj obsługę zdarzeń przycisków
            Przycisk1.Click += Przycisk1_Click;
            Przycisk2.Click += Przycisk2_Click;
            Przycisk3.Click += Przycisk3_Click;
        }

        private void Przycisk1_Click(object sender, RoutedEventArgs e)
        {
            // Obsługa kliknięcia przycisku 1
            MessageBox.Show("Kliknięto przycisk 1");
        }

        private void Przycisk2_Click(object sender, RoutedEventArgs e)
        {
            // Obsługa kliknięcia przycisku 2
            MessageBox.Show("Kliknięto przycisk 2");
        }

        private void Przycisk3_Click(object sender, RoutedEventArgs e)
        {
            // Obsługa kliknięcia przycisku 3
            MessageBox.Show("Kliknięto przycisk 3");
        }
    }
}
