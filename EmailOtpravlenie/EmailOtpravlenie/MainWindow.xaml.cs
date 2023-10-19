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


        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboBox.Text == "Письмо")
            {
                cost = letterCost;
            }
            else if(ComboBox.Text == "Бандероль")
            {
                cost = banderCost;
            }
            else if(ComboBox.Text == "Посылка")
            {
                cost = boxCost;
            }

            Recalculate();
        }

        void Recalculate()
        {
            if (toFarbool == true) cost += 300;
            Cost.Content= "Итоговая цена: " + cost;
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void toFar_Checked(object sender, RoutedEventArgs e)
        { 
            if(toFarbool == true)
            {
                toFarbool = false;
            }
            else
            {
                toFarbool = true;
            }
            Recalculate();
        }
    }
}
