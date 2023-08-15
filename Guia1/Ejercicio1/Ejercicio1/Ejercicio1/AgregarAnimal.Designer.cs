namespace Ejercicio1
{
    partial class AgregarAnimal
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
            bAceptar = new Button();
            bCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tBnombre = new TextBox();
            tBedad = new TextBox();
            tBpeso = new TextBox();
            cBtipo = new ComboBox();
            SuspendLayout();
            // 
            // bAceptar
            // 
            bAceptar.DialogResult = DialogResult.OK;
            bAceptar.Location = new Point(293, 332);
            bAceptar.Name = "bAceptar";
            bAceptar.Size = new Size(94, 29);
            bAceptar.TabIndex = 0;
            bAceptar.Text = "Aceptar";
            bAceptar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            bCancelar.DialogResult = DialogResult.Cancel;
            bCancelar.Location = new Point(472, 332);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(94, 29);
            bCancelar.TabIndex = 1;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 57);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 110);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 3;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 177);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 243);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 5;
            label4.Text = "Peso";
            // 
            // tBnombre
            // 
            tBnombre.Location = new Point(415, 50);
            tBnombre.Name = "tBnombre";
            tBnombre.Size = new Size(125, 27);
            tBnombre.TabIndex = 6;
            // 
            // tBedad
            // 
            tBedad.Location = new Point(415, 170);
            tBedad.Name = "tBedad";
            tBedad.Size = new Size(125, 27);
            tBedad.TabIndex = 8;
            // 
            // tBpeso
            // 
            tBpeso.Location = new Point(415, 236);
            tBpeso.Name = "tBpeso";
            tBpeso.Size = new Size(125, 27);
            tBpeso.TabIndex = 9;
            // 
            // cBtipo
            // 
            cBtipo.FormattingEnabled = true;
            cBtipo.Items.AddRange(new object[] { "Perro", "Gato", "Conejo", "Hamster", "Otro" });
            cBtipo.Location = new Point(415, 102);
            cBtipo.Name = "cBtipo";
            cBtipo.Size = new Size(151, 28);
            cBtipo.TabIndex = 10;
            // 
            // AgregarAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cBtipo);
            Controls.Add(tBpeso);
            Controls.Add(tBedad);
            Controls.Add(tBnombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bCancelar);
            Controls.Add(bAceptar);
            Name = "AgregarAnimal";
            Text = "AgregarAnimal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bAceptar;
        private Button bCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox tBnombre;
        public ComboBox cBtipo;
        public TextBox tBedad;
        public TextBox tBpeso;
    }
}