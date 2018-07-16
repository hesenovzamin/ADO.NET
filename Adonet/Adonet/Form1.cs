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

namespace Adonet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            var Constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\P106\source\repos\Adonet\Adonet\Class.mdf;Integrated Security=True";
            var Connect = new SqlConnection(Constring);
            Connect.Open();
            var CLASSNAMEA = ClassName.Text;
            var Count = Convert.ToInt32(StudentCount.Text);
            var teacher = TECcombobox.SelectedItem.ToString();
            var InserQuery = "INSERT INTO Class(name,teacherID,studentCount)  VALUES('" + CLASSNAMEA + "',(SELECT id FROM Teachers WHERE  name='" + teacher + "'), '" + Count + "' )";
            var Comand = new SqlCommand(InserQuery, Connect);
            if (Comand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Product Add ADD");
            }
            Connect.Close();
         

        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            var Constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\P106\source\repos\Adonet\Adonet\Class.mdf;Integrated Security=True";
            var Connect = new SqlConnection(Constring);
            Connect.Open();
            var teacher = Teachern.Text;
            TECcombobox.Items.Add(Teachern.Text);
            var InserQuery = "INSERT INTO Teachers(name) VALUES('" + teacher + "')";
            var Comand = new SqlCommand(InserQuery, Connect);
            if (Comand.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Category ADD");
            } 
            Connect.Close();
        }

        private void ShowTABLE_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowCat_Click(object sender, EventArgs e)
        {

            var Constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\P106\source\repos\Adonet\Adonet\Class.mdf;Integrated Security=True";
            var Connect = new SqlConnection(Constring);
            Connect.Open();
            var Query = "SELECT * FROM Teachers";
           // var ReadComand = new SqlCommand(Query, Connect);
            var Data = new SqlDataAdapter(Query, Connect);
            var Ds = new DataSet();
            Data.Fill(Ds);
            foreach (DataRow item in Ds.Tables[0].Rows)
            {
                TECcombobox.Items.Add(item["name"].ToString());
                ShowTABLE.Text += item["id"] + "." + item["name"] + "\r\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ShowPro_Click(object sender, EventArgs e)
        {
            var Constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\P106\source\repos\Adonet\Adonet\Class.mdf;Integrated Security=True";
            var Connect = new SqlConnection(Constring);
            Connect.Open();
            var Query = "SELECT * FROM Class ";
            // var ReadComand = new SqlCommand(Query, Connect);
            var Data = new SqlDataAdapter(Query, Connect);
            var Ds = new DataSet();
            Data.Fill(Ds);
            foreach (DataRow item in Ds.Tables[0].Rows)
            {
              
                textBox2.Text += item["Id"] + ".   " + item["studentCount"] + ".   " + item["teacherID"] + "\r\n";
            }
        }
    }
}
