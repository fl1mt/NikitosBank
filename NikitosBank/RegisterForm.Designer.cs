namespace NikitosBank
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fullUserNameText = new System.Windows.Forms.TextBox();
            this.loginUserText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordUserText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(96, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "РЕГИСТРАЦИЯ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите ФИО через пробелы:";
            // 
            // fullUserNameText
            // 
            this.fullUserNameText.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullUserNameText.Location = new System.Drawing.Point(50, 144);
            this.fullUserNameText.Multiline = true;
            this.fullUserNameText.Name = "fullUserNameText";
            this.fullUserNameText.Size = new System.Drawing.Size(287, 27);
            this.fullUserNameText.TabIndex = 2;
            // 
            // loginUserText
            // 
            this.loginUserText.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginUserText.Location = new System.Drawing.Point(50, 226);
            this.loginUserText.Multiline = true;
            this.loginUserText.Name = "loginUserText";
            this.loginUserText.Size = new System.Drawing.Size(287, 27);
            this.loginUserText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите логин:";
            // 
            // passwordUserText
            // 
            this.passwordUserText.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordUserText.Location = new System.Drawing.Point(50, 307);
            this.passwordUserText.Multiline = true;
            this.passwordUserText.Name = "passwordUserText";
            this.passwordUserText.Size = new System.Drawing.Size(287, 27);
            this.passwordUserText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите пароль:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 506);
            this.Controls.Add(this.passwordUserText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginUserText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullUserNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullUserNameText;
        private System.Windows.Forms.TextBox loginUserText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordUserText;
        private System.Windows.Forms.Label label3;
    }
}