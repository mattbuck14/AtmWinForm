namespace AtmApp.Forms
{
    partial class RegisterForm
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
            this.sumbitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.pinNumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sumbitBtn
            // 
            this.sumbitBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.sumbitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sumbitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sumbitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.sumbitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.sumbitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumbitBtn.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sumbitBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.sumbitBtn.Location = new System.Drawing.Point(139, 339);
            this.sumbitBtn.Name = "sumbitBtn";
            this.sumbitBtn.Size = new System.Drawing.Size(119, 55);
            this.sumbitBtn.TabIndex = 8;
            this.sumbitBtn.Text = "Submit";
            this.sumbitBtn.UseVisualStyleBackColor = false;
            this.sumbitBtn.Click += new System.EventHandler(this.sumbitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(124, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Register User";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bdayDatePicker);
            this.panel1.Controls.Add(this.pinNumTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 233);
            this.panel1.TabIndex = 7;
            // 
            // bdayDatePicker
            // 
            this.bdayDatePicker.Location = new System.Drawing.Point(141, 127);
            this.bdayDatePicker.Name = "bdayDatePicker";
            this.bdayDatePicker.Size = new System.Drawing.Size(199, 23);
            this.bdayDatePicker.TabIndex = 9;
            // 
            // pinNumTextBox
            // 
            this.pinNumTextBox.Location = new System.Drawing.Point(141, 176);
            this.pinNumTextBox.Name = "pinNumTextBox";
            this.pinNumTextBox.Size = new System.Drawing.Size(199, 23);
            this.pinNumTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(26, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(89, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pin";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(141, 77);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(199, 23);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(141, 25);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(199, 23);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(415, 421);
            this.Controls.Add(this.sumbitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sumbitBtn;
        private Label label1;
        private Panel panel1;
        private TextBox lastNameTextBox;
        private Label label3;
        private TextBox firstNameTextBox;
        private Label label2;
        private TextBox pinNumTextBox;
        private Label label4;
        private Label label5;
        private DateTimePicker bdayDatePicker;
    }
}