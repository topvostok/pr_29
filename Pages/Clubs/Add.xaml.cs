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

namespace PG_29.Pages.Clubs
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        /// <summary> Главная страница клубов
        /// </summary>
        Main Main;


        /// <summary> Данные клуба
        /// </summary>
        Models.Clubs Club;

        public Add(Main Main, Models.Clubs Club = null)
        {
            InitializeComponent();

            // Запоминаем в переменную
            this.Main = Main;

            // Если пришёл клуб, отображаем данные
            if (Club != null)
            {
                // Запоминаем клуб в переменную
                this.Club = Club;
                // Указываем наименование
                this.Name.Text = Club.Name;
                // Указываем адрес
                this.Address.Text = Club.Address;
                // Указываем время работы
                this.WorkTime.Text = Club.WorkTime;
                // Изменяем текст кнопки
                BtAdd.Content = "Изменить";
            }
        }

        /// <summary> Метод добавления или изменения
        /// </summary>
        private void AddClub(object sender, System.Windows.RoutedEventArgs e)
        {
            // Если клуб пустой (создаём новый)
            if (this.Club == null)
            {
                // Создаём новый объект
                Club = new Models.Clubs();
                // Задаём данные
                Club.Name = this.Name.Text;
                Club.Address = this.Address.Text;
                Club.WorkTime = this.WorkTime.Text;
                // Добавляем объект в контекст
                this.Main.AllClubs.Add(this.Club);
            }
            else
            {
                // Если изменение
                // Изменяем данные
                Club.Name = this.Name.Text;
                Club.Address = this.Address.Text;
                Club.WorkTime = this.WorkTime.Text;
            }

            // Сохраняем изменения
            this.Main.AllClubs.SaveChanges();

            // Открываем страницу клубов
            MainWindow.init.OpenPages(new Pages.Clubs.Main());
        }
    }
}