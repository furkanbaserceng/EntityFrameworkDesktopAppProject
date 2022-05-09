using EntityFrameworkProject.DataAccess.Concrete.Context;

namespace EntityFrameworkProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(ETradeSampleContext context=new ETradeSampleContext())
            {

                dgwProducts.DataSource = context.Products.ToList();

            }
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}