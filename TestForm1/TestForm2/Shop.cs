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
            GridViewDataBaze.Columns.Add("ProductCategory", "Тип товара");
            GridViewDataBaze.Columns.Add("ProductName", "Название товара");
            GridViewDataBaze.Columns.Add("ProductCost", "Цена");
            GridViewDataBaze.Columns.Add("isNew", String.Empty);
        }

        private void LoadDataFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ProductCategory, ProductName, ProductCost FROM Product";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Чтение данных о товарах из базы данных
                                string productCategory = reader.GetString(0);
                                string productName = reader.GetString(1);
                                decimal productCost = reader.GetDecimal(2);

                                // Добавление строки с данными о товаре в DataGridView
                                GridViewDataBaze.Rows.Add(productCategory, productName, productCost, string.Empty);
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
                string productCategory = dialog.ProductCategory;
                string productName = dialog.ProductName;
                decimal productCost = dialog.ProductCost;

                // Добавление товара в базу данных
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO Product (ProductCategory, ProductName, ProductCost) " +
                                       "VALUES (@Category, @Name, @Cost)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Category", productCategory);
                            command.Parameters.AddWithValue("@Name", productName);
                            command.Parameters.AddWithValue("@Cost", productCost);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Добавление строки с новым товаром в DataGridView
                                GridViewDataBaze.Rows.Add(productCategory, productName, productCost, string.Empty);
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
            // Проверка, выбрана ли строка в DataGridView
            if (GridViewDataBaze.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GridViewDataBaze.SelectedRows[0];

                // Получение значений столбцов выбранной строки
                string productCategory = selectedRow.Cells["ProductCategory"].Value.ToString();
                string productName = selectedRow.Cells["ProductName"].Value.ToString();
                decimal productCost = Convert.ToDecimal(selectedRow.Cells["ProductCost"].Value);

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
                            string query = "DELETE FROM Product WHERE ProductCategory = @Category " +
                                           "AND ProductName = @Name AND ProductCost = @Cost";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Category", productCategory);
                                command.Parameters.AddWithValue("@Name", productName);
                                command.Parameters.AddWithValue("@Cost", productCost);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    // Удаление выбранной строки с товаром из DataGridView
                                    GridViewDataBaze.Rows.Remove(selectedRow);
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

        private void GridViewDataBaze_CellContentClick(object sender, PaintEventArgs e)
        {

        }

        private void GridViewDataBaze_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


  