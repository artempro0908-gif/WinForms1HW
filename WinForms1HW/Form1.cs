namespace WinForms1HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = txtMyInput.Text;

            if (string.IsNullOrWhiteSpace(filePath))
            {
                MessageBox.Show("Будь ласка, вкажіть шлях до файлу!");
                return;
            }

            try
            {
                string fileContent = File.ReadAllText(filePath);
                txtFileContent.Text = fileContent;
            }
            catch
            {
                MessageBox.Show("Помилка! Неправильний шлях або файл не знайдено.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
