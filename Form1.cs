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

namespace CordysAdministration
{
    public partial class Form1 : Form
    {

     

        SqlConnection con = new SqlConnection("Data Source = LAPTOP - 3ROFGPDJ\\SQLEXPRESS; Initial Catalog = CorrieSeDatabase; Integrated Security = True");
        SqlDataAdapter adapt;
        SqlCommand cmd;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;


        public Form1()
        {
            InitializeComponent();
            comboBoxTableSelect.Items.Add("Products");
            comboBoxTableSelect.Items.Add("Stores");
            comboBoxTableSelect.Items.Add("ProductSales");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxInput1.Text != "" && textBoxInput2.Text != "")
            {
                cmd = new SqlCommand("update Products set Description=@Description,Price=@Price where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@iD", ID);
                cmd.Parameters.AddWithValue("@Description", textBoxInput1.Text);
                cmd.Parameters.AddWithValue("@Price", textBoxInput2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
            

           
        }


        //kom ons doen dit oor soos indian man ,laat dit eder werk as wat ons hierdie ding wat se code netjies is maar nie werk nie

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Products", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            textBoxInput1.Text = "";
            textBoxInput2.Text = "";
            textBoxInput3.Text = "";
            textBoxInput4.Text = "";
            ID = 0;
        }


        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxInput1.Text != "" && textBoxInput2.Text != "")
            {
                cmd = new SqlCommand("insert into Products(Description,Price) values(@Description,@Price)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Description", textBoxInput1.Text);
                cmd.Parameters.AddWithValue("@Price", textBoxInput2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide More Details");
            }
            
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTableSelect.SelectedIndex == 0)
            {
                ClearData();
                labelInput1.Visible = true;
                labelInput1.Text = "Description";
        
                labelInput2.Visible = true;
                labelInput2.Text = "Price";
            
                labelInput3.Visible = false;
                textBoxInput3.Visible = false;
   
                labelInput4.Visible = false;
                textBoxInput4.Visible = false;

            }
            if (comboBoxTableSelect.SelectedIndex == 1)
            {
                ClearData();
                labelInput1.Visible = true;
                labelInput1.Text = "Name";
   
                labelInput2.Visible = true;
                labelInput2.Text = "Address";

                labelInput3.Visible = true;
                textBoxInput3.Visible = true;

                labelInput3.Text = "Tel";
                labelInput4.Visible = false;
                textBoxInput4.Visible = false;

            }
            if (comboBoxTableSelect.SelectedIndex == 2)
            {
                ClearData();
                labelInput1.Visible = true;
                labelInput1.Text = "Product";

                labelInput2.Visible = true;
                labelInput2.Text = "Store";

                labelInput3.Visible = true;
                labelInput3.Text = "Date";
                textBoxInput3.Visible = true;

                labelInput4.Visible = true;
                labelInput4.Text = "Quantity";
                textBoxInput4.Visible = true;
 
            }
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'corrieSeDatabaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.corrieSeDatabaseDataSet.Products);

        }

        private void labelDelete_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInput3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Products where ID=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxInput1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxInput2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
