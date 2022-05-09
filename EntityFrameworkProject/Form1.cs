using EntityFrameworkProject.DataAccess.Concrete;
using EntityFrameworkProject.DataAccess.Concrete.Context;
using EntityFrameworkProject.Entities.Concrete;

namespace EntityFrameworkProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            ListAllProducts();
            tbxProductId.Enabled = false;
            btnGetAllProducts.Visible = false;
        }

        

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxProductId.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
            tbxProductNameUpdate.Text=dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxProductUnitPriceUpdate.Text=dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxProductStockAmountUpdate.Text=dgwProducts.CurrentRow.Cells[3].Value.ToString();


        }


        private void btnProductAdd_Click(object sender, EventArgs e)
        {

            _productDal.Add(new Product
            {

                ProductName = tbxProductNameAdd.Text,
                ProductUnitPrice=Convert.ToDecimal(tbxProductUnitPriceAdd.Text),
                ProductStockAmount=Convert.ToInt32(tbxProductStockAmountAdd.Text)


            }) ;

            MessageBox.Show("Product Added Successfully!");
            ListAllProducts();
            ClearTextBoxAdd();

        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                ProductName=tbxProductNameUpdate.Text,
                ProductUnitPrice=Convert.ToDecimal(tbxProductUnitPriceUpdate.Text),
                ProductStockAmount=Convert.ToInt32(tbxProductStockAmountUpdate.Text)


            }) ;

            MessageBox.Show("Products Updated Successfully!");
            ListAllProducts();
            ClearTextBoxUpdateOrDelete();

        }

        

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

            _productDal.Delete(new Product
            {

                Id=Convert.ToInt32( tbxProductId.Text )  //sadece id vermek yeterli


            });
            MessageBox.Show("Products Deleted Successfully!");
            ListAllProducts();
            ClearTextBoxUpdateOrDelete();

        }

        private void tbxSearchByName_TextChanged(object sender, EventArgs e)
        {

            dgwProducts.DataSource= _productDal.GetByNameFilter(tbxSearchByName.Text);


        }

      

        private void btnGetByUnitPrice_Click(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.GetByUnitPriceFilter(Convert.ToDecimal(tbxMinUnitPrice.Text), 
                                                                    Convert.ToDecimal(tbxMaxUnitPrice.Text));
            btnGetAllProducts.Visible = true;
            btnGetByUnitPrice.Visible = false;

            tbxMinUnitPrice.Clear();
            tbxMaxUnitPrice.Clear();
        
        }

        private void btnGetAllProducts_Click(object sender, EventArgs e)
        {
            ListAllProducts();
            btnGetAllProducts.Visible = false;
            btnGetByUnitPrice.Visible = true;
        }

        private void ListAllProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void ClearTextBoxAdd()
        {

            tbxProductNameAdd.Clear();
            tbxProductUnitPriceAdd.Clear();
            tbxProductStockAmountAdd.Clear();

        }
        private void ClearTextBoxUpdateOrDelete()
        {
            tbxProductId.Clear();
            tbxProductNameUpdate.Clear();
            tbxProductUnitPriceUpdate.Clear();
            tbxProductStockAmountUpdate.Clear();

        }

       
    }
}