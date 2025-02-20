namespace WinFormsApp1
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
            lista1 = new ListBox();
            szukaj = new Button();
            text1 = new TextBox();
            text2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dodawanie = new Button();
            SuspendLayout();
            // 
            // lista1
            // 
            lista1.FormattingEnabled = true;
            lista1.ItemHeight = 15;
            lista1.Location = new Point(25, 220);
            lista1.Name = "lista1";
            lista1.Size = new Size(744, 169);
            lista1.TabIndex = 0;
            // 
            // szukaj
            // 
            szukaj.Location = new Point(25, 167);
            szukaj.Name = "szukaj";
            szukaj.Size = new Size(107, 23);
            szukaj.TabIndex = 2;
            szukaj.Text = "Szukaj";
            szukaj.UseVisualStyleBackColor = true;
            szukaj.Click += szukaj_Click;
            // 
            // text1
            // 
            text1.Location = new Point(97, 39);
            text1.Name = "text1";
            text1.Size = new Size(320, 23);
            text1.TabIndex = 3;
            // 
            // text2
            // 
            text2.Location = new Point(97, 107);
            text2.Name = "text2";
            text2.Size = new Size(320, 23);
            text2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 110);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 6;
            label2.Text = "Tytuł";
            // 
            // dodawanie
            // 
            dodawanie.Location = new Point(567, 42);
            dodawanie.Name = "dodawanie";
            dodawanie.Size = new Size(133, 48);
            dodawanie.TabIndex = 7;
            dodawanie.Text = "Dodaj książkę";
            dodawanie.UseVisualStyleBackColor = true;
            dodawanie.Click += dodawanie_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dodawanie);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text2);
            Controls.Add(text1);
            Controls.Add(szukaj);
            Controls.Add(lista1);
            Name = "Form1";
            Text = "Baza danych książek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lista1;
        private Button szukaj;
        private TextBox text1;
        private TextBox text2;
        private Label label1;
        private Label label2;
        private Button dodawanie;
    }
}
