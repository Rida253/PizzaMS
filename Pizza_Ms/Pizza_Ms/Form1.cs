using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Pizza_Ms
{
    public partial class Form1 : Form
    {
        string[] prds = new string[50];
        int[] qty = new int[50];
        int[] pprice = new int[50];
        int counter = 0;
        Form2 f2=new Form2();
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            this.button41.Visible = false;
            this.button42.Visible = false;
            this.button43.Visible = false;
            this.button44.Visible = false;
            this.button45.Visible = false;
            this.Text=("PIZZA HUT MANAGEMENT SYSTEM");
            this.textBox83.Text = "Enter user id";
            this.textBox84.Text = "Enter password";

            panel11.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();
            panel15.Hide();
            panel16.Hide();
            panel17.Hide();
            panel18.Hide();
            panel19.Hide();
            panel20.Hide();
            panel21.Hide();
            panel25.Hide();
            this.WindowState = FormWindowState.Maximized;

           
           





            f2.sqlConnection1.Open();
            SqlCommand cmd4 = new SqlCommand("select ptype from Pizza", f2.sqlConnection1);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while(dr4.Read())
            {
                comboBox4.Items.Add(dr4["ptype"]);
            }
            f2.sqlConnection1.Close();


            f2.sqlConnection1.Open();
            SqlCommand cmd1 = new SqlCommand("select D_typ from Soft_Drinks", f2.sqlConnection1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1["D_typ"]);
            }
            f2.sqlConnection1.Close();

            f2.sqlConnection1.Open();
            SqlCommand cmd2 = new SqlCommand("select S_ID from Salad", f2.sqlConnection1);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox3.Items.Add(dr2["S_ID"]);
            }
            f2.sqlConnection1.Close();

            /*int c = 0;
            f2.sqlConnection1.Open();
            SqlCommand cmd3 = new SqlCommand("select count(C_ID) from Customer", f2.sqlConnection1);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                c = Convert.ToInt32(dr3[0]);
                c++;
            }
            {
                textBox1.Text = "00" + c.ToString();
            }*/

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select Piz_Size from Pizza_Price", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Piz_Size"]);
            }
            f2.sqlConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Small")
            {
                textBox2.Text = "800";
            }
            if (comboBox1.Text == "Regular")
            {
                textBox2.Text = "1200";
            }
            if (comboBox1.Text == "Large")
            {
                textBox2.Text = "1600";
            }
            if (comboBox1.Text == "Jumbo")
            {
                textBox2.Text = "2000";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "7 Up")
            {
                textBox7.Text = "60";
            }

            if (comboBox2.Text == "Sprite")
            {
                textBox7.Text = "60";
            }

            if (comboBox2.Text == "Coke")
            {
                textBox7.Text = "60";
            }

            if (comboBox2.Text == "sting")
            {
                textBox7.Text = "60";
            }

            if (comboBox2.Text == "Pepsi")
            {
                textBox7.Text = "60";
            }

            if (comboBox2.Text == "Dew")
            {
                textBox7.Text = "60";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel15.Show();

            int k = 0;
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select count(Cus_ID) from Eat_Inn", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                k = Convert.ToInt32(dr[0]);
                k++;
            }
            {
                textBox56.Text = "00" + k.ToString();
            }
            f2.sqlConnection1.Close();

            


            f2.sqlConnection1.Open();
            SqlCommand cmd2 = new SqlCommand("select ptype from Pizza", f2.sqlConnection1);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox9.Items.Add(dr2["ptype"]);
            }
            f2.sqlConnection1.Close();

            f2.sqlConnection1.Open();
            SqlCommand cmd3 = new SqlCommand("select D_typ from Soft_Drinks", f2.sqlConnection1);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox11.Items.Add(dr3["D_typ"]);
            }
            f2.sqlConnection1.Close();

            f2.sqlConnection1.Open();
            SqlCommand cmd4 = new SqlCommand("select Salad_typ from Salad", f2.sqlConnection1);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                comboBox10.Items.Add(dr4["Salad_typ"]);
            }
            f2.sqlConnection1.Close();

        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel11.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //insert vendor panel open
        private void button10_Click(object sender, EventArgs e)
        {
            panel5.Show();
            int k = 0;
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select count(V_ID) from Vendor", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                k = Convert.ToInt32(dr[0]);
                k++;
            }
            {
                textBox9.Text = "00" + k.ToString();
            }
            f2.sqlConnection1.Close();
        }
        //update vendor panel open
        private void button11_Click(object sender, EventArgs e)
        {
            panel6.Show();
            f2.sqlConnection1.Close();

            f2.sqlConnection1.Open();
            SqlCommand cmd5 = new SqlCommand("select V_ID from Vendor", f2.sqlConnection1);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                comboBox5.Items.Add(dr5["V_ID"]);
            }
            f2.sqlConnection1.Close();
        }
        //delete vendor panel open
        private void button12_Click(object sender, EventArgs e)
        {
            panel7.Show();
            f2.sqlConnection1.Open();
            SqlCommand cmd5 = new SqlCommand("select V_ID from Vendor", f2.sqlConnection1);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                comboBox6.Items.Add(dr5["V_ID"]);
            }
            f2.sqlConnection1.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel4.Show();
        }
        //vendor option panel open
        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Insert into Vendor values(@V_ID,@V_Name,@V_Code,@V_City,@V_PH,@v_Address,@CP_Name,@CP_PH,@CP_Email)", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@V_ID",textBox9.Text);
            cmd.Parameters.AddWithValue("@V_Name", textBox10.Text);
            cmd.Parameters.AddWithValue("@V_Code", textBox11.Text);
            cmd.Parameters.AddWithValue("@V_City", textBox12.Text);
            cmd.Parameters.AddWithValue("@V_PH", textBox13.Text);
            cmd.Parameters.AddWithValue("@v_Address", textBox14.Text);
            cmd.Parameters.AddWithValue("@CP_Name", textBox15.Text);
            cmd.Parameters.AddWithValue("@CP_PH", textBox16.Text);
            cmd.Parameters.AddWithValue("@CP_Email", textBox17.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been inserted...");
            f2.sqlConnection1.Close();
        }
        //back to home from vendor options
        private void button13_Click(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select * from Vendor where V_ID=@V_ID", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@V_ID", this.comboBox5.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox19.Text = dr["V_Name"].ToString();
                textBox20.Text = dr["V_Code"].ToString();
                textBox21.Text = dr["V_City"].ToString();
                textBox22.Text = dr["V_PH"].ToString();
                textBox23.Text = dr["V_Address"].ToString();
                textBox24.Text = dr["CP_Name"].ToString();
                textBox25.Text = dr["CP_PH"].ToString();
                textBox26.Text = dr["CP_Email"].ToString();
            }
            f2.sqlConnection1.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            panel4.Show();
        }
        //update vendor details
        private void button17_Click(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("update Vendor set V_Name=@V_Name,V_Code=@V_Code,V_City=@V_City,V_PH=@V_PH,V_Address=@V_Address,CP_Name=@CP_Name,CP_PH=@CP_PH,CP_Email=@CP_Email where V_ID=@V_ID", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@V_ID", comboBox5.Text);
            cmd.Parameters.AddWithValue("@V_Name", textBox19.Text);
            cmd.Parameters.AddWithValue("@V_Code", textBox20.Text);
            cmd.Parameters.AddWithValue("@V_City", textBox21.Text);
            cmd.Parameters.AddWithValue("@V_PH", textBox22.Text);
            cmd.Parameters.AddWithValue("@V_Address", textBox23.Text);
            cmd.Parameters.AddWithValue("@CP_Name", textBox24.Text);
            
            cmd.Parameters.AddWithValue("@CP_PH", textBox25.Text);
            cmd.Parameters.AddWithValue("@CP_Email", textBox26.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been updated");
            f2.sqlConnection1.Close();
        }
        //delete panel clear button
        private void button22_Click(object sender, EventArgs e)
        {
            textBox18.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
        }
        //delete panel back button
        private void button21_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            panel4.Show();
        }
        //delete vendor data button
        private void button20_Click(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Delete from Vendor where V_ID=@V_ID", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@V_ID", this.comboBox6.Text);
            cmd.Parameters.AddWithValue("@V_Name", textBox18.Text);
            cmd.Parameters.AddWithValue("@V_Code", textBox27.Text);
            cmd.Parameters.AddWithValue("@V_City", textBox28.Text);
            cmd.Parameters.AddWithValue("@V_PH", textBox29.Text);
            cmd.Parameters.AddWithValue("@V_Address", textBox30.Text);
            cmd.Parameters.AddWithValue("@CP_Name", textBox31.Text);

            cmd.Parameters.AddWithValue("@CP_PH", textBox32.Text);
            cmd.Parameters.AddWithValue("@CP_Email", textBox32.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            f2.sqlConnection1.Close();
        }
        //staff option panel open
        private void button7_Click(object sender, EventArgs e)
        {
            panel9.Show();
        }
        //insert staff new data button
        private void button23_Click(object sender, EventArgs e)
        {
            panel8.Show();
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Insert into Staff values(@Emp_ID,@Emp_Name,@Emp_PH,@Emp_Address,@Emp_Age,@Emp_Qualification,@Emp_Designation,@Hire_Date,@Emp_Sal)", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@Emp_ID", textBox34.Text);
            cmd.Parameters.AddWithValue("@Emp_Name", textBox35.Text);
            cmd.Parameters.AddWithValue("@Emp_PH", textBox36.Text);
            cmd.Parameters.AddWithValue("@Emp_Address", textBox37.Text);
            cmd.Parameters.AddWithValue("@Emp_Age", textBox38.Text);
            cmd.Parameters.AddWithValue("@Emp_Qualification", textBox39.Text);
            cmd.Parameters.AddWithValue("@Emp_Designation", textBox40.Text);
            cmd.Parameters.AddWithValue("@Hire_Date", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@Emp_Sal", textBox41.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been inserted...");
            f2.sqlConnection1.Close();
        }
        //new staff data clear button
        private void button25_Click(object sender, EventArgs e)
        {
            textBox35.Clear();
            textBox36.Clear();
            textBox37.Clear();
            textBox38.Clear();
            textBox39.Clear();
            textBox40.Clear();
            textBox41.Clear();
            
        }
        //back from new staff panel
        private void button24_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            panel9.Show();
        }
        //insert new staff panel open
        private void button26_Click(object sender, EventArgs e)
        {
            panel8.Show();
            panel9.Hide();

            int k = 0;
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select count(Emp_ID) from Staff", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                k = Convert.ToInt32(dr[0]);
                k++;
            }
            {
                textBox34.Text = "00" + k.ToString();
            }
            f2.sqlConnection1.Close();
        }
        //update staff data panel open
        private void button28_Click(object sender, EventArgs e)
        {
            panel10.Show();
            panel9.Hide();

            f2.sqlConnection1.Open();
            SqlCommand cmd5 = new SqlCommand("select Emp_ID from Staff", f2.sqlConnection1);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                comboBox7.Items.Add(dr5["Emp_ID"]);
            }
            f2.sqlConnection1.Close();

        }
        //delete staff data panel open
        private void button29_Click(object sender, EventArgs e)
        {

            panel12.Show();
            panel9.Hide();

            f2.sqlConnection1.Open();
            SqlCommand cmd5 = new SqlCommand("select Emp_ID from Staff", f2.sqlConnection1);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                comboBox8.Items.Add(dr5["Emp_ID"]);
            }
            f2.sqlConnection1.Close();



        }
        //back to main from staff option panel
        private void button27_Click(object sender, EventArgs e)
        {
            panel9.Hide();
        }
        //update staff data button
        private void button30_Click(object sender, EventArgs e)
        {

            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("update Staff set Emp_Name=@Emp_Name,Emp_PH=@Emp_PH,Emp_Address=@Emp_Address,Emp_Qualification=@Emp_Qualification,Emp_Designation=@Emp_Designation,Hire_Date=@Hire_Date,Emp_Sal=@Emp_Sal where Emp_ID=@Emp_ID", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@Emp_ID", comboBox7.Text);
            cmd.Parameters.AddWithValue("@Emp_Name", textBox42.Text);
            cmd.Parameters.AddWithValue("@Emp_PH", textBox43.Text);
            cmd.Parameters.AddWithValue("@Emp_Address", textBox44.Text);
            cmd.Parameters.AddWithValue("@Emp_Age", textBox45.Text);
            cmd.Parameters.AddWithValue("@Emp_Qualification", textBox46.Text);
            cmd.Parameters.AddWithValue("@Emp_Designation", textBox47.Text);
            cmd.Parameters.AddWithValue("@Hire_Date", dateTimePicker3.Text);
            cmd.Parameters.AddWithValue("@Emp_Sal", textBox48.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been updated");
            f2.sqlConnection1.Close();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox42.Clear();
            textBox43.Clear();
            textBox44.Clear();
            textBox45.Clear();
            textBox46.Clear();
            textBox47.Clear();
            textBox48.Clear();
        }
        //back button from update panel to main options
        private void button31_Click(object sender, EventArgs e)
        {
            panel9.Show();
            panel10.Hide();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select * from Vendor where V_ID=@V_ID", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@V_ID", this.comboBox6.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox18.Text = dr["V_Name"].ToString();
                textBox27.Text = dr["V_Code"].ToString();
                textBox28.Text = dr["V_City"].ToString();
                textBox29.Text = dr["V_PH"].ToString();
                textBox30.Text = dr["V_Address"].ToString();
                textBox31.Text = dr["CP_Name"].ToString();
                textBox32.Text = dr["CP_PH"].ToString();
                textBox33.Text = dr["CP_Email"].ToString();
            }
            f2.sqlConnection1.Close();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select * from Staff where Emp_ID=@Emp_ID", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@Emp_ID", this.comboBox7.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox42.Text = dr["Emp_Name"].ToString();
                textBox43.Text = dr["Emp_PH"].ToString();
                textBox44.Text = dr["Emp_Address"].ToString();
                textBox45.Text = dr["Emp_Age"].ToString();
                textBox46.Text = dr["Emp_Qualification"].ToString();
                textBox47.Text = dr["Emp_Designation"].ToString();
                //dateTimePicker3.Text = dr["Hire_Date"].ToString()+System.DateTime.Today.Year;
                textBox48.Text = dr["Emp_Sal"].ToString();
            }
            f2.sqlConnection1.Close();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox49.Clear();
            textBox50.Clear();
            textBox51.Clear();
            textBox52.Clear();
            textBox53.Clear();
            textBox54.Clear();
            textBox55.Clear();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            panel12.Hide();
            panel9.Show();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Delete from Staff where Emp_ID=@Emp_ID", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@Emp_ID", this.comboBox8.Text);
            cmd.Parameters.AddWithValue("@Emp_Name", textBox49.Text);
            cmd.Parameters.AddWithValue("@Emp_PH", textBox50.Text);
            cmd.Parameters.AddWithValue("@Emp_Address", textBox51.Text);
            cmd.Parameters.AddWithValue("@Emp_Age", textBox52.Text);
            cmd.Parameters.AddWithValue("@Emp_Qualification", textBox53.Text);
            cmd.Parameters.AddWithValue("@Emp_Designation", textBox54.Text);

            //cmd.Parameters.AddWithValue("@Hire_Date", dateTimePicker4.ToString()+System.DateTime.Today.Year);
            cmd.Parameters.AddWithValue("@Emp_sal", textBox55.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been deleted");
            f2.sqlConnection1.Close();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select * from Staff where Emp_ID=@Emp_ID", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@Emp_ID", this.comboBox8.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox49.Text = dr["Emp_Name"].ToString();
                textBox50.Text = dr["Emp_PH"].ToString();
                textBox51.Text = dr["Emp_Address"].ToString();
                textBox52.Text = dr["Emp_Age"].ToString();
                textBox53.Text = dr["Emp_Qualification"].ToString();
                textBox54.Text = dr["Emp_Designation"].ToString();
                //dateTimePicker3.Text = dr["Hire_Date"].ToString()+System.DateTime.Today.Year;
                textBox55.Text = dr["Emp_Sal"].ToString();
            }
            f2.sqlConnection1.Close();
            }

        private void button6_Click(object sender, EventArgs e)
        {
            panel13.Show();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            panel13.Hide();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select * from Sales", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            f2.sqlConnection1.Close();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            panel14.Show();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select * from Eat_Inn", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView2.DataSource = dt;
            f2.sqlConnection1.Close();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            panel14.Hide();
        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {
            /*int pizBasePrice = 0;
            int pizQty = 0;
            pizBasePrice = Convert.ToInt32(textBox57.Text);
            pizQty = Convert.ToInt32(textBox58.Text);
            prds[counter] = comboBox12.Text;
            this.textBox64.Text = Convert.ToString(pizBasePrice * pizQty);*/
            this.textBox63.Text += "*****Reciept*******" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text += "Cus ID:" + textBox56.Text + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text += "Pizza type:" + comboBox9.Text + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text += "Pizza size:" + comboBox12.Text + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text += "Pizza base price:" + textBox57.Text + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text += "Pizza quantity:" + textBox58.Text + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text += "Pizza total amount:" + textBox64.Text + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text += "Drink:" + comboBox11.Text + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text += "Drink base price:" + textBox59.Text + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text += "Drink quantity:" + textBox60.Text + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text += "Salad:" + comboBox10.Text + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text += "Salad base price:" + textBox61.Text + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text += "Salad quantity:" + textBox62.Text + Environment.NewLine + Environment.NewLine;
            this.textBox63.Text+= "Date & Time:"+dateTimePicker5.Text+ Environment.NewLine + Environment.NewLine;
            
            MessageBox.Show("Bill generated......");
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd1 = new SqlCommand("select Piz_Size from Pizza_Price", f2.sqlConnection1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox12.Items.Add(dr1["Piz_Size"]);
            }
            f2.sqlConnection1.Close();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox12.Text == "Small")
            {
                textBox57.Text = "800";
            }
            if (comboBox12.Text == "Regular")
            {
                textBox57.Text = "1200";
            }
            if (comboBox12.Text == "Large")
            {
                textBox57.Text = "1600";
            }
            if (comboBox12.Text == "Jumbo")
            {
                textBox57.Text = "2000";
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox11.Text == "7 Up")
            {
                textBox59.Text = "60";
            }

            if (comboBox11.Text == "Sprite")
            {
                textBox59.Text = "60";
            }

            if (comboBox11.Text == "Coke")
            {
                textBox59.Text = "60";
            }

            if (comboBox11.Text == "Sting")
            {
                textBox59.Text = "60";
            }

            if (comboBox11.Text == "Pepsi")
            {
                textBox59.Text = "60";
            }

            if (comboBox11.Text == "Dew")
            {
                textBox59.Text = "60";
            }
        }
        // Add bill in DB button
        private void button49_Click(object sender, EventArgs e)
        {
            
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("insert into Eat_Inn(Cus_ID,Piz_type,Piz_size,Piz_qty,Piz_price,Soft_drink,Drink_Price,Drink_qty,Salad,Salad_Price,Salad_qty,totalamount,date_time)values(@Cus_ID,@Cus_type,@date_time,@Piz_type,@Piz_size,@Piz_qty,@Piz_price,@Soft_drink,@Drink_Price,@Drink_qty,@Salad,@Salad_Price,@Salad_qty,@totalamount,@date_time)", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@Cus_ID", textBox56.Text);
            cmd.Parameters.AddWithValue("@Piz_type", comboBox9.Text);
            cmd.Parameters.AddWithValue("@Piz_size", comboBox12.Text);
            cmd.Parameters.AddWithValue("@Piz_qty", textBox58.Text);
            cmd.Parameters.AddWithValue("@Piz_price", textBox57.Text);
            cmd.Parameters.AddWithValue("@Soft_drink", textBox11.Text);
            cmd.Parameters.AddWithValue("@Drink_Price", textBox59.Text);
            cmd.Parameters.AddWithValue("@Drink_qty", textBox60.Text);
            cmd.Parameters.AddWithValue("@Salad", comboBox10.Text);
            cmd.Parameters.AddWithValue("@Salad_Price", textBox61.Text);
            //cmd.Parameters.AddWithValue("@totalamount", textBox64.Text);
            cmd.Parameters.AddWithValue("@Salad_qty", textBox62.Text);
            cmd.Parameters.AddWithValue("@date_time", dateTimePicker5.Text);
            MessageBox.Show("Data has been inserted");

            f2.sqlConnection1.Close();

           
        }

        private void button50_Click(object sender, EventArgs e)
        {
            panel15.Hide();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.Text == "yes")
            {
                textBox61.Text = "500";
            }

            if (comboBox10.Text == "no")
            {
                textBox61.Text = "00";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel16.Show();

            int k = 0;
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select count(Cus_ID) from Eat_Inn", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                k = Convert.ToInt32(dr[0]);
                k++;
            }
            {
                textBox67.Text = "00" + k.ToString();
            }
            f2.sqlConnection1.Close();




            f2.sqlConnection1.Open();
            SqlCommand cmd2 = new SqlCommand("select ptype from Pizza", f2.sqlConnection1);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox16.Items.Add(dr2["ptype"]);
            }
            f2.sqlConnection1.Close();

            f2.sqlConnection1.Open();
            SqlCommand cmd3 = new SqlCommand("select D_typ from Soft_Drinks", f2.sqlConnection1);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox14.Items.Add(dr3["D_typ"]);
            }
            f2.sqlConnection1.Close();

            f2.sqlConnection1.Open();
            SqlCommand cmd4 = new SqlCommand("select Salad_typ from Salad", f2.sqlConnection1);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                comboBox15.Items.Add(dr4["Salad_typ"]);
            }
            f2.sqlConnection1.Close();

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox14.Text == "7 Up")
            {
                textBox70.Text = "60";
            }

            if (comboBox14.Text == "Sprite")
            {
                textBox70.Text = "60";
            }

            if (comboBox14.Text == "Coke")
            {
                textBox70.Text = "60";
            }

            if (comboBox14.Text == "Sting")
            {
                textBox70.Text = "60";
            }

            if (comboBox14.Text == "Pepsi")
            {
                textBox70.Text = "60";
            }

            if (comboBox14.Text == "Dew")
            {
                textBox70.Text = "60";
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox15.Text == "yes")
            {
                textBox72.Text = "500";
            }

            if (comboBox15.Text == "no")
            {
                textBox72.Text = "00";
            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox13.Text == "Small")
            {
                textBox68.Text = "800";
            }
            if (comboBox13.Text == "Regular")
            {
                textBox68.Text = "1200";
            }
            if (comboBox13.Text == "Large")
            {
                textBox68.Text = "1600";
            }
            if (comboBox13.Text == "Jumbo")
            {
                textBox68.Text = "2000";
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select Piz_Size from Pizza_Price", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox13.Items.Add(dr["Piz_Size"]);
            }
            f2.sqlConnection1.Close();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            /*int pizBasePrice = 0;
          int pizQty = 0;
          pizBasePrice = Convert.ToInt32(textBox57.Text);
          pizQty = Convert.ToInt32(textBox58.Text);
          prds[counter] = comboBox12.Text;
          this.textBox64.Text = Convert.ToString(pizBasePrice * pizQty);*/
            this.textBox65.Text += "*****Reciept*******" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Cus ID:" + textBox67.Text + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Pizza type:" + comboBox16.Text + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Pizza size:" + comboBox13.Text + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Pizza base price:" + textBox68.Text + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Pizza quantity:" + textBox69.Text + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Pizza total amount:" + textBox66.Text + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Drink:" + comboBox14.Text + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Drink base price:" + textBox70.Text + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Drink quantity:" + textBox71.Text + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Salad:" + comboBox15.Text + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Salad base price:" + textBox72.Text + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Salad quantity:" + textBox73.Text + Environment.NewLine + Environment.NewLine;
            this.textBox65.Text += "Date & Time:" + dateTimePicker6.Text + Environment.NewLine + Environment.NewLine;

            MessageBox.Show("Bill generated......");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("insert into Take_Away(Cus_ID,Piz_type,Piz_size,Piz_qty,Piz_price,Soft_drink,Drink_Price,Drink_qty,Salad,Salad_Price,Salad_qty,totalamount,date_time)values(@Cus_ID,@Cus_type,@date_time,@Piz_type,@Piz_size,@Piz_qty,@Piz_price,@Soft_drink,@Drink_Price,@Drink_qty,@Salad,@Salad_Price,@Salad_qty,@totalamount,@date_time)", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@Cus_ID", textBox67.Text);
            cmd.Parameters.AddWithValue("@Piz_type", comboBox16.Text);
            cmd.Parameters.AddWithValue("@Piz_size", comboBox13.Text);
            cmd.Parameters.AddWithValue("@Piz_qty", textBox69.Text);
            cmd.Parameters.AddWithValue("@Piz_price", textBox68.Text);
            cmd.Parameters.AddWithValue("@Soft_drink", comboBox14.Text);
            cmd.Parameters.AddWithValue("@Drink_Price", textBox70.Text);
            cmd.Parameters.AddWithValue("@Drink_qty", textBox71.Text);
            cmd.Parameters.AddWithValue("@Salad", comboBox15.Text);
            cmd.Parameters.AddWithValue("@Salad_Price", textBox72.Text);
            //cmd.Parameters.AddWithValue("@totalamount", textBox64.Text);
            cmd.Parameters.AddWithValue("@Salad_qty", textBox73.Text);
            cmd.Parameters.AddWithValue("@date_time", dateTimePicker6.Text);
            MessageBox.Show("Data has been inserted");

            f2.sqlConnection1.Close();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            panel16.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel17.Show();

            int k = 0;
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select count(Cus_ID) from Home_Delivery", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                k = Convert.ToInt32(dr[0]);
                k++;
            }
            {
                textBox76.Text = "00" + k.ToString();
            }
            f2.sqlConnection1.Close();




            f2.sqlConnection1.Open();
            SqlCommand cmd2 = new SqlCommand("select ptype from Pizza", f2.sqlConnection1);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox20.Items.Add(dr2["ptype"]);
            }
            f2.sqlConnection1.Close();

            f2.sqlConnection1.Open();
            SqlCommand cmd3 = new SqlCommand("select D_typ from Soft_Drinks", f2.sqlConnection1);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox18.Items.Add(dr3["D_typ"]);
            }
            f2.sqlConnection1.Close();

            f2.sqlConnection1.Open();
            SqlCommand cmd4 = new SqlCommand("select Salad_typ from Salad", f2.sqlConnection1);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                comboBox19.Items.Add(dr4["Salad_typ"]);
            }
            f2.sqlConnection1.Close();

        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select Piz_Size from Pizza_Price", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox17.Items.Add(dr["Piz_Size"]);
            }
            f2.sqlConnection1.Close();
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox17.Text == "Small")
            {
                textBox77.Text = "800";
            }
            if (comboBox17.Text == "Regular")
            {
                textBox77.Text = "1200";
            }
            if (comboBox17.Text == "Large")
            {
                textBox7.Text = "1600";
            }
            if (comboBox17.Text == "Jumbo")
            {
                textBox77.Text = "2000";
            }
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox18.Text == "7 Up")
            {
                textBox79.Text = "60";
            }

            if (comboBox18.Text == "Sprite")
            {
                textBox79.Text = "60";
            }

            if (comboBox18.Text == "Coke")
            {
                textBox79.Text = "60";
            }

            if (comboBox18.Text == "Sting")
            {
                textBox79.Text = "60";
            }

            if (comboBox18.Text == "Pepsi")
            {
                textBox79.Text = "60";
            }

            if (comboBox18.Text == "Dew")
            {
                textBox79.Text = "60";
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            /*int pizBasePrice = 0;
         int pizQty = 0;
         pizBasePrice = Convert.ToInt32(textBox57.Text);
         pizQty = Convert.ToInt32(textBox58.Text);
         prds[counter] = comboBox12.Text;
         this.textBox64.Text = Convert.ToString(pizBasePrice * pizQty);*/
            this.textBox74.Text += "*****Reciept*******" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Cus ID:" + textBox76.Text + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Pizza type:" + comboBox20.Text + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Pizza size:" + comboBox17.Text + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Pizza base price:" + textBox77.Text + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Pizza quantity:" + textBox78.Text + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Pizza total amount:" + textBox75.Text + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Drink:" + comboBox18.Text + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Drink base price:" + textBox79.Text + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Drink quantity:" + textBox80.Text + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Salad:" + comboBox19.Text + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Salad base price:" + textBox81.Text + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Salad quantity:" + textBox82.Text + Environment.NewLine + Environment.NewLine;
            this.textBox74.Text += "Date & Time:" + dateTimePicker7.Text + Environment.NewLine + Environment.NewLine;

            MessageBox.Show("Bill generated......");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("insert into Home Delivery(Cus_ID,Piz_type,Piz_size,Piz_qty,Piz_price,Soft_drink,Drink_Price,Drink_qty,Salad,Salad_Price,Salad_qty,totalamount,date_time)values(@Cus_ID,@Cus_type,@date_time,@Piz_type,@Piz_size,@Piz_qty,@Piz_price,@Soft_drink,@Drink_Price,@Drink_qty,@Salad,@Salad_Price,@Salad_qty,@totalamount,@date_time)", f2.sqlConnection1);
            cmd.Parameters.AddWithValue("@Cus_ID", textBox76.Text);
            cmd.Parameters.AddWithValue("@Piz_type", comboBox20.Text);
            cmd.Parameters.AddWithValue("@Piz_size", comboBox17.Text);
            cmd.Parameters.AddWithValue("@Piz_qty", textBox78.Text);
            cmd.Parameters.AddWithValue("@Piz_price", textBox77.Text);
            cmd.Parameters.AddWithValue("@Soft_drink", comboBox18.Text);
            cmd.Parameters.AddWithValue("@Drink_Price", textBox79.Text);
            cmd.Parameters.AddWithValue("@Drink_qty", textBox80.Text);
            cmd.Parameters.AddWithValue("@Salad", comboBox19.Text);
            cmd.Parameters.AddWithValue("@Salad_Price", textBox81.Text);
            //cmd.Parameters.AddWithValue("@totalamount", textBox64.Text);
            cmd.Parameters.AddWithValue("@Salad_qty", textBox82.Text);
            cmd.Parameters.AddWithValue("@date_time", dateTimePicker7.Text);
            MessageBox.Show("Data has been inserted");

            f2.sqlConnection1.Close();
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox19.Text == "yes")
            {
                textBox81.Text = "500";
            }

            if (comboBox19.Text == "no")
            {
                textBox81.Text = "00";
                textBox82.ReadOnly = true;
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            panel18.Hide();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select * from Take_Away", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView3.DataSource = dt;
            f2.sqlConnection1.Close();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            panel18.Show();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            panel19.Show();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select * from Home_Delivery", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView4.DataSource = dt;
            f2.sqlConnection1.Close();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            panel19.Hide();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            panel20.Show();
        }

        private void button62_Click(object sender, EventArgs e)
        {

            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select * from Vendor", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView5.DataSource = dt;
            f2.sqlConnection1.Close();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            panel21.Show();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            panel21.Hide();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            f2.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Select * from Staff", f2.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView6.DataSource = dt;
            f2.sqlConnection1.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button41.Visible = true;
            this.button42.Visible = true;
            this.button43.Visible = true;
            this.button44.Visible = true;
            this.button45.Visible = true;
            
        }

        private void button63_Click(object sender, EventArgs e)
        {
            panel20.Hide();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            panel17.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel22.Hide();
            button2.Hide();
            button4.Hide();
            button6.Hide();
            button7.Hide();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            
            panel22.Hide();
            button66.Hide();
            panel25.Show();
            this.textBox83.Text = "Enter user id";
            this.textBox84.Text = "Enter password";



        }

        private void button67_Click(object sender, EventArgs e)
        {
             this.textBox83.Text = "Enter user id";
            this.textBox84.Text = "Enter password";
           //if(this.textBox1.Text == "BS3A" && this.textBox2.Text == "b")
            { panel1.Show();
            panel25.Show();
            button1.Enabled = false;
            button5.Enabled = false;
            button3.Enabled = false;
           
        }

        }

        private void button66_Click(object sender, EventArgs e)
        {
            //if (this.textBox83.Text == "BS3A" && this.textBox84.Text == "b")
            {
                panel1.Show();
                panel25.Show();
                button2.Hide();
                button4.Hide();
                button6.Hide();
                button7.Hide();
            }
        }

        private void textBox84_TextChanged(object sender, EventArgs e)
        {
           // textBox84.Text = null;
            textBox84.PasswordChar = '*';
        }

        private void textBox83_TextChanged(object sender, EventArgs e)
        {
           // textBox83.Text = null;
        }
    }
}
