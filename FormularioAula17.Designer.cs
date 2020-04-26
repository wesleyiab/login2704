namespace TesteAula17
{
    partial class FormularioAula17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAula17));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDividendo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDivisor = new System.Windows.Forms.TextBox();
            this.textBoxResto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRealizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dividendo:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxDividendo
            // 
            this.textBoxDividendo.Location = new System.Drawing.Point(170, 61);
            this.textBoxDividendo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDividendo.Name = "textBoxDividendo";
            this.textBoxDividendo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDividendo.TabIndex = 1;
            this.textBoxDividendo.Text = "Digite um numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Divisor:";
            // 
            // textBoxDivisor
            // 
            this.textBoxDivisor.Location = new System.Drawing.Point(469, 64);
            this.textBoxDivisor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxDivisor.Name = "textBoxDivisor";
            this.textBoxDivisor.Size = new System.Drawing.Size(100, 20);
            this.textBoxDivisor.TabIndex = 3;
            this.textBoxDivisor.Text = "Digite um numero";
            // 
            // textBoxResto
            // 
            this.textBoxResto.AccessibleDescription = "";
            this.textBoxResto.Location = new System.Drawing.Point(469, 166);
            this.textBoxResto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxResto.Name = "textBoxResto";
            this.textBoxResto.Size = new System.Drawing.Size(100, 20);
            this.textBoxResto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resto:";
            // 
            // buttonRealizar
            // 
            this.buttonRealizar.Location = new System.Drawing.Point(170, 163);
            this.buttonRealizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRealizar.Name = "buttonRealizar";
            this.buttonRealizar.Size = new System.Drawing.Size(74, 23);
            this.buttonRealizar.TabIndex = 6;
            this.buttonRealizar.Text = "Realizar";
            this.buttonRealizar.UseVisualStyleBackColor = true;
            this.buttonRealizar.Click += new System.EventHandler(this.buttonRealizar_Click);
            // 
            // FormularioAula17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.buttonRealizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResto);
            this.Controls.Add(this.textBoxDivisor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDividendo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FormularioAula17";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDividendo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDivisor;
        private System.Windows.Forms.TextBox textBoxResto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRealizar;
    }
}

