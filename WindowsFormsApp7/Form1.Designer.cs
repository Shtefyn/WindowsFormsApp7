namespace WindowsFormsApp7
{
    partial class Form1
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
            this.lbl_liczba = new System.Windows.Forms.Label();
            this.lbl_potega = new System.Windows.Forms.Label();
            this.lbl_wynik = new System.Windows.Forms.Label();
            this.txt_liczba = new System.Windows.Forms.TextBox();
            this.txt_potega = new System.Windows.Forms.TextBox();
            this.txt_wynik = new System.Windows.Forms.TextBox();
            this.btn_oblicz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_liczba
            // 
            this.lbl_liczba.AutoSize = true;
            this.lbl_liczba.Location = new System.Drawing.Point(32, 28);
            this.lbl_liczba.Name = "lbl_liczba";
            this.lbl_liczba.Size = new System.Drawing.Size(38, 13);
            this.lbl_liczba.TabIndex = 0;
            this.lbl_liczba.Text = "Liczba";
            
            // 
            // lbl_potega
            // 
            this.lbl_potega.AutoSize = true;
            this.lbl_potega.Location = new System.Drawing.Point(32, 61);
            this.lbl_potega.Name = "lbl_potega";
            this.lbl_potega.Size = new System.Drawing.Size(41, 13);
            this.lbl_potega.TabIndex = 1;
            this.lbl_potega.Text = "Potega";
            // 
            // lbl_wynik
            // 
            this.lbl_wynik.AutoSize = true;
            this.lbl_wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_wynik.Location = new System.Drawing.Point(32, 104);
            this.lbl_wynik.Name = "lbl_wynik";
            this.lbl_wynik.Size = new System.Drawing.Size(42, 13);
            this.lbl_wynik.TabIndex = 2;
            this.lbl_wynik.Text = "Wynik";
            // 
            // txt_liczba
            // 
            this.txt_liczba.Location = new System.Drawing.Point(94, 28);
            this.txt_liczba.Name = "txt_liczba";
            this.txt_liczba.Size = new System.Drawing.Size(100, 20);
            this.txt_liczba.TabIndex = 3;
            // 
            // txt_potega
            // 
            this.txt_potega.Location = new System.Drawing.Point(94, 61);
            this.txt_potega.Name = "txt_potega";
            this.txt_potega.Size = new System.Drawing.Size(100, 20);
            this.txt_potega.TabIndex = 4;
            // 
            // txt_wynik
            // 
            this.txt_wynik.Location = new System.Drawing.Point(94, 104);
            this.txt_wynik.Name = "txt_wynik";
            this.txt_wynik.Size = new System.Drawing.Size(100, 20);
            this.txt_wynik.TabIndex = 5;
            // 
            // btn_oblicz
            // 
            this.btn_oblicz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oblicz.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_oblicz.Location = new System.Drawing.Point(35, 151);
            this.btn_oblicz.Name = "btn_oblicz";
            this.btn_oblicz.Size = new System.Drawing.Size(159, 34);
            this.btn_oblicz.TabIndex = 6;
            this.btn_oblicz.Text = "Oblicz";
            this.btn_oblicz.UseVisualStyleBackColor = true;
            this.btn_oblicz.Click += new System.EventHandler(this.Btn_oblicz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 217);
            this.Controls.Add(this.btn_oblicz);
            this.Controls.Add(this.txt_wynik);
            this.Controls.Add(this.txt_potega);
            this.Controls.Add(this.txt_liczba);
            this.Controls.Add(this.lbl_wynik);
            this.Controls.Add(this.lbl_potega);
            this.Controls.Add(this.lbl_liczba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_liczba;
        private System.Windows.Forms.Label lbl_potega;
        private System.Windows.Forms.Label lbl_wynik;
        private System.Windows.Forms.TextBox txt_liczba;
        private System.Windows.Forms.TextBox txt_potega;
        private System.Windows.Forms.TextBox txt_wynik;
        private System.Windows.Forms.Button btn_oblicz;
    }
}

