using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestForm2
{
    public partial class Shop : Form
    {
        private string login;
        private string connectionString = @"Data Source=HOME-PC; Initial Catalog=Test; Integrated Security=True;";

        public Shop(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            CreateColumns(); // Создание столбцов перед загрузкой данных
            LoadDataFromDatabase(); // Загрузка данных из базы данных
        }

        private void CreateColumns()
        {
            // Создание столбцов для отображения данных о товарах
            ColumnHeader columnHeader = new ColumnHeader();
            columnHeader.Text = "ProductPhoto";
            columnHeader.Width = 100; // Задайте ширину столбца в пикселях
            listViewDataBaze.Columns.Add(columnHeader);

            columnHeader = new ColumnHeader();
            columnHeader.Text = "Тип товара";
            columnHeader.Width = 100; // Задайте ширину столбца в пикселях
            listViewDataBaze.Columns.Add(columnHeader);

            columnHeader = new ColumnHeader();
            columnHeader.Text = "Название товара";
            columnHeader.Width = 150; // Задайте ширину столбца в пикселях
            listViewDataBaze.Columns.Add(columnHeader);

            columnHeader = new ColumnHeader();
            columnHeader.Text = "Цена";
            columnHeader.Width = 100; // Задайте ширину столбца в пикселях
            listViewDataBaze.Columns.Add(columnHeader);

            columnHeader = new ColumnHeader();
            columnHeader.Text = "isNew";
            columnHeader.Width = 50; // Задайте ширину столбца в пикселях
            listViewDataBaze.Columns.Add(columnHeader);
        }

        private void LoadDataFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ProductArticleNumber, ProductCategory, ProductName, ProductCost, ProductPhoto FROM Product";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Чтение данных о товарах из базы данных
                                string productArticleNumber = reader.GetString(0);
                                string productCategory = reader.GetString(1);
                                string productName = reader.GetString(2);
                                decimal productCost = reader.GetDecimal(3);
                                string productPhoto = reader.GetString(4);

                                // Добавление строки с данными о товаре в ListView
                                ListViewItem item = new ListViewItem(productPhoto);
                                item.SubItems.Add(productCategory);
                                item.SubItems.Add(productName);
                                item.SubItems.Add(productCost.ToString());
                                item.SubItems.Add(string.Empty);
                                listViewDataBaze.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            // Обработчик события клика по кнопке "Добавить товар"
            // Открытие диалогового окна для ввода данных о новом товаре
            AddProductDialog dialog = new AddProductDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Получение введенных данных о новом товаре
                string productArticleNumber = dialog.ProductArticleNumber;
                string productCategory = dialog.ProductCategory;
                string productName = dialog.ProductName;
                decimal productCost = dialog.ProductCost;

                // Добавление товара в базу данных
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO Product (ProductArticleNumber, ProductCategory, ProductName, ProductCost) " +
                                       "VALUES (@ArticleNumber, @Category, @Name, @Cost)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ArticleNumber", productArticleNumber);
                            command.Parameters.AddWithValue("@Category", productCategory);
                            command.Parameters.AddWithValue("@Name", productName);
                            command.Parameters.AddWithValue("@Cost", productCost);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Добавление строки с новым товаром в ListView
                                ListViewItem item = new ListViewItem(productArticleNumber);
                                item.SubItems.Add(productCategory);
                                item.SubItems.Add(productName);
                                item.SubItems.Add(productCost.ToString());
                                item.SubItems.Add(string.Empty);
                                listViewDataBaze.Items.Add(item);
                                MessageBox.Show("Товар успешно добавлен.");
                            }
                            else
                            {
                                MessageBox.Show("Ошибка при добавлении товара.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            // Обработчик события клика по кнопке "Удалить товар"
            // Проверка, выбрана ли строка в ListView
            if (listViewDataBaze.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewDataBaze.SelectedItems[0];

                // Получение значения столбца ProductArticleNumber выбранной строки
                string productArticleNumber = selectedItem.Text;

                // Подтверждение удаления товара
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранный товар?",
                                                      "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Удаление товара из базы данных
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM Product WHERE ProductArticleNumber = @ArticleNumber";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ArticleNumber", productArticleNumber);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Удаление выбранной строки с товаром из ListView
                                    listViewDataBaze.Items.Remove(selectedItem);
                                    MessageBox.Show("Товар успешно удален.");
                                }
                                else
                                {
                                    MessageBox.Show("Ошибка при удалении товара.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewDataBaze_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
