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
using System.IO;
using Microsoft.Win32;
namespace WpfApp19.Windows
{
    /// <summary>
    /// Логика взаимодействия для exitwindow.xaml
    /// </summary>
    public partial class exitwindow : Window
    {
        public string text;
        public exitwindow()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile= new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt";
            saveFile.ShowDialog();
            if (string.IsNullOrEmpty(saveFile.FileName))
            {
                return;
            }
            File.WriteAllText(saveFile.FileName, text);
            if(File.Exists(saveFile.FileName))
            {
                Application.Current.Shutdown();
            }
        }

        private void btnnoexit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
