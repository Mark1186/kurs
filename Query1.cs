using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Query1 : Form
    {
        string connectionString = @"Data Source=MARK-PC;Initial Catalog=KurSoft;Integrated Security=True";

        public Query1()
        {
            InitializeComponent();
        }

        private void Query1_Load(object sender, EventArgs e)
        {

        }

        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Software software = new Software();
            Hide();
            software.ShowDialog();
            software.StartPosition = FormStartPosition.CenterScreen;
        }

        private void typeSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type_Software type_Software = new Type_Software();
            Hide();
            type_Software.ShowDialog();
            type_Software.StartPosition = FormStartPosition.CenterScreen;
        }

        private void firmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Firm firm = new Firm();
            Hide();
            firm.ShowDialog();
            firm.StartPosition = FormStartPosition.CenterScreen;
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            License license = new License();
            Hide();
            license.ShowDialog();
            license.StartPosition = FormStartPosition.CenterScreen;
        }

        private void licenseSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            License_Software license_Software = new License_Software();
            Hide();
            license_Software.ShowDialog();
            license_Software.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PC pC = new PC();
            Hide();
            pC.ShowDialog();
            pC.StartPosition = FormStartPosition.CenterScreen;
        }

        private void typePCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type_PC type_PC = new Type_PC();
            Hide();
            type_PC.ShowDialog();
            type_PC.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pCSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PC_Software pC_Software = new PC_Software();
            Hide();
            pC_Software.ShowDialog();
            pC_Software.StartPosition = FormStartPosition.CenterScreen;
        }

        private void documentMovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document_Mov document_Mov = new Document_Mov();
            Hide();
            document_Mov.ShowDialog();
            document_Mov.StartPosition = FormStartPosition.CenterScreen;
        }

        private void typeDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type_Doc type_Doc = new Type_Doc();
            Hide();
            type_Doc.ShowDialog();
            type_Doc.StartPosition = FormStartPosition.CenterScreen;
        }

        private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Organization organization = new Organization();
            Hide();
            organization.ShowDialog();
            organization.StartPosition = FormStartPosition.CenterScreen;
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Division division = new Division();
            Hide();
            division.ShowDialog();
            division.StartPosition = FormStartPosition.CenterScreen;
        }

        private void softwareCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Software_Comp software_Comp = new Software_Comp();
            Hide();
            software_Comp.ShowDialog();
            software_Comp.StartPosition = FormStartPosition.CenterScreen;
        }

        private void streetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Street street = new Street();
            Hide();
            street.ShowDialog();
            street.StartPosition = FormStartPosition.CenterScreen;
        }

        private void humanSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Human_Set human_Set = new Human_Set();
            Hide();
            human_Set.ShowDialog();
            human_Set.StartPosition = FormStartPosition.CenterScreen;
        }

        private void typeStreetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type_Street type_Street = new Type_Street();
            Hide();
            type_Street.ShowDialog();
            type_Street.StartPosition = FormStartPosition.CenterScreen;
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();
            Hide();
            phone.ShowDialog();
            phone.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lbMessage.Text = "на заданную дату список подразделений, \nна компьютерах которых установлено \nне лицензионное ПО";
                lbMessage.Visible = true;
                dataGridView1.Columns.Clear();
                dataGridView2.Columns.Clear();
                dataGridView3.Columns.Clear();
                dataGridView4.Columns.Clear();
                groupBox2.Text = "Software";
                groupBox4.Text = "License_Software";
                groupBox3.Text = "";
                groupBox6.Text = "Result";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Division", connection);
                    var adapter2 = new SqlDataAdapter("SELECT * FROM Software", connectionString);
                    var adapter3 = new SqlDataAdapter("SELECT * FROM License_Software", connectionString);

                    DataTable table1 = new DataTable();
                    DataTable table2 = new DataTable();
                    DataTable table3 = new DataTable();

                    adapter1.Fill(table1);
                    adapter2.Fill(table2);
                    adapter3.Fill(table3);


                    dataGridView1.DataSource = table1;
                    dataGridView2.DataSource = table2;
                    dataGridView3.DataSource = table3;

                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    string str = "SELECT Division.Name_Div, Software.Name_Product, Software.Installation_Date, License_Software.Type_License " +
                            "FROM Division " +
                            "INNER JOIN Software ON Division.Id = Software.Id " +
                            "INNER JOIN License_Software ON Software.Id = License_Software.Software_Id " +
                            "WHERE Software.Installation_Date = '" + dateTimePicker1.Value.Date + "' AND License_Software.Type_License = '" + comboBox1.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(str, connection);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dataGridView4.DataSource = dt;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private async void btShow2_Click(object sender, EventArgs e)
        {
            try
            {
                lbMessage.Text = "список лицензионного ПО, \nколичество лицензий на это ПО \n(по убыванию) на заданную дату";
                lbMessage.Visible = true;
                dataGridView1.Columns.Clear();
                dataGridView2.Columns.Clear();
                dataGridView3.Columns.Clear();
                dataGridView4.Columns.Clear();
                groupBox2.Text = "Software";
                groupBox4.Text = "License_Software";
                groupBox3.Text = "";
                groupBox6.Text = "Result";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Software", connection);
                    var adapter2 = new SqlDataAdapter("SELECT * FROM License_Software", connectionString);

                    DataTable table1 = new DataTable();
                    DataTable table2 = new DataTable();

                    adapter1.Fill(table1);
                    adapter2.Fill(table2);


                    dataGridView1.DataSource = table1;
                    dataGridView2.DataSource = table2;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        

        private async void btExec2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    string str = "SELECT Software.Name_Product, Software.Installation_Date, License_Software.Type_License, " +
                            "COUNT(*) as count_of_license " +
                            "FROM Software " +
                            "LEFT JOIN License_Software ON License_Software.Software_Id = Software.Id " +
                            "WHERE Software.Installation_Date = '" + dateTimePicker1.Value.Date + "' AND License_Software.Type_License <> '" + comboBox1.Text + "'" +
                            "GROUP BY Software.Name_Product, Software.Installation_Date, License_Software.Type_License " +
                            "ORDER BY Software.Name_Product DESC, Software.Installation_Date DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(str, connection);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dataGridView4.DataSource = dt;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }

        private async void btShow3_Click(object sender, EventArgs e)
        {
            lbMessage.Text = "список подразделений, \nколичество компьютеров у подразделения \n(по убыванию) на заданную дату";
            lbMessage.Visible = true;
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Columns.Clear();
            dataGridView4.Columns.Clear();
            groupBox2.Text = "Division";
            groupBox4.Text = "Document_Mov";
            groupBox3.Text = "PC";
            groupBox6.Text = "Result";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Division", connection);
                    var adapter2 = new SqlDataAdapter("SELECT * FROM Document_Mov", connectionString);
                    var adapter3 = new SqlDataAdapter("SELECT * FROM PC", connectionString);

                    DataTable table1 = new DataTable();
                    DataTable table2 = new DataTable();
                    DataTable table3 = new DataTable();

                    adapter1.Fill(table1);
                    adapter2.Fill(table2);
                    adapter3.Fill(table3);


                    dataGridView1.DataSource = table1;
                    dataGridView2.DataSource = table2;
                    dataGridView3.DataSource = table3;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private async void btExec3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    await connection.OpenAsync();

                    string view = "CREATE VIEW Division_PC_DocMov AS " +
                            "SELECT Division.Name_Div, Document_Mov.Installation_Date, " +
                            "COUNT(*) as count_of_license " +
                            "FROM Division " +
                            "LEFT JOIN PC ON PC.Division_Id = Division.Id " +
                            "LEFT JOIN Document_Mov ON Document_Mov.Id = PC.DocumentMov_Id " +
                            "WHERE Document_Mov.Installation_Date = '" + dateTimePicker1.Value.Date + "'" +
                            "GROUP BY Division.Name_Div, Document_Mov.Installation_Date " +
                            "ORDER BY Division.Name_Div DESC, Document_Mov.Installation_Date DESC";
                    string str = "SELECT * FROM Division_PC_DocMov";
                    SqlDataAdapter adapter = new SqlDataAdapter(str, connection);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dataGridView4.DataSource = dt;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
            form1.ShowDialog();
        }
    }
}
