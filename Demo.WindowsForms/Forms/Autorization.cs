using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Demo.WindowsForms
{
    public partial class Autorization : Form
    {
        ConnectContext db;
        IEnumerable<User_access> user;
        public Autorization()
        {
            InitializeComponent();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                if (user.Count() == 1)
                {
                    foreach (User_access u in user)
                    {
                       switch (u.type)
                        {
                            case "управление": new Main().Show(); break;
                           

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с такими данными не зарегистрирован!");
                }

        }
        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Configuration()).Show();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            try
            {
                db = new ConnectContext((new ConfigJson()).StringConnecting());
                user = db.User_access.Where(u => (u.login == login.Text && u.password == password.Text));
                user.ToList();
            }
            catch
            {

                MessageBox.Show("Проверьте настройки подключения к серверу БД");
                (new Configuration()).Show();

            }
        }
    }
}
