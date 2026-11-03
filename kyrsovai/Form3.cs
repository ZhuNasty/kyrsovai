using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kyrsova1
{
    public partial class Form3 : Form
    {
        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdmissionDB;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(connStr))
                {
                    var adapter = new SqlDataAdapter("SELECT Id, Name FROM Specialties ORDER BY Name", conn);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    cmbSpec.DataSource = dt;
                    cmbSpec.DisplayMember = "Name";
                    cmbSpec.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки специальностей: " + ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // 1. Проверяем, заполнено ли ФИО (ищем первое текстовое поле)
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите ФИО!");
                return;
            }

            // 2. Проверяем баллы
            if (!int.TryParse(txtAttestat.Text, out int attScore) ||
                !int.TryParse(txtExam.Text, out int examScore) ||
                !int.TryParse(txtTotal.Text, out int totalScore))
            {
                MessageBox.Show("Баллы должны быть числами!");
                return;
            }

            // Строка подключения
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdmissionDB;Integrated Security=True";

            // Запрос для добавления
            string query = @"INSERT INTO Abiturients 
        (FullName, SpecialtyId, GroupName, AttestatScore, ExamScore, TotalScore, HasOriginalDocs, NeedsDorm, IsPaid, HasBenefits) 
        VALUES (@name, @spec, @group, @att, @exam, @total, @orig, @dorm, @paid, @benefits)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());

                        // ВОТ ЗДЕСЬ МЫ БЕРЕМ ID ИЗ COMBOBOX
                        // Если он называется comboBox1, замени cmbSpec на comboBox1
                        cmd.Parameters.AddWithValue("@spec", (int)cmbSpec.SelectedValue);

                        cmd.Parameters.AddWithValue("@group", txtGroup.Text.Trim());
                        cmd.Parameters.AddWithValue("@att", attScore);
                        cmd.Parameters.AddWithValue("@exam", examScore);
                        cmd.Parameters.AddWithValue("@total", totalScore);
                        cmd.Parameters.AddWithValue("@orig", chkOriginal.Checked);
                        cmd.Parameters.AddWithValue("@dorm", chkDorm.Checked);
                        cmd.Parameters.AddWithValue("@paid", chkPaid.Checked);
                        cmd.Parameters.AddWithValue("@benefits", chkBenefits.Checked);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Абитуриент успешно добавлен!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка базы данных: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Отменяем действие
            this.Close(); // Закрываем форму
        }
    }
}