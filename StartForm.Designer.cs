namespace Quiz_personal
{
    partial class StartForm
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
            fileSystemWatcher1 = new FileSystemWatcher();
            label1 = new Label();
            btnFiveQuestions = new Button();
            btnTenQuestions = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(253, 153);
            label1.Name = "label1";
            label1.Size = new Size(525, 73);
            label1.TabIndex = 0;
            label1.Text = "Brain Quest - Game";
            // 
            // btnFiveQuestions
            // 
            btnFiveQuestions.BackColor = Color.FromArgb(234, 53, 70);
            btnFiveQuestions.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnFiveQuestions.ForeColor = SystemColors.ControlLight;
            btnFiveQuestions.Location = new Point(306, 489);
            btnFiveQuestions.Name = "btnFiveQuestions";
            btnFiveQuestions.Size = new Size(120, 50);
            btnFiveQuestions.TabIndex = 1;
            btnFiveQuestions.Text = "5";
            btnFiveQuestions.UseVisualStyleBackColor = false;
            btnFiveQuestions.Click += btnFiveQuestions_Click;
            // 
            // btnTenQuestions
            // 
            btnTenQuestions.BackColor = Color.FromArgb(234, 53, 70);
            btnTenQuestions.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnTenQuestions.ForeColor = SystemColors.ControlLight;
            btnTenQuestions.Location = new Point(586, 489);
            btnTenQuestions.Name = "btnTenQuestions";
            btnTenQuestions.Size = new Size(120, 50);
            btnTenQuestions.TabIndex = 1;
            btnTenQuestions.Text = "10";
            btnTenQuestions.UseVisualStyleBackColor = false;
            btnTenQuestions.Click += btnTenQuestions_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(253, 359);
            label2.Name = "label2";
            label2.Size = new Size(525, 73);
            label2.TabIndex = 0;
            label2.Text = "We’re excited to get started! This is your personal quiz. How many questions would you like to answer?";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 46, 155);
            ClientSize = new Size(1029, 699);
            Controls.Add(btnTenQuestions);
            Controls.Add(btnFiveQuestions);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizForm";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Button btnTenQuestions;
        private Button btnFiveQuestions;
        private Label label1;
        private Label label2;
    }
}