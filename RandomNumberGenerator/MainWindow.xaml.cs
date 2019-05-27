using RandomNumberGenerator.Models;
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

namespace RandomNumberGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBlock.Text = "Orignal List:";
            textBlock1.Text = "Sorted List:";
        }
        Tree MyTree;
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Random ran = new Random();
            int num;
            int num1 = int.Parse(Number1.Text);
            string generatedNumbers = "";
            string treestring = "";
            num = ran.Next(0, 100);
            generatedNumbers = generatedNumbers + num.ToString().PadLeft(3);
            MyTree = new Tree(num);
            int n = Convert.ToInt32(num1);
            for (int i = 1; i < n; i++)
            {
                num = ran.Next(0, 100);
                generatedNumbers = generatedNumbers + num.ToString().PadLeft(3);
                MyTree.AddRc(num);
            }
            MyTree.Print(null, ref treestring);
            textBlock.Text = $"Orignal List: {generatedNumbers}";
            textBlock1.Text = $"Sorted List: {treestring}";
        }
    }
}
