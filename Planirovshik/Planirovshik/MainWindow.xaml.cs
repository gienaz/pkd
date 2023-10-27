using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Planirovshik
{

    public partial class MainWindow : Window
    {
        string savePath;

        Task task;
        List<Task> tasks;
        public MainWindow()
        {
            savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\TaskHolder\\";
            InitializeComponent();


            task = new Task();
            tasks = new List<Task>();

            SetFilesIntoList();

            RefreshList();
        }

        //////////
        ///Setting tasks in the table <summary>
        
        void RefreshList()
        {
            listView.Items.Clear();

            foreach(Task t in tasks)
            {
                //////////////////
                //this.listView.Items.Add(t.name);
            }
        }
        void SetFilesIntoList()
        {
            string[] fileNames = Directory.GetFiles(savePath);

            foreach (string fileName in fileNames)
            {
                tasks.Add(CreateTaskFromFile(fileName));
            }
        }
        Task CreateTaskFromFile(string filePath)
        {
            string[] lines = null;
            Task t = new Task();
            try
            {
                lines = File.ReadAllLines(filePath);
                //MessageBox.Show(lines[0] + "\n" + lines[1] + "\n" + lines[2] + "\n" + lines[3]);
                t.name = lines[0];
                t.priority = Convert.ToInt32(lines[1]);
                t.deadline = lines[2];
                t.description = lines[3];
                

                t.status = false;//temporary
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return new Task();
        }


        ///////////
        ///creating tasks and saving
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
                    //GetPriority(task.priority),
                    task.priority.ToString(),
                    task.deadline,
                    task.description
                };

            tasks.Add(task);
            RefreshList();
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
                    using (FileStream fs = File.Create(savePath + task.name + ".txt"))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
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
            else if (i == 2) s = "Не срочно";
            return s;
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            RefreshList();
        }
    }



    public class Task
    {
        public bool status {  get; set; }
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
