using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Software : Form
    {
        string connectionString = @"Data Source=MARK-PC;Initial Catalog=KurSoft;Integrated Security=True";
        public Software()
        {
            InitializeComponent();
            tbId.ReadOnly = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("DISABLE TRIGGER Software_IU ON Software", connection);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Software_Load(object sender, EventArgs e)
        {
            tbId.ReadOnly = true;
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

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string date = DateTime.Now.ToString();
                    await connection.OpenAsync();

                    SqlDataAdapter adapter = new SqlDataAdapter("INSERT INTO Software (Name_Product, Installation_Date, Price, Firm_Id, TypeSoftware_Id, SoftwareCompany_Id) VALUES ('" + textbox1.Text + "','" + dateTimePicker1.Value.Date + "','" + textBox2.Text + "', '"+ comboBox1.Text +"', '" + comboBox2.Text +"', '"+ comboBox3.Text +"')", connection);

                    adapter.SelectCommand.ExecuteNonQuery();

                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM History", connection);
                    DataTable dt1 = new DataTable();
                    adapter1.Fill(dt1);
                    dataGridView2.DataSource = dt1;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Software WHERE Id='" + tbId.Text + "'", connection);
                    adapter.SelectCommand.ExecuteNonQuery();

                    
                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM History", connection);
                    DataTable dt1 = new DataTable();
                    adapter1.Fill(dt1);
                    dataGridView2.DataSource = dt1;
                    
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

                    SqlDataAdapter adapter = new SqlDataAdapter("UPDATE Software SET Name_Product='" + textbox1.Text + "', Installation_Date='" + dateTimePicker1.Value.Date + "', Price='" + textBox2.Text + "', Firm_Id='"+comboBox1.Text+"', TypeSoftware_Id='"+comboBox2.Text+"', SoftwareCompany_Id='"+comboBox3.Text+"' WHERE Id = '"+tbId.Text+"'", connection);
                    adapter.SelectCommand.ExecuteNonQuery();


                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM History", connection);
                    DataTable dt1 = new DataTable();
                    adapter1.Fill(dt1);
                    dataGridView2.DataSource = dt1;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Software", connection);
                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT Id FROM Firm", connection);
                    SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT Id FROM Type_Software", connection);
                    SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT Id FROM Soft_Company", connection);
                    SqlDataAdapter adapter4 = new SqlDataAdapter("SELECT * FROM History", connection);


                    DataTable dt = new DataTable();
                    DataTable dt1 = new DataTable();
                    DataTable dt2 = new DataTable();
                    DataTable dt3 = new DataTable();
                    DataTable dt4 = new DataTable();

                    adapter.Fill(dt);
                    adapter1.Fill(dt1);
                    adapter2.Fill(dt2);
                    adapter3.Fill(dt3);
                    adapter4.Fill(dt4);

                    dataGridView1.DataSource = dt;
                    comboBox1.DataSource = dt1;
                    comboBox1.DisplayMember = dt1.Columns[0].ColumnName;
                    comboBox2.DataSource = dt2;
                    comboBox2.DisplayMember = dt2.Columns[0].ColumnName;
                    comboBox3.DataSource = dt3;
                    comboBox3.DisplayMember = dt3.Columns[0].ColumnName;

                    dataGridView2.DataSource = dt4;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                    tbId.ReadOnly = false;
                else
                    tbId.ReadOnly = true;
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            Query1 query1 = new Query1();
            Hide();
            query1.StartPosition = FormStartPosition.CenterScreen;
            query1.ShowDialog();
        }

        private async void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox2.Checked == true)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        await connection.OpenAsync();

                        SqlDataAdapter adapter = new SqlDataAdapter("ENABLE TRIGGER Software_IU ON Software", connection);
                        adapter.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("Trigger Enabled");
                    }
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        await connection.OpenAsync();
                        SqlDataAdapter adapter = new SqlDataAdapter("DISABLE TRIGGER Software_IU ON Software", connection);
                        adapter.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("Trigger Disabled");
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
            form1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            textbox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
        }
    }
}
