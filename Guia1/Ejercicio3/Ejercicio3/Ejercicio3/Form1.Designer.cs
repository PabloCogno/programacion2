namespace Ejercicio3
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
            tBnumero = new TextBox();
            label1 = new Label();
            bAceptar = new Button();
            SuspendLayout();
            // 
            // tBnumero
            // 
            tBnumero.Location = new Point(133, 40);
            tBnumero.Name = "tBnumero";
            tBnumero.Size = new Size(125, 27);
            tBnumero.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 47);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Numero";
            // 
            // bAceptar
            // 
            bAceptar.Location = new Point(214, 123);
            bAceptar.Name = "bAceptar";
            bAceptar.Size = new Size(94, 29);
            bAceptar.TabIndex = 2;
            bAceptar.Text = "Aceptar";
            bAceptar.UseVisualStyleBackColor = true;
            bAceptar.Click += bAceptar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 188);
            Controls.Add(bAceptar);
            Controls.Add(label1);
            Controls.Add(tBnumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBnumero;
        private Label label1;
        private Button bAceptar;
    }
}