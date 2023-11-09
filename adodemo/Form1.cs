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

namespace adodemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into department values(@p_deptname,@p_location)", cn);
            cmd.Parameters.AddWithValue("@p_deptname", DeptName.Text);
            cmd.Parameters.AddWithValue("@p_location", Location.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            MessageBox.Show("successfully completed");
            btndisp_Click(sender, e);
        }

        private void btndisp_Click(object sender, EventArgs e)
        {
 
            SqlConnection cn=new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=northwind;Integrated Security=True");
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from[dbo].showdisplay()",cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Dept> Deplist = new List<Dept>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Dept d = new Dept();
                        d.Deptno = Convert.ToInt32(dr["deptid"]);
                        d.Deptname = dr["deptname"].ToString();
                        d.DeptLoc = dr["location"].ToString();
                        Deplist.Add(d);
                    }
                }
                dgvDeptData.DataSource = Deplist;

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
        }

        private void DeptData_Enter(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Updatedata",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p_deptno",(DeptID.Text));
            cmd.Parameters.AddWithValue("@p_deptname",Convert.ToString(DeptName.Text));
            cmd.Parameters.AddWithValue("@p_location", Convert.ToString(Location.Text));

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            cn.Close();
            cn.Dispose();
            MessageBox.Show("update successfully");
            btndisp_Click(sender, e);



        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from department where deptid=" + Convert.ToInt32(DeptID.Text),cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Dept d = new Dept();
                d.Deptno = Convert.ToInt32(dr["deptid"]);
                d.Deptname = dr["deptname"].ToString();
                d.DeptLoc = dr["location"].ToString();


                DeptName.Text = d.Deptname;
                Location.Text = d.DeptLoc;

                //txtdeptname.Text= dr["dname"].ToString();
                //txtdeptloc.Text = dr["loc"].ToString();



                MessageBox.Show("Record found successfully");
            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Deletedata", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p_deptno", (DeptID.Text));
            

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            cn.Close();
            cn.Dispose();
            MessageBox.Show("Deleted successfully");
            btndisp_Click(sender, e);
        }
    }
}
