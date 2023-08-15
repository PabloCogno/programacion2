namespace Ejercicio2
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
            bMostrar = new Button();
            bAgregar = new Button();
            label1 = new Label();
            tBnumero = new TextBox();
            SuspendLayout();
            // 
            // bMostrar
            // 
            bMostrar.Location = new Point(285, 132);
            bMostrar.Name = "bMostrar";
            bMostrar.Size = new Size(94, 29);
            bMostrar.TabIndex = 0;
            bMostrar.Text = "Mostrar";
            bMostrar.UseVisualStyleBackColor = true;
            bMostrar.Click += bMostrar_Click;
            // 
            // bAgregar
            // 
            bAgregar.Location = new Point(285, 63);
            bAgregar.Name = "bAgregar";
            bAgregar.Size = new Size(94, 29);
            bAgregar.TabIndex = 1;
            bAgregar.Text = "Agregar";
            bAgregar.UseVisualStyleBackColor = true;
            bAgregar.Click += bAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Numero";
            // 
            // tBnumero
            // 
            tBnumero.Location = new Point(101, 60);
            tBnumero.Name = "tBnumero";
            tBnumero.Size = new Size(125, 27);
            tBnumero.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 212);
            Controls.Add(tBnumero);
            Controls.Add(label1);
            Controls.Add(bAgregar);
            Controls.Add(bMostrar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bMostrar;
        private Button bAgregar;
        private Label label1;
        private TextBox tBnumero;
    }
}