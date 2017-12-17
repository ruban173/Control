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
                gridSubsidiaryCompaniesRegion.ClearSelection();
                gridSubsidiaryCompaniesRegion.CurrentCell = null;



            }
            gridSubsidiaryCompanies.Refresh();
          


        }

        private void Main_Load(object sender, EventArgs e)
        {
            gridSubsidiaryCompanies.DataSource = db.Subsidiary_companies.ToList();
            RefreshModels();

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
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Indicators( ref gridSubsidiaryCompanies,ref gridSubsidiaryCompaniesRegion).Show();
        }
    }
}
