namespace Catalog
{
    public partial class Form1 : Form
    {
        public static List<Product> products { get; set; } = new();
        public string Choice { get; set; }
        public static bool Temp { get; set; }
        public static Product? Find { get; set; }
        public Form1()
        {
            InitializeComponent();

            foreach (var item in products)
            {
                listBox1.Items.Add(item);
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Temp = true;
            Form2 form2 = new();
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
                listBox1.Items.Add(products[products.Count-1]);
           
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Temp = false;
            Find = listBox1.SelectedItem as Product;
            var product = products.Find(x => x == Find);
            Form2 form2 = new Form2();
            form2.textBoxName.Text = product?.Name;
            form2.textBoxCountry.Text = product?.Country;
            form2.textBoxCost.Text = product?.Cost;
            form2.ShowDialog();       
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox1.Items.Remove(item);
            products.Remove(item as Product);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            products.Clear();
        }
    }
}