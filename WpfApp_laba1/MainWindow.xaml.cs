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

namespace WpfApp_laba1
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

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (name_box.Text.Length == 0)
            {
                MessageBox.Show("Введіть ваше ім'я, будь ласка!", "Error!");
                name_box.Focus();
                return;

            }
            MessageBox.Show("Привіт, " + name_box.Text + " з групи " + group_box.Text);

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
