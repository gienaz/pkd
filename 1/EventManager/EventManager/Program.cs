/* Напишите программу для регистрации событий с возможностью фильтрации и отображения событий по дате и типу*/
class Program
{
    public static void Main(string[] args)
    {
        EventManager em = new EventManager();
        em.Start();
    }
}

public class EventManager
{
    Day[] days;
    Day kostil = new Day();
    public void Start()
    {
        days= new Day[5];
        days[0] = kostil.MakeDay("День рождения", 10, 10, "личный");
        days[1] = kostil.MakeDay("Новый год", 31, 1, "всемирный");
        days[2] = kostil.MakeDay("День победы", 9, 5, "всероссийский");
        days[3] = kostil.MakeDay("День России", 12, 6, "всероссийский");
        days[4] = kostil.MakeDay("День знаний", 1, 9, "всероссийский");

        ShowAllEvents();
        while (true)
        {
            Console.Write("Что вы хотите сделать?\n1.Добавить новое событие\n2.Отсортировать список\n3.Выйти из программы\nВаш ответ: ");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            if (inputOne == 1)
            {
                RegisterNew();
            }
            else if (inputOne == 2)
            {
                ClearConsole();
                Console.Write("Какой тип сортировки?\n1.Сортировка по названию\n2.Сортировка по типу\nВаш ответ: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input >0 && input < 4)
                {
                    SortEvents(input);
                }

            }
            else { break; }
        }

    }
    void RegisterNew()
    {
        ClearConsole();
        Day[] cachedDays = new Day[days.Length];
        for(int i = 0; i < days.Length; i++)
        {
            cachedDays[i] = days[i];
        }

        days = new Day[days.Length+1];
        for (int i = 0; i < days.Length-1; i++)
        {
            days[i] = cachedDays[i];
        }
        Console.Write("Введите название нового события: ");
        string newName= Console.ReadLine();
        Console.WriteLine();
        Console.Write("Введите дату(день) нового события: ");
        int newDay= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введите дату(месяц) нового события: ");
        int newMonth= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введите тип нового события: ");
        string newType = Console.ReadLine();
        Console.WriteLine();

        days[days.Length-1] = kostil.MakeDay(newName, newDay, newMonth, newType);
        ClearConsole();
    }

    void SortEvents(int type) //1 - по названию 2 - по типу
    {
        ClearConsole();
        

        if(type == 1) //сортировка по названию
        {
            string[] cache = new string[days.Length];
            Day[] dayscache = new Day[days.Length];
            for (int i = 0; i < days.Length; i++)
            {
                cache[i] = days[i].name;
                dayscache[i] = days[i];
            }
            Array.Sort(cache);
            for (int i = 0; i < days.Length; i++)
            {
                for (int j = 0; j < days.Length; j++)
                {
                    if(dayscache[j].name == cache[i])
                    days[i] = dayscache[j];
                }
            }
        }
        else if (type == 2) //сортировка по типу
        {
            string[] cache = new string[days.Length];
            Day[] dayscache = new Day[days.Length];
            for (int i = 0; i < days.Length; i++)
            {
                cache[i] = days[i].type;
                dayscache[i] = days[i];
            }
            Array.Sort(cache);
            for (int i = 0; i < days.Length; i++)
            {
                for (int j = 0; j < days.Length; j++)
                {
                    if (dayscache[j].type == cache[i])
                        days[i] = dayscache[j];
                }
            }
        }
        ClearConsole();
    }
    void ClearConsole()
    {
        Console.Clear();
        ShowAllEvents();
    }
    void ShowAllEvents()
    {
        foreach (Day day in days)
        {
            Console.WriteLine(day.name + " - " + day.day + "." + day.month + " - " + day.type);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

public class Day
{
    public string? name { get; set; }
    public int day { get; set; }
    public int month { get; set; }
    public string? type { get; set; }

    public Day MakeDay(string name = "Birthday", int day = 10, int month = 10, string type = "private")
    {
        Day currentDay = new Day()
        {
            name = name,
            day = day,
            month = month,
            type = type
        };
        return currentDay;
    }
}