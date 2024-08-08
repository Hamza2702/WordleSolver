using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle
{
    public partial class Form1 : Form
    {
        string word;
        List<string> words = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadWordsFromFile(string filePath)
        {
            try
            {
                words = File.ReadAllLines(filePath).ToList();
                if (words.Count == 0)
                {
                    MessageBox.Show("File is empty");
                    Application.Exit();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void CheckIncludeTextBox()
        {
            Regex regex = new Regex(@"[0-9+\-\/\*\(\)]");
            MatchCollection matches = regex.Matches(txtBoxInclude.Text);

            if (txtBoxInclude.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter valid arguments");
            }
            if (matches.Count > 0)
            {
                MessageBox.Show("Characters only");
                return;
            }
            if (txtBoxInclude.Text.Trim().Length > 1)
            {
                MessageBox.Show("One character at a time");
            }
        }
        private void CheckExcludeTextBox()
        {
            Regex regex = new Regex(@"[0-9+\-\/\*\(\)]");
            MatchCollection matches = regex.Matches(txtBoxInclude.Text);

            if (txtBoxExclude.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter valid arguments");
            }
            if (matches.Count > 0)
            {
                MessageBox.Show("Characters only");
                return;
            }
            if (txtBoxExclude.Text.Trim().Length > 1)
            {
                MessageBox.Show("One character at a time");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(67,67,67);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckIncludeTextBox();
        }
    }
}
