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
            orderAdapter = new SqlDataAdapter("Select * from Покупка", connectionString);
            couponAdapter = new SqlDataAdapter("Select * from Купон", connectionString);
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
            orderAdapter.Update(dataSet, "Покупка");
        }

        private void buttonCoupon_Click(object sender, EventArgs e)
        {
            couponAdapter.Update(dataSet, "Купон");
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
                sqlAdapter.SelectCommand.Parameters["@month"].Value = numericUpDown2.Value;

                DataSet dataSet = new DataSet();
                sqlAdapter.Fill(dataSet, "report2");

                dataGridViewProcedura.DataSource = dataSet.Tables["report2"];
            }
        }
    }
}
