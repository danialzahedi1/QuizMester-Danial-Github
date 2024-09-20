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
            this.label9 = new System.Windows.Forms.Label();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.tbnBack1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbLoginPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbLoginUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tpRegister = new System.Windows.Forms.TabPage();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRegisterPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbRegisterUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tpQuiz = new System.Windows.Forms.TabPage();
            this.pgbTimeLeftTotal = new System.Windows.Forms.ProgressBar();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.pgbTimeLeftQuestion = new System.Windows.Forms.ProgressBar();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lblSelector = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tpLeaderboard = new System.Windows.Forms.TabPage();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.rtbLeaderboard = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tcQuiz.SuspendLayout();
            this.tpStart.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.tpRegister.SuspendLayout();
            this.tpQuiz.SuspendLayout();
            this.tpLeaderboard.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "QuizMester";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartLogin
            // 
            this.btnStartLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartLogin.Location = new System.Drawing.Point(287, 316);
            this.btnStartLogin.Name = "btnStartLogin";
            this.btnStartLogin.Size = new System.Drawing.Size(270, 89);
            this.btnStartLogin.TabIndex = 1;
            this.btnStartLogin.Text = "Log in";
            this.btnStartLogin.UseVisualStyleBackColor = true;
            this.btnStartLogin.Click += new System.EventHandler(this.btnStartLogin_Click);
            // 
            // btnStartRegister
            // 
            this.btnStartRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRegister.Location = new System.Drawing.Point(287, 432);
            this.btnStartRegister.Name = "btnStartRegister";
            this.btnStartRegister.Size = new System.Drawing.Size(270, 94);
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
            this.tcQuiz.Controls.Add(this.tabPage1);
            this.tcQuiz.Location = new System.Drawing.Point(12, 12);
            this.tcQuiz.Name = "tcQuiz";
            this.tcQuiz.SelectedIndex = 0;
            this.tcQuiz.Size = new System.Drawing.Size(858, 668);
            this.tcQuiz.TabIndex = 3;
            // 
            // tpStart
            // 
            this.tpStart.BackgroundImage = global::QuizMester_Danial.Properties.Resources.darkmode;
            this.tpStart.Controls.Add(this.label9);
            this.tpStart.Controls.Add(this.label1);
            this.tpStart.Controls.Add(this.btnStartRegister);
            this.tpStart.Controls.Add(this.btnStartLogin);
            this.tpStart.Location = new System.Drawing.Point(4, 25);
            this.tpStart.Name = "tpStart";
            this.tpStart.Padding = new System.Windows.Forms.Padding(3);
            this.tpStart.Size = new System.Drawing.Size(850, 639);
            this.tpStart.TabIndex = 0;
            this.tpStart.Text = "Start";
            this.tpStart.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(279, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 46);
            this.label9.TabIndex = 3;
            this.label9.Text = "Danial Zahedi";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpLogin
            // 
            this.tpLogin.BackgroundImage = global::QuizMester_Danial.Properties.Resources.darkmode;
            this.tpLogin.Controls.Add(this.tbnBack1);
            this.tpLogin.Controls.Add(this.label5);
            this.tpLogin.Controls.Add(this.txbLoginPassword);
            this.tpLogin.Controls.Add(this.label4);
            this.tpLogin.Controls.Add(this.txbLoginUsername);
            this.tpLogin.Controls.Add(this.label2);
            this.tpLogin.Controls.Add(this.btnLogin);
            this.tpLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLogin.Location = new System.Drawing.Point(4, 25);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(850, 639);
            this.tpLogin.TabIndex = 1;
            this.tpLogin.Text = "Login";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // tbnBack1
            // 
            this.tbnBack1.BackColor = System.Drawing.Color.White;
            this.tbnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnBack1.ForeColor = System.Drawing.Color.Black;
            this.tbnBack1.Location = new System.Drawing.Point(297, 489);
            this.tbnBack1.Name = "tbnBack1";
            this.tbnBack1.Size = new System.Drawing.Size(238, 72);
            this.tbnBack1.TabIndex = 20;
            this.tbnBack1.Text = "Back";
            this.tbnBack1.UseVisualStyleBackColor = false;
            this.tbnBack1.Click += new System.EventHandler(this.Back);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(208, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // txbLoginPassword
            // 
            this.txbLoginPassword.BackColor = System.Drawing.Color.Gray;
            this.txbLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoginPassword.ForeColor = System.Drawing.Color.White;
            this.txbLoginPassword.Location = new System.Drawing.Point(214, 308);
            this.txbLoginPassword.Name = "txbLoginPassword";
            this.txbLoginPassword.PasswordChar = '*';
            this.txbLoginPassword.Size = new System.Drawing.Size(415, 56);
            this.txbLoginPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(208, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // txbLoginUsername
            // 
            this.txbLoginUsername.BackColor = System.Drawing.Color.Gray;
            this.txbLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoginUsername.ForeColor = System.Drawing.Color.White;
            this.txbLoginUsername.Location = new System.Drawing.Point(214, 202);
            this.txbLoginUsername.Name = "txbLoginUsername";
            this.txbLoginUsername.Size = new System.Drawing.Size(415, 56);
            this.txbLoginUsername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(275, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 91);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log in";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(297, 411);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(238, 72);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tpRegister
            // 
            this.tpRegister.BackgroundImage = global::QuizMester_Danial.Properties.Resources.darkmode;
            this.tpRegister.Controls.Add(this.btnBack2);
            this.tpRegister.Controls.Add(this.label3);
            this.tpRegister.Controls.Add(this.txbRegisterPassword);
            this.tpRegister.Controls.Add(this.label10);
            this.tpRegister.Controls.Add(this.txbRegisterUsername);
            this.tpRegister.Controls.Add(this.label8);
            this.tpRegister.Controls.Add(this.btnRegister);
            this.tpRegister.Location = new System.Drawing.Point(4, 25);
            this.tpRegister.Name = "tpRegister";
            this.tpRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegister.Size = new System.Drawing.Size(850, 639);
            this.tpRegister.TabIndex = 2;
            this.tpRegister.Text = "Register";
            this.tpRegister.UseVisualStyleBackColor = true;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.White;
            this.btnBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.ForeColor = System.Drawing.Color.Black;
            this.btnBack2.Location = new System.Drawing.Point(297, 489);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(238, 72);
            this.btnBack2.TabIndex = 19;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.Back);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // txbRegisterPassword
            // 
            this.txbRegisterPassword.BackColor = System.Drawing.Color.Gray;
            this.txbRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRegisterPassword.ForeColor = System.Drawing.Color.White;
            this.txbRegisterPassword.Location = new System.Drawing.Point(214, 308);
            this.txbRegisterPassword.Name = "txbRegisterPassword";
            this.txbRegisterPassword.PasswordChar = '*';
            this.txbRegisterPassword.Size = new System.Drawing.Size(415, 56);
            this.txbRegisterPassword.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(208, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Username";
            // 
            // txbRegisterUsername
            // 
            this.txbRegisterUsername.BackColor = System.Drawing.Color.Gray;
            this.txbRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRegisterUsername.ForeColor = System.Drawing.Color.White;
            this.txbRegisterUsername.Location = new System.Drawing.Point(214, 202);
            this.txbRegisterUsername.Name = "txbRegisterUsername";
            this.txbRegisterUsername.Size = new System.Drawing.Size(415, 56);
            this.txbRegisterUsername.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(250, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 91);
            this.label8.TabIndex = 9;
            this.label8.Text = "Register";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(297, 411);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(238, 72);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tpQuiz
            // 
            this.tpQuiz.BackgroundImage = global::QuizMester_Danial.Properties.Resources.darkmode;
            this.tpQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpQuiz.Controls.Add(this.pgbTimeLeftTotal);
            this.tpQuiz.Controls.Add(this.lblQuestionNumber);
            this.tpQuiz.Controls.Add(this.pgbTimeLeftQuestion);
            this.tpQuiz.Controls.Add(this.btn1);
            this.tpQuiz.Controls.Add(this.btn3);
            this.tpQuiz.Controls.Add(this.btn4);
            this.tpQuiz.Controls.Add(this.btn2);
            this.tpQuiz.Controls.Add(this.lblSelector);
            this.tpQuiz.Controls.Add(this.lblQuestion);
            this.tpQuiz.Controls.Add(this.lblUsername);
            this.tpQuiz.Location = new System.Drawing.Point(4, 25);
            this.tpQuiz.Name = "tpQuiz";
            this.tpQuiz.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuiz.Size = new System.Drawing.Size(850, 639);
            this.tpQuiz.TabIndex = 3;
            this.tpQuiz.Text = "Quiz";
            this.tpQuiz.UseVisualStyleBackColor = true;
            // 
            // pgbTimeLeftTotal
            // 
            this.pgbTimeLeftTotal.Location = new System.Drawing.Point(62, 593);
            this.pgbTimeLeftTotal.Name = "pgbTimeLeftTotal";
            this.pgbTimeLeftTotal.Size = new System.Drawing.Size(726, 23);
            this.pgbTimeLeftTotal.TabIndex = 19;
            this.pgbTimeLeftTotal.Value = 100;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.ForeColor = System.Drawing.Color.White;
            this.lblQuestionNumber.Location = new System.Drawing.Point(649, 5);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(90, 20);
            this.lblQuestionNumber.TabIndex = 18;
            this.lblQuestionNumber.Text = "Question:";
            // 
            // pgbTimeLeftQuestion
            // 
            this.pgbTimeLeftQuestion.Location = new System.Drawing.Point(63, 552);
            this.pgbTimeLeftQuestion.Name = "pgbTimeLeftQuestion";
            this.pgbTimeLeftQuestion.Size = new System.Drawing.Size(726, 23);
            this.pgbTimeLeftQuestion.TabIndex = 17;
            this.pgbTimeLeftQuestion.Value = 100;
            // 
            // btn1
            // 
            this.btn1.AllowDrop = true;
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn1.FlatAppearance.BorderSize = 10;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Gadugi", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(63, 323);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(360, 100);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "Yes";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseEnter += new System.EventHandler(this.BtnStart_MouseEnter);
            this.btn1.MouseLeave += new System.EventHandler(this.BtnStart_MouseLeave);
            // 
            // btn3
            // 
            this.btn3.AllowDrop = true;
            this.btn3.BackColor = System.Drawing.Color.Silver;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn3.FlatAppearance.BorderSize = 10;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Gadugi", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(63, 429);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(360, 100);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "Leaderboard";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.MouseEnter += new System.EventHandler(this.BtnStart_MouseEnter);
            this.btn3.MouseLeave += new System.EventHandler(this.BtnStart_MouseLeave);
            // 
            // btn4
            // 
            this.btn4.AllowDrop = true;
            this.btn4.BackColor = System.Drawing.Color.Silver;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn4.FlatAppearance.BorderSize = 10;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Gadugi", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(429, 429);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(360, 100);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "Logout";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn4.MouseEnter += new System.EventHandler(this.BtnStart_MouseEnter);
            this.btn4.MouseLeave += new System.EventHandler(this.BtnStart_MouseLeave);
            // 
            // btn2
            // 
            this.btn2.AllowDrop = true;
            this.btn2.BackColor = System.Drawing.Color.Silver;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn2.FlatAppearance.BorderSize = 10;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Gadugi", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(429, 323);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(360, 100);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "No";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.MouseEnter += new System.EventHandler(this.BtnStart_MouseEnter);
            this.btn2.MouseLeave += new System.EventHandler(this.BtnStart_MouseLeave);
            // 
            // lblSelector
            // 
            this.lblSelector.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelector.ForeColor = System.Drawing.Color.White;
            this.lblSelector.Location = new System.Drawing.Point(63, 225);
            this.lblSelector.Name = "lblSelector";
            this.lblSelector.Size = new System.Drawing.Size(726, 95);
            this.lblSelector.TabIndex = 11;
            this.lblSelector.Text = "Ready?";
            this.lblSelector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AllowDrop = true;
            this.lblQuestion.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblQuestion.Font = new System.Drawing.Font("Gadugi", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(29, 38);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(800, 206);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "QuizMester!";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(3, 3);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(205, 22);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Logged in as: Username";
            // 
            // tpLeaderboard
            // 
            this.tpLeaderboard.BackgroundImage = global::QuizMester_Danial.Properties.Resources.darkmode;
            this.tpLeaderboard.Controls.Add(this.label12);
            this.tpLeaderboard.Controls.Add(this.btnBack3);
            this.tpLeaderboard.Controls.Add(this.rtbLeaderboard);
            this.tpLeaderboard.Controls.Add(this.label6);
            this.tpLeaderboard.Location = new System.Drawing.Point(4, 25);
            this.tpLeaderboard.Name = "tpLeaderboard";
            this.tpLeaderboard.Padding = new System.Windows.Forms.Padding(3);
            this.tpLeaderboard.Size = new System.Drawing.Size(850, 639);
            this.tpLeaderboard.TabIndex = 4;
            this.tpLeaderboard.Text = "Leaderboard";
            this.tpLeaderboard.UseVisualStyleBackColor = true;
            // 
            // btnBack3
            // 
            this.btnBack3.BackColor = System.Drawing.Color.White;
            this.btnBack3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack3.ForeColor = System.Drawing.Color.Black;
            this.btnBack3.Location = new System.Drawing.Point(309, 516);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(238, 72);
            this.btnBack3.TabIndex = 20;
            this.btnBack3.Text = "Back";
            this.btnBack3.UseVisualStyleBackColor = false;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // rtbLeaderboard
            // 
            this.rtbLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLeaderboard.ForeColor = System.Drawing.Color.White;
            this.rtbLeaderboard.Location = new System.Drawing.Point(210, 214);
            this.rtbLeaderboard.Name = "rtbLeaderboard";
            this.rtbLeaderboard.Size = new System.Drawing.Size(428, 285);
            this.rtbLeaderboard.TabIndex = 13;
            this.rtbLeaderboard.Text = resources.GetString("rtbLeaderboard.Text");
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Gadugi", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(726, 134);
            this.label6.TabIndex = 12;
            this.label6.Text = "LeaderBoard";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::QuizMester_Danial.Properties.Resources.darkmode;
            this.tabPage1.Controls.Add(this.btnLeaderboard);
            this.tabPage1.Controls.Add(this.btnPlayAgain);
            this.tabPage1.Controls.Add(this.lblYourScore);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 639);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Game Over";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.BackColor = System.Drawing.Color.White;
            this.btnLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboard.ForeColor = System.Drawing.Color.Black;
            this.btnLeaderboard.Location = new System.Drawing.Point(306, 476);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(238, 72);
            this.btnLeaderboard.TabIndex = 22;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.White;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.Black;
            this.btnPlayAgain.Location = new System.Drawing.Point(306, 398);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(238, 72);
            this.btnPlayAgain.TabIndex = 21;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblYourScore
            // 
            this.lblYourScore.Font = new System.Drawing.Font("Gadugi", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourScore.ForeColor = System.Drawing.Color.White;
            this.lblYourScore.Location = new System.Drawing.Point(233, 258);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(402, 70);
            this.lblYourScore.TabIndex = 15;
            this.lblYourScore.Text = "9999";
            this.lblYourScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gadugi", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(296, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(277, 56);
            this.label11.TabIndex = 14;
            this.label11.Text = "Your Score:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(188, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(483, 95);
            this.label7.TabIndex = 13;
            this.label7.Text = "Game Over!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(215, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(358, 52);
            this.label12.TabIndex = 21;
            this.label12.Text = "Your high score:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 683);
            this.Controls.Add(this.tcQuiz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QuizMester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcQuiz.ResumeLayout(false);
            this.tpStart.ResumeLayout(false);
            this.tpStart.PerformLayout();
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            this.tpRegister.ResumeLayout(false);
            this.tpRegister.PerformLayout();
            this.tpQuiz.ResumeLayout(false);
            this.tpQuiz.PerformLayout();
            this.tpLeaderboard.ResumeLayout(false);
            this.tpLeaderboard.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSelector;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbRegisterPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbRegisterUsername;
        private System.Windows.Forms.Button tbnBack1;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.RichTextBox rtbLeaderboard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.ProgressBar pgbTimeLeftQuestion;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.ProgressBar pgbTimeLeftTotal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Label label12;
    }
}

