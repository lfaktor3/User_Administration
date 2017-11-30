namespace WindowsFormsUsers
{
    partial class Form4
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
            this.btnAddNewuser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.inptNewFirstName = new System.Windows.Forms.TextBox();
            this.inptNewLastName = new System.Windows.Forms.TextBox();
            this.inptNewUserName = new System.Windows.Forms.TextBox();
            this.inptNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddNewuser
            // 
            this.btnAddNewuser.Location = new System.Drawing.Point(32, 167);
            this.btnAddNewuser.Name = "btnAddNewuser";
            this.btnAddNewuser.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewuser.TabIndex = 1;
            this.btnAddNewuser.Text = "Dodaj";
            this.btnAddNewuser.UseVisualStyleBackColor = true;
            this.btnAddNewuser.Click += new System.EventHandler(this.btnAddNewuser_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(172, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // inptNewFirstName
            // 
            this.inptNewFirstName.Location = new System.Drawing.Point(109, 63);
            this.inptNewFirstName.Name = "inptNewFirstName";
            this.inptNewFirstName.Size = new System.Drawing.Size(138, 20);
            this.inptNewFirstName.TabIndex = 4;
            // 
            // inptNewLastName
            // 
            this.inptNewLastName.Location = new System.Drawing.Point(109, 89);
            this.inptNewLastName.Name = "inptNewLastName";
            this.inptNewLastName.Size = new System.Drawing.Size(138, 20);
            this.inptNewLastName.TabIndex = 5;
            // 
            // inptNewUserName
            // 
            this.inptNewUserName.Location = new System.Drawing.Point(109, 141);
            this.inptNewUserName.Name = "inptNewUserName";
            this.inptNewUserName.Size = new System.Drawing.Size(138, 20);
            this.inptNewUserName.TabIndex = 6;
            // 
            // inptNewPassword
            // 
            this.inptNewPassword.Location = new System.Drawing.Point(109, 115);
            this.inptNewPassword.Name = "inptNewPassword";
            this.inptNewPassword.Size = new System.Drawing.Size(138, 20);
            this.inptNewPassword.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lozinka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Korisničko ime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(60, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dodavanje novog korisnika";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inptNewPassword);
            this.Controls.Add(this.inptNewUserName);
            this.Controls.Add(this.inptNewLastName);
            this.Controls.Add(this.inptNewFirstName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewuser);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewuser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox inptNewFirstName;
        private System.Windows.Forms.TextBox inptNewLastName;
        private System.Windows.Forms.TextBox inptNewUserName;
        private System.Windows.Forms.TextBox inptNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}