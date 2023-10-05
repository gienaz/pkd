/* Управление списком задач. Разработайте приложение для управления списком заддач с возможностью добавления, удаления и редактирования задач*/
class Program
{
    public static void Main(string[] args)
    {
        EventManager em = new EventManager();
        em.Start();
    }
}

public class Task
{
    public string? name { get; set; }
    public string? desc { get; set; }

    public Task MakeTask(string name, string desc = " ")
    {
        Task currentTask = new Task()
        {
            name = name,
            desc = desc
        };
        return currentTask;
    }
}
public class EventManager
{
    Task[] tasks;
    Task kostil = new Task();
    public void Start()
    {
        tasks = new Task[5];
        tasks[0] = kostil.MakeTask("Посуда", "Помыть посуду");
        tasks[1] = kostil.MakeTask("Продукты", "Купить продукты");
        tasks[2] = kostil.MakeTask("Задание от 1.09.2023", "Выполнить задание по с#");
        tasks[3] = kostil.MakeTask("Еще задание", "Описание задания");
        tasks[4] = kostil.MakeTask("Задание", "Сделать задание");

        ShowAllEvents();
        while (true)
        {
            Console.Write("Что вы хотите сделать?\n1.Добавить новое событие\n2.Выйти из программы\nВаш ответ: ");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            if (inputOne == 1)
            {
                RegisterNew();
            }
            else { break; }
        }

    }
    void RegisterNew()
    {
        ClearConsole();
        Task[] cachedDays = new Task[tasks.Length];
        for (int i = 0; i < tasks.Length; i++)
        {
            cachedDays[i] = tasks[i];
        }

        tasks = new Task[tasks.Length + 1];
        for (int i = 0; i < tasks.Length - 1; i++)
        {
            tasks[i] = cachedDays[i];
        }
        Console.Write("Введите название новой задачи: ");
        string newName = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Введите описание новой задачи: ");
        string newType = Console.ReadLine();
        Console.WriteLine();

        tasks[tasks.Length - 1] = kostil.MakeTask(newName, newType);
        ClearConsole();
    }

    void ClearConsole()
    {
        Console.Clear();
        ShowAllEvents();
    }
    void ShowAllEvents()
    {
        foreach (Task day in tasks)
        {
            Console.WriteLine(day.name + " - " + day.desc);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
