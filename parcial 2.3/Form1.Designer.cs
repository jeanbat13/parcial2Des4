namespace parcial_2._3
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            mtxtPass = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 31);
            label1.Name = "label1";
            label1.Size = new Size(371, 35);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a Banquisimo! Inicie sesion";
            // 
            // txtName
            // 
            txtName.Location = new Point(66, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 96);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre de usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 179);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(182, 291);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(126, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // mtxtPass
            // 
            mtxtPass.Location = new Point(73, 212);
            mtxtPass.Name = "mtxtPass";
            mtxtPass.PasswordChar = '*';
            mtxtPass.Size = new Size(257, 23);
            mtxtPass.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 382);
            Controls.Add(mtxtPass);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private MaskedTextBox mtxtPass;
    }
}
