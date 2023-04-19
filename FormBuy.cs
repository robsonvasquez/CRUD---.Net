using MessageUtils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.Models;

namespace teste
{
    public partial class FormBuy : Form
    {
        public FormBuy()
        {
            InitializeComponent();
        }

        private void FormBuy_Load(object sender, EventArgs e)
        {
            var db = new DBContext();

            var listClient = db.Client.ToList();
            foreach (var item in listClient)
            {
                comboBoxClient.Items.Add(item.firstName +" " + item.lastName);
            }

            var listProduct = db.Product.ToList();
            foreach (var item in listProduct)
            {
                comboBoxProduct.Items.Add(item.Name);
            }
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            var selected = comboBoxProduct.Text;
            listViewProduct.Items.Add(selected);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var db = new DBContext();

            Buy buy = new Buy();
            Product bu = db.Product.Where(x => x.Name == "Fini").FirstOrDefault();
            buy.Value = bu.Price;
            buy.IdClient = 3;
            buy.IdProduct = 3;
            db.Buy.Add(buy);
            db.SaveChanges();
            this.Close();
            SimpleMessage.Inform("Buy save.", "Information");
            
            
        }
    }
}
