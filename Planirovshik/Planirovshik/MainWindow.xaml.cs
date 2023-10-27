using System;
using System.Collections.Generic;
using System.IO;
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
        //string savePath = "C:\\Users\\User\\Desktop\\TaskHolder\\";
        string savePath = "C:\\Users\\fckngienaz\\Desktop\\TaskHolder\\";

        Task task;
        public MainWindow()
        {
            InitializeComponent();

            task = new Task();

        }
        private void NewTask_Click(object sender, RoutedEventArgs e)
        {
            var w = new Window2();
            if (w.ShowDialog() == true)
            {
                task = w.Dialogue;
                AddTaskToList(task);
            }
        }

        void AddTaskToList(Task task)
        {
                string[] taskProperties = new string[] {
                    task.name,
                    GetPriority(task.priority),
                    task.deadline,
                    task.description
                };

            SaveTask(taskProperties);
        }

        void SaveTask(string[] properties)
        {
            if(System.IO.File.Exists(savePath + task.name + ".txt"))
            {
                System.IO.File.WriteAllLines(savePath + task.name + ".txt", properties);

            }
            else
            {
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);
                }
                    File.Create(savePath + task.name + ".txt");
                    using (FileStream fs = File.Create(savePath + task.name + ".txt"))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
                    File.WriteAllLines(savePath + task.name + ".txt", properties);
            }
            MessageBox.Show("Task saved!");
        }

        string GetPriority(int i)
        {
            string s = "Ноль";
            if (i == 0) s = "Срочно";
            else if (i == 1) s = "Второстепенно";
            else s = "Не срочно";
            return s;
        }
    }


    public class Task
    {
        public string name {  get; set; }
        public int priority { get; set; }
            public string deadline { get; set; }// = new DateTime(2008, 3, 1, 7, 0, 0);  Displays 01/03/2008 07:00:00
            public string description { get; set; }
            public bool isCompleted { get; set; }

            public Task newTask(string name, int priority, string deadline, string description, bool isCompleted)
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
