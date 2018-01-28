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
    public partial class Indicators : Form
    {

        ConnectContext db;
        DataGridView gridSubsidiaryCompanies;
        DataGridView gridSubsidiaryCompaniesRegion;
        public Indicators()
        {
            InitializeComponent();
            this.db = new ConnectContext((new ConfigJson()).StringConnecting());
        }
        public Indicators(ref DataGridView gridSubsidiaryCompanies, ref DataGridView gridSubsidiaryCompaniesRegion)
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            this.gridSubsidiaryCompanies = gridSubsidiaryCompanies;
            this.gridSubsidiaryCompaniesRegion = gridSubsidiaryCompaniesRegion;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new ParamsSaleOrder(ref gridIndicators, ref labRes, ref Chart).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var BestEmp = from s in db.Sale
                          join p in db.Employees on s.id_employess equals p.id_user_access

                          select new
                          {
                              s.id,
                              fio = p.first_name + " " + p.middle_name + " " + p.last_name,
                              // s.date_up, s.payment, s.price, count = s.Sale_basket.Count()
                          };
            gridIndicators.DataSource = BestEmp.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in Chart.Series) item.ChartType = SeriesChartType.Line;


        }

        private void button_column_Click(object sender, EventArgs e)
        {
            foreach (var item in Chart.Series) item.ChartType = SeriesChartType.RangeColumn;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in Chart.Series) item.ChartType = SeriesChartType.Point;

        }

        private void Indicators_Load(object sender, EventArgs e)
        {
           
            List<int?> idRegion = new List<int?>();
            if (this.gridSubsidiaryCompanies.CurrentRow != null)
            {
                if (this.gridSubsidiaryCompaniesRegion.CurrentRow != null)
                {

                    foreach (DataGridViewRow item in this.gridSubsidiaryCompaniesRegion.SelectedRows)
                    {
                        var row = item.DataBoundItem as Subsidiary_companies_region;
                        idRegion.Add(row.id);

                    }

                    ChartCreate(idRegion);
                }
                else
                {
                    var row = this.gridSubsidiaryCompanies.CurrentRow.DataBoundItem as Subsidiary_companies;
                    foreach (var item in db.Subsidiary_companies_region.Where(s => s.id_subsidiary_companies == row.id).ToList()) idRegion.Add(row.id);
                    ChartCreate(idRegion);

                }

                gridIndicators.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                gridIndicators.Columns["date_up"].HeaderText = "Дата";
                gridIndicators.Columns["payment"].HeaderText = "Стоимость со скидкой";
                gridIndicators.Columns["price"].HeaderText = "Стоимость без скидки";
                gridIndicators.Columns["count"].HeaderText = "Количество";
                gridIndicators.Columns["company"].HeaderText = "Дочерняя компания";

                gridIndicators.Columns["id_reg"].Visible = false;

            }

            else
            {
                gridIndicators.DataSource = null;

                MessageBox.Show("По запросу ничего не найдено");
            }
        }

        private void ChartCreate(List<int?> idRegion = null)
        {

            Subsidiary_companies_region legendText = null;
            var res = from s in db.Sale
                        where idRegion.Contains(s.id_subsidiary_companies_region)
                        select new
                        {
                            s.id,
                            s.date_up,
                            s.payment,
                            s.price,
                            count = s.Sale_basket.Count(),
                            id_reg = s.Subsidiary_companies_region,
                            company = s.Subsidiary_companies_region.Subsidiary_companies.title + " " + s.Subsidiary_companies_region.adress
                        };
            
            gridIndicators.DataSource = res.ToList();

            if (res.Count() != 0)
            {
                foreach (var item in idRegion)
                {

                    Series series = new Series
                    {
                        XValueMember = "date_up",
                        XValueType = ChartValueType.DateTime,
                        YValueType = ChartValueType.Double,
                        YValueMembers = "payment"
                    };
                    series.ChartType = SeriesChartType.Line;

                    if (res.Where(s => s.id_reg.id == item).Count() != 0)
                    {
                        series.Points.DataBind(res.Where(s => s.id_reg.id == item), "date_up", "payment", null);
                        series.LegendText = res.Where(s => s.id_reg.id == item).First().company.ToString();
                        this.Chart.Series.Add(series);
                    }
                    else
                    {
                        legendText = db.Subsidiary_companies_region.Where(s => s.id == item).First();
                        series.LegendText = legendText.Subsidiary_companies.title.ToString() + " " + legendText.adress.ToString() + " (Нет продаж)";
                        this.Chart.Series.Add(series);
                    }

                    this.labRes.Text += (res.Where(s => s.id_reg.id == item).Count() != 0) ? "---- " + res.First().company.ToString() + "----" + Environment.NewLine +
                    "-> Выручка= " + res.Sum(d => d.payment).ToString() +
                                    Environment.NewLine + " -> Количество товаров=" + res.Sum(d => d.count).ToString() +
                                    Environment.NewLine + " ->  Период продаж с " + res.Min(d => d.date_up).ToString() +
                                    Environment.NewLine + " по " + res.Max(d => d.date_up).ToString() +
                                    Environment.NewLine + " ->  Максимальная стоимость сделки " + res.Max(d => d.payment).ToString() +
                                    Environment.NewLine + " ->  Минимальная стоимость сделки " + res.Min(d => d.payment).ToString() + Environment.NewLine
                                    : "---- " + legendText.Subsidiary_companies.title + " " + legendText.adress + "----" +
                                    Environment.NewLine + "-> Выручка= 0" +
                                    Environment.NewLine + " -> Количество товаров=0" +
                                    Environment.NewLine + " ->  Период продаж с отсутствует" +
                                    Environment.NewLine + " ->  Максимальная стоимость сделки 0" +
                                    Environment.NewLine + " ->  Минимальная стоимость сделки 0" + Environment.NewLine;
                }
            }

        }

        private void gridIndicators_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void gridIndicators_DataSourceChanged(object sender, EventArgs e)
        {
        
        }
    }
}
