namespace Quiz_personal
{
    partial class QuestionForm
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
            lblQuestion = new Label();
            btnNext = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblQuestion.ForeColor = SystemColors.ControlLight;
            lblQuestion.Location = new Point(91, 115);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(850, 38);
            lblQuestion.TabIndex = 0;
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(234, 53, 70);
            btnNext.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btnNext.ForeColor = SystemColors.ControlLight;
            btnNext.Location = new Point(453, 587);
            btnNext.Margin = new Padding(4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(120, 50);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.None;
            radioButton1.Appearance = Appearance.Button;
            radioButton1.BackColor = Color.FromArgb(67, 188, 205);
            radioButton1.FlatAppearance.BorderColor = Color.White;
            radioButton1.FlatAppearance.BorderSize = 0;
            radioButton1.FlatAppearance.CheckedBackColor = Color.FromArgb(248, 102, 36);
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            radioButton1.ForeColor = SystemColors.ControlLightLight;
            radioButton1.Location = new Point(112, 329);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(350, 70);
            radioButton1.TabIndex = 3;
            radioButton1.Text = "radioButton1";
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.None;
            radioButton2.Appearance = Appearance.Button;
            radioButton2.BackColor = Color.FromArgb(67, 188, 205);
            radioButton2.FlatAppearance.BorderColor = Color.White;
            radioButton2.FlatAppearance.BorderSize = 0;
            radioButton2.FlatAppearance.CheckedBackColor = Color.FromArgb(248, 102, 36);
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            radioButton2.ForeColor = SystemColors.ControlLightLight;
            radioButton2.Location = new Point(564, 329);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(350, 70);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "radioButton1";
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.None;
            radioButton3.Appearance = Appearance.Button;
            radioButton3.BackColor = Color.FromArgb(67, 188, 205);
            radioButton3.FlatAppearance.BorderColor = Color.White;
            radioButton3.FlatAppearance.BorderSize = 0;
            radioButton3.FlatAppearance.CheckedBackColor = Color.FromArgb(248, 102, 36);
            radioButton3.FlatStyle = FlatStyle.Flat;
            radioButton3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            radioButton3.ForeColor = SystemColors.ControlLightLight;
            radioButton3.Location = new Point(112, 425);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(350, 70);
            radioButton3.TabIndex = 3;
            radioButton3.Text = "radioButton1";
            radioButton3.TextAlign = ContentAlignment.MiddleCenter;
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.Anchor = AnchorStyles.None;
            radioButton4.Appearance = Appearance.Button;
            radioButton4.BackColor = Color.FromArgb(67, 188, 205);
            radioButton4.Checked = true;
            radioButton4.FlatAppearance.BorderColor = Color.White;
            radioButton4.FlatAppearance.BorderSize = 0;
            radioButton4.FlatAppearance.CheckedBackColor = Color.FromArgb(248, 102, 36);
            radioButton4.FlatStyle = FlatStyle.Flat;
            radioButton4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            radioButton4.ForeColor = SystemColors.ControlLightLight;
            radioButton4.Location = new Point(564, 425);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(350, 70);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton1";
            radioButton4.TextAlign = ContentAlignment.MiddleCenter;
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 46, 155);
            ClientSize = new Size(1029, 699);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btnNext);
            Controls.Add(lblQuestion);
            Font = new Font("Microsoft Sans Serif", 11.25F);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ultra Quiz OOP ";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuestion;
        private Button btnNext;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}
