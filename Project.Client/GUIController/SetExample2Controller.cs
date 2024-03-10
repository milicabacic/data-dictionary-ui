using Common;
using Domain;
using Project.Client.ServerCommunication;
using Project.Client.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.GUIController
{
    public class SetExample2Controller
    {
        private UCSetExample2 _userControl;
        private BindingList<InvoiceItem> _invoiceItems = new BindingList<InvoiceItem>();
        public SetExample2Controller(UCSetExample2 userControl) {
            _userControl = userControl;
            LoadProducts();
            InitializeInvoice();
        }

        private void LoadProducts()
        {
            List<Product> products = Communication.Instance.SendRequestGetResponse<List<Product>>(Operation.GET_PRODUCTS);
            _userControl.DgvProducts.DataSource = products;
        }

        private void InitializeInvoice()
        {
            Invoice invoice = new Invoice()
            {
                ID = 1,
                Items = _invoiceItems.ToList()
            };
            _userControl.IdLabel.Text += invoice.ID;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _invoiceItems;
            _userControl.DgvCart.DataSource = bindingSource;
        }

        public void AddItem()
        {
            DataGridViewRow row = _userControl.DgvProducts.CurrentRow;
            Product selectedProduct = (Product)row.DataBoundItem;

            selectedProduct.AvailableQuantity--;
            selectedProduct.SoldQuantity++;

            foreach (InvoiceItem item in _invoiceItems)
            {
                if (item.Product.ID == selectedProduct.ID) 
                {
                    item.Quantity++;
                    _userControl.DgvCart.Refresh();
                    _userControl.DgvProducts.Refresh();
                    return;
                }
            }
            _invoiceItems.Add(
                new InvoiceItem()
                {
                    ID = _invoiceItems.Count + 1,
                    Product = selectedProduct,
                    Quantity = 1
                }
            );
            _userControl.DgvProducts.Refresh();
        }
    }
}
