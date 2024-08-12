using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace Wordle
{
    public partial class Form1 : Form
    {
        string letter;
        Stack<String> includedLetters = new Stack<string>();
        Stack<String> excludedLetters = new Stack<string>();
        List<string> words = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadWordsFromFile(string filePath)
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the file
                string[] fileWords = File.ReadAllLines(filePath);

                // Clear the current list of words
                words.Clear();

                foreach (var item in fileWords)
                {
                    string word = item.Trim().ToLower();

                    // Add word if it isn't empty
                    if (!string.IsNullOrEmpty(word))
                    {
                        words.Add(word);
                    }
                }
            }
            else
            {
                MessageBox.Show("The specified file does not exist.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(67, 67, 67);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            lblInclude.Text = "";
            lblExclude.Text = "";

            LoadWordsFromFile("words.txt");
        }

        private void txtBoxInclude_KeyUp(object sender, KeyEventArgs e)
        {
            letter = txtBoxInclude.Text.Trim().ToLower();

            // If not a single character
            if (letter.Length != 1)
            {
                txtBoxInclude.Clear();
                return;
            }

            // If 4 letters
            if (includedLetters.Count == 4)
            {
                txtBoxInclude.Clear();
                return;
            }

             includedLetters.Push(letter);
             lblInclude.Text = string.Join("", includedLetters.Reverse()); // Reverse to show correct order
             txtBoxInclude.Clear();
        }

        private void txtBoxInclude_KeyDown(object sender, KeyEventArgs e)
        {
            // Remove last letter
            if (e.KeyCode == Keys.Back && includedLetters.Count > 0)
            {
                includedLetters.Pop();
                lblInclude.Text = string.Join("", includedLetters.Reverse()); // Reverse to maintain correct order
                e.SuppressKeyPress = true; // Stop processing the backspace key
                return;
            }
        }

        private void txtBoxExclude_KeyUp(object sender, KeyEventArgs e)
        {
            letter = txtBoxExclude.Text.Trim().ToLower();

            // If not a single character
            if (letter.Length != 1)
            {
                txtBoxExclude.Clear();
                return;
            }

            if (includedLetters.Contains(letter))
            {
                txtBoxExclude.Clear();
                return;
            }

            // Add letter if it isn't already included
            if (!excludedLetters.Contains(letter))
            {
                excludedLetters.Push(letter);
                lblExclude.Text = string.Join("", excludedLetters.Reverse()); // Reverse to show correct order
                txtBoxExclude.Clear();
            }
        }

        private void txtBoxExclude_KeyDown(object sender, KeyEventArgs e)
        {
            // Remove last letter
            if (e.KeyCode == Keys.Back && excludedLetters.Count > 0)
            {
                excludedLetters.Pop();
                lblExclude.Text = string.Join("", excludedLetters.Reverse()); // Reverse to maintain correct order
                e.SuppressKeyPress = true; // Stop processing the backspace key
                return;
            }
        }

        // Check for the words
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Clear list
            listBoxWords.Items.Clear();

            // Convert included stack to the list
            var includedList = includedLetters.ToList();

            // Filter the words
            var filteredWords = words.Where(word =>
            {
                // Check if each word contains the required amount of letters
                bool includeCheck = includedList.All(l => word.Count(c => c == l[0]) >= includedList.Count(x => x == l));

                // Check if the word doesn't contain any excluded letters
                bool excludeCheck = excludedLetters.All(l => !word.Contains(l));

                return includeCheck && excludeCheck;
            });

            // Add to list box
            foreach (var word in filteredWords)
            {
                listBoxWords.Items.Add(word);
            }

            // If no words
            if (listBoxWords.Items.Count == 0)
            {
                MessageBox.Show("No words found that match the criteria.");
            }
        }


    }
}