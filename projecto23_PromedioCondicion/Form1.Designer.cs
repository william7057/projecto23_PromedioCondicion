
namespace projecto23_PromedioCondicion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nota01 = new System.Windows.Forms.TextBox();
            this.txt_Nota02 = new System.Windows.Forms.TextBox();
            this.txt_Nota03 = new System.Windows.Forms.TextBox();
            this.txt_Promedio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Location = new System.Drawing.Point(221, 272);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(106, 36);
            this.btn_Ejecutar.TabIndex = 0;
            this.btn_Ejecutar.Text = "Ejecutar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota 01 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 02 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota 03 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Promedio";
            // 
            // txt_Nota01
            // 
            this.txt_Nota01.Location = new System.Drawing.Point(133, 72);
            this.txt_Nota01.Multiline = true;
            this.txt_Nota01.Name = "txt_Nota01";
            this.txt_Nota01.Size = new System.Drawing.Size(100, 32);
            this.txt_Nota01.TabIndex = 5;
            // 
            // txt_Nota02
            // 
            this.txt_Nota02.Location = new System.Drawing.Point(133, 112);
            this.txt_Nota02.Multiline = true;
            this.txt_Nota02.Name = "txt_Nota02";
            this.txt_Nota02.Size = new System.Drawing.Size(100, 32);
            this.txt_Nota02.TabIndex = 6;
            // 
            // txt_Nota03
            // 
            this.txt_Nota03.Location = new System.Drawing.Point(133, 162);
            this.txt_Nota03.Multiline = true;
            this.txt_Nota03.Name = "txt_Nota03";
            this.txt_Nota03.Size = new System.Drawing.Size(100, 28);
            this.txt_Nota03.TabIndex = 7;
            // 
            // txt_Promedio
            // 
            this.txt_Promedio.Location = new System.Drawing.Point(133, 208);
            this.txt_Promedio.Multiline = true;
            this.txt_Promedio.Name = "txt_Promedio";
            this.txt_Promedio.Size = new System.Drawing.Size(139, 36);
            this.txt_Promedio.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "PROMEDIO DE NOTAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 320);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Promedio);
            this.Controls.Add(this.txt_Nota03);
            this.Controls.Add(this.txt_Nota02);
            this.Controls.Add(this.txt_Nota01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ejecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nota01;
        private System.Windows.Forms.TextBox txt_Nota02;
        private System.Windows.Forms.TextBox txt_Nota03;
        private System.Windows.Forms.TextBox txt_Promedio;
        private System.Windows.Forms.Label label5;
    }
}

