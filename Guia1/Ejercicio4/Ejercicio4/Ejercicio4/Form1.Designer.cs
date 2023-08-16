namespace Ejercicio4
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
            label2 = new Label();
            tBx = new TextBox();
            tBy = new TextBox();
            bResultados = new Button();
            lBresultados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 48);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Eje x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 109);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Eje y";
            // 
            // tBx
            // 
            tBx.Location = new Point(230, 48);
            tBx.Name = "tBx";
            tBx.Size = new Size(125, 27);
            tBx.TabIndex = 2;
            // 
            // tBy
            // 
            tBy.Location = new Point(230, 109);
            tBy.Name = "tBy";
            tBy.Size = new Size(125, 27);
            tBy.TabIndex = 3;
            // 
            // bResultados
            // 
            bResultados.Location = new Point(391, 145);
            bResultados.Name = "bResultados";
            bResultados.Size = new Size(94, 29);
            bResultados.TabIndex = 4;
            bResultados.Text = "Resultados";
            bResultados.UseVisualStyleBackColor = true;
            bResultados.Click += bResultados_Click;
            // 
            // lBresultados
            // 
            lBresultados.FormattingEnabled = true;
            lBresultados.ItemHeight = 20;
            lBresultados.Location = new Point(30, 192);
            lBresultados.Name = "lBresultados";
            lBresultados.Size = new Size(455, 144);
            lBresultados.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 356);
            Controls.Add(lBresultados);
            Controls.Add(bResultados);
            Controls.Add(tBy);
            Controls.Add(tBx);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tBx;
        private TextBox tBy;
        private Button bResultados;
        private ListBox lBresultados;
    }
}