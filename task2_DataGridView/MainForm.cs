using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task2_DataGridView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("—“–Œ ¿ 1", typeof(string));
            dataTable.Columns.Add("—“–Œ ¿ 2", typeof(string));
            dataTable.Columns.Add("¬€¬Œƒ", typeof(int));
            DataGridView.DataSource = dataTable;
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            string word = WordsTextBox.Text;
            string letters = LettersTextBox.Text;

            DataTable dataTable = (DataTable)DataGridView.DataSource;

            int count = CountLetter(word, letters);
            dataTable.Rows.Add(word, letters, count);
        }

        private int CountLetter(string word, string letters)
        {
            int count = 0;
            for (int i = 0; i <= word.Length - letters.Length; i++)
            {
                if (word.Substring(i, letters.Length) == letters)
                {
                    count++;
                }
            }
            return count;
        }
    }
}