namespace Calculator
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.TB_output = new System.Windows.Forms.TextBox();
            this.percentage = new System.Windows.Forms.Button();
            this.cancelentry = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.onebyx = new System.Windows.Forms.Button();
            this.powx = new System.Windows.Forms.Button();
            this.sqroot = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.plusorminus = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.decimalpoint = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.Label_display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_output
            // 
            this.TB_output.BackColor = System.Drawing.SystemColors.WindowText;
            this.TB_output.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_output.ForeColor = System.Drawing.Color.White;
            this.TB_output.Location = new System.Drawing.Point(3, 54);
            this.TB_output.Margin = new System.Windows.Forms.Padding(0);
            this.TB_output.Multiline = true;
            this.TB_output.Name = "TB_output";
            this.TB_output.ReadOnly = true;
            this.TB_output.Size = new System.Drawing.Size(309, 54);
            this.TB_output.TabIndex = 0;
            this.TB_output.Text = "0";
            this.TB_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // percentage
            // 
            this.percentage.Location = new System.Drawing.Point(7, 114);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(72, 62);
            this.percentage.TabIndex = 1;
            this.percentage.Text = "Log";
            this.percentage.UseVisualStyleBackColor = true;
            this.percentage.Click += new System.EventHandler(this.operation_Click);
            // 
            // cancelentry
            // 
            this.cancelentry.BackColor = System.Drawing.Color.IndianRed;
            this.cancelentry.Location = new System.Drawing.Point(85, 114);
            this.cancelentry.Name = "cancelentry";
            this.cancelentry.Size = new System.Drawing.Size(72, 62);
            this.cancelentry.TabIndex = 2;
            this.cancelentry.Text = "CE";
            this.cancelentry.UseVisualStyleBackColor = false;
            this.cancelentry.Click += new System.EventHandler(this.Clear_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(162, 114);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(72, 62);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "C";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Clear_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(240, 114);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(72, 62);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Clear_Click);
            // 
            // onebyx
            // 
            this.onebyx.Location = new System.Drawing.Point(7, 182);
            this.onebyx.Name = "onebyx";
            this.onebyx.Size = new System.Drawing.Size(72, 62);
            this.onebyx.TabIndex = 5;
            this.onebyx.Text = "1/x";
            this.onebyx.UseVisualStyleBackColor = true;
            this.onebyx.Click += new System.EventHandler(this.operation_Click);
            // 
            // powx
            // 
            this.powx.Location = new System.Drawing.Point(85, 182);
            this.powx.Name = "powx";
            this.powx.Size = new System.Drawing.Size(72, 62);
            this.powx.TabIndex = 6;
            this.powx.Text = "x^2";
            this.powx.UseVisualStyleBackColor = true;
            this.powx.Click += new System.EventHandler(this.operation_Click);
            // 
            // sqroot
            // 
            this.sqroot.Location = new System.Drawing.Point(163, 182);
            this.sqroot.Name = "sqroot";
            this.sqroot.Size = new System.Drawing.Size(72, 62);
            this.sqroot.TabIndex = 7;
            this.sqroot.Text = "Root(x)";
            this.sqroot.UseVisualStyleBackColor = true;
            this.sqroot.Click += new System.EventHandler(this.operation_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(240, 182);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(72, 62);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operation_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(7, 250);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(72, 62);
            this.num7.TabIndex = 9;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.number_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(85, 250);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(72, 62);
            this.num8.TabIndex = 10;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.number_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(163, 250);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(72, 62);
            this.num9.TabIndex = 11;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.number_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(240, 250);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(72, 62);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operation_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(7, 318);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(72, 62);
            this.num4.TabIndex = 13;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.number_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(85, 318);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(72, 62);
            this.num5.TabIndex = 14;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.number_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(162, 318);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(72, 62);
            this.num6.TabIndex = 15;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.number_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(240, 318);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(72, 62);
            this.sub.TabIndex = 16;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.operation_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(7, 386);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(72, 62);
            this.num1.TabIndex = 17;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.number_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(85, 389);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(72, 62);
            this.num2.TabIndex = 18;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.number_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(163, 389);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(72, 62);
            this.num3.TabIndex = 19;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.number_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(241, 389);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(72, 62);
            this.add.TabIndex = 20;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operation_Click);
            // 
            // plusorminus
            // 
            this.plusorminus.Location = new System.Drawing.Point(7, 454);
            this.plusorminus.Name = "plusorminus";
            this.plusorminus.Size = new System.Drawing.Size(72, 62);
            this.plusorminus.TabIndex = 21;
            this.plusorminus.Text = "+/-";
            this.plusorminus.UseVisualStyleBackColor = true;
            this.plusorminus.Click += new System.EventHandler(this.changeSign_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(85, 454);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(72, 62);
            this.num0.TabIndex = 22;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.number_Click);
            // 
            // decimalpoint
            // 
            this.decimalpoint.Location = new System.Drawing.Point(163, 454);
            this.decimalpoint.Name = "decimalpoint";
            this.decimalpoint.Size = new System.Drawing.Size(72, 62);
            this.decimalpoint.TabIndex = 23;
            this.decimalpoint.Text = ".";
            this.decimalpoint.UseVisualStyleBackColor = true;
            this.decimalpoint.Click += new System.EventHandler(this.number_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.DarkOrchid;
            this.equals.Location = new System.Drawing.Point(240, 454);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(72, 62);
            this.equals.TabIndex = 24;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // Label_display
            // 
            this.Label_display.AutoSize = true;
            this.Label_display.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_display.ForeColor = System.Drawing.Color.White;
            this.Label_display.Location = new System.Drawing.Point(6, 22);
            this.Label_display.Name = "Label_display";
            this.Label_display.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_display.Size = new System.Drawing.Size(23, 28);
            this.Label_display.TabIndex = 25;
            this.Label_display.Text = "0";
            this.Label_display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(320, 520);
            this.Controls.Add(this.Label_display);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.decimalpoint);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.plusorminus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.sqroot);
            this.Controls.Add(this.powx);
            this.Controls.Add(this.onebyx);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.cancelentry);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.TB_output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TB_output;
        private Button percentage;
        private Button cancelentry;
        private Button cancel;
        private Button delete;
        private Button onebyx;
        private Button powx;
        private Button sqroot;
        private Button divide;
        private Button num7;
        private Button num8;
        private Button num9;
        private Button multiply;
        private Button num4;
        private Button num5;
        private Button num6;
        private Button sub;
        private Button num1;
        private Button num2;
        private Button num3;
        private Button add;
        private Button plusorminus;
        private Button num0;
        private Button decimalpoint;
        private Button equals;
        private Label Label_display;
    }
}