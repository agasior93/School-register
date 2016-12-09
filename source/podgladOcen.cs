using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Dziennik
{
    public partial class podgladOcen : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)MSSQLLocalDB;
AttachDbFilename=C:\Users\Maciek\Desktop\BD2_projekt\Kod\Dziennik\dbdziennik.mdf;
Integrated Security=True;User Instance=True");
        

       
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        String id;

        public podgladOcen()
        {
            InitializeComponent();
        }

        private void podgladOcen_Load(object sender, EventArgs e)
        {
           
        }
              

        private void SprawdzBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();

            cmd.Connection = cn;
            cn.Open();

            cmd.CommandText = "Select IDucznia FROM uczniowieTbl WHERE (Imie ='" + imieBox.Text + "' AND Nazwisko = '" + nazwiskoBox.Text + "')";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    id = dr[0].ToString();
                }

            }

            cn.Close();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();

            cn.Open();

            cmd.CommandText = "SELECT o.Ocena, p.Przedmiot, o.Data, o.Waga, n.Imie, n.Nazwisko FROM ocenyTbl o INNER JOIN przedmiotyTbl p ON (o.Przedmiot = p.IDprzedmiotu) INNER JOIN nauczycieleTbl n ON (o.Nauczyciel = n.IDnauczyciela) WHERE (IDucznia = '" + id + "')";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0].ToString());
                    listBox2.Items.Add(dr[1].ToString());
                    listBox3.Items.Add(dr[2].ToString());
                    listBox4.Items.Add(dr[3].ToString());
                    listBox5.Items.Add(dr[4].ToString());
                    listBox6.Items.Add(dr[5].ToString());
                }
            }
            cn.Close();
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
                listBox4.SelectedIndex = l.SelectedIndex;
                listBox5.SelectedIndex = l.SelectedIndex;
                listBox6.SelectedIndex = l.SelectedIndex;
            }
        }

        private void imieBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nazwiskoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
