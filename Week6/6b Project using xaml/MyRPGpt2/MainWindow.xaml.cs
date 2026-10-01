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

namespace MyRPGpt2
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

        private void btnPress_Click(object sender, RoutedEventArgs e)
        {
            // Show the name input controls and focus the textbox
            namePanel.Visibility = Visibility.Visible;
            txtName.Focus();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            SubmitName();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SubmitName();
            }
        }

        private void SubmitName()
        {
            var name = (txtName.Text ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.", "Input Required", MessageBoxButton.OK, MessageBoxImage.Information);
                txtName.Focus();
                return;
            }

            lblMessage.Content = $"Welcome {name}";
            // hide input after submit
            namePanel.Visibility = Visibility.Collapsed;
            txtName.Text = string.Empty;
        }
    }
}
