namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCreareCredit = new System.Windows.Forms.Button();
            this.tbNumeClient = new System.Windows.Forms.TextBox();
            this.tbSumaImprumutata = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbDobandaAnuala = new System.Windows.Forms.TextBox();
            this.tbDurataLuni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbAdaugaClient = new System.Windows.Forms.Button();
            this.btnRestaureazaClienti = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculeazaSumaTotalImprumutataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaClientDinBdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereClientDinBdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiseazaBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.afisezaClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreareCredit
            // 
            this.btnCreareCredit.Location = new System.Drawing.Point(12, 229);
            this.btnCreareCredit.Name = "btnCreareCredit";
            this.btnCreareCredit.Size = new System.Drawing.Size(163, 38);
            this.btnCreareCredit.TabIndex = 0;
            this.btnCreareCredit.Text = "Creare Credit";
            this.btnCreareCredit.UseVisualStyleBackColor = true;
            this.btnCreareCredit.Click += new System.EventHandler(this.btnCreareCredit_Click);
            // 
            // tbNumeClient
            // 
            this.tbNumeClient.Location = new System.Drawing.Point(99, 71);
            this.tbNumeClient.Name = "tbNumeClient";
            this.tbNumeClient.Size = new System.Drawing.Size(129, 22);
            this.tbNumeClient.TabIndex = 1;
            // 
            // tbSumaImprumutata
            // 
            this.tbSumaImprumutata.Location = new System.Drawing.Point(136, 111);
            this.tbSumaImprumutata.Name = "tbSumaImprumutata";
            this.tbSumaImprumutata.Size = new System.Drawing.Size(129, 22);
            this.tbSumaImprumutata.TabIndex = 2;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(99, 31);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(129, 22);
            this.tbId.TabIndex = 3;
            // 
            // tbDobandaAnuala
            // 
            this.tbDobandaAnuala.Location = new System.Drawing.Point(127, 181);
            this.tbDobandaAnuala.Name = "tbDobandaAnuala";
            this.tbDobandaAnuala.Size = new System.Drawing.Size(129, 22);
            this.tbDobandaAnuala.TabIndex = 4;
            // 
            // tbDurataLuni
            // 
            this.tbDurataLuni.Location = new System.Drawing.Point(119, 146);
            this.tbDurataLuni.Name = "tbDurataLuni";
            this.tbDurataLuni.Size = new System.Drawing.Size(129, 22);
            this.tbDurataLuni.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nume Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Suma Imprumutata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Durata in Luni";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dobanda Anuala";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(360, 12);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(350, 308);
            this.tbInfo.TabIndex = 12;
            this.tbInfo.Visible = false;
            // 
            // tbAdaugaClient
            // 
            this.tbAdaugaClient.Location = new System.Drawing.Point(191, 229);
            this.tbAdaugaClient.Name = "tbAdaugaClient";
            this.tbAdaugaClient.Size = new System.Drawing.Size(163, 38);
            this.tbAdaugaClient.TabIndex = 16;
            this.tbAdaugaClient.Text = "Salveaza in Fisier";
            this.tbAdaugaClient.UseVisualStyleBackColor = true;
            this.tbAdaugaClient.Click += new System.EventHandler(this.tbAdaugaClient_Click);
            // 
            // btnRestaureazaClienti
            // 
            this.btnRestaureazaClienti.Location = new System.Drawing.Point(191, 282);
            this.btnRestaureazaClienti.Name = "btnRestaureazaClienti";
            this.btnRestaureazaClienti.Size = new System.Drawing.Size(163, 38);
            this.btnRestaureazaClienti.TabIndex = 17;
            this.btnRestaureazaClienti.Text = "Restaureaza Clienti";
            this.btnRestaureazaClienti.UseVisualStyleBackColor = true;
            this.btnRestaureazaClienti.Click += new System.EventHandler(this.btnRestaureazaClienti_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1504, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculeazaSumaTotalImprumutataToolStripMenuItem,
            this.adaugaClientDinBdToolStripMenuItem,
            this.stergereClientDinBdToolStripMenuItem,
            this.afiseazaBDToolStripMenuItem,
            this.salvareXMLToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // calculeazaSumaTotalImprumutataToolStripMenuItem
            // 
            this.calculeazaSumaTotalImprumutataToolStripMenuItem.Name = "calculeazaSumaTotalImprumutataToolStripMenuItem";
            this.calculeazaSumaTotalImprumutataToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.calculeazaSumaTotalImprumutataToolStripMenuItem.Text = "Suma total Imprumutata";
            this.calculeazaSumaTotalImprumutataToolStripMenuItem.Click += new System.EventHandler(this.calculeazaSumaTotalImprumutataToolStripMenuItem_Click);
            // 
            // adaugaClientDinBdToolStripMenuItem
            // 
            this.adaugaClientDinBdToolStripMenuItem.Name = "adaugaClientDinBdToolStripMenuItem";
            this.adaugaClientDinBdToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.adaugaClientDinBdToolStripMenuItem.Text = "Adauga Client in BD";
            this.adaugaClientDinBdToolStripMenuItem.Click += new System.EventHandler(this.adaugaClientDinBdToolStripMenuItem_Click);
            // 
            // stergereClientDinBdToolStripMenuItem
            // 
            this.stergereClientDinBdToolStripMenuItem.Name = "stergereClientDinBdToolStripMenuItem";
            this.stergereClientDinBdToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.stergereClientDinBdToolStripMenuItem.Text = "Stergere Client din BD";
            this.stergereClientDinBdToolStripMenuItem.Click += new System.EventHandler(this.stergereClientDinBdToolStripMenuItem_Click);
            // 
            // afiseazaBDToolStripMenuItem
            // 
            this.afiseazaBDToolStripMenuItem.Name = "afiseazaBDToolStripMenuItem";
            this.afiseazaBDToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.afiseazaBDToolStripMenuItem.Text = "Afiseaza BD";
            this.afiseazaBDToolStripMenuItem.Click += new System.EventHandler(this.afiseazaBDToolStripMenuItem_Click);
            // 
            // salvareXMLToolStripMenuItem
            // 
            this.salvareXMLToolStripMenuItem.Name = "salvareXMLToolStripMenuItem";
            this.salvareXMLToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.salvareXMLToolStripMenuItem.Text = "Salvare XML";
            this.salvareXMLToolStripMenuItem.Click += new System.EventHandler(this.salvareXMLToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Grafic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisezaClientToolStripMenuItem,
            this.incarcaDateToolStripMenuItem,
            this.printToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(170, 76);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // afisezaClientToolStripMenuItem
            // 
            this.afisezaClientToolStripMenuItem.Name = "afisezaClientToolStripMenuItem";
            this.afisezaClientToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.afisezaClientToolStripMenuItem.Text = "Afiseza Grafic";
            this.afisezaClientToolStripMenuItem.Click += new System.EventHandler(this.afisezaClientToolStripMenuItem_Click);
            // 
            // incarcaDateToolStripMenuItem
            // 
            this.incarcaDateToolStripMenuItem.Name = "incarcaDateToolStripMenuItem";
            this.incarcaDateToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.incarcaDateToolStripMenuItem.Text = "Incarca Date";
            this.incarcaDateToolStripMenuItem.Click += new System.EventHandler(this.incarcaDateToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.printToolStripMenuItem.Text = "Print ";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(732, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "SumaImprumutata";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(760, 370);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 289);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1504, 712);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRestaureazaClienti);
            this.Controls.Add(this.tbAdaugaClient);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDurataLuni);
            this.Controls.Add(this.tbDobandaAnuala);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbSumaImprumutata);
            this.Controls.Add(this.tbNumeClient);
            this.Controls.Add(this.btnCreareCredit);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Credite Bancare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreareCredit;
        private System.Windows.Forms.TextBox tbNumeClient;
        private System.Windows.Forms.TextBox tbSumaImprumutata;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbDobandaAnuala;
        private System.Windows.Forms.TextBox tbDurataLuni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button tbAdaugaClient;
        private System.Windows.Forms.Button btnRestaureazaClienti;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calculeazaSumaTotalImprumutataToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem afisezaClientToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem incarcaDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem adaugaClientDinBdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereClientDinBdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiseazaBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareXMLToolStripMenuItem;
    }
}

