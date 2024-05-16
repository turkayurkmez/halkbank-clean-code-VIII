namespace SingleResponsibility
{
    public partial class Form1 : Form
    {

        /*
*     Her nesnenin bir sorumluluğu olmalı.
*       - Bir nesnede fonksiyonel değişiklik yapmak (yeni eklemek, eskiyi değiştirmek vs gibi) için birden fazla sebebiniz varsa, prensibe uymuyorsunuz demektir.
*       
*       - Form1 insan olsaydı, "senin sorumluluğun ne" sorusuna nasıl cevap verirdi?
*       
* 
*/
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);

            ProductService productService = new ProductService();
            NotificationService notificationService = new NotificationService();

            productService.CreateProduct(name, price);
            notificationService.SendMailTo("admim@mail.com", "Yeni ürün eklendi");
        }

        

      

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }
  
    }
}
