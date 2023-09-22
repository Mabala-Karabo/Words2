namespace Words2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtWords = new TextBox();
            txtWordsConcatenated = new TextBox();
            btnConcatenate = new Button();
            txtAddWords = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtWordlist1 = new ComboBox();
            txtWordList2 = new ComboBox();
            txtRemove1 = new RadioButton();
            txtRemove2 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter a word: ";
            // 
            // txtWords
            // 
            txtWords.Location = new Point(97, 37);
            txtWords.Name = "txtWords";
            txtWords.Size = new Size(533, 31);
            txtWords.TabIndex = 1;
            // 
            // txtWordsConcatenated
            // 
            txtWordsConcatenated.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtWordsConcatenated.Location = new Point(12, 389);
            txtWordsConcatenated.Name = "txtWordsConcatenated";
            txtWordsConcatenated.Size = new Size(733, 34);
            txtWordsConcatenated.TabIndex = 2;
            // 
            // btnConcatenate
            // 
            btnConcatenate.Location = new Point(242, 338);
            btnConcatenate.Name = "btnConcatenate";
            btnConcatenate.Size = new Size(211, 34);
            btnConcatenate.TabIndex = 3;
            btnConcatenate.Text = "Concatenate";
            btnConcatenate.UseVisualStyleBackColor = true;
            btnConcatenate.Click += btnConcatenate_Click;
            // 
            // txtAddWords
            // 
            txtAddWords.Location = new Point(290, 93);
            txtAddWords.Name = "txtAddWords";
            txtAddWords.Size = new Size(178, 34);
            txtAddWords.TabIndex = 4;
            txtAddWords.Text = "Add Word";
            txtAddWords.UseVisualStyleBackColor = true;
            txtAddWords.Click += txtAddWords_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 159);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 5;
            label2.Text = "OR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 203);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 6;
            label3.Text = "Select a word:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 212);
            label4.Name = "label4";
            label4.Size = new Size(176, 25);
            label4.TabIndex = 7;
            label4.Text = "Select Another Word";
            // 
            // txtWordlist1
            // 
            txtWordlist1.FormattingEnabled = true;
            txtWordlist1.Location = new Point(27, 231);
            txtWordlist1.Name = "txtWordlist1";
            txtWordlist1.Size = new Size(182, 33);
            txtWordlist1.TabIndex = 8;
            // 
            // txtWordList2
            // 
            txtWordList2.FormattingEnabled = true;
            txtWordList2.Location = new Point(529, 241);
            txtWordList2.Name = "txtWordList2";
            txtWordList2.Size = new Size(182, 33);
            txtWordList2.TabIndex = 9;
            // 
            // txtRemove1
            // 
            txtRemove1.AutoSize = true;
            txtRemove1.Location = new Point(27, 270);
            txtRemove1.Name = "txtRemove1";
            txtRemove1.Size = new Size(101, 29);
            txtRemove1.TabIndex = 10;
            txtRemove1.TabStop = true;
            txtRemove1.Text = "Remove";
            txtRemove1.UseVisualStyleBackColor = true;
            // 
            // txtRemove2
            // 
            txtRemove2.AutoSize = true;
            txtRemove2.Location = new Point(529, 280);
            txtRemove2.Name = "txtRemove2";
            txtRemove2.Size = new Size(101, 29);
            txtRemove2.TabIndex = 11;
            txtRemove2.TabStop = true;
            txtRemove2.Text = "Remove";
            txtRemove2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRemove2);
            Controls.Add(txtRemove1);
            Controls.Add(txtWordList2);
            Controls.Add(txtWordlist1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAddWords);
            Controls.Add(btnConcatenate);
            Controls.Add(txtWordsConcatenated);
            Controls.Add(txtWords);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWords;
        private TextBox txtWordsConcatenated;
        private Button btnConcatenate;
        private Button txtAddWords;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox txtWordlist1;
        private ComboBox txtWordList2;
        private RadioButton txtRemove1;
        private RadioButton txtRemove2;
    }
}