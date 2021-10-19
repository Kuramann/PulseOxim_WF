using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace PulseOxim
{
    public partial class Alerta : Form
    {
        FirestoreDb database;
        public Alerta()
        {
            InitializeComponent();
        }

        private void Alerta_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"max30100.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            database = FirestoreDb.Create("max30100-5e96d");
            GetAllDocuments("Utilizatori");
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

                    reciever.Items.Add(email);
                }
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "pulseoxim.medic@gmail.com",
                    Password = "fqmczrhfzeealxtw"
                }
            };
            MailAddress fromMail = new MailAddress("pulseoxim.medic@gmail.com", "Medic");
            MailAddress toMail = new MailAddress(reciever.Text, "Pacient");
            MailMessage Message = new MailMessage()
            {
                From = fromMail,
                Subject = tip_alerta.Text,
                Body = mesaj.Text
            };
            Message.To.Add(toMail);
            client.Send(Message);
            MessageBox.Show("Alerta  fost trimisa!");
           
        }
    }
}
