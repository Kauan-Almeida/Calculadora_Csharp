namespace Aplicação_condicional
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
            grbAritmetica = new GroupBox();
            rdbDividir = new RadioButton();
            rdbMultiplicar = new RadioButton();
            rdbSubtrair = new RadioButton();
            rdbSomar = new RadioButton();
            lblX = new Label();
            lblY = new Label();
            lblTotal = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            txtTotal = new TextBox();
            btnLimpar = new Button();
            btnCalcular = new Button();
            btnFechar = new Button();
            grbAritmetica.SuspendLayout();
            SuspendLayout();
            // 
            // grbAritmetica
            // 
            grbAritmetica.Controls.Add(rdbDividir);
            grbAritmetica.Controls.Add(rdbMultiplicar);
            grbAritmetica.Controls.Add(rdbSubtrair);
            grbAritmetica.Controls.Add(rdbSomar);
            grbAritmetica.Location = new Point(40, 114);
            grbAritmetica.Name = "grbAritmetica";
            grbAritmetica.Size = new Size(200, 121);
            grbAritmetica.TabIndex = 1;
            grbAritmetica.TabStop = false;
            grbAritmetica.Text = "Operações";
            // 
            // rdbDividir
            // 
            rdbDividir.AutoSize = true;
            rdbDividir.Location = new Point(6, 94);
            rdbDividir.Name = "rdbDividir";
            rdbDividir.Size = new Size(59, 19);
            rdbDividir.TabIndex = 3;
            rdbDividir.TabStop = true;
            rdbDividir.Text = "Dividir";
            rdbDividir.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicar
            // 
            rdbMultiplicar.AutoSize = true;
            rdbMultiplicar.Location = new Point(6, 69);
            rdbMultiplicar.Name = "rdbMultiplicar";
            rdbMultiplicar.Size = new Size(82, 19);
            rdbMultiplicar.TabIndex = 2;
            rdbMultiplicar.TabStop = true;
            rdbMultiplicar.Text = "Multiplicar";
            rdbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdbSubtrair
            // 
            rdbSubtrair.AutoSize = true;
            rdbSubtrair.Location = new Point(6, 44);
            rdbSubtrair.Name = "rdbSubtrair";
            rdbSubtrair.Size = new Size(66, 19);
            rdbSubtrair.TabIndex = 1;
            rdbSubtrair.TabStop = true;
            rdbSubtrair.Text = "Subtrair";
            rdbSubtrair.UseVisualStyleBackColor = true;
            rdbSubtrair.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdbSomar
            // 
            rdbSomar.AutoSize = true;
            rdbSomar.Location = new Point(6, 22);
            rdbSomar.Name = "rdbSomar";
            rdbSomar.Size = new Size(59, 19);
            rdbSomar.TabIndex = 0;
            rdbSomar.TabStop = true;
            rdbSomar.Text = "Somar";
            rdbSomar.UseVisualStyleBackColor = true;
            rdbSomar.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(40, 27);
            lblX.Name = "lblX";
            lblX.Size = new Size(14, 15);
            lblX.TabIndex = 2;
            lblX.Text = "X";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(40, 56);
            lblY.Name = "lblY";
            lblY.Size = new Size(14, 15);
            lblY.TabIndex = 3;
            lblY.Text = "Y";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(40, 85);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // txtX
            // 
            txtX.Location = new Point(98, 27);
            txtX.Name = "txtX";
            txtX.Size = new Size(142, 23);
            txtX.TabIndex = 5;
            txtX.TextChanged += textBox1_TextChanged;
            // 
            // txtY
            // 
            txtY.Location = new Point(98, 56);
            txtY.Name = "txtY";
            txtY.Size = new Size(142, 23);
            txtY.TabIndex = 6;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(98, 85);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(142, 23);
            txtTotal.TabIndex = 7;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(40, 241);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(165, 241);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(98, 270);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 341);
            Controls.Add(btnFechar);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpar);
            Controls.Add(txtTotal);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(lblTotal);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Controls.Add(grbAritmetica);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            grbAritmetica.ResumeLayout(false);
            grbAritmetica.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblX;
        private Label lblY;
        private Label lblTotal;
        private GroupBox grbAritmetica;
        private RadioButton rdbDividir;
        private RadioButton rdbMultiplicar;
        private RadioButton rdbSubtrair;
        private RadioButton rdbSomar;
        private TextBox txtX;
        private TextBox txtY;
        private TextBox txtTotal;
        private Button btnLimpar;
        private Button btnCalcular;
        private Button btnFechar;
    }
}