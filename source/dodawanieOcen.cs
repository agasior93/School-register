using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Dziennik
{
    public partial class dodawanieOcen : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)MSSQLLocalDB;
AttachDbFilename=C:\Users\Maciek\Desktop\BD2_projekt\Kod\Dziennik\dbdziennik.mdf;
Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        String IDn;
        String waga;
        String ocena;

        public dodawanieOcen()
        {
            InitializeComponent();
        }

        
        private void dodawanieOcen_Load(object sender, EventArgs e)
        {         
                    

               comboBox4.Items.Add(1);
               comboBox4.Items.Add(2);
               comboBox4.Items.Add(3);

               comboBox3.Items.Add("1");
               comboBox3.Items.Add("1.5");
               comboBox3.Items.Add("2");
               comboBox3.Items.Add("2.5");
               comboBox3.Items.Add("3");
               comboBox3.Items.Add("3.5");
               comboBox3.Items.Add("4");
               comboBox3.Items.Add("4.5");
               comboBox3.Items.Add("5");

               
               dataBox.Text = DateTime.Now.ToShortDateString();

           
               
               cn.Open();

               SqlCommand sc = new SqlCommand("SELECT IDklasy, Klasa FROM klasyTbl", cn);
               SqlDataReader reader;

               reader = sc.ExecuteReader();
               DataTable dt = new DataTable();
               dt.Columns.Add("ID", typeof(string));
               dt.Columns.Add("Klasa", typeof(string));
               dt.Load(reader);

               comboBox1.ValueMember = "IDklasy";
               comboBox1.DisplayMember = "Klasa";
               comboBox1.DataSource = dt;

               cn.Close();

               cn.Open();

               SqlCommand sc2 = new SqlCommand("SELECT IDprzedmiotu, Przedmiot FROM przedmiotyTbl", cn);
               SqlDataReader reader2;

               reader2 = sc2.ExecuteReader();
               DataTable dt2 = new DataTable();
               dt2.Columns.Add("IDprzedmiotu", typeof(string));
               dt2.Columns.Add("Przedmiot", typeof(string));
               dt2.Load(reader2);

               comboBox2.ValueMember = "IDprzedmiotu";
               comboBox2.DisplayMember = "Przedmiot";
               comboBox2.DataSource = dt2;

               cn.Close();

                
                                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Connection = cn;                      
            
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            cn.Open();
            cmd.CommandText = "SELECT IDucznia, Imie, Nazwisko FROM uczniowieTbl WHERE (Klasa = '" + comboBox1.SelectedValue + "')";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0].ToString());
                    listBox2.Items.Add(dr[1].ToString());
                    listBox3.Items.Add(dr[2].ToString());
                }
            }
            cn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            cmd.Connection = cn;

            string idU = listBox1.GetItemText(listBox1.SelectedItem);
            string Ocena = comboBox3.GetItemText(comboBox3.SelectedItem);
            string Waga = comboBox4.GetItemText(comboBox4.SelectedItem);

            if (iBox.Text != "" & nBox.Text != "" & idU != "" & IDn != "" & Ocena != "" & Waga != "")
            {

                cn.Open();
                cmd.CommandText = "INSERT into ocenyTbl(Ocena, IDucznia, Przedmiot, Nauczyciel, Waga, Data) VALUES ('" + Ocena + "', '" + idU + "', '" + comboBox2.SelectedValue + "', '" + IDn + "', '" + Waga + "', '" + dataBox.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                const string message = "Ocena dodana pomyslnie.";
                const string caption = "";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK);
                cn.Close();
            }

            else
            {
                const string message = "Nie udalo sie dodac oceny. Upewnij się czy wypełniłeś wszystkie pola.";
                const string caption = "";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK);
            }
                                          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.Connection = cn;

            cn.Open();

            cmd.CommandText = "Select IDnauczyciela from nauczycieleTbl Where (Imie ='" + iBox.Text + "' AND Nazwisko = '" + nBox.Text + "')";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    IDn = dr[0].ToString();
                }

            }

            cn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void ocenaBox_TextChanged(object sender, EventArgs e)
        {

        } 

       
    }
}
