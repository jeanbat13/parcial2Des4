namespace parcial_2._3
{
    partial class Menu
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
            lblname = new Label();
            lblCuenta = new Label();
            lblSaldo = new Label();
            label1 = new Label();
            btnTransaccion = new Button();
            btnHistorial = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Cascadia Code", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblname.Location = new Point(90, 19);
            lblname.Name = "lblname";
            lblname.Size = new Size(182, 32);
            lblname.TabIndex = 0;
            lblname.Text = "Bienvenido! ";
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Segoe UI", 18F);
            lblCuenta.Location = new Point(104, 74);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(78, 32);
            lblCuenta.TabIndex = 1;
            lblCuenta.Text = "label1";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 18F);
            lblSaldo.Location = new Point(338, 74);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(78, 32);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 123);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 3;
            label1.Text = "Que operacion desea hacer?";
            // 
            // btnTransaccion
            // 
            btnTransaccion.BackColor = SystemColors.ActiveCaption;
            btnTransaccion.Location = new Point(181, 189);
            btnTransaccion.Name = "btnTransaccion";
            btnTransaccion.Size = new Size(162, 48);
            btnTransaccion.TabIndex = 4;
            btnTransaccion.Text = "Realizar Transaccion";
            btnTransaccion.UseVisualStyleBackColor = false;
            btnTransaccion.Click += btnTransaccion_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = SystemColors.ActiveCaption;
            btnHistorial.Location = new Point(181, 254);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(162, 54);
            btnHistorial.TabIndex = 5;
            btnHistorial.Text = "Ver Historial de transacciones";
            btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = SystemColors.ActiveCaption;
            btnCerrarSesion.Location = new Point(181, 324);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(162, 54);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnHistorial);
            Controls.Add(btnTransaccion);
            Controls.Add(label1);
            Controls.Add(lblSaldo);
            Controls.Add(lblCuenta);
            Controls.Add(lblname);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private Label lblCuenta;
        private Label lblSaldo;
        private Label label1;
        private Button btnTransaccion;
        private Button btnHistorial;
        private Button btnCerrarSesion;
    }
}