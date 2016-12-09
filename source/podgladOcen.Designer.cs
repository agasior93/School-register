namespace Dziennik
{
    partial class podgladOcen
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ocena = new System.Windows.Forms.Label();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nazwiskoBox = new System.Windows.Forms.TextBox();
            this.SprawdzBtn = new System.Windows.Forms.Button();
            this.imieBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nauczyciel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Waga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Przedmiot";
            // 
            // Ocena
            // 
            this.Ocena.AutoSize = true;
            this.Ocena.Location = new System.Drawing.Point(11, 118);
            this.Ocena.Name = "Ocena";
            this.Ocena.Size = new System.Drawing.Size(39, 13);
            this.Ocena.TabIndex = 19;
            this.Ocena.Text = "Ocena";
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(284, 134);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(52, 212);
            this.listBox6.TabIndex = 18;
            this.listBox6.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(237, 134);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(52, 212);
            this.listBox5.TabIndex = 17;
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(184, 134);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(19, 212);
            this.listBox4.TabIndex = 16;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(115, 134);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(63, 212);
            this.listBox3.TabIndex = 15;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(44, 134);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(65, 212);
            this.listBox2.TabIndex = 14;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(24, 212);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nazwiskoBox);
            this.groupBox1.Controls.Add(this.SprawdzBtn);
            this.groupBox1.Controls.Add(this.imieBox);
            this.groupBox1.Location = new System.Drawing.Point(59, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 87);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaj imie i nazwisko ucznia";
            // 
            // nazwiskoBox
            // 
            this.nazwiskoBox.Location = new System.Drawing.Point(16, 55);
            this.nazwiskoBox.Name = "nazwiskoBox";
            this.nazwiskoBox.Size = new System.Drawing.Size(158, 20);
            this.nazwiskoBox.TabIndex = 2;
            this.nazwiskoBox.TextChanged += new System.EventHandler(this.nazwiskoBox_TextChanged);
            // 
            // SprawdzBtn
            // 
            this.SprawdzBtn.Location = new System.Drawing.Point(180, 19);
            this.SprawdzBtn.Name = "SprawdzBtn";
            this.SprawdzBtn.Size = new System.Drawing.Size(57, 56);
            this.SprawdzBtn.TabIndex = 0;
            this.SprawdzBtn.Text = "Sprawdź";
            this.SprawdzBtn.UseVisualStyleBackColor = true;
            this.SprawdzBtn.Click += new System.EventHandler(this.SprawdzBtn_Click);
            // 
            // imieBox
            // 
            this.imieBox.Location = new System.Drawing.Point(16, 22);
            this.imieBox.Name = "imieBox";
            this.imieBox.Size = new System.Drawing.Size(158, 20);
            this.imieBox.TabIndex = 1;
            this.imieBox.TextChanged += new System.EventHandler(this.imieBox_TextChanged);
            // 
            // podgladOcen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 405);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ocena);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "podgladOcen";
            this.Text = "Podgląd ocen";
            this.Load += new System.EventHandler(this.podgladOcen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ocena;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nazwiskoBox;
        private System.Windows.Forms.Button SprawdzBtn;
        private System.Windows.Forms.TextBox imieBox;
    }
}