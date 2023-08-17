namespace Ejercicio6
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
            tBnumero = new TextBox();
            label2 = new Label();
            cBorden = new ComboBox();
            lBlistado = new ListBox();
            bIngresar = new Button();
            bAplicar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 35);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingresar numero";
            // 
            // tBnumero
            // 
            tBnumero.Location = new Point(159, 28);
            tBnumero.Name = "tBnumero";
            tBnumero.Size = new Size(125, 27);
            tBnumero.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 146);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Ordenar";
            // 
            // cBorden
            // 
            cBorden.FormattingEnabled = true;
            cBorden.Items.AddRange(new object[] { "Ascendente", "Descendente" });
            cBorden.Location = new Point(133, 146);
            cBorden.Name = "cBorden";
            cBorden.Size = new Size(151, 28);
            cBorden.TabIndex = 3;
            // 
            // lBlistado
            // 
            lBlistado.FormattingEnabled = true;
            lBlistado.ItemHeight = 20;
            lBlistado.Location = new Point(34, 206);
            lBlistado.Name = "lBlistado";
            lBlistado.Size = new Size(611, 204);
            lBlistado.TabIndex = 4;
            // 
            // bIngresar
            // 
            bIngresar.Location = new Point(323, 31);
            bIngresar.Name = "bIngresar";
            bIngresar.Size = new Size(94, 29);
            bIngresar.TabIndex = 5;
            bIngresar.Text = "Ingresar";
            bIngresar.UseVisualStyleBackColor = true;
            bIngresar.Click += bIngresar_Click;
            // 
            // bAplicar
            // 
            bAplicar.Location = new Point(336, 146);
            bAplicar.Name = "bAplicar";
            bAplicar.Size = new Size(94, 29);
            bAplicar.TabIndex = 6;
            bAplicar.Text = "Aplicar";
            bAplicar.UseVisualStyleBackColor = true;
            bAplicar.Click += bAplicar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bAplicar);
            Controls.Add(bIngresar);
            Controls.Add(lBlistado);
            Controls.Add(cBorden);
            Controls.Add(label2);
            Controls.Add(tBnumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tBnumero;
        private Label label2;
        private ComboBox cBorden;
        private ListBox lBlistado;
        private Button bIngresar;
        private Button bAplicar;
    }
}