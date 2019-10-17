
using System.Windows;

namespace EditControlDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            editControl1.LoadFile("../../Products.xml");
        }
    }
}
