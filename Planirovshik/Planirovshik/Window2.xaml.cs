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
using System.Xml.Linq;

namespace Planirovshik
{
    public partial class Window2 : Window
    {
        Task task;
        public Window2()
        {
            InitializeComponent();
            ComboBox_Priority.SelectedIndex = 2;
            Date.SelectedDate = DateTime.Now;
            task = new Task();
        }

        public Task Dialogue
        {
            get { return task; }
        }

        bool CheckIfCan()
        {
            bool temp = false;
            if(Add_Name.Text.Length > 0 && Add_Desc.Text.Length > 0)

            return temp;
        }

        private void Add_Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            task.name = Add_Name.Text;
        }
        private void ComboBox_Priority_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ////////////////
        }
        private void Date_Changed(object sender, SelectedCellsChangedEventArgs e)
        {
            task.deadline = Date.Text;
        }
        private void Add_Desc_TextChanged(object sender, TextChangedEventArgs e)
        {
            task.description = Add_Desc.Text;
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
