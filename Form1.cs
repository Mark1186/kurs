using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kursach
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=MARK-PC;Initial Catalog=KurSoft;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "\n\n\nБаза данных "+"\nУчета лицензионного Программного Обеспечения";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {    
            /*
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True";
                string com = "SELECT * FROM dbo.Groups";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(com, connection);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // string com = "INSERT Groups VALUES('Three Days Greace',2002)";
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //SqlDataAdapter adapter = new SqlDataAdapter("INSERT INTO Groups (Name, Year) VALUES('"+this.tbId.Text +"','"+ Convert.ToInt32(tbName.Text) +"')", connection);
               // adapter.SelectCommand.ExecuteNonQuery();

            }
        }

        private void but_Click(object sender, EventArgs e)
        {
            // string com = "INSERT Groups VALUES('Three Days Greace',2002)";
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //SqlDataAdapter adapter = new SqlDataAdapter("INSERT INTO Groups (Name, Year) VALUES('" +  + "','" + Convert.ToInt32(this.textBox2.Text) + "')", connection);
               // adapter.SelectCommand.ExecuteNonQuery();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Software software = new Software();
            Hide();
            software.ShowDialog();
            software.StartPosition = FormStartPosition.CenterScreen;
        }

        private void typeSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Type_Software type_Software = new Type_Software();
            Hide();
            type_Software.ShowDialog();
            type_Software.StartPosition = FormStartPosition.CenterScreen;
        }

        private void firmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Firm firm = new Firm();
            Hide();
            firm.ShowDialog();
            firm.StartPosition = FormStartPosition.CenterScreen;
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            License license = new License();
            Hide();
            license.ShowDialog();
            license.StartPosition = FormStartPosition.CenterScreen;
        }

        private void licenseSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            License_Software license_Software = new License_Software();
            Hide();
            license_Software.ShowDialog();
            license_Software.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            PC pC = new PC();
            Hide();
            pC.ShowDialog();
            pC.StartPosition = FormStartPosition.CenterScreen;
        }

        private void typePCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Type_PC type_PC = new Type_PC();
            Hide();
            type_PC.ShowDialog();
            type_PC.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pCSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            PC_Software pC_Software = new PC_Software();
            Hide();
            pC_Software.ShowDialog();
            pC_Software.StartPosition = FormStartPosition.CenterScreen;
        }

        private void documentMovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Document_Mov document_Mov = new Document_Mov();
            Hide();
            document_Mov.ShowDialog();
            document_Mov.StartPosition = FormStartPosition.CenterScreen;
        }

        private void typeDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Type_Doc type_Doc = new Type_Doc();
            Hide();
            type_Doc.ShowDialog();
            type_Doc.StartPosition = FormStartPosition.CenterScreen;
        }

        private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Organization organization = new Organization();
            Hide();
            organization.ShowDialog();
            organization.StartPosition = FormStartPosition.CenterScreen;
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Division division = new Division();
            Hide();
            division.ShowDialog();
            division.StartPosition = FormStartPosition.CenterScreen;
        }

        private void softwareCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Software_Comp software_Comp = new Software_Comp();
            Hide();
            software_Comp.ShowDialog();
            software_Comp.StartPosition = FormStartPosition.CenterScreen;
        }

        private void streetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Street street = new Street();
            Hide();
            street.ShowDialog();
            street.StartPosition = FormStartPosition.CenterScreen;
        }

        private void humanSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Human_Set human_Set = new Human_Set();
            Hide();
            human_Set.ShowDialog();
            human_Set.StartPosition = FormStartPosition.CenterScreen;
        }

        private void typeStreetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Type_Street type_Street = new Type_Street();
            Hide();
            type_Street.ShowDialog();
            type_Street.StartPosition = FormStartPosition.CenterScreen;
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Phone phone = new Phone();
            Hide();
            phone.ShowDialog();
            phone.StartPosition = FormStartPosition.CenterScreen;
        }

        private void запрос1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query1 query1 = new Query1();
            Hide();
            query1.ShowDialog();
            query1.StartPosition = FormStartPosition.CenterScreen;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mes = "Программа учета лицензионного ПО" +
                "\n\t\tAutor: Vakhitov M.R." +
                "\n\t\tGroup: 17IVT(ba)OP";
            MessageBox.Show(mes);
        }

        private async void списокЛицензионногоПОИЕгоКоличествоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = new DataGridView();
            panel3.Controls.Clear();
            try
            {
                dataGrid.Visible = true;
                dataGrid.Dock = DockStyle.Fill;
                panel3.Controls.Add(dataGrid);
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Division_Lic_Soft ORDER BY 'Дата установки' DESC", connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGrid.DataSource = dt;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private async void списокПодразделенийКоличествоПКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = new DataGridView();
            panel3.Controls.Clear();
            try
            {
                

                dataGrid.Visible = true;
                dataGrid.Dock = DockStyle.Fill;
                panel3.Controls.Add(dataGrid);
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Software_LicSoft", connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGrid.DataSource = dt;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private async void использованиеПредставления3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = new DataGridView();
            panel3.Controls.Clear();
            try
            {


                dataGrid.Visible = true;
                dataGrid.Dock = DockStyle.Fill;
                panel3.Controls.Add(dataGrid);
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Division_PC_DocMov ORDER BY 'Дата установки' DESC", connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGrid.DataSource = dt;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
