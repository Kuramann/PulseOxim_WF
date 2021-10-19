using Google.Cloud.Firestore;
using System;
using System.Windows.Forms;

namespace PulseOxim
{
    public partial class Form1 : Form
    {
        FirestoreDb database;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"max30100.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            database = FirestoreDb.Create("max30100-5e96d");
            GetAllDocuments("Utilizatori");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        async void GetAllDocuments(string nameOfCollection)
        {
            Query usersque = database.Collection(nameOfCollection);
            QuerySnapshot snap = await usersque.GetSnapshotAsync();
            foreach (DocumentSnapshot docsnap in snap.Documents)
            {
               User user = docsnap.ConvertTo<User>();

                if (docsnap.Exists)
                {
                    var email = docsnap.GetValue<string>("E-mail");

                    dataGridView1.Rows.Add(user.Nume, email, user.Puls, user.SPO2, user.Temperatura, user.Telefon);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                Nume_txt.Text = row.Cells["Nume"].Value.ToString();
                Email_txt.Text = row.Cells["Email"].Value.ToString();
                Puls_txt.Text = row.Cells["Puls"].Value.ToString();
                SPO2_txt.Text = row.Cells["SPO2"].Value.ToString();
                Temperatura_txt.Text = row.Cells["Temperatura"].Value.ToString();
                Telefon_txt.Text = row.Cells["Telefon"].Value.ToString();
            }
        }

        private void Nume_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void alert_Click(object sender, EventArgs e)
        {
            Alerta f = new Alerta();
            f.Show();
        }
    }
}
