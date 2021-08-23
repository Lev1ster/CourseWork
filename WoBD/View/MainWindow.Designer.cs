
namespace View
{
    partial class MainWindow
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.regPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nickRegLabel = new System.Windows.Forms.Label();
            this.passRegBox = new System.Windows.Forms.TextBox();
            this.passRegLabel = new System.Windows.Forms.Label();
            this.logRegBox = new System.Windows.Forms.TextBox();
            this.logRegLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.signinButton = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.raceRegLabel = new System.Windows.Forms.Label();
            this.classRegLabel = new System.Windows.Forms.Label();
            this.raceRegComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.regRegButton = new System.Windows.Forms.Button();
            this.backRegButton = new System.Windows.Forms.Button();
            this.exitRegButton = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.regPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.Controls.Add(this.regPanel);
            this.loginPanel.Controls.Add(this.exitButton);
            this.loginPanel.Controls.Add(this.regButton);
            this.loginPanel.Controls.Add(this.signinButton);
            this.loginPanel.Controls.Add(this.passBox);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.loginBox);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1082, 571);
            this.loginPanel.TabIndex = 0;
            // 
            // regPanel
            // 
            this.regPanel.Controls.Add(this.exitRegButton);
            this.regPanel.Controls.Add(this.backRegButton);
            this.regPanel.Controls.Add(this.regRegButton);
            this.regPanel.Controls.Add(this.comboBox1);
            this.regPanel.Controls.Add(this.raceRegComboBox);
            this.regPanel.Controls.Add(this.classRegLabel);
            this.regPanel.Controls.Add(this.raceRegLabel);
            this.regPanel.Controls.Add(this.textBox1);
            this.regPanel.Controls.Add(this.nickRegLabel);
            this.regPanel.Controls.Add(this.passRegBox);
            this.regPanel.Controls.Add(this.passRegLabel);
            this.regPanel.Controls.Add(this.logRegBox);
            this.regPanel.Controls.Add(this.logRegLabel);
            this.regPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regPanel.Location = new System.Drawing.Point(0, 0);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(1082, 571);
            this.regPanel.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(286, 160);
            this.textBox1.MaxLength = 12;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 30);
            this.textBox1.TabIndex = 9;
            // 
            // nickRegLabel
            // 
            this.nickRegLabel.AutoSize = true;
            this.nickRegLabel.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nickRegLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.nickRegLabel.Location = new System.Drawing.Point(277, 113);
            this.nickRegLabel.Name = "nickRegLabel";
            this.nickRegLabel.Size = new System.Drawing.Size(205, 54);
            this.nickRegLabel.TabIndex = 8;
            this.nickRegLabel.Text = "Nickname";
            // 
            // passRegBox
            // 
            this.passRegBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passRegBox.Location = new System.Drawing.Point(286, 241);
            this.passRegBox.MaxLength = 16;
            this.passRegBox.Name = "passRegBox";
            this.passRegBox.Size = new System.Drawing.Size(249, 30);
            this.passRegBox.TabIndex = 7;
            this.passRegBox.UseSystemPasswordChar = true;
            // 
            // passRegLabel
            // 
            this.passRegLabel.AutoSize = true;
            this.passRegLabel.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passRegLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passRegLabel.Location = new System.Drawing.Point(277, 194);
            this.passRegLabel.Name = "passRegLabel";
            this.passRegLabel.Size = new System.Drawing.Size(192, 54);
            this.passRegLabel.TabIndex = 6;
            this.passRegLabel.Text = "Password";
            // 
            // logRegBox
            // 
            this.logRegBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logRegBox.Location = new System.Drawing.Point(286, 80);
            this.logRegBox.MaxLength = 12;
            this.logRegBox.Name = "logRegBox";
            this.logRegBox.Size = new System.Drawing.Size(249, 30);
            this.logRegBox.TabIndex = 5;
            // 
            // logRegLabel
            // 
            this.logRegLabel.AutoSize = true;
            this.logRegLabel.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logRegLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.logRegLabel.Location = new System.Drawing.Point(277, 33);
            this.logRegLabel.Name = "logRegLabel";
            this.logRegLabel.Size = new System.Drawing.Size(124, 54);
            this.logRegLabel.TabIndex = 4;
            this.logRegLabel.Text = "Login";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(821, 505);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(249, 54);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.regButton.FlatAppearance.BorderSize = 0;
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regButton.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.ForeColor = System.Drawing.SystemColors.Control;
            this.regButton.Location = new System.Drawing.Point(12, 505);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(249, 54);
            this.regButton.TabIndex = 6;
            this.regButton.Text = "Registration";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // signinButton
            // 
            this.signinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.signinButton.FlatAppearance.BorderSize = 0;
            this.signinButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signinButton.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signinButton.ForeColor = System.Drawing.SystemColors.Control;
            this.signinButton.Location = new System.Drawing.Point(422, 299);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(249, 54);
            this.signinButton.TabIndex = 4;
            this.signinButton.Text = "SignIn";
            this.signinButton.UseVisualStyleBackColor = false;
            this.signinButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBox.Location = new System.Drawing.Point(422, 251);
            this.passBox.MaxLength = 16;
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(249, 30);
            this.passBox.TabIndex = 3;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordLabel.Location = new System.Drawing.Point(413, 204);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(192, 54);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(422, 159);
            this.loginBox.MaxLength = 12;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(249, 30);
            this.loginBox.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loginLabel.Location = new System.Drawing.Point(413, 112);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(124, 54);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // raceRegLabel
            // 
            this.raceRegLabel.AutoSize = true;
            this.raceRegLabel.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.raceRegLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.raceRegLabel.Location = new System.Drawing.Point(595, 33);
            this.raceRegLabel.Name = "raceRegLabel";
            this.raceRegLabel.Size = new System.Drawing.Size(109, 54);
            this.raceRegLabel.TabIndex = 10;
            this.raceRegLabel.Text = "Race";
            // 
            // classRegLabel
            // 
            this.classRegLabel.AutoSize = true;
            this.classRegLabel.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classRegLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.classRegLabel.Location = new System.Drawing.Point(595, 112);
            this.classRegLabel.Name = "classRegLabel";
            this.classRegLabel.Size = new System.Drawing.Size(112, 54);
            this.classRegLabel.TabIndex = 11;
            this.classRegLabel.Text = "Class";
            // 
            // raceRegComboBox
            // 
            this.raceRegComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.raceRegComboBox.FormattingEnabled = true;
            this.raceRegComboBox.Location = new System.Drawing.Point(604, 80);
            this.raceRegComboBox.Name = "raceRegComboBox";
            this.raceRegComboBox.Size = new System.Drawing.Size(249, 33);
            this.raceRegComboBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(604, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 33);
            this.comboBox1.TabIndex = 13;
            // 
            // regRegButton
            // 
            this.regRegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.regRegButton.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regRegButton.ForeColor = System.Drawing.SystemColors.Control;
            this.regRegButton.Location = new System.Drawing.Point(416, 299);
            this.regRegButton.Name = "regRegButton";
            this.regRegButton.Size = new System.Drawing.Size(282, 54);
            this.regRegButton.TabIndex = 14;
            this.regRegButton.Text = "Registration";
            this.regRegButton.UseVisualStyleBackColor = false;
            this.regRegButton.Click += new System.EventHandler(this.regRegButton_Click);
            // 
            // backRegButton
            // 
            this.backRegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.backRegButton.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backRegButton.ForeColor = System.Drawing.SystemColors.Control;
            this.backRegButton.Location = new System.Drawing.Point(744, 505);
            this.backRegButton.Name = "backRegButton";
            this.backRegButton.Size = new System.Drawing.Size(160, 54);
            this.backRegButton.TabIndex = 15;
            this.backRegButton.Text = "Back";
            this.backRegButton.UseVisualStyleBackColor = false;
            this.backRegButton.Click += new System.EventHandler(this.backRegButton_Click);
            // 
            // exitRegButton
            // 
            this.exitRegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.exitRegButton.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitRegButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitRegButton.Location = new System.Drawing.Point(910, 505);
            this.exitRegButton.Name = "exitRegButton";
            this.exitRegButton.Size = new System.Drawing.Size(160, 54);
            this.exitRegButton.TabIndex = 16;
            this.exitRegButton.Text = "Exit";
            this.exitRegButton.UseVisualStyleBackColor = false;
            this.exitRegButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::View.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1082, 571);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WoBD";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nickRegLabel;
        private System.Windows.Forms.TextBox passRegBox;
        private System.Windows.Forms.Label passRegLabel;
        private System.Windows.Forms.TextBox logRegBox;
        private System.Windows.Forms.Label logRegLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox raceRegComboBox;
        private System.Windows.Forms.Label classRegLabel;
        private System.Windows.Forms.Label raceRegLabel;
        private System.Windows.Forms.Button exitRegButton;
        private System.Windows.Forms.Button backRegButton;
        private System.Windows.Forms.Button regRegButton;
    }
}

