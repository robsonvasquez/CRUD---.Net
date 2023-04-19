using MessageUtils;
using System.Linq;
using teste.Models;

namespace teste
{
    public partial class FormHome : Form
    {

        public FormHome()
        {
            InitializeComponent();
        }

        string[] grids = { "home", "client", "product", "buy" };

        public void RefreshGrid(string grid)
        {
            var db = new DBContext();

            if (grid == "home")
            {
                list(db, "client");
                list(db, "product");
                list(db, "buy");
            }
            else if (grid == "client")
            {
                list(db, "client");
            }
            else if (grid == "product")
            {
                list(db, "product");
            }
            else if (grid == "buy")
            {
                list(db, "buy");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGrid(grids[0]);
        }

        private void btnClientCreate_Click(object sender, EventArgs e)
        {
            FormClient client = new FormClient();
            client.ShowDialog();

            RefreshGrid(grids[1]);
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow? line = null;
            line = dataGridViewClient.SelectedRows[0];
            Client? clientselect = line.DataBoundItem as Client;

            FormClient client = new FormClient();
            client.idUpdate = clientselect.IdClient;
            client.firstNameUpdate = clientselect.firstName;
            client.lastNameUpdate = clientselect.lastName;

            client.ShowDialog();

            RefreshGrid(grids[1]);
        }

        private void btnClientDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow? line = null;
            line = dataGridViewClient.SelectedRows[0];
            Client? clientselect = line.DataBoundItem as Client;

            var db = new DBContext();
            db.Remove(clientselect);
            db.SaveChanges();
            RefreshGrid(grids[1]);
            SimpleMessage.Inform("Client remove.", "Information");
        }

        private void btnProductCreate_Click(object sender, EventArgs e)
        {
            FormProduct product = new FormProduct();
            product.ShowDialog();

            RefreshGrid(grids[2]);
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow? line = null;
            line = dataGridViewProduct.SelectedRows[0];
            Product? productselect = line.DataBoundItem as Product;

            FormProduct product = new FormProduct();
            product.idUpdate = productselect.IdProduct;
            product.nameUpdate = productselect.Name;
            product.priceUpdate = productselect.Price;
            product.ShowDialog();

            RefreshGrid(grids[2]);
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow? line = null;
            line = dataGridViewProduct.SelectedRows[0];
            Product? productselect = line.DataBoundItem as Product;

            var db = new DBContext();
            db.Remove(productselect);
            db.SaveChanges();
            RefreshGrid(grids[2]);
            SimpleMessage.Inform("Product remove.", "Information");
        }

        private void btnBuyCreate_Click(object sender, EventArgs e)
        {
            FormBuy buy = new FormBuy();
            buy.ShowDialog();

            RefreshGrid(grids[3]);
        }

        private void btnBuyUpdate_Click(object sender, EventArgs e)
        {
            FormBuy buy = new FormBuy();
            buy.ShowDialog();
        }

        private void btnBuyDelete_Click(object sender, EventArgs e)
        {
            FormBuy buy = new FormBuy();
            buy.ShowDialog();
        }

        private void list(DBContext db, string grid)
        {
            if (grid == "home" || grid == "client")
            {
                dataGridViewClient.DataSource = db.Client.ToList();
                dataGridViewClient.Columns.Remove(dataGridViewClient.Columns[$"IdClient"]);
            }

            if (grid == "home" || grid == "product")
            {
                dataGridViewProduct.DataSource = db.Product.ToList();
                dataGridViewProduct.Columns.Remove(dataGridViewProduct.Columns[$"IdProduct"]);
            }

            if (grid == "home" || grid == "buy")
            {
                dataGridViewBuy.DataSource = db.Buy.ToList();
                dataGridViewBuy.Columns.Remove(dataGridViewBuy.Columns[$"IdBuy"]);
            }

        }
    }
}