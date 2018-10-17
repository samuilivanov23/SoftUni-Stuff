namespace WindowsFormsApplication1
{
    partial class Calculator
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
            this.Seven = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Null = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.CE = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Devide = new System.Windows.Forms.Button();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(13, 53);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(46, 40);
            this.Seven.TabIndex = 0;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Button_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(12, 99);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(46, 40);
            this.Four.TabIndex = 1;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Button_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(13, 145);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(46, 40);
            this.One.TabIndex = 2;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.Button_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(65, 145);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(46, 40);
            this.Two.TabIndex = 3;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Button_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(65, 99);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(46, 40);
            this.Five.TabIndex = 4;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Button_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(65, 53);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(46, 40);
            this.Eight.TabIndex = 5;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Button_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(117, 99);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(46, 40);
            this.Six.TabIndex = 6;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Button_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(117, 53);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(46, 40);
            this.Nine.TabIndex = 7;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Button_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(117, 145);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(46, 40);
            this.Three.TabIndex = 8;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Button_Click);
            // 
            // Null
            // 
            this.Null.Location = new System.Drawing.Point(13, 191);
            this.Null.Name = "Null";
            this.Null.Size = new System.Drawing.Size(150, 40);
            this.Null.TabIndex = 9;
            this.Null.Text = "0";
            this.Null.UseVisualStyleBackColor = true;
            this.Null.Click += new System.EventHandler(this.Button_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(169, 53);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(46, 40);
            this.Plus.TabIndex = 10;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(169, 99);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(46, 40);
            this.Minus.TabIndex = 11;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Equals
            // 
            this.Equals.Location = new System.Drawing.Point(169, 145);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(46, 86);
            this.Equals.TabIndex = 12;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(13, 8);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(291, 38);
            this.Result.TabIndex = 13;
            this.Result.Text = "0";
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(221, 145);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(43, 41);
            this.CE.TabIndex = 14;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(221, 99);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(43, 40);
            this.Multiply.TabIndex = 15;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Devide
            // 
            this.Devide.Location = new System.Drawing.Point(221, 53);
            this.Devide.Name = "Devide";
            this.Devide.Size = new System.Drawing.Size(43, 40);
            this.Devide.TabIndex = 16;
            this.Devide.Text = "/";
            this.Devide.UseVisualStyleBackColor = true;
            this.Devide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.equation.Location = new System.Drawing.Point(254, 11);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 16);
            this.equation.TabIndex = 17;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 243);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.Devide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Null);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Seven);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Null;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Devide;
        private System.Windows.Forms.Label equation;
    }
}

