using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class Window3 : Window
    {
        Task task;
        public Window3()
        {
            InitializeComponent();
            Task primalTask = MainWindow.tasks[MainWindow.selectedTask];
            task = new Task();

            ComboBox_Priority.SelectedIndex = primalTask.priority;
            Add_Desc.Text = primalTask.description;
            Add_Name.Text = primalTask.name;
            Date.SelectedDate = Convert.ToDateTime(primalTask.deadline);




            task.priority = ComboBox_Priority.SelectedIndex;
            btn_Submit.IsEnabled = false;
        }

        public Task Dialogue
        {
            get { return task; }
        }

        bool CheckIfCan()
        {
            bool temp = false;
            if (Add_Name.Text.Length > 0 && Add_Desc.Text.Length > 0 && deadlineSet) temp = true;

            return temp;
        }

        private void Add_Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            task.name = Add_Name.Text;
            if (CheckIfCan())
            {
                btn_Submit.IsEnabled = true;
            }
            else
            {
                btn_Submit.IsEnabled = false;
            }
        }
        private void ComboBox_Priority_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(task != null)
            {
                task.priority = ComboBox_Priority.SelectedIndex;
                //MessageBox.Show(ComboBox_Priority.SelectedIndex.ToString());
            }
        }
        bool deadlineSet = false;
        private void Date_Changed(object sender, SelectionChangedEventArgs e)
        {

            if (task != null)
            {
                task.deadline = Date.Text;
                deadlineSet = true;

                if (CheckIfCan())
                {
                    btn_Submit.IsEnabled = true;
                }
                else
                {
                    btn_Submit.IsEnabled = false;
                }
            }
        }
        private void Add_Desc_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (task != null)
            task.description = Add_Desc.Text;
            if (CheckIfCan())
            {
                btn_Submit.IsEnabled = true;
            }
            else
            {
                btn_Submit.IsEnabled = false;
            }
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            this.DialogResult = true;
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
        }
    }
}
