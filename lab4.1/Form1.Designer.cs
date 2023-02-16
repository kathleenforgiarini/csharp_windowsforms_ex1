namespace lab4._1
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
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resAdd = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.resSub = new System.Windows.Forms.TextBox();
            this.mul = new System.Windows.Forms.Button();
            this.resMul = new System.Windows.Forms.TextBox();
            this.div = new System.Windows.Forms.Button();
            this.resDiv = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number &1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number &2 :";
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(160, 134);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(105, 22);
            this.number1.TabIndex = 0;
            this.number1.Text = "0";
            this.number1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number1.TextChanged += new System.EventHandler(this.number1_TextChanged);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(160, 181);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(105, 22);
            this.number2.TabIndex = 1;
            this.number2.Text = "0";
            this.number2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number2.TextChanged += new System.EventHandler(this.number2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Results";
            // 
            // resAdd
            // 
            this.resAdd.Location = new System.Drawing.Point(426, 94);
            this.resAdd.Name = "resAdd";
            this.resAdd.ReadOnly = true;
            this.resAdd.Size = new System.Drawing.Size(127, 22);
            this.resAdd.TabIndex = 5;
            this.resAdd.TabStop = false;
            this.resAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.Control;
            this.add.Location = new System.Drawing.Point(311, 90);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(91, 30);
            this.add.TabIndex = 6;
            this.add.Text = "&Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.Control;
            this.sub.Location = new System.Drawing.Point(311, 131);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(91, 30);
            this.sub.TabIndex = 8;
            this.sub.Text = "&Sub";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // resSub
            // 
            this.resSub.Location = new System.Drawing.Point(426, 135);
            this.resSub.Name = "resSub";
            this.resSub.ReadOnly = true;
            this.resSub.Size = new System.Drawing.Size(127, 22);
            this.resSub.TabIndex = 7;
            this.resSub.TabStop = false;
            this.resSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.Control;
            this.mul.Location = new System.Drawing.Point(311, 173);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(91, 30);
            this.mul.TabIndex = 10;
            this.mul.Text = "&Mul";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // resMul
            // 
            this.resMul.Location = new System.Drawing.Point(426, 177);
            this.resMul.Name = "resMul";
            this.resMul.ReadOnly = true;
            this.resMul.Size = new System.Drawing.Size(127, 22);
            this.resMul.TabIndex = 9;
            this.resMul.TabStop = false;
            this.resMul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.Control;
            this.div.Location = new System.Drawing.Point(311, 215);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(91, 30);
            this.div.TabIndex = 12;
            this.div.Text = "&Div";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // resDiv
            // 
            this.resDiv.Location = new System.Drawing.Point(426, 219);
            this.resDiv.Name = "resDiv";
            this.resDiv.ReadOnly = true;
            this.resDiv.Size = new System.Drawing.Size(127, 22);
            this.resDiv.TabIndex = 11;
            this.resDiv.TabStop = false;
            this.resDiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.Control;
            this.exit.Location = new System.Drawing.Point(462, 280);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(91, 30);
            this.exit.TabIndex = 13;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.div);
            this.Controls.Add(this.resDiv);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.resMul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.resSub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.resAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kathleen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resAdd;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.TextBox resSub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.TextBox resMul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.TextBox resDiv;
        private System.Windows.Forms.Button exit;
    }
}

