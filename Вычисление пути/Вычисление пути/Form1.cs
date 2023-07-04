using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Вычисление_пути
{
    public partial class Form1 : Form
    {
        public double initialVelocityPub, timePub, accelerationPub, pathPub;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            initialVelocityPub = EvaluateExpression(velocityTextBox);
            velocityTextBox.Text = Convert.ToString(initialVelocityPub);
            timePub = EvaluateExpression(timeTextBox);
            timeTextBox.Text = Convert.ToString(timePub);
            accelerationPub = EvaluateExpression(accelerationTextBox);
            accelerationTextBox.Text = Convert.ToString(accelerationPub);
            velocityTextBox.ForeColor = Color.Black;
            timeTextBox.ForeColor = Color.Black;
            accelerationTextBox.ForeColor = Color.Black;
            // Находим путь пройденный телом с помощью определенного интеграла
            pathPub = CalculateDistance();
            // Выводим результат в лейбл
            text.AppendText($"Результаты расчетов:\r\nНачальная скорость: {velocityTextBox.Text} к/ч\r\nВремя движения: {timeTextBox.Text} ч\r\nУскорение: {accelerationTextBox.Text} км/ч^2\r\nПуть пройденный телом: {pathPub} км.\nРешение: {pathPub} = {initialVelocityPub} * {timePub} + 0.5 * {accelerationPub} * {Math.Pow(timePub, 2)}\r\n{Environment.NewLine}");
        }

        private double CalculateDistance()
        {
            pathPub = initialVelocityPub * timePub + 0.5 * accelerationPub * Math.Pow(timePub, 2);
            return pathPub;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            velocityTextBox.Text = "0";
            timeTextBox.Text = "0";
            accelerationTextBox.Text = "0";
            text.Clear();
        }

        private void wordButton_Click(object sender, EventArgs e)
        {
            Word();
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            Excel();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void velocityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Word()
        {
            Word.Application word = new Word.Application(); // создание объекта Word
            Word.Document doc = word.Documents.Add(); // создание нового документа Word
            doc.Paragraphs[1].Range.Text = $"Результаты расчетов:\r\nНачальная скорость: {velocityTextBox.Text} к/ч\r\nВремя движения: {timeTextBox.Text} ч\r\nУскорение: {accelerationTextBox.Text} км/ч^2\r\nПуть пройденный телом: {pathPub} км.\r\n{Environment.NewLine}"; // вывод текста
            word.Visible = true;
        }

        private void Excel()
        {
            Excel.Application excel = new Excel.Application(); // создание объекта Excel
            Excel.Workbook workbook = excel.Workbooks.Add(); // создание новой книги Excel
            Excel.Worksheet sheet = (Excel.Worksheet)workbook.ActiveSheet; // выбор активного листа
            // вывод текста на ячейку
            sheet.Cells[1, 1].Value = "Результаты расчетов:";
            sheet.Cells[2, 1].Value = "Начальная скорость:";
            sheet.Cells[2, 2].Value = initialVelocityPub;
            sheet.Cells[3, 1].Value = "Время движения:";
            sheet.Cells[3, 2].Value = timePub;
            sheet.Cells[4, 1].Value = "Ускорение:";
            sheet.Cells[4, 2].Value = accelerationPub;
            sheet.Cells[5, 1].Value = "Путь пройденный телом:";
            sheet.Cells[5, 2].Value = pathPub;
            sheet.Columns.AutoFit(); // выравнивание столбцов
            sheet.Rows.AutoFit(); // выравнивание строк
            excel.Visible = true;
        }

        private static double EvaluateExpression(TextBox expression)
        {
            try
            {
                expression.Text = expression.Text.Replace(" ", ""); // удаление пробелов из выражения
                System.Data.DataTable dt = new System.Data.DataTable(); // создание объекта для вычисления математических выражений
                var result = dt.Compute(expression.Text, ""); // вычисление математических выражений
                return Convert.ToDouble(result); // возврат результата
            }
            catch (Exception ex)
            {
                expression.ForeColor = Color.Red;
                expression.Text = "0";
                MessageBox.Show($"Ошибка в {expression}: " + ex.Message + "Все поля с ошибками были заменены на 0"); // вывод ошибки
                return 0.0;
            }
        }
    }
}