using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace kyrsova1 
{
    public partial class Form2 : Form
    {
        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdmissionDB;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadSpecialties();
            LoadEnrolled();
        }

        private void LoadSpecialties()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Name FROM Specialties ORDER BY Name", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Добавляем пункт "Все" на первое место
                    DataRow all = dt.NewRow();
                    all["Id"] = 0;
                    all["Name"] = "Все";
                    dt.Rows.InsertAt(all, 0);

                    // Имя твоего ComboBox на второй форме (посмотри в свойствах, если не comboBox1, замени)
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки специальностей: " + ex.Message);
            }
        }

        private void LoadEnrolled()
        {
            if (comboBox1.SelectedValue == null) return;

            // Берем текст, который выбран (Все, Повар, Программист...)
            string specName = comboBox1.Text;

            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdmissionDB;Integrated Security=True";

            // Запрос: только с оригиналами!
            string query = @"
        SELECT a.FullName       AS [ФИО],
               s.Name           AS [Специальность],
               s.Code           AS [Код],
               a.GroupName      AS [Группа],
               a.TotalScore     AS [Баллы],
               CASE WHEN a.IsPaid = 1 THEN N'Платно' ELSE N'Бюджет' END AS [Основа],
               CASE WHEN a.HasBenefits = 1 THEN N'Да' ELSE N'Нет' END AS [Льготы]
        FROM Abiturients a
        JOIN Specialties s ON a.SpecialtyId = s.Id
        WHERE a.HasOriginalDocs = 1 "; // Оригинал сдан!

            // Фильтр по названию (если выбрано не "Все")
            if (specName != "Все" && specName != "All" && specName != "")
            {
                query += " AND s.Name = @specName ";
            }

            // Сортировка: сначала льготники, потом по баллам
            query += " ORDER BY a.HasBenefits DESC, a.TotalScore DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    if (specName != "Все" && specName != "All" && specName != "")
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@specName", specName);
                    }

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Привязка к таблице (если она называется dgvAll, оставь dgvAll)
                    dgvAll.DataSource = dt;

                    // Обновляем надпись внизу (если она называется lblCount)
                    label2.Text = "Зачислено: " + dt.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEnrolled();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}