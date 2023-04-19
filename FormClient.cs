using MessageUtils;
using Microsoft.EntityFrameworkCore;
using System.Data;
using teste.Models;

namespace teste
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
 
        }

        public int idUpdate { get; set; }
        public string? firstNameUpdate { get; set; }
        public string? lastNameUpdate { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var db = new DBContext();

            if (firstNameUpdate == null && lastNameUpdate == null)
            {
                Client client = new Client();
                client.firstName = textBoxFirstName.Text;
                client.lastName = textBoxLastName.Text;
                db.Client.Add(client);
                db.SaveChanges();
                this.Close();
                SimpleMessage.Inform("client save.", "Information");
            }
            else
            {
                Client client = db.Client.Where(x => x.IdClient == idUpdate).FirstOrDefault();
                client.firstName = textBoxFirstName.Text;
                client.lastName = textBoxLastName.Text;
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                this.Close();
                SimpleMessage.Inform("client save.", "Information");
                
            }
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = this.firstNameUpdate;
            textBoxLastName.Text = this.lastNameUpdate;
        }
    }
}
