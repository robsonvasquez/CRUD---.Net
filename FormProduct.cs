using MessageUtils;
using Microsoft.EntityFrameworkCore;
using teste.Models;

namespace teste
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        public int idUpdate { get; set; }
        public string? nameUpdate { get; set; }
        public double? priceUpdate { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var db = new DBContext();

            if (nameUpdate == null && priceUpdate == null)
            {
                Product product = new Product();
                product.Name = textBoxName.Text;
                product.Price = Convert.ToDouble(textBoxPrice.Text);
                db.Product.Add(product);
                db.SaveChanges();
                this.Close();
                SimpleMessage.Inform("Product save.", "Information");
            }
            else
            {
                Product product = db.Product.Where(x => x.IdProduct == idUpdate).FirstOrDefault();
                product.Name = textBoxName.Text;
                product.Price = Convert.ToDouble(textBoxPrice.Text);
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                this.Close();
                SimpleMessage.Inform("Product save.", "Information");
            }
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            textBoxName.Text = this.nameUpdate;
            textBoxPrice.Text = Convert.ToString(this.priceUpdate);
        }
    }
}
