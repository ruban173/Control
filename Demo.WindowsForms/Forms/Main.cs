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
            db.Subsidiary_companies_region.Local.CollectionChanged += Local_CollectionChanged;
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

                gridSubsidiaryCompaniesRegion.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                    gridSubsidiaryCompaniesRegion.Columns["city"].HeaderText = "Город";
                    gridSubsidiaryCompaniesRegion.Columns["adress"].HeaderText = "Адрес";
                    gridSubsidiaryCompaniesRegion.Columns["latitude"].HeaderText = "Широта";
                    gridSubsidiaryCompaniesRegion.Columns["longitude"].HeaderText = "Долгота";

                    gridSubsidiaryCompaniesRegion.Columns["Goods"].Visible = false;
                    gridSubsidiaryCompaniesRegion.Columns["Sale"].Visible = false;
                    gridSubsidiaryCompaniesRegion.Columns["Subsidiary_companies"].Visible = false;
                    gridSubsidiaryCompaniesRegion.Columns["id_subsidiary_companies"].Visible = false;

                    gridSubsidiaryCompanies.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    gridSubsidiaryCompanies.Columns["title"].HeaderText = "Название";
                    gridSubsidiaryCompanies.Columns["description"].HeaderText = "Описание";

                    gridSubsidiaryCompanies.Columns["activity"].Visible = false;
                    gridSubsidiaryCompanies.Columns["Subsidiary_companies_region"].Visible = false;
                    gridSubsidiaryCompanies.Columns["date_up"].Visible = false;

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridSubsidiaryCompaniesRegion.CurrentRow != null)
            {
               
                var Row = gridSubsidiaryCompaniesRegion.CurrentRow.DataBoundItem as Subsidiary_companies_region;
                db.Subsidiary_companies_region.Remove(Row);
                db.SaveChanges();
               

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
