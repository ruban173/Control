namespace Demo.WindowsForms
{
    partial class Indicators
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridIndicators = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button_column = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.labRes = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIndicators)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 432);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(905, 34);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Продажи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 46);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridIndicators);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(905, 382);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 2;
            // 
            // gridIndicators
            // 
            this.gridIndicators.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridIndicators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIndicators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridIndicators.Location = new System.Drawing.Point(0, 0);
            this.gridIndicators.Name = "gridIndicators";
            this.gridIndicators.Size = new System.Drawing.Size(403, 382);
            this.gridIndicators.TabIndex = 0;
            this.gridIndicators.DataSourceChanged += new System.EventHandler(this.gridIndicators_DataSourceChanged);
            this.gridIndicators.Paint += new System.Windows.Forms.PaintEventHandler(this.gridIndicators_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Chart, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupInfo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(498, 382);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button_column);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Типы графиков";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(168, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Точечный";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_column
            // 
            this.button_column.Location = new System.Drawing.Point(87, 20);
            this.button_column.Name = "button_column";
            this.button_column.Size = new System.Drawing.Size(75, 23);
            this.button_column.TabIndex = 1;
            this.button_column.Text = "Гистограмма";
            this.button_column.UseVisualStyleBackColor = true;
            this.button_column.Click += new System.EventHandler(this.button_column_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Линейный";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Chart
            // 
            chartArea4.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea4);
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.Chart.Legends.Add(legend4);
            this.Chart.Location = new System.Drawing.Point(3, 196);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(492, 217);
            this.Chart.TabIndex = 1;
            this.Chart.Text = "chart1";
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.labRes);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupInfo.Location = new System.Drawing.Point(3, 3);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(492, 127);
            this.groupInfo.TabIndex = 2;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Информация";
            // 
            // labRes
            // 
            this.labRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labRes.Location = new System.Drawing.Point(3, 16);
            this.labRes.Multiline = true;
            this.labRes.Name = "labRes";
            this.labRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.labRes.Size = new System.Drawing.Size(486, 108);
            this.labRes.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отчет";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Indicators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 432);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Indicators";
            this.Text = "Показатели";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Indicators_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridIndicators)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridIndicators;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_column;
        private System.Windows.Forms.TextBox labRes;
        private System.Windows.Forms.Button button2;
    }
}