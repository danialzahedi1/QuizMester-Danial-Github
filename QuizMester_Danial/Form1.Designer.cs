namespace QuizMester_Danial
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartLogin = new System.Windows.Forms.Button();
            this.btnStartRegister = new System.Windows.Forms.Button();
            this.tcQuiz = new System.Windows.Forms.TabControl();
            this.tpStart = new System.Windows.Forms.TabPage();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txbLoginPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbLoginUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tpRegister = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txbRegisterPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbRegisterUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tpQuiz = new System.Windows.Forms.TabPage();
            this.tpLeaderboard = new System.Windows.Forms.TabPage();
            this.tcQuiz.SuspendLayout();
            this.tpStart.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.tpRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "QuizMester";
            // 
            // btnStartLogin
            // 
            this.btnStartLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartLogin.Location = new System.Drawing.Point(287, 177);
            this.btnStartLogin.Name = "btnStartLogin";
            this.btnStartLogin.Size = new System.Drawing.Size(238, 72);
            this.btnStartLogin.TabIndex = 1;
            this.btnStartLogin.Text = "Log in";
            this.btnStartLogin.UseVisualStyleBackColor = true;
            this.btnStartLogin.Click += new System.EventHandler(this.btnStartLogin_Click);
            // 
            // btnStartRegister
            // 
            this.btnStartRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRegister.Location = new System.Drawing.Point(287, 287);
            this.btnStartRegister.Name = "btnStartRegister";
            this.btnStartRegister.Size = new System.Drawing.Size(238, 72);
            this.btnStartRegister.TabIndex = 2;
            this.btnStartRegister.Text = "Register";
            this.btnStartRegister.UseVisualStyleBackColor = true;
            this.btnStartRegister.Click += new System.EventHandler(this.btnStartRegister_Click);
            // 
            // tcQuiz
            // 
            this.tcQuiz.Controls.Add(this.tpStart);
            this.tcQuiz.Controls.Add(this.tpLogin);
            this.tcQuiz.Controls.Add(this.tpRegister);
            this.tcQuiz.Controls.Add(this.tpQuiz);
            this.tcQuiz.Controls.Add(this.tpLeaderboard);
            this.tcQuiz.Location = new System.Drawing.Point(12, 12);
            this.tcQuiz.Name = "tcQuiz";
            this.tcQuiz.SelectedIndex = 0;
            this.tcQuiz.Size = new System.Drawing.Size(858, 629);
            this.tcQuiz.TabIndex = 3;
            // 
            // tpStart
            // 
            this.tpStart.Controls.Add(this.label1);
            this.tpStart.Controls.Add(this.btnStartRegister);
            this.tpStart.Controls.Add(this.btnStartLogin);
            this.tpStart.Location = new System.Drawing.Point(4, 25);
            this.tpStart.Name = "tpStart";
            this.tpStart.Padding = new System.Windows.Forms.Padding(3);
            this.tpStart.Size = new System.Drawing.Size(850, 600);
            this.tpStart.TabIndex = 0;
            this.tpStart.Text = "Start";
            this.tpStart.UseVisualStyleBackColor = true;
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.label5);
            this.tpLogin.Controls.Add(this.txbLoginPassword);
            this.tpLogin.Controls.Add(this.label4);
            this.tpLogin.Controls.Add(this.txbLoginUsername);
            this.tpLogin.Controls.Add(this.label2);
            this.tpLogin.Controls.Add(this.btnLogin);
            this.tpLogin.Location = new System.Drawing.Point(4, 25);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(850, 600);
            this.tpLogin.TabIndex = 1;
            this.tpLogin.Text = "Login";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // txbLoginPassword
            // 
            this.txbLoginPassword.Location = new System.Drawing.Point(296, 342);
            this.txbLoginPassword.Name = "txbLoginPassword";
            this.txbLoginPassword.Size = new System.Drawing.Size(217, 22);
            this.txbLoginPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // txbLoginUsername
            // 
            this.txbLoginUsername.Location = new System.Drawing.Point(296, 251);
            this.txbLoginUsername.Name = "txbLoginUsername";
            this.txbLoginUsername.Size = new System.Drawing.Size(217, 22);
            this.txbLoginUsername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 91);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log in";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(287, 423);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(238, 72);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tpRegister
            // 
            this.tpRegister.Controls.Add(this.label6);
            this.tpRegister.Controls.Add(this.txbRegisterPassword);
            this.tpRegister.Controls.Add(this.label7);
            this.tpRegister.Controls.Add(this.txbRegisterUsername);
            this.tpRegister.Controls.Add(this.label8);
            this.tpRegister.Controls.Add(this.btnRegister);
            this.tpRegister.Location = new System.Drawing.Point(4, 25);
            this.tpRegister.Name = "tpRegister";
            this.tpRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegister.Size = new System.Drawing.Size(850, 600);
            this.tpRegister.TabIndex = 2;
            this.tpRegister.Text = "Register";
            this.tpRegister.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // txbRegisterPassword
            // 
            this.txbRegisterPassword.Location = new System.Drawing.Point(312, 368);
            this.txbRegisterPassword.Name = "txbRegisterPassword";
            this.txbRegisterPassword.Size = new System.Drawing.Size(217, 22);
            this.txbRegisterPassword.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Username";
            // 
            // txbRegisterUsername
            // 
            this.txbRegisterUsername.Location = new System.Drawing.Point(312, 277);
            this.txbRegisterUsername.Name = "txbRegisterUsername";
            this.txbRegisterUsername.Size = new System.Drawing.Size(217, 22);
            this.txbRegisterUsername.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 91);
            this.label8.TabIndex = 9;
            this.label8.Text = "Register";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(303, 449);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(238, 72);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tpQuiz
            // 
            this.tpQuiz.Location = new System.Drawing.Point(4, 25);
            this.tpQuiz.Name = "tpQuiz";
            this.tpQuiz.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuiz.Size = new System.Drawing.Size(850, 600);
            this.tpQuiz.TabIndex = 3;
            this.tpQuiz.Text = "Quiz";
            this.tpQuiz.UseVisualStyleBackColor = true;
            // 
            // tpLeaderboard
            // 
            this.tpLeaderboard.Location = new System.Drawing.Point(4, 25);
            this.tpLeaderboard.Name = "tpLeaderboard";
            this.tpLeaderboard.Padding = new System.Windows.Forms.Padding(3);
            this.tpLeaderboard.Size = new System.Drawing.Size(850, 600);
            this.tpLeaderboard.TabIndex = 4;
            this.tpLeaderboard.Text = "Leaderboard";
            this.tpLeaderboard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.tcQuiz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QuizMester";
            this.tcQuiz.ResumeLayout(false);
            this.tpStart.ResumeLayout(false);
            this.tpStart.PerformLayout();
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            this.tpRegister.ResumeLayout(false);
            this.tpRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartLogin;
        private System.Windows.Forms.Button btnStartRegister;
        private System.Windows.Forms.TabControl tcQuiz;
        private System.Windows.Forms.TabPage tpStart;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.TabPage tpRegister;
        private System.Windows.Forms.TabPage tpQuiz;
        private System.Windows.Forms.TabPage tpLeaderboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbLoginUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbLoginPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbRegisterPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbRegisterUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegister;
    }
}

