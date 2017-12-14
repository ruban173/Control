using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Demo.WindowsForms
{
    public partial class Main : Form
    {
        ConnectContext db;
        User_access user;
        Subsidiary_companies SubsidiaryCompanies;
        
        public Main()
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
        }
        public  Main(User_access user)
        {
            InitializeComponent();
            db = new ConnectContext((new ConfigJson()).StringConnecting());
            this.user = user;

        }
        void Local_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RefreshModels();

        }
        private void RefreshModels()
        {
            if (gridSubsidiaryCompanies.CurrentRow != null)
            {

                var currentSubsidiaryCompanies = gridSubsidiaryCompanies.CurrentRow.DataBoundItem as Subsidiary_companies;
                if (currentSubsidiaryCompanies != null) gridSubsidiaryCompaniesRegion.DataSource = currentSubsidiaryCompanies.Subsidiary_companies_region.ToList();

            /*    gridGoods.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                gridGoods.Columns["title"].HeaderText = "Название";
                gridGoods.Columns["shelf_life"].HeaderText = "Срок годности";
                gridGoods.Columns["date_create"].HeaderText = "Дата производства";
                gridGoods.Columns["code"].HeaderText = "Штрих код";
                gridGoods.Columns["manufacturer"].HeaderText = "Производитель";
                gridGoods.Columns["count"].HeaderText = "Количество";

                gridGoods.Columns["id_goods_category"].Visible = false;
                gridGoods.Columns["id_subsidiary_companies_region"].Visible = false;
                gridGoods.Columns["status"].Visible = false;
                gridGoods.Columns["Subsidiary_companies_region"].Visible = false;
                gridGoods.Columns["price"].Visible = false;
                gridGoods.Columns["discont"].Visible = false;
                gridGoods.Columns["measurement"].Visible = false;
                gridGoods.Columns["Goods_category"].Visible = false;
                gridGoods.Columns["description"].Visible = false;
                gridGoods.Columns["basket"].Visible = false;
                gridGoods.Columns["Sale_basket"].Visible = false;
                */
            }
            gridSubsidiaryCompanies.Refresh();
          


        }

        private void Main_Load(object sender, EventArgs e)
        {
            gridSubsidiaryCompanies.DataSource = db.Subsidiary_companies.ToList();
        }

        private void картаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GisForm().Show();
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void gridSubsidiaryCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshModels();
        }

        

        private void gridSubsidiaryCompaniesRegion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridSubsidiaryCompaniesRegion.CurrentRow != null)
            {
                
                Subsidiary_companies_region currentCompaniesRegion = gridSubsidiaryCompaniesRegion.CurrentRow.DataBoundItem as Subsidiary_companies_region;
                DataTable table = new DataTable("TableInfo");
                DataColumn column;


                column = new DataColumn();
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "id";
                column.AutoIncrement = true;
                column.Caption = "ID";
                column.ReadOnly = true;
                column.Unique = true;
                table.Columns.Add(column);
                column = new DataColumn();

                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "countEmp";
                column.AutoIncrement = true;
                column.Caption = "Количество сотрудников";
                column.ReadOnly = true;
                column.Unique = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "sumAll";
                column.AutoIncrement = true;
                column.Caption = "Доход всего";
                column.ReadOnly = true;
                column.Unique = true;
                table.Columns.Add(column);

                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "sumDD";
                column.AutoIncrement = true;
                column.Caption = "Доход за день";
                column.ReadOnly = true;
                column.Unique = true;
                table.Columns.Add(column);

                var sum = db.Sale.Where(s => s.id == currentCompaniesRegion.id).Sum(s => s.price);
                  DataRow row = table.NewRow();
                  row["id"] = 1;
                  row["countEmp"] = db.Employees.Where(s=>s.id== currentCompaniesRegion.id).Count();
                  row["sumAll"] = (sum==null)?0.ToString():sum.ToString();
                 // row["sumDD"] = db.Sale.Where(s => s.id == currentCompaniesRegion.id && s.date_up==DateTime.Now.Date).Sum(s => s.price).Value.ToString();

                table.Rows.Add(row);

                gridInfCompany.DataSource = table;
            }
        }
    }
}
