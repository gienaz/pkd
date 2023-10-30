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
        public static List<Task> tasks;
        public static int selectedTask = 0;
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
        ///Editing
        
        private void EditTask_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedIndex < 0 || listView.SelectedIndex >= tasks.Count)
            {
                MessageBox.Show("Выберите задачу!");
            }
            else
            {
                selectedTask = listView.SelectedIndex;
                var w = new Window4();
                if (w.ShowDialog() == true)
                {
                    task = w.Dialogue;
                    DeleteTask(tasks[selectedTask]);
                    AddTaskToList(task);
                }
            }
        }

        void DeleteTask(Task t)
        {
            File.Delete(savePath + t.name + ".txt");
            RefreshList();
        }

        //////////
        ///Setting tasks in the table <summary>
        
        void RefreshList()
        {
            tasks.Clear();
            SetFilesIntoList();

            listView.Items.Clear();

            foreach(Task t in tasks)
            {
                //////////////////
                this.listView.Items.Add(ConvertTaskToLine(t));
            }
            selectedTask = tasks.Count - 1;
        }
        Task ConvertTaskToLine(Task t)
        {
            Task taskkkk = new Task();

            taskkkk.name = t.name;
            taskkkk.description = t.description;
            taskkkk.priorityString = GetPriority(t.priority);
            taskkkk.deadline = t.deadline;

            return taskkkk;
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
            Task t = new Task();
            try
            {
                string[] lines = new string[4];
                lines = File.ReadAllLines(filePath);
                //MessageBox.Show(lines[0] + "\n" + lines[1] + "\n" + lines[2] + "\n" + lines[3]);
                //t.status = false;
                t.name = lines[0];
                t.priority = Convert.ToInt32(lines[1]);
                t.deadline = lines[2];
                t.description = lines[3];
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return t;
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
            SaveTask(taskProperties);
            RefreshList();
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
            MessageBox.Show("Задача сохранена!");
        }

        string GetPriority(int i)
        {
            string s = "Ноль";
            if (i == 0) s = "Срочно";
            else if (i == 1) s = "Второстепенно";
            else if (i == 2) s = "Не срочно";
            return s;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(listView.SelectedIndex < 0 || listView.SelectedIndex >= tasks.Count)
            {
                MessageBox.Show("Выберите задачу!");
            }
            else
            {
                DeleteTask(tasks[listView.SelectedIndex]);
                RefreshList();
            }
        }

    }



    public class Task
    {
        //public bool status {  get; set; }
        public string name {  get; set; }
        public string deadline { get; set; }// = new DateTime(2008, 3, 1, 7, 0, 0);  Displays 01/03/2008 07:00:00
        public string description { get; set; }
        public int priority { get; set; }
        public string priorityString { get; set; }
        public bool status { get; set; }  

            public Task newTask(string name, int priority, string deadline, string description, bool isCompleted)
            {
                Task task = new Task();
                task.name = name;
                task.priority = priority;
                task.deadline = deadline;
                task.description = description;
                return task;
            }
    }
}
