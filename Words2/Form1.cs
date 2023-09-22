namespace Words2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAddWords_Click(object sender, EventArgs e)
        {
            string newWord = txtWords.Text.Trim();

            // Check if the TextBox is empty or contains only white space
            if (string.IsNullOrWhiteSpace(newWord))
            {
                MessageBox.Show("Please enter a word in the TextBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the word already exists in either ComboBox
            if (txtWordlist1.Items.Contains(newWord) || txtWordList2.Items.Contains(newWord))
            {
                MessageBox.Show("The word already exists in one of the ComboBoxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the word is already in the Combo box
            if (txtWordlist1.Contains(txtAddWords))
            {
                MessageBox.Show("The word appears in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determine which ComboBox to add the word
            if (txtWordlist1.Items.Count < txtWordList2.Items.Count)
            {
                txtWordlist1.Items.Add(newWord);
            }
            else
            {
                txtWordList2.Items.Add(newWord);
            }

            // Clear the TextBox
            txtWords.Clear();

            // Display a success message
            MessageBox.Show("The new word has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnConcatenate_Click(object sender, EventArgs e)
        {
            // Check which radio button is selected
            if (txtRemove1.Checked)
            {
                RemoveWordFromComboBox(txtWordlist1);
            }
            else if (txtRemove2.Checked)
            {
                RemoveWordFromComboBox(txtWordList2);
            }
            else
            {
                MessageBox.Show("Please select a radio button to indicate from which ComboBox to remove the word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveWordFromComboBox(ComboBox comboBox)
        {
            // Get the selected words from ComboBox1 and ComboBox2
            string selectedWord1 = txtWordlist1.SelectedItem as string;
            string selectedWord2 = txtWordList2.SelectedItem as string;

            // Check if a word is selected from both ComboBoxes
            if (string.IsNullOrWhiteSpace(selectedWord1) || string.IsNullOrWhiteSpace(selectedWord2))
            {
                MessageBox.Show("Please select a word from both ComboBoxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the same word is selected in both ComboBoxes
            if (selectedWord1 == selectedWord2)
            {
                MessageBox.Show("Please select different words from each ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Concatenate the selected words
            string concatenatedWords = selectedWord1 + " " + selectedWord2;

            // Display the concatenated result in the label
            txtWordsConcatenated.Text = "Concatenated Result: " + concatenatedWords;

        }
    }
}