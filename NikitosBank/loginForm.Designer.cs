namespace NikitosBank
{
    partial class LoginForm
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
            this.entryAccountButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.registerAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entryAccountButton
            // 
            this.entryAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryAccountButton.Location = new System.Drawing.Point(152, 155);
            this.entryAccountButton.Name = "entryAccountButton";
            this.entryAccountButton.Size = new System.Drawing.Size(128, 40);
            this.entryAccountButton.TabIndex = 0;
            this.entryAccountButton.Text = "Войти";
            this.entryAccountButton.UseVisualStyleBackColor = true;
            this.entryAccountButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(61, 44);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(85, 27);
            this.login.TabIndex = 2;
            this.login.Text = "Логин:";
            // 
            // loginText
            // 
            this.loginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginText.Location = new System.Drawing.Point(152, 44);
            this.loginText.Multiline = true;
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(174, 31);
            this.loginText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пароль:";
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordText.Location = new System.Drawing.Point(152, 88);
            this.passwordText.Multiline = true;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(174, 31);
            this.passwordText.TabIndex = 5;
            // 
            // registerAccountButton
            // 
            this.registerAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerAccountButton.Location = new System.Drawing.Point(298, 167);
            this.registerAccountButton.Name = "registerAccountButton";
            this.registerAccountButton.Size = new System.Drawing.Size(117, 28);
            this.registerAccountButton.TabIndex = 6;
            this.registerAccountButton.Text = "Регистрация";
            this.registerAccountButton.UseVisualStyleBackColor = true;
            this.registerAccountButton.Click += new System.EventHandler(this.registerAccountButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 207);
            this.Controls.Add(this.registerAccountButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.login);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.entryAccountButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Быстрые займы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entryAccountButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button registerAccountButton;
    }
}