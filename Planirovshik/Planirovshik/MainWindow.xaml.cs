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

    public partial class MainWindow : Window
    {
        string savePath = "C:\\Users\\User\\Desktop\\TaskHolder";

        public MainWindow()
        {
            InitializeComponent();

            Task testTask = new Task();

        }
        private void NewTask_Click(object sender, RoutedEventArgs e)
        {
            var w = new Window2();
            if (w.ShowDialog() == true)
            {
                Task task = w.Dialogue;
            }
        }

        void AddTaskToList(Task task)
        {

        }
    }


    public class Task
    {
        public string name {  get; set; }
        public int priority { get; set; }
            public string deadline { get; set; }// = new DateTime(2008, 3, 1, 7, 0, 0);  Displays 01/03/2008 07:00:00
            public string description { get; set; }
            public bool isCompleted { get; set; }

            public Task newTask(string name, int priority, DateTime deadline, string description, bool isCompleted)
        {
            Task task = new Task();
            task.name = name;
            task.priority = priority;
            task.deadline = deadline;
            task.description = description;
            task.isCompleted = isCompleted;
            return task;
        }
    }
}
