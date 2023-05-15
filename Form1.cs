using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CountWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbWordChecking_TextChanged(object sender, EventArgs e)
        {
            string checkingText = tbWordChecking.Text;
            string cleanedText = Regex.Replace(checkingText, @"[^a-zA-Z]", ""); //get only a-z and A-Z
            string vowelOnlyText = Regex.Replace(checkingText, @"[^aeiou]", "");

            string compWord = tbText.Text;

            if (!(string.IsNullOrEmpty(checkingText)))
            {
                //characters count 
                int textCount = cleanedText.Length;
                lblCharCount.Text = textCount.ToString();

                //wordCount

                string[] words = checkingText.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                int wordsCount = words.Length;
                lblWordCount.Text = wordsCount.ToString();

                //vowels count
                int vowelCount = vowelOnlyText.Length;
                lblVowelsCount.Text = vowelCount.ToString();

                //word
                CountWordOccered(compWord, checkingText);


            }
            else
            {
                lblCharCount.Text = "0";
                lblWordCount.Text = "0";
                lblVowelsCount.Text = "0";
            }

        }

        private void CountWordOccered(string compWord, string checkingText)
        {
            if (!(string.IsNullOrEmpty(compWord)))
            {
                string[] wordsChar = checkingText.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                int count = 0;

                foreach (string word in wordsChar)
                {
                    if (string.Equals(compWord, word))
                    {
                        count++;
                    }
                }
                lblEnteredWordCount.Text = count.ToString();
            }
            else
            {
                lblEnteredWordCount.Text = "0";
            }

        }

        private void tbText_TextChanged(object sender, EventArgs e)
        {
            string checkingText = tbWordChecking.Text;
            string compWord = tbText.Text;


            if (!(string.IsNullOrEmpty(checkingText)))
            {
                CountWordOccered(compWord, checkingText);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string topic = tbTopic.Text; // Get the TOPIC
                string topicCount = lblWordCount.Text; // get the count of the topic

                int newRow = dgvTrack.Rows.Add(); // Create a new row

                dgvTrack.Rows[newRow].Cells[0].Value = topic;
                dgvTrack.Rows[newRow].Cells[1].Value = topicCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTrack.SelectedRows.Count > 0)
                {
                    int row = dgvTrack.SelectedRows[0].Index;
                    dgvTrack.Rows.RemoveAt(row);
                }
                else
                {
                    // Display an error message or perform any other desired action
                    MessageBox.Show("Please select a row to delete.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}