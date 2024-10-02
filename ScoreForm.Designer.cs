namespace Quiz_personal
{
    partial class ScoreForm
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
            lblScore = new Label();
            btnRestart = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.Font = new Font("Segoe UI", 40F);
            lblScore.ForeColor = SystemColors.ControlLight;
            lblScore.Location = new Point(95, 140);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(850, 113);
            lblScore.TabIndex = 0;
            lblScore.Text = "label1";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.FromArgb(234, 53, 70);
            btnRestart.BackgroundImageLayout = ImageLayout.None;
            btnRestart.FlatAppearance.BorderSize = 0;
            btnRestart.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRestart.ForeColor = SystemColors.ControlLight;
            btnRestart.Location = new Point(214, 466);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(120, 50);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(234, 53, 70);
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ControlLight;
            btnClose.Location = new Point(671, 466);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 50);
            btnClose.TabIndex = 1;
            btnClose.Text = "Exit";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 46, 155);
            ClientSize = new Size(1029, 699);
            Controls.Add(btnClose);
            Controls.Add(btnRestart);
            Controls.Add(lblScore);
            Name = "ScoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScoreForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblScore;
        private Button btnRestart;
        private Button btnClose;
    }
}