using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm2
{
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
        }

        private void FormEnter_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=HOME-PC; Initial Catalog=Test; Integrated Security=True;";

            string login = textLog.Text;
            string password = textPass.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM [User] WHERE Login = @Login AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            Shop shop = new Shop(login); // Передаем значение логина
                            shop.Show();
                            this.Hide();
                            MessageBox.Show("Вы успешно вошли!");
                        }
                        else
                        {
                            Caphca capcha = new Caphca();
                            capcha.Show();
                            this.Hide();
                            MessageBox.Show("Почта или пароль введены неверно.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

#pragma warning disable IDE1006 // Стили именования
        private void checkCaphca_CheckedChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Стили именования
        {
           
        }
    }   
}  

