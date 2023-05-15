namespace CountWords
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
            label2 = new Label();
            lblCharCount = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            tbWordChecking = new RichTextBox();
            panel4 = new Panel();
            btnAdd = new Button();
            label7 = new Label();
            tbTopic = new TextBox();
            panel5 = new Panel();
            btnDelete = new Button();
            dgvTrack = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            tbText = new TextBox();
            lblWordCount = new Label();
            label5 = new Label();
            lblEnteredWordCount = new Label();
            label4 = new Label();
            lblVowelsCount = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrack).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 46);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 1;
            label1.Text = "Word Count :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 192);
            label2.Name = "label2";
            label2.Size = new Size(248, 30);
            label2.TabIndex = 3;
            label2.Text = "Character Count :";
            // 
            // lblCharCount
            // 
            lblCharCount.AutoSize = true;
            lblCharCount.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCharCount.ForeColor = Color.Red;
            lblCharCount.Location = new Point(255, 192);
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(31, 33);
            lblCharCount.TabIndex = 4;
            lblCharCount.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(8, 9);
            label3.Name = "label3";
            label3.Size = new Size(323, 30);
            label3.TabIndex = 5;
            label3.Text = "Word Count Calculater";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 461);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(tbWordChecking);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 48);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(784, 110);
            panel3.TabIndex = 9;
            // 
            // tbWordChecking
            // 
            tbWordChecking.CausesValidation = false;
            tbWordChecking.Dock = DockStyle.Fill;
            tbWordChecking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbWordChecking.Location = new Point(10, 10);
            tbWordChecking.Name = "tbWordChecking";
            tbWordChecking.Size = new Size(764, 90);
            tbWordChecking.TabIndex = 0;
            tbWordChecking.Text = "";
            tbWordChecking.TextChanged += tbWordChecking_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(tbTopic);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(tbText);
            panel4.Controls.Add(lblWordCount);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lblEnteredWordCount);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblVowelsCount);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(lblCharCount);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 158);
            panel4.Name = "panel4";
            panel4.Size = new Size(784, 303);
            panel4.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(326, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 50);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, 11);
            label7.Name = "label7";
            label7.Size = new Size(102, 30);
            label7.TabIndex = 15;
            label7.Text = "Topic : ";
            // 
            // tbTopic
            // 
            tbTopic.Cursor = Cursors.Hand;
            tbTopic.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbTopic.Location = new Point(120, 15);
            tbTopic.MaximumSize = new Size(300, 30);
            tbTopic.Name = "tbTopic";
            tbTopic.Size = new Size(200, 27);
            tbTopic.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(dgvTrack);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(388, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20);
            panel5.Size = new Size(396, 303);
            panel5.TabIndex = 13;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(334, 20);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(50, 50);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "DEL";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvTrack
            // 
            dgvTrack.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrack.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvTrack.Dock = DockStyle.Left;
            dgvTrack.Location = new Point(20, 20);
            dgvTrack.Name = "dgvTrack";
            dgvTrack.RowHeadersWidth = 4;
            dgvTrack.RowTemplate.Height = 25;
            dgvTrack.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrack.Size = new Size(305, 263);
            dgvTrack.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Topic";
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Word Count";
            Column2.Name = "Column2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 260);
            label6.Name = "label6";
            label6.Size = new Size(88, 30);
            label6.TabIndex = 11;
            label6.Text = "word";
            // 
            // tbText
            // 
            tbText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbText.Location = new Point(104, 262);
            tbText.Name = "tbText";
            tbText.Size = new Size(133, 27);
            tbText.TabIndex = 10;
            tbText.TextChanged += tbText_TextChanged;
            // 
            // lblWordCount
            // 
            lblWordCount.AutoSize = true;
            lblWordCount.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWordCount.ForeColor = Color.Red;
            lblWordCount.Location = new Point(202, 46);
            lblWordCount.Name = "lblWordCount";
            lblWordCount.Size = new Size(31, 33);
            lblWordCount.TabIndex = 9;
            lblWordCount.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(245, 260);
            label5.Name = "label5";
            label5.Size = new Size(105, 30);
            label5.TabIndex = 7;
            label5.Text = "Count :";
            // 
            // lblEnteredWordCount
            // 
            lblEnteredWordCount.AutoSize = true;
            lblEnteredWordCount.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnteredWordCount.ForeColor = Color.Red;
            lblEnteredWordCount.Location = new Point(345, 260);
            lblEnteredWordCount.Name = "lblEnteredWordCount";
            lblEnteredWordCount.Size = new Size(31, 33);
            lblEnteredWordCount.TabIndex = 8;
            lblEnteredWordCount.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 225);
            label4.Name = "label4";
            label4.Size = new Size(206, 30);
            label4.TabIndex = 5;
            label4.Text = "Vowels Count :";
            // 
            // lblVowelsCount
            // 
            lblVowelsCount.AutoSize = true;
            lblVowelsCount.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVowelsCount.ForeColor = Color.Red;
            lblVowelsCount.Location = new Point(211, 224);
            lblVowelsCount.Name = "lblVowelsCount";
            lblVowelsCount.Size = new Size(31, 33);
            lblVowelsCount.TabIndex = 6;
            lblVowelsCount.Text = "0";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 48);
            panel2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Word Counter";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrack).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label lblCharCount;
        private Label label3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private RichTextBox tbWordChecking;
        private Label label4;
        private Label lblVowelsCount;
        private Label label5;
        private Label lblEnteredWordCount;
        private Label lblWordCount;
        private Label label6;
        private TextBox tbText;
        private Panel panel5;
        private DataGridView dgvTrack;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnAdd;
        private Label label7;
        private TextBox tbTopic;
        private Button btnDelete;
    }
}