namespace TecIn
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
            txtDecaimientoI = new TextBox();
            txtDistancia = new TextBox();
            txtTasaD = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lblRes = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDecaimientoI
            // 
            txtDecaimientoI.Location = new Point(35, 52);
            txtDecaimientoI.Margin = new Padding(3, 2, 3, 2);
            txtDecaimientoI.Name = "txtDecaimientoI";
            txtDecaimientoI.Size = new Size(144, 23);
            txtDecaimientoI.TabIndex = 0;
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(35, 197);
            txtDistancia.Margin = new Padding(3, 2, 3, 2);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(144, 23);
            txtDistancia.TabIndex = 1;
            // 
            // txtTasaD
            // 
            txtTasaD.Location = new Point(35, 122);
            txtTasaD.Margin = new Padding(3, 2, 3, 2);
            txtTasaD.Name = "txtTasaD";
            txtTasaD.Size = new Size(144, 23);
            txtTasaD.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(35, 253);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(144, 22);
            button1.TabIndex = 3;
            button1.Text = "Resultado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 180);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Distancia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 104);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 5;
            label2.Text = "Tasa de Decaimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 34);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 6;
            label3.Text = "Decaimiento Inicial";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(lblRes);
            panel1.Location = new Point(318, 34);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 240);
            panel1.TabIndex = 7;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.BackColor = Color.FromArgb(224, 224, 224);
            lblRes.Location = new Point(18, 17);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(62, 15);
            lblRes.TabIndex = 0;
            lblRes.Text = "Resultado:";
            lblRes.Click += lblRes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(695, 328);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtTasaD);
            Controls.Add(txtDistancia);
            Controls.Add(txtDecaimientoI);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Decaimiento Exponencial";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDecaimientoI;
        private TextBox txtDistancia;
        private TextBox txtTasaD;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label lblRes;
    }
}
