namespace Sem2EstructuraCProb10Ventana
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
            lblcuenta = new Label();
            label1 = new Label();
            txtnum = new TextBox();
            btncalcular = new Button();
            btnlimpiar = new Button();
            SuspendLayout();
            // 
            // lblcuenta
            // 
            lblcuenta.AutoSize = true;
            lblcuenta.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblcuenta.Location = new Point(12, 77);
            lblcuenta.Name = "lblcuenta";
            lblcuenta.Size = new Size(112, 21);
            lblcuenta.TabIndex = 4;
            lblcuenta.Text = "La cuenta es: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 0;
            label1.Text = "Ingrese cuenta: ";
            // 
            // txtnum
            // 
            txtnum.Location = new Point(168, 26);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(122, 23);
            txtnum.TabIndex = 1;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(12, 191);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(93, 36);
            btncalcular.TabIndex = 2;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(168, 191);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(93, 36);
            btnlimpiar.TabIndex = 3;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 239);
            Controls.Add(lblcuenta);
            Controls.Add(btnlimpiar);
            Controls.Add(btncalcular);
            Controls.Add(txtnum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnum;
        private Button btncalcular;
        private Button btnlimpiar;
        private Label lblcuenta;
    }
}