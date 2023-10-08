using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab01
{
    public partial class Form1 : Form
    {
        private string connectionString;

        private SqlDataAdapter orderAdapter;
        private SqlDataAdapter couponAdapter;
        private SqlDataAdapter userAdapter;
        private SqlDataAdapter firmAdapter;

        private SqlCommandBuilder couponBuilder = new SqlCommandBuilder();
        private SqlCommandBuilder orderBuilder = new SqlCommandBuilder();
        private SqlCommandBuilder userBuilder = new SqlCommandBuilder();

        private DataSet dataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();

           connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

            // Создание объектов SqlDataAdapter.
            orderAdapter = new SqlDataAdapter("Select Покупка.ID, Покупка.[Стоимость покупки], Покупка.Дата, Пользователь.Логин, " +
                "Купон.Наименование from Покупка INNER JOIN Пользователь ON Покупка.[Код пользователя] = Пользователь.ID" +
                " INNER JOIN Купон ON Покупка.[Код купона] = Купон.ID", connectionString);
            
            couponAdapter = new SqlDataAdapter("Select Купон.ID, Купон.Наименование, [Вид купона].Наименование," +
                " Фирма.Наименование, Купон.[Срок действия], Купон.[Полная стоимость товара], Купон.[Величина скидки], " +
                "Купон.[Стоимость купона] from Купон INNER JOIN Фирма ON Купон.[Код фирмы] = Фирма.ID" +
                " INNER JOIN [Вид купона] ON Купон.[Код вида купона] = [Вид купона].ID", connectionString);
            
            userAdapter = new SqlDataAdapter("Select * from Пользователь", connectionString);
            firmAdapter = new SqlDataAdapter("Select * from Фирма", connectionString);

            // Автоматическая генерация команд SQL.
            couponBuilder = new SqlCommandBuilder(couponAdapter);
            orderBuilder = new SqlCommandBuilder(orderAdapter);
            userBuilder = new SqlCommandBuilder(userAdapter);

            // Заполнение таблиц в DataSet.
            couponAdapter.Fill(dataSet, "Купон");
            orderAdapter.Fill(dataSet, "Покупка");
            userAdapter.Fill(dataSet, "Пользователь");
            firmAdapter.Fill(dataSet, "Фирма");

            // Связывание элементов управления с данными.
            dataGridViewCoupon.DataSource = dataSet.Tables["Купон"];
            dataGridViewOrder.DataSource = dataSet.Tables["Покупка"];
            dataGridViewUser.DataSource = dataSet.Tables["Пользователь"];
            dataGridViewFirm.DataSource = dataSet.Tables["Фирма"];
            dataGridViewViborka.DataSource = dataSet.Tables["Купон"];

            
            FillCouponCombobox();
        }

        private void FillCouponCombobox()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("select Наименование from Купон", sqlConnection);

                DataSet dataSet = new DataSet();
                sqlAdapter.Fill(dataSet, "Наименование");

                comboBox1.DataSource = dataSet.Tables["Наименование"];
                comboBox1.ValueMember = "Наименование";
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewOrder.SelectedRows[0];

                string login = selectedRow.Cells["Логин"].Value.ToString();
                string couponName = selectedRow.Cells["Наименование"].Value.ToString();
                string date = selectedRow.Cells["Дата"].Value.ToString();
                string cost = selectedRow.Cells["Стоимость покупки"].Value.ToString();

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    SqlCommand userCommand = new SqlCommand("SELECT ID FROM Пользователь WHERE Логин = @paramLogin", sqlConnection);
                    userCommand.Parameters.AddWithValue("@paramLogin", login);
                    int userId = Convert.ToInt32(userCommand.ExecuteScalar());

                    SqlCommand couponCommand = new SqlCommand("SELECT ID FROM Купон WHERE Наименование = @paramCouponName", sqlConnection);
                    couponCommand.Parameters.AddWithValue("@paramCouponName", couponName);
                    int couponId = Convert.ToInt32(couponCommand.ExecuteScalar());

                    DateTime orderDate = Convert.ToDateTime(date);
                    int orderCost = Convert.ToInt32(cost);

                    SqlCommand updateCommand = new SqlCommand("INSERT INTO Покупка (Дата, [Стоимость покупки], [Код пользователя], [Код купона])" +
                        " VALUES (@orderDate, @orderCost, @userId, @couponId)", sqlConnection);

                    updateCommand.Parameters.AddWithValue("@orderDate", orderDate);
                    updateCommand.Parameters.AddWithValue("@orderCost", orderCost);
                    updateCommand.Parameters.AddWithValue("@userId", userId);
                    updateCommand.Parameters.AddWithValue("@couponId", couponId);
                    updateCommand.ExecuteNonQuery();
                }
            }
            dataGridViewCoupon.Refresh();
        }

        private void buttonCoupon_Click(object sender, EventArgs e)
        {
            if (dataGridViewCoupon.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCoupon.SelectedRows[0];

                string vid = selectedRow.Cells["Наименование1"].Value.ToString();
                string firmName = selectedRow.Cells["Наименование2"].Value.ToString();
                string couponName = selectedRow.Cells["Наименование"].Value.ToString();
                string date = selectedRow.Cells["Срок действия"].Value.ToString();

                string fullCost = selectedRow.Cells["Полная стоимость товара"].Value.ToString();
                string saleCost = selectedRow.Cells["Величина скидки"].Value.ToString();
                string couponCost = selectedRow.Cells["Стоимость купона"].Value.ToString();

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    SqlCommand userCommand = new SqlCommand("SELECT ID FROM [Вид купона] WHERE Наименование = @paramVid", sqlConnection);
                    userCommand.Parameters.AddWithValue("@paramVid", vid);
                    int couponVid = Convert.ToInt32(userCommand.ExecuteScalar());

                    SqlCommand couponCommand = new SqlCommand("SELECT ID FROM Фирма WHERE Наименование = @paramFirmName", sqlConnection);
                    couponCommand.Parameters.AddWithValue("@paramFirmName", firmName);
                    int firmId = Convert.ToInt32(couponCommand.ExecuteScalar());

                    DateTime orderDate = Convert.ToDateTime(date);
                    int fullPrice = Convert.ToInt32(fullCost);
                    int salePrice = Convert.ToInt32(saleCost);
                    int couponPrice = Convert.ToInt32(couponCost);

                    SqlCommand updateCommand = new SqlCommand("INSERT INTO Купон (Наименование, [Код вида купона], [Код фирмы], " +
                        "[Срок действия], [Полная стоимость товара], [Величина скидки], [Стоимость купона])" +
                        " VALUES (@couponName, @couponVid, @firmId, @orderDate, @fullPrice, @salePrice, @couponPrice)", sqlConnection);

                    updateCommand.Parameters.AddWithValue("@orderDate", orderDate);
                    updateCommand.Parameters.AddWithValue("@couponName", couponName);
                    updateCommand.Parameters.AddWithValue("@couponVid", couponVid);
                    updateCommand.Parameters.AddWithValue("firmId", firmId);
                    updateCommand.Parameters.AddWithValue("@fullPrice", fullPrice);
                    updateCommand.Parameters.AddWithValue("@salePrice", salePrice);
                    updateCommand.Parameters.AddWithValue("@couponPrice", couponPrice);
                    updateCommand.ExecuteNonQuery();
                }
            }
            dataGridViewCoupon.Refresh();
        }

        private void buttonViborka_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand =
                    new SqlCommand("SELECT * FROM Купон" +
                                  " where Наименование = @SelectedValue", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@SelectedValue", comboBox1.SelectedValue.ToString());
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable("Выборка");
                dataTable.Load(sqlDataReader);
                sqlDataReader.Close();
                dataGridViewViborka.DataSource = dataTable;
            }
        }

        private void buttonProcedura_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("Проданные_купоны", sqlConnection);
                sqlAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlAdapter.SelectCommand.Parameters.Add(new SqlParameter("@year", SqlDbType.Int));
                sqlAdapter.SelectCommand.Parameters["@year"].Value = numericUpDown1.Value;

                sqlAdapter.SelectCommand.Parameters.Add(new SqlParameter("@month", SqlDbType.Int));
                sqlAdapter.SelectCommand.Parameters["@month"].Value = comboBox2.SelectedItem;

                DataSet dataSet = new DataSet();
                sqlAdapter.Fill(dataSet, "report2");

                dataGridViewProcedura.DataSource = dataSet.Tables["report2"];
            }
        }
    }
}
