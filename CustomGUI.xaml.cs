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

namespace AlpaATMGUI
{
    /// <summary>
    /// Interaction logic for CustomGUI.xaml
    /// </summary>
    public partial class CustomGUI : Window
    {
        public CustomGUI()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Execute Unit Test Case L");

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Execute Unit Test Case A");
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Execute Unit Test Case B");

        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Execute Unit Test Case C");

        }

        private void CheckBox_Checked_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Execute Unit Test Case D");

        }

        private void CheckBox_Checked_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Execute Unit Test Case E");

        }

        private void CheckBox_Checked_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Execute Unit Test Case F");

        }

        private void CheckBox_Checked_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Execute Unit Test Case G");

        }

        private void CheckBox_Checked_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Execute Unit Test Case H");

        }

        private void CheckBox_Checked_9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Execute Unit Test Case I");

        }

        private void CheckBox_Checked_10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Execute Unit Test Case J");

        }

        private void CheckBox_Checked_11(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Execute Unit Test Case K");

        }

        private void DataLogging_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LogFile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Show Log File");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Run Test Suite ");

        }

        private void EventHandling_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Run Test Suite with event handling enabled");

        }

        private void Handshaking_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Run test suite with hand shaking enabled");

        }

        private void StopOnFail_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Run test suite with stop on fail enabled");

        }
    }
}
