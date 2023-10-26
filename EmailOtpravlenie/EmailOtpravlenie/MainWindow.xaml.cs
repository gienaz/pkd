using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

namespace EmailOtpravlenie
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //отправитель
        //адрес отправителя
        //получатель
        //адрес получателя
        //тип посылки(письмо, бандероль, посылка)
        //хрупкая посылка(да\нет)
        //отправление за границу(да\нет)


        int cost = 0;
        int letterCost = 100;
        int banderCost = 200;
        int boxCost = 500;
        bool toFarbool = false;
        bool isreadytouse = false;


        public MainWindow()
        {
            InitializeComponent();
            ComboBox.SelectedIndex = 0;
            Button.IsEnabled = false;
            TextBox4.Text = "mofeyax639@scubalm.com";

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfYouCan();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboBox.SelectedIndex == 1)
            {
                cost = letterCost;
            }
            else if(ComboBox.SelectedIndex == 2)
            {
                cost = banderCost;
            }
            else if(ComboBox.SelectedIndex == 3)
            {
                cost = boxCost;
            }
            CheckIfYouCan();
            Recalculate();
        }
         void CheckIfYouCan()
        {
            if (TextBox.Text.Length > 0 && TextBox4.Text.Length > 0 && TextBox1.Text.Length > 0 && TextBox2.Text.Length > 0 && TextBox3.Text.Length > 0 && ComboBox.SelectedIndex != 0)
            {
                isreadytouse = true;
                Button.IsEnabled = true;
            }
            else
            {
                isreadytouse = true;
                Button.IsEnabled = false;
            }
        }
        void Recalculate(bool boolean=true)
        {
            if (toFarbool == true) cost += 300;
            else if(boolean == false) cost -= 300;
            Cost.Content= "Итоговая цена: " + cost;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isreadytouse)
            {
                string[] mystrings = new string[] { "Отправитель: " + TextBox.Text, "Адрес отправления: " + TextBox1.Text, "Получатель: " + TextBox2.Text,
                                                "Адрес получателя: " + TextBox3.Text,
                                                "Вид отправления: " + ComboBox.Text, "За границу: " + toFar.Content, "Итоговая стоимость: " + cost};

                System.IO.File.WriteAllLines($"C://Users/User/Desktop/pismo.txt", mystrings);

                Send();
                Environment.Exit(0);
            }

        }
        void Send()
        {
            string path = "C://Users/User/Desktop/pismo.txt";
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("npl1u1pc@mail.ru", "Stass");
            // кому отправляем
            MailAddress to = new MailAddress(TextBox4.Text);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            m.Subject = "OpisaniePosilki";
            m.Attachments.Add(new Attachment(path));
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 2525);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("npl1u1pc@mail.ru", "dWxZks4tnrEGDq3XWqQh");
            smtp.EnableSsl = true;
            smtp.Send(m);
            //npl1u1pc@mail.ru
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfYouCan();
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfYouCan();
        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfYouCan();
        }

        private void toFar_Checked(object sender, RoutedEventArgs e)
        { 
            toFarbool = true;
            Recalculate();
        }
        private void toFar_Unchecked(object sender, RoutedEventArgs e)
        { 
            toFarbool = false;
            Recalculate(false);
        }

        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckIfYouCan();
        }
    }
}
