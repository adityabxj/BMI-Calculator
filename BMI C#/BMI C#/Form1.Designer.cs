namespace BMI_C_
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
            this.button1 = new System.Windows.Forms.Button();
            this.weight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(267, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(268, 233);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(267, 26);
            this.weight.TabIndex = 3;
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Height";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(267, 145);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(267, 26);
            this.height.TabIndex = 6;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Weight";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(267, 399);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(267, 60);
            this.Result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(838, 483);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Result;
    }
}

