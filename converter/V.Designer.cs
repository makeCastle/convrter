namespace converter
{
    partial class V
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.outCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите значение и единицы измерения";
            // 
            // inCb
            // 
            this.inCb.DisplayMember = "0";
            this.inCb.FormattingEnabled = true;
            this.inCb.Items.AddRange(new object[] {
            "куб. м",
            "куб. см",
            "куб. мм"});
            this.inCb.Location = new System.Drawing.Point(118, 43);
            this.inCb.Name = "inCb";
            this.inCb.Size = new System.Drawing.Size(121, 21);
            this.inCb.TabIndex = 3;
            this.inCb.SelectedIndexChanged += new System.EventHandler(this.inCb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите во что конвертировать";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // outCb
            // 
            this.outCb.FormattingEnabled = true;
            this.outCb.Items.AddRange(new object[] {
            "куб. м",
            "куб. см",
            "куб. мм"});
            this.outCb.Location = new System.Drawing.Point(12, 118);
            this.outCb.Name = "outCb";
            this.outCb.Size = new System.Drawing.Size(121, 21);
            this.outCb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат";
            // 
            // outB
            // 
            this.outB.Location = new System.Drawing.Point(164, 185);
            this.outB.Name = "outB";
            this.outB.Size = new System.Drawing.Size(108, 32);
            this.outB.TabIndex = 8;
            this.outB.Text = "Конвертировать";
            this.outB.UseVisualStyleBackColor = true;
            this.outB.Click += new System.EventHandler(this.outB_Click);
            // 
            // V
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.outB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outCb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "V";
            this.Text = "V";
            this.Load += new System.EventHandler(this.V_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox outCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button outB;
    }
}