using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;


namespace Demo.WindowsForms
{
    public partial class Admin : Form
    {
        int? id_region;
        ConnectContext db;
       

        public Admin()
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
        }
        public Admin(int id_region)
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            this.id_region = id_region;
            this.Text = db.Subsidiary_companies_region.Where(x => x.id == id_region).First().adress;

        }
        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AddEmployee((int)this.id_region)).Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new UserAccess((int)this.id_region)).Show();

        }

        private void сменитьРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminSaleOrder(ref gridAdmin,ref  labRres,ref Chart).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var BestEmp = from s in db.Sale

                          join p in db.Employees on s.id_employess equals p.id_user_access
                          where s.id_subsidiary_companies_region == this.id_region

                          select new
                          {
                              s.id,
                              fio = p.first_name + " " + p.middle_name + " " + p.last_name,
                              // s.date_up, s.payment, s.price, count = s.Sale_basket.Count()
                          };
            gridAdmin.DataSource = BestEmp.ToList();

        }

        private void Chart_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             Chart.Series[0].ChartType = SeriesChartType.Line;

        }

        private void button_column_Click(object sender, EventArgs e)
        {
            Chart.Series[0].ChartType = SeriesChartType.RangeColumn;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chart.Series[0].ChartType = SeriesChartType.Point;

        }
    }
}
