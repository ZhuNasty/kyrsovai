using kyrsova1;
using kyrsovai;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AdmissionApp // Убедись, что тут твое пространство имен (kyrsova1 или AdmissionApp)
{
    public partial class Form1 : Form
    {
        // Строка подключения
        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdmissionDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        // Загрузка при старте
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSpecialties();
            LoadAll();
        }

        // Заполнение ComboBox (обращаемся напрямую к cmbSpecialtyFilter)
        private void LoadSpecialties()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Name FROM Specialties ORDER BY Name", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // ВОТ ЭТА ЧАСТЬ ДОБАВЛЯЕТ ПУНКТ "ВСЕ"
                    DataRow all = dt.NewRow();
                    all["Id"] = 0;
                    all["Name"] = "Все";
                    dt.Rows.InsertAt(all, 0);

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

        // Загрузка данных в таблицу
        private void LoadAll()
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdmissionDB;Integrated Security=True";

            // Базовый запрос (без фильтра)
            string query = @"
        SELECT a.FullName       AS [ФИО],
               s.Name           AS [Специальность],
               s.Code           AS [Код],
               a.GroupName      AS [Группа],
               a.TotalScore     AS [Баллы],
               CASE WHEN a.HasOriginalDocs = 1 THEN N'Да' ELSE N'Нет' END AS [Оригинал],
               CASE WHEN a.NeedsDorm = 1 THEN N'Да' ELSE N'Нет' END AS [Общежитие],
               CASE WHEN a.IsPaid = 1 THEN N'Платно' ELSE N'Бюджет' END AS [Основа],
               CASE WHEN a.HasBenefits = 1 THEN N'Да' ELSE N'Нет' END AS [Льготы]
        FROM Abiturients a
        JOIN Specialties s ON a.SpecialtyId = s.Id ";

            // Если в списке что-то выбрано (и это не "Все"), добавляем фильтр по ID
            if (comboBox1.SelectedIndex > 0 && comboBox1.SelectedValue != null)
            {
                query += " WHERE s.Id = @specId ";
            }

            query += " ORDER BY s.Name, a.TotalScore DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    // Передаем ID только если выбран не "Все"
                    if (comboBox1.SelectedIndex > 0 && comboBox1.SelectedValue != null)
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@specId", (int)comboBox1.SelectedValue);
                    }

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Привязываем к таблице
                    dgvAll.DataSource = dt;

                    // Обновляем надпись
                    lblStatus.Text = "Всего: " + dt.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        // Обработчик изменения выбора в ComboBox
        private void cmbSpecialtyFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAll();
        }

        // Кнопка Обновить
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        // Кнопка Показать зачисленных (открывает Форму 2)
        private void btnShowEnrolled_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        // Кнопка Добавить (открывает Форму 3)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Если формы Form3 физически нет в проекте, эта строка будет красной.
            // Как только создашь Form3, ошибка пропадет.
            Form3 f3 = new Form3();
            f3.ShowDialog();
            LoadAll();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            LoadAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            LoadAll();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LoadAll();
        }
    }
}