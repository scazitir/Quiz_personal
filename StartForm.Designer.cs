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
            label1.AutoSize = true;
            label1.Location = new Point(314, 82);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Brain Quest - Game";
            // 
            // btnFiveQuestions
            // 
            btnFiveQuestions.Location = new Point(110, 234);
            btnFiveQuestions.Name = "btnFiveQuestions";
            btnFiveQuestions.Size = new Size(75, 23);
            btnFiveQuestions.TabIndex = 1;
            btnFiveQuestions.Text = "5";
            btnFiveQuestions.UseVisualStyleBackColor = true;
            btnFiveQuestions.Click += btnFiveQuestions_Click;
            // 
            // btnTenQuestions
            // 
            btnTenQuestions.Location = new Point(605, 234);
            btnTenQuestions.Name = "btnTenQuestions";
            btnTenQuestions.Size = new Size(75, 23);
            btnTenQuestions.TabIndex = 1;
            btnTenQuestions.Text = "10";
            btnTenQuestions.UseVisualStyleBackColor = true;
            btnTenQuestions.Click += btnTenQuestions_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTenQuestions);
            Controls.Add(btnFiveQuestions);
            Controls.Add(label1);
            Name = "StartForm";
            Text = "QuizForm";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Button btnTenQuestions;
        private Button btnFiveQuestions;
        private Label label1;
    }
}