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
using System.Windows.Shapes;

namespace LanguageMaker.Views.Windows.MainWindows
{
    /// <summary>
    /// Логика взаимодействия для NavigationWindow.xaml
    /// </summary>
    public partial class NavigationWindow : Window
    {
        public NavigationWindow()
        {
            InitializeComponent();
        }

        private void GenerateNewLanguageBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ConsonantsTb.Text) || string.IsNullOrEmpty(VowelsTb.Text))
            {
                MessageBox.Show("Заполните поля", "", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            //if ()
            //{
            //    MessageBox.Show("Этого не достаточно для создания языка", "", MessageBoxButton.OK, MessageBoxImage.Warning);
            //    return;
            //}
        }
        #region AddEnglishConsonantsClicks
        private void ConsonantBtn1_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn1.Content + " ";
        }
        private void ConsonantBtn2_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn2.Content + " ";
        }
        private void ConsonantBtn3_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn3.Content + " ";
        }
        private void ConsonantBtn4_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn4.Content + " ";
        }
        private void ConsonantBtn5_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn5.Content + " ";
        }
        private void ConsonantBtn6_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn6.Content + " ";
        }
        private void ConsonantBtn7_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn7.Content + " ";
        }
        private void ConsonantBtn8_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn8.Content + " ";
        }
        private void ConsonantBtn9_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn9.Content + " ";
        }
        private void ConsonantBtn10_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn10.Content + " ";
        }
        private void ConsonantBtn11_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn11.Content + " ";
        }
        private void ConsonantBtn12_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn12.Content + " ";
        }
        private void ConsonantBtn13_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn13.Content + " ";
        }
        private void ConsonantBtn14_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn14.Content + " ";
        }
        private void ConsonantBtn15_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn15.Content + " ";
        }
        private void ConsonantBtn16_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn16.Content + " ";
        }
        private void ConsonantBtn17_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn17.Content + " ";
        }
        private void ConsonantBtn18_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn18.Content + " ";
        }
        private void ConsonantBtn19_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn19.Content + " ";
        }
        private void ConsonantBtn20_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn20.Content + " ";
        }
        private void ConsonantBtn21_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn21.Content + " ";
        }
        private void ConsonantBtn22_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn22.Content + " ";
        }
        private void ConsonantBtn23_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn23.Content + " ";
        }
        private void ConsonantBtn24_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text + ConsonantBtn24.Content + " ";
        }
        private void AddAllEnglishConsonantsBtn_Click(object sender, RoutedEventArgs e)
        {
            ConsonantsTb.Text = ConsonantsTb.Text
                + ConsonantBtn1.Content + " "
                + ConsonantBtn2.Content + " "
                + ConsonantBtn3.Content + " "
                + ConsonantBtn4.Content + " "
                + ConsonantBtn5.Content + " "
                + ConsonantBtn6.Content + " "
                + ConsonantBtn7.Content + " "
                + ConsonantBtn8.Content + " "
                + ConsonantBtn9.Content + " "
                + ConsonantBtn10.Content + " "
                + ConsonantBtn11.Content + " "
                + ConsonantBtn12.Content + " "
                + ConsonantBtn13.Content + " "
                + ConsonantBtn14.Content + " "
                + ConsonantBtn15.Content + " "
                + ConsonantBtn16.Content + " "
                + ConsonantBtn17.Content + " "
                + ConsonantBtn18.Content + " "
                + ConsonantBtn19.Content + " "
                + ConsonantBtn20.Content + " "
                + ConsonantBtn21.Content + " "
                + ConsonantBtn22.Content + " "
                + ConsonantBtn23.Content + " "
                + ConsonantBtn24.Content + " ";
        }
        #endregion
        #region AddEnglishVowelsClicks
        private void VowelBtn1_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn1.Content + " ";
        }
        private void VowelBtn2_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn2.Content + " ";
        }
        private void VowelBtn3_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn3.Content + " ";
        }
        private void VowelBtn4_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn4.Content + " ";
        }
        private void VowelBtn5_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn5.Content + " ";
        }
        private void VowelBtn6_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn6.Content + " ";
        }
        private void VowelBtn7_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn7.Content + " ";
        }
        private void VowelBtn8_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn8.Content + " ";
        }
        private void VowelBtn9_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn9.Content + " ";
        }
        private void VowelBtn10_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn10.Content + " ";
        }
        private void VowelBtn11_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn11.Content + " ";
        }
        private void VowelBtn12_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn12.Content + " ";
        }
        private void VowelBtn13_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn13.Content + " ";
        }
        private void VowelBtn14_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn14.Content + " ";
        }
        private void VowelBtn15_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn15.Content + " ";
        }
        private void AddAllEnglishVowelsBtn_Click(object sender, RoutedEventArgs e)
        {
            VowelsTb.Text = VowelsTb.Text + VowelBtn1.Content + " "
                + VowelBtn1.Content + " "
                + VowelBtn2.Content + " "
                + VowelBtn3.Content + " "
                + VowelBtn4.Content + " "
                + VowelBtn5.Content + " "
                + VowelBtn6.Content + " "
                + VowelBtn7.Content + " "
                + VowelBtn8.Content + " "
                + VowelBtn9.Content + " "
                + VowelBtn10.Content + " "
                + VowelBtn11.Content + " "
                + VowelBtn12.Content + " "
                + VowelBtn13.Content + " "
                + VowelBtn14.Content + " "
                + VowelBtn15.Content + " ";
        }
        #endregion

    }
}
