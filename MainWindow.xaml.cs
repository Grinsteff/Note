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
using System.IO;
using Microsoft.Win32;
using WpfApp19.Windows;

namespace WpfApp19
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

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt)|*.txt";
            openFile.ShowDialog();
            if (string.IsNullOrEmpty(openFile.FileName))
            {
                return;
            }
            textbox.Text = File.ReadAllText(openFile.FileName);
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt";
            saveFile.ShowDialog();
            if (string.IsNullOrEmpty(saveFile.FileName))
            {
                return;
            }
            File.WriteAllText(saveFile.FileName, textbox.Text);
        }

       

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            exitwindow exitwindow = new exitwindow() {text = textbox.Text };
            exitwindow.ShowDialog();
        }
    }
}
