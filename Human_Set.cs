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
    public partial class Human_Set : Form
    {
        string connectionString = @"Data Source=MARK-PC;Initial Catalog=KurSoft;Integrated Security=True";

        public Human_Set()
        {
            InitializeComponent();
        }

        private void Human_Set_Load(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Human_Settlement", connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string date = DateTime.Now.ToString();
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("INSERT INTO Human_Settlement (Name) VALUES ('" + textBox1.Text + "')", connection);

                adapter.SelectCommand.ExecuteNonQuery();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("DELETE FROM Human_Settlement WHERE Id='" + tbId.Text + "'", connection);
                adapter.SelectCommand.ExecuteNonQuery();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE Human_Settlement SET Name='" + textBox1.Text + "' WHERE Id='" + tbId.Text + "'", connection);
                adapter.SelectCommand.ExecuteNonQuery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                tbId.ReadOnly = false;
            else
                tbId.ReadOnly = true;
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            Query1 query1 = new Query1();
            Hide();
            query1.StartPosition = FormStartPosition.CenterScreen;
            query1.ShowDialog();
        }
    }
}
