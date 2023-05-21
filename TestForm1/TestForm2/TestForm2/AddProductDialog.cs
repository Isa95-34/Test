using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestForm2
{
    public partial class AddProductDialog : Form
    {
        public string ProductArticleNumber { get; private set; }
        public string ProductCategory { get; private set; }
        public string ProductName { get; private set; }
        public decimal ProductCost { get; private set; }

        public AddProductDialog()
        {
            InitializeComponent();
        }

        private void AddProductDialog_Load(object sender, EventArgs e)
        {
            // Инициализация диалогового окна
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Обработчик события клика по кнопке "Добавить"
            // Получение введенных данных о новом товаре из текстовых полей
            ProductArticleNumber = txtArticleNumber.Text;
            ProductCategory = txtCategory.Text;
            ProductName = txtName.Text;

            // Проверка корректности введенной цены
            if (decimal.TryParse(txtCost.Text, out decimal cost))
            {
                ProductCost = cost;

                // Закрытие диалогового окна с результатом DialogResult.OK
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Некорректная цена товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Обработчик события клика по кнопке "Отмена"
            // Закрытие диалогового окна с результатом DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtArticleNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductDialog_Load_1(object sender, EventArgs e)
        {

        }
    }
}
