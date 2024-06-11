namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(286, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(15, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter 1st Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter 2nd Number:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(424, 140);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 45);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(424, 239);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(458, 43);
            this.textBox2.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.AddButton.Location = new System.Drawing.Point(54, 323);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(119, 64);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.SubtractButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubtractButton.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.SubtractButton.Location = new System.Drawing.Point(179, 323);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(205, 64);
            this.SubtractButton.TabIndex = 3;
            this.SubtractButton.Text = "SUBTRACT";
            this.SubtractButton.UseVisualStyleBackColor = false;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.MultiplicationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MultiplicationButton.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicationButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.MultiplicationButton.Location = new System.Drawing.Point(390, 323);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(298, 64);
            this.MultiplicationButton.TabIndex = 4;
            this.MultiplicationButton.Text = "MULTIPLICATION";
            this.MultiplicationButton.UseVisualStyleBackColor = false;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.DivisionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DivisionButton.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.DivisionButton.Location = new System.Drawing.Point(694, 323);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(188, 64);
            this.DivisionButton.TabIndex = 5;
            this.DivisionButton.Text = "DIVISION";
            this.DivisionButton.UseVisualStyleBackColor = false;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(29, 467);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(167, 47);
            this.Result.TabIndex = 4;
            this.Result.Text = "Result:";
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 47);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter 2nd Number:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(54, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "AC";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

