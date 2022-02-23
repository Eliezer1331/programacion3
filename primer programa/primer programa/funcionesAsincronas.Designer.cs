namespace primer_programa
{
    partial class funcionesAsincronas
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
            this.label1 = new System.Windows.Forms.Label();
            this.HornearButton = new System.Windows.Forms.Button();
            this.OtrasTraeasButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // HornearButton
            // 
            this.HornearButton.Location = new System.Drawing.Point(210, 55);
            this.HornearButton.Name = "HornearButton";
            this.HornearButton.Size = new System.Drawing.Size(89, 37);
            this.HornearButton.TabIndex = 1;
            this.HornearButton.Text = "hornear pizza";
            this.HornearButton.UseVisualStyleBackColor = true;
            this.HornearButton.Click += new System.EventHandler(this.HornearButton_Click);
            // 
            // OtrasTraeasButton
            // 
            this.OtrasTraeasButton.Location = new System.Drawing.Point(338, 55);
            this.OtrasTraeasButton.Name = "OtrasTraeasButton";
            this.OtrasTraeasButton.Size = new System.Drawing.Size(89, 37);
            this.OtrasTraeasButton.TabIndex = 2;
            this.OtrasTraeasButton.Text = "Otras Tareas";
            this.OtrasTraeasButton.UseVisualStyleBackColor = true;
            this.OtrasTraeasButton.Click += new System.EventHandler(this.OtrasTraeasButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sumar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // funcionesAsincronas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OtrasTraeasButton);
            this.Controls.Add(this.HornearButton);
            this.Controls.Add(this.label1);
            this.Name = "funcionesAsincronas";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HornearButton;
        private System.Windows.Forms.Button OtrasTraeasButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}