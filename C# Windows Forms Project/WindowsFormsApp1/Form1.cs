using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
         List<Client> clienti = new List<Client>();
         Client client;
         Credit credit;
         List<Credit> listCredit = new List<Credit>();
        List<ClientGrafic> listaclientigrafic = new List<ClientGrafic>();
        bool dateIncarcate;

        const int margine = 10;
        Color culoareBars = Color.Blue;
        Font fontText = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        Color culoareText = Color.Black;
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Facultate\ANUL 2\SEMESTRUL 2\PAW\Proiect PAW\1052_Florescu_Eduard-Andrei_\WindowsFormsApp1\Database.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);


        public Form1()
        {
            InitializeComponent();
            chart1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCreareCredit_Click(object sender, EventArgs e)
        {
            tbInfo.Visible = true;
            string numeClient = tbNumeClient.Text;
            decimal sumaImprumutata = decimal.Parse(tbSumaImprumutata.Text);
            int id = int.Parse(tbId.Text);
            int durataInLuni = int.Parse(tbDurataLuni.Text);
            decimal dobandaAnuala = decimal.Parse(tbDobandaAnuala.Text);
            Credit credit = new ConcreteCredit(id, numeClient, sumaImprumutata, durataInLuni, dobandaAnuala);
            Client client = new Client(numeClient);
            client.AdaugaCredit(credit);
            tbInfo.AppendText($"ID: {id}, Nume: {numeClient}, Suma: {sumaImprumutata}, Durata: {durataInLuni}, Dobanda: {dobandaAnuala}%\n");
            MessageBox.Show("Credit adaugat cu succes");
        }

        private void salvareFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }
        private void tbAdaugaClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNumeClient.Text))
            {
                MessageBox.Show("Introduceți numele clientului.");
                return;
            }

            if (!decimal.TryParse(tbSumaImprumutata.Text, out decimal sumaImprumutata))
            {
                MessageBox.Show("Introduceți o sumă de imprumut validă.");
                return;
            }

            int id = int.Parse(tbId.Text);
            int durataInLuni = int.Parse(tbDurataLuni.Text);
            decimal dobandaAnuala = decimal.Parse(tbDobandaAnuala.Text);
            Client client = new Client(tbNumeClient.Text);
            Credit credit = new ConcreteCredit(id, tbNumeClient.Text, sumaImprumutata, durataInLuni, dobandaAnuala); 

            client.AdaugaCredit(credit);
            clienti.Add(client);

            SalveazaClientiInFisier("clienti.txt");

            MessageBox.Show("Clientul a fost adăugat și datele au fost salvate.");
        }

        private void SalveazaClientiInFisier(string numeFisier)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(numeFisier))
                {
                    foreach (Client client in clienti)
                    {
                       // writer.WriteLine(client.Nume);

                        foreach (Credit credit in client.Credite)
                        {
                            writer.WriteLine($"{credit.Id},{credit.NumeClient},{credit.SumaImprumutata},{credit.DurataInLuni},{credit.DobandaAnuala}");
                        }

                        //writer.WriteLine(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la salvarea datelor: {ex.Message}");
            }
        }

        private void btnRestaureazaClienti_Click(object sender, EventArgs e)
        {
            RestaureazaClientiDinFisier("clienti.txt");
            MessageBox.Show("Datele au fost restaurate din fișier.");
        }
        private void RestaureazaClientiDinFisier(string numeFisier)
        {
            try
            {
                if (File.Exists("clienti.txt"))
                {
                    clienti.Clear();

                    using (StreamReader sr = new StreamReader("clienti.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] clientData = line.Split(',');

                            if (clientData.Length == 2)
                            {
                                string nume = clientData[0];
                                Client client = new Client(nume);

                                string[] crediteData = clientData[1].Split(';');
                                foreach (string creditString in crediteData)
                                {
                                    string[] creditData = creditString.Split('|');

                                    if (creditData.Length == 5)
                                    {
                                        int id = int.Parse(creditData[0]);
                                        string numeClient = creditData[1];
                                        decimal sumaImprumutata = decimal.Parse(creditData[2]);
                                        int durataInLuni = int.Parse(creditData[3]);
                                        decimal dobandaAnuala = decimal.Parse(creditData[4]);

                                        Credit credit = new ConcreteCredit(id, numeClient, sumaImprumutata, durataInLuni, dobandaAnuala);
                                        client.AdaugaCredit(credit);
                                    }
                                }

                                clienti.Add(client);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la restaurarea datelor: {ex.Message}");
            }
        }

        private void calculeazaSumaTotalImprumutataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbSumaImprumutata.Text, out decimal sumaImprumutata) &&
            int.TryParse(tbDurataLuni.Text, out int durataInLuni) &&
            decimal.TryParse(tbDobandaAnuala.Text, out decimal dobandaAnuala))
            {
                decimal sumaTotala = sumaImprumutata + (sumaImprumutata * durataInLuni * dobandaAnuala) / 100;
                MessageBox.Show($"Suma totala imprumutata este: {sumaTotala}");
            }
            else
            {
                MessageBox.Show("Datele introduse nu sunt valide.");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(button1, 0, button1.Height);
        }

        private void afisezaClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dateIncarcate == true)
            {
                chart1.Series["SumaImprumutata"].Points.Clear();
                chart1.Titles.Clear();
                chart1.Visible = true;
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
                for (int i = 0; i < listaclientigrafic.Count; i++)
                {
                    chart1.Series["SumaImprumutata"].Points.AddXY(listaclientigrafic[i].Nume, listaclientigrafic[i].SUmaImprumutata);
                }
                chart1.Titles.Add("Clienti-Sume Imprumutate");
            }
            else
            {
                MessageBox.Show("Datele nu au fost incarcate");
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Date.txt");
            string linie = null;
            listaclientigrafic.Clear();
            while ((linie = sr.ReadLine()) != null)
            {
                try
                {
                    string nume = linie.Split(',')[0];
                    int sumaImprumutata = Convert.ToInt32(linie.Split(',')[1]);
                    ClientGrafic c = new ClientGrafic(nume,sumaImprumutata);
                    listaclientigrafic.Add(c);
                    dateIncarcate = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            sr.Close();
            MessageBox.Show("S-au incarcat datele!");
        }

        private void pp(object sender, PrintPageEventArgs e)
        {
            if (dateIncarcate)
            {
                Graphics g = e.Graphics;
                Rectangle rectangle = new Rectangle(e.PageBounds.X + margine, e.PageBounds.Y + 4 * margine,
                    e.PageBounds.Width - 2 * margine, e.PageBounds.Height - 5 * margine);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rectangle);

                double latime = rectangle.Width / listaclientigrafic.Count / 3;
                double distanta = (rectangle.Width - listaclientigrafic.Count * latime) / (listaclientigrafic.Count + 1);
                double vMax = listaclientigrafic.Max(max => max.SUmaImprumutata);

                Brush brBars = new SolidBrush(culoareBars);
                Brush brFont = new SolidBrush(culoareText);

                Rectangle[] rectangles = new Rectangle[listaclientigrafic.Count];
                for (int i = 0; i < rectangles.Length; i++)
                {
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rectangle.Location.Y + rectangle.Height - listaclientigrafic[i].SUmaImprumutata / vMax * rectangle.Height),
                        (int)latime,
                        (int)(listaclientigrafic[i].SUmaImprumutata / vMax * rectangle.Height));

                    g.DrawString(listaclientigrafic[i].Nume, fontText, brFont, new Point((int)(rectangles[i].Location.X),
                        (int)(rectangles[i].Location.Y - fontText.Height)));
                }
                g.FillRectangles(brBars, rectangles);

                for (int i = 0; i < listaclientigrafic.Count - 1; i++)
                {
                    g.DrawLine(pen, new Point((int)(rectangles[i].Location.X + latime / 2), (int)(rectangles[i].Location.Y)),
                        new Point((int)(rectangles[i + 1].Location.X + latime / 2), (int)(rectangles[i + 1].Location.Y)));
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pp);
            PrintPreviewDialog pdlg = new PrintPreviewDialog
            {
                Document = pd
            };
            pdlg.ShowDialog();
        }

        private void adaugaClientDinBdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            connection.Open();
            string numeClient = tbNumeClient.Text;
            decimal sumaImprumutata = decimal.Parse(tbSumaImprumutata.Text);
            int id = int.Parse(tbId.Text);
            int durataInLuni = int.Parse(tbDurataLuni.Text);
            decimal dobandaAnuala = decimal.Parse(tbDobandaAnuala.Text);
            Credit credit = new ConcreteCredit(id, numeClient, sumaImprumutata, durataInLuni, dobandaAnuala);
            Client client = new Client(numeClient);
            client.AdaugaCredit(credit);
            SqlCommand cmd=connection.CreateCommand();
            cmd = new SqlCommand("INSERT INTO Clienti(Id, NumeClient, SumaImprumutata, DurataInLuni, DobandaAnuala) VALUES(@id, @numeClient,@sumaImprumutata,@durataInLuni,@dobandaAnuala)", connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@numeClient", numeClient);
            cmd.Parameters.AddWithValue("@sumaImprumutata", sumaImprumutata);
            cmd.Parameters.AddWithValue("@durataInLuni", durataInLuni);
            cmd.Parameters.AddWithValue("@dobandaAnuala", dobandaAnuala);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = connection.CreateCommand();
            cmd2 = new SqlCommand("SELECT Id, NumeClient, SumaImprumutata, DurataInLuni, DobandaAnuala FROM Clienti", connection);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            DataTable dataTable=new DataTable();
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();

            MessageBox.Show("Clietul adaugat cu succes!");

           
        }

        private void stergereClientDinBdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int idToDelete = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd = new SqlCommand("DELETE FROM Clienti WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", idToDelete);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = connection.CreateCommand();
            cmd2 = new SqlCommand("SELECT Id, NumeClient, SumaImprumutata, DurataInLuni, DobandaAnuala FROM Clienti", connection);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            adapter = new SqlDataAdapter(cmd2);
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
            MessageBox.Show("Clientul cu ID-ul " + idToDelete + " a fost sters cu succes!");
        }

        private void afiseazaBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from Clienti";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void salvareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog.Title = "Fisier XML de salvat";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                dataTable.TableName = "Clienti";

                StreamWriter streamWriter = new StreamWriter(fileName);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataTable));
                xmlSerializer.Serialize(streamWriter, dataTable);

                MessageBox.Show("Datele au fost salvate in fisierul XML!");
            }
        }
    }
 }


