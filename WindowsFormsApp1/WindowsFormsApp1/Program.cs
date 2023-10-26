using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public partial class SendForm : Form
        {
            // Типы отправления
            enum SendType
            {
                Package, // Посылка
                Letter, // Письмо
                Parcel // Бандероль
            }

            // Типы доставки
            enum DeliveryType
            {
                Domestic, // По стране
                International // За границу
            }

            // Стоимость отправления в рублях за килограмм в зависимости от типа отправления и доставки
            double[,] sendCost = new double[3, 2] { { 200, 500 }, { 100, 300 }, { 150, 400 } };
            private void sendButton_Click(object sender, EventArgs e)
            {
                // Получаем данные из полей ввода
                string senderName = senderNameTextBox.Text;
                string senderAddress = senderAddressTextBox.Text;
                string receiverName = receiverNameTextBox.Text;
                string receiverAddress = receiverAddressTextBox.Text;
                double weight = (double)weightNumericUpDown.Value;
                SendType sendType = (SendType)sendTypeComboBox.SelectedIndex;
                DeliveryType deliveryType = (DeliveryType)deliveryTypeComboBox.SelectedIndex;
                string email = emailTextBox.Text;

                // Проверяем корректность данных
                if (string.IsNullOrEmpty(senderName) || string.IsNullOrEmpty(senderAddress) || string.IsNullOrEmpty(receiverName) || string.IsNullOrEmpty(receiverAddress) || weight <= 0 || sendType == null || deliveryType == null || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля корректно.");
                    return;
                }

                // Рассчитываем стоимость отправления
                double cost = sendCost[(int)sendType, (int)deliveryType] * weight;

                // Формируем отчет об отправлении
                string report = $"Отправитель: {senderName}\nАдрес отправителя: {senderAddress}\nПолучатель: {receiverName}\nАдрес получателя: {receiverAddress}\nТип отправления: {sendType}\nТип доставки: {deliveryType}\nВес: {weight} кг\nСтоимость: {cost} руб.";

                // Отправляем отчет на email
                try
                {
                    MailMessage message = new MailMessage("sendwindow@example.com", email, "Отчет об отправлении", report);
                    SmtpClient client = new SmtpClient("smtp.example.com");
                    client.Send(message);
                    MessageBox.Show("Отчет успешно отправлен на email.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при отправке отчета на email: " + ex.Message);
                }
            }
        }

    }
}
