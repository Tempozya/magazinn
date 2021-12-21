using InternetShop.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetShop.Admin
{
    public partial class simulation : Form
    {
        sqlFunc sql = new sqlFunc();
        public simulation()
        {
            InitializeComponent();
        }



        private bool working = false;
        private int countUser = 0;
        private DateTime date = new DateTime(2021, 12, 1);


        public void SimpleGenerateUser()
        {
            string id, login, password, name, surname, phone;

            string[] Arrlogin = { "KOD", "ральф", "ХУЛИGАН", "Dreamer", "The_Red_Hunter", "Qwerty", "Orissi", "Waldo" };
            string[] Arrpassword = { "Al1aHRXT9i3psaT", "qGQZqX7HGN6GUYk", "QAxd40eviRSHnOZ", "18fG9bJkAIGQcTs", "XjUo4NmTjdDGNPz", "3kMkHpZG659hF5e" };
            string[] Arrname = { "Эдуард", "Устин", "Цицерон", "Зенон", "Марат", "Эрик", "Юлиан", "Йоханес", "Харитон", "Станислав", "Йонас", "Клаус" };
            string[] Arrsurname = { "Коновалов", "Иванов", "Цветков", "Назаров", "Ермаков", "Пестов", "Архипов", "Горбачёв", "Красинец", "Гуляев" };
            string[] Arrphone = { "111765958", "753069090", "277869249", "277869249", "857907618", "549071467", "939915908", "588554078", "782785473", "609017116" };

            Random random = new Random();

            while (working)
            {
                id = random.Next(1000, 99999).ToString();
                login = Arrlogin[random.Next(0, Arrlogin.Length - 1)];
                password = Arrpassword[random.Next(0, Arrpassword.Length - 1)];
                name = Arrname[random.Next(0, Arrname.Length - 1)];
                surname = Arrsurname[random.Next(0, Arrsurname.Length - 1)];
                phone = Arrphone[random.Next(0, Arrphone.Length - 1)];


                countUser++;



                sql.RegUser(id, login, password, name,phone);

                Thread.Sleep(500);

            }



        }

        private void SimLoop()
        {
            while (working)
            {
                if (date.DayOfWeek == DayOfWeek.Monday)
                {

                }
                labelCount.Invoke(new Action(() => labelCount.Text = countUser.ToString()));

                labeldate.Invoke(new Action(() => labeldate.Text = date.ToString("d")));

                date = date.AddDays(1);
                Thread.Sleep(1000);

            }
        }




        private void Start()
        {
            working = true;
            Task.Run(() => SimLoop());
            Task.Run(() => SimpleGenerateUser());
        }

        private void Stop()
        {
            working = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stop();
        }
    }
}
