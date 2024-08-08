namespace Wordle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWordle = new System.Windows.Forms.Label();
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.lblPossibleWords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInclude = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxInclude = new System.Windows.Forms.TextBox();
            this.lblExclude = new System.Windows.Forms.Label();
            this.txtBoxExclude = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWordle
            // 
            this.lblWordle.AutoSize = true;
            this.lblWordle.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordle.ForeColor = System.Drawing.Color.White;
            this.lblWordle.Location = new System.Drawing.Point(60, 10);
            this.lblWordle.Name = "lblWordle";
            this.lblWordle.Size = new System.Drawing.Size(381, 84);
            this.lblWordle.TabIndex = 0;
            this.lblWordle.Text = "Wordle Solver";
            // 
            // listBoxWords
            // 
            this.listBoxWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.Location = new System.Drawing.Point(259, 198);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.Size = new System.Drawing.Size(218, 169);
            this.listBoxWords.TabIndex = 1;
            // 
            // lblPossibleWords
            // 
            this.lblPossibleWords.AutoSize = true;
            this.lblPossibleWords.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.lblPossibleWords.ForeColor = System.Drawing.Color.White;
            this.lblPossibleWords.Location = new System.Drawing.Point(252, 148);
            this.lblPossibleWords.Name = "lblPossibleWords";
            this.lblPossibleWords.Size = new System.Drawing.Size(234, 48);
            this.lblPossibleWords.TabIndex = 2;
            this.lblPossibleWords.Text = "Possible words:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exclude letters:";
            // 
            // lblInclude
            // 
            this.lblInclude.AutoSize = true;
            this.lblInclude.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.lblInclude.ForeColor = System.Drawing.Color.White;
            this.lblInclude.Location = new System.Drawing.Point(45, 199);
            this.lblInclude.Name = "lblInclude";
            this.lblInclude.Size = new System.Drawing.Size(71, 28);
            this.lblInclude.TabIndex = 3;
            this.lblInclude.Text = "a e i o u";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Include letters:";
            // 
            // txtBoxInclude
            // 
            this.txtBoxInclude.Location = new System.Drawing.Point(10, 176);
            this.txtBoxInclude.Name = "txtBoxInclude";
            this.txtBoxInclude.Size = new System.Drawing.Size(149, 20);
            this.txtBoxInclude.TabIndex = 5;
            // 
            // lblExclude
            // 
            this.lblExclude.AutoSize = true;
            this.lblExclude.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.lblExclude.ForeColor = System.Drawing.Color.White;
            this.lblExclude.Location = new System.Drawing.Point(46, 327);
            this.lblExclude.Name = "lblExclude";
            this.lblExclude.Size = new System.Drawing.Size(71, 28);
            this.lblExclude.TabIndex = 3;
            this.lblExclude.Text = "a e i o u";
            // 
            // txtBoxExclude
            // 
            this.txtBoxExclude.Location = new System.Drawing.Point(10, 304);
            this.txtBoxExclude.Name = "txtBoxExclude";
            this.txtBoxExclude.Size = new System.Drawing.Size(149, 20);
            this.txtBoxExclude.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.Location = new System.Drawing.Point(170, 216);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(83, 59);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(503, 434);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtBoxExclude);
            this.Controls.Add(this.txtBoxInclude);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExclude);
            this.Controls.Add(this.lblInclude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPossibleWords);
            this.Controls.Add(this.listBoxWords);
            this.Controls.Add(this.lblWordle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Wordle Solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWordle;
        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.Label lblPossibleWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInclude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxInclude;
        private System.Windows.Forms.Label lblExclude;
        private System.Windows.Forms.TextBox txtBoxExclude;
        private System.Windows.Forms.Button btnCheck;
    }
}

