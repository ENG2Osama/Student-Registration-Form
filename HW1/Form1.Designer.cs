namespace HW1
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
            this.txtSign = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthate = new System.Windows.Forms.DateTimePicker();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.lblSelectColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblgender = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdosingle = new System.Windows.Forms.RadioButton();
            this.rdoMarried = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.grpmarital = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSign
            // 
            this.txtSign.AutoSize = true;
            this.txtSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSign.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSign.Location = new System.Drawing.Point(418, 15);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(92, 32);
            this.txtSign.TabIndex = 0;
            this.txtSign.Tag = "";
            this.txtSign.Text = " Sign In";
            this.txtSign.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = true;
            this.txtName.Location = new System.Drawing.Point(163, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(262, 32);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(25, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(25, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(20, 89);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(95, 23);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name";
            this.lblUserName.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(20, 174);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBirthDate);
            this.groupBox1.Controls.Add(this.dtpBirthate);
            this.groupBox1.Controls.Add(this.btnPickColor);
            this.groupBox1.Controls.Add(this.lblSelectColor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 391);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(25, 254);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(91, 25);
            this.lblBirthDate.TabIndex = 13;
            this.lblBirthDate.Text = "BirthDate";
            this.lblBirthDate.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // dtpBirthate
            // 
            this.dtpBirthate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthate.Location = new System.Drawing.Point(162, 248);
            this.dtpBirthate.Name = "dtpBirthate";
            this.dtpBirthate.Size = new System.Drawing.Size(262, 32);
            this.dtpBirthate.TabIndex = 12;
            // 
            // btnPickColor
            // 
            this.btnPickColor.Location = new System.Drawing.Point(163, 206);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(262, 32);
            this.btnPickColor.TabIndex = 11;
            this.btnPickColor.Text = "Choose Color";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // lblSelectColor
            // 
            this.lblSelectColor.AutoSize = true;
            this.lblSelectColor.Location = new System.Drawing.Point(431, 211);
            this.lblSelectColor.Name = "lblSelectColor";
            this.lblSelectColor.Size = new System.Drawing.Size(92, 25);
            this.lblSelectColor.TabIndex = 10;
            this.lblSelectColor.Text = "No Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Favorite Color:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 32);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(163, 164);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(262, 32);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(163, 81);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(262, 32);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.ItemHeight = 20;
            this.cmbCountry.Items.AddRange(new object[] {
            "Yemen",
            "egypt",
            "palestine",
            "Syria",
            "Omen",
            "Qater"});
            this.cmbCountry.Location = new System.Drawing.Point(589, 91);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(358, 104);
            this.cmbCountry.TabIndex = 8;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(589, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Select Nationality";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(607, 252);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(63, 24);
            this.rdoMale.TabIndex = 10;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(605, 293);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(78, 24);
            this.rdoFemale.TabIndex = 11;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblgender.Location = new System.Drawing.Point(0, 23);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(136, 23);
            this.lblgender.TabIndex = 12;
            this.lblgender.Text = "Choosen gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(790, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Marital Status";
            // 
            // rdosingle
            // 
            this.rdosingle.AutoSize = true;
            this.rdosingle.Location = new System.Drawing.Point(808, 293);
            this.rdosingle.Name = "rdosingle";
            this.rdosingle.Size = new System.Drawing.Size(75, 24);
            this.rdosingle.TabIndex = 14;
            this.rdosingle.TabStop = true;
            this.rdosingle.Text = "Single ";
            this.rdosingle.UseVisualStyleBackColor = true;
            // 
            // rdoMarried
            // 
            this.rdoMarried.AutoSize = true;
            this.rdoMarried.Location = new System.Drawing.Point(808, 253);
            this.rdoMarried.Name = "rdoMarried";
            this.rdoMarried.Size = new System.Drawing.Size(82, 24);
            this.rdoMarried.TabIndex = 13;
            this.rdoMarried.TabStop = true;
            this.rdoMarried.Text = "Married";
            this.rdoMarried.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(787, 397);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(158, 35);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Register";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.lblgender);
            this.grpGender.Location = new System.Drawing.Point(589, 201);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(177, 141);
            this.grpGender.TabIndex = 21;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // grpmarital
            // 
            this.grpmarital.Location = new System.Drawing.Point(787, 201);
            this.grpmarital.Name = "grpmarital";
            this.grpmarital.Size = new System.Drawing.Size(160, 141);
            this.grpmarital.TabIndex = 22;
            this.grpmarital.TabStop = false;
            this.grpmarital.Text = "Marital";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(586, 398);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 33);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(958, 453);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdosingle);
            this.Controls.Add(this.rdoMarried);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.grpmarital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Student Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtSign;
        private TextBox txtName;
        private Label lblName;
        private Label lblEmail;
        private Label lblUserName;
        private Label lblPassword;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private ListBox cmbCountry;
        private Label label6;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private Label lblgender;
        private Label label8;
        private RadioButton rdosingle;
        private RadioButton rdoMarried;
        private Button btnSubmit;
        private Label label1;
        private GroupBox grpGender;
        private Label lblSelectColor;
        private Button btnPickColor;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthate;
        private GroupBox grpmarital;
        private Button btnReset;
    }
}