namespace WinFormsApp1
{
    partial class Form2
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dodaj = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 27);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 0;
            label3.Text = "Wprowadź książkę";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(373, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(182, 215);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(373, 23);
            textBox4.TabIndex = 4;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(40, 321);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(113, 38);
            dodaj.TabIndex = 5;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 72);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "Tytuł";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 118);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 7;
            label5.Text = "Autor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 166);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 8;
            label6.Text = "Rok Wydania";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 218);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 9;
            label7.Text = "Gatunek";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dodaj);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button dodaj;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}