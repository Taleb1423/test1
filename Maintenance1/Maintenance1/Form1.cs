using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Maintenance1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            String usern = user.Text;
            String passw = pass.Text;

           //db.openconnection();

            DataTable Table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            string sql = "select * from login where username = @usn and password = @pass";
            MySqlCommand cmd = new MySqlCommand(sql, db.getConnection());
            cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usern;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passw; 

            adapter.SelectCommand= cmd;
            adapter.Fill(Table);

            if(Table.Rows.Count > 0)
            {
                //MessageBox.Show("Yes");
                Form2 registrationForm = new Form2();
                registrationForm.Show();
                Visible= false;
                db.closeconnection();
            }
                else
                {
                    MessageBox.Show("Error");
                    db.closeconnection();
            }
            }
        

        }

       
    }

