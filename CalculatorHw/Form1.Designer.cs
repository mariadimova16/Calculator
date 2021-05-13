
namespace CalculatorHw
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
            this.infoBox = new System.Windows.Forms.TextBox();
            this.butMminus = new System.Windows.Forms.Button();
            this.butMplus = new System.Windows.Forms.Button();
            this.butMR = new System.Windows.Forms.Button();
            this.butMC = new System.Windows.Forms.Button();
            this.butClearAll = new System.Windows.Forms.Button();
            this.butSqrt = new System.Windows.Forms.Button();
            this.butClearCur = new System.Windows.Forms.Button();
            this.butDev = new System.Windows.Forms.Button();
            this.butMult = new System.Windows.Forms.Button();
            this.butMinus = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.butDec = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.butPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBox.Location = new System.Drawing.Point(36, 56);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(395, 75);
            this.infoBox.TabIndex = 54;
            this.infoBox.Text = "0";
            this.infoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.infoBox.TextChanged += new System.EventHandler(this.infoBox_TextChanged);
            // 
            // butMminus
            // 
            this.butMminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butMminus.Location = new System.Drawing.Point(200, 227);
            this.butMminus.Name = "butMminus";
            this.butMminus.Size = new System.Drawing.Size(151, 37);
            this.butMminus.TabIndex = 53;
            this.butMminus.Text = "M-";
            this.butMminus.UseVisualStyleBackColor = true;
            this.butMminus.Click += new System.EventHandler(this.butMminus_Click);
            this.butMminus.MouseCaptureChanged += new System.EventHandler(this.button2_Click);
            // 
            // butMplus
            // 
            this.butMplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butMplus.Location = new System.Drawing.Point(38, 227);
            this.butMplus.Name = "butMplus";
            this.butMplus.Size = new System.Drawing.Size(143, 37);
            this.butMplus.TabIndex = 52;
            this.butMplus.Text = "M+";
            this.butMplus.UseVisualStyleBackColor = true;
            this.butMplus.Click += new System.EventHandler(this.butMplus_Click);
            this.butMplus.MouseCaptureChanged += new System.EventHandler(this.button2_Click);
            // 
            // butMR
            // 
            this.butMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butMR.Location = new System.Drawing.Point(38, 167);
            this.butMR.Name = "butMR";
            this.butMR.Size = new System.Drawing.Size(82, 54);
            this.butMR.TabIndex = 51;
            this.butMR.Text = "MR";
            this.butMR.UseVisualStyleBackColor = true;
            this.butMR.Click += new System.EventHandler(this.butMR_Click);
            this.butMR.MouseCaptureChanged += new System.EventHandler(this.button2_Click);
            // 
            // butMC
            // 
            this.butMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butMC.Location = new System.Drawing.Point(153, 167);
            this.butMC.Name = "butMC";
            this.butMC.Size = new System.Drawing.Size(82, 54);
            this.butMC.TabIndex = 50;
            this.butMC.Text = "MC";
            this.butMC.UseVisualStyleBackColor = true;
            this.butMC.Click += new System.EventHandler(this.butMC_Click);
            this.butMC.MouseCaptureChanged += new System.EventHandler(this.button2_Click);
            // 
            // butClearAll
            // 
            this.butClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butClearAll.Location = new System.Drawing.Point(374, 167);
            this.butClearAll.Name = "butClearAll";
            this.butClearAll.Size = new System.Drawing.Size(58, 54);
            this.butClearAll.TabIndex = 49;
            this.butClearAll.Text = "C";
            this.butClearAll.UseVisualStyleBackColor = true;
            this.butClearAll.Click += new System.EventHandler(this.butClearAll_Click);
            this.butClearAll.MouseCaptureChanged += new System.EventHandler(this.button2_Click);
            // 
            // butSqrt
            // 
            this.butSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSqrt.Location = new System.Drawing.Point(38, 270);
            this.butSqrt.Name = "butSqrt";
            this.butSqrt.Size = new System.Drawing.Size(313, 54);
            this.butSqrt.TabIndex = 46;
            this.butSqrt.Text = "√ ";
            this.butSqrt.UseVisualStyleBackColor = true;
            this.butSqrt.Click += new System.EventHandler(this.butSqrt_Click);
            this.butSqrt.MouseCaptureChanged += new System.EventHandler(this.button2_Click);
            // 
            // butClearCur
            // 
            this.butClearCur.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butClearCur.Location = new System.Drawing.Point(269, 167);
            this.butClearCur.Name = "butClearCur";
            this.butClearCur.Size = new System.Drawing.Size(82, 54);
            this.butClearCur.TabIndex = 45;
            this.butClearCur.Text = "AC";
            this.butClearCur.UseVisualStyleBackColor = true;
            this.butClearCur.Click += new System.EventHandler(this.butClearCur_Click);
            this.butClearCur.MouseCaptureChanged += new System.EventHandler(this.button2_Click);
            // 
            // butDev
            // 
            this.butDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDev.Location = new System.Drawing.Point(374, 236);
            this.butDev.Name = "butDev";
            this.butDev.Size = new System.Drawing.Size(58, 54);
            this.butDev.TabIndex = 44;
            this.butDev.Text = "/";
            this.butDev.UseVisualStyleBackColor = true;
            this.butDev.Click += new System.EventHandler(this.butDev_Click);
            // 
            // butMult
            // 
            this.butMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butMult.Location = new System.Drawing.Point(374, 298);
            this.butMult.Name = "butMult";
            this.butMult.Size = new System.Drawing.Size(58, 54);
            this.butMult.TabIndex = 43;
            this.butMult.Text = "X";
            this.butMult.UseVisualStyleBackColor = true;
            this.butMult.Click += new System.EventHandler(this.butMult_Click);
            // 
            // butMinus
            // 
            this.butMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butMinus.Location = new System.Drawing.Point(375, 365);
            this.butMinus.Name = "butMinus";
            this.butMinus.Size = new System.Drawing.Size(58, 54);
            this.butMinus.TabIndex = 42;
            this.butMinus.Text = "-";
            this.butMinus.UseVisualStyleBackColor = true;
            this.butMinus.Click += new System.EventHandler(this.butMinus_Click);
            // 
            // but9
            // 
            this.but9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but9.Location = new System.Drawing.Point(269, 335);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(82, 38);
            this.but9.TabIndex = 41;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            this.but9.Click += new System.EventHandler(this.but9_Click);
            // 
            // but8
            // 
            this.but8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but8.Location = new System.Drawing.Point(153, 335);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(82, 38);
            this.but8.TabIndex = 40;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            this.but8.Click += new System.EventHandler(this.but8_Click);
            // 
            // but7
            // 
            this.but7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but7.Location = new System.Drawing.Point(38, 335);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(82, 38);
            this.but7.TabIndex = 39;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            this.but7.Click += new System.EventHandler(this.but7_Click);
            // 
            // but6
            // 
            this.but6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but6.Location = new System.Drawing.Point(269, 387);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(82, 38);
            this.but6.TabIndex = 38;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            this.but6.Click += new System.EventHandler(this.but6_Click);
            // 
            // but5
            // 
            this.but5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but5.Location = new System.Drawing.Point(153, 387);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(82, 38);
            this.but5.TabIndex = 37;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            this.but5.Click += new System.EventHandler(this.but5_Click);
            // 
            // but4
            // 
            this.but4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but4.Location = new System.Drawing.Point(38, 387);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(82, 38);
            this.but4.TabIndex = 36;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(269, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 38);
            this.button2.TabIndex = 35;
            this.button2.Text = "=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butDec
            // 
            this.butDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDec.Location = new System.Drawing.Point(153, 505);
            this.butDec.Name = "butDec";
            this.butDec.Size = new System.Drawing.Size(82, 38);
            this.butDec.TabIndex = 34;
            this.butDec.Text = ".";
            this.butDec.UseVisualStyleBackColor = true;
            this.butDec.Click += new System.EventHandler(this.butDec_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(38, 505);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 38);
            this.button4.TabIndex = 33;
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // but3
            // 
            this.but3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but3.Location = new System.Drawing.Point(269, 446);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(82, 38);
            this.but3.TabIndex = 32;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // but2
            // 
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but2.Location = new System.Drawing.Point(153, 446);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(82, 38);
            this.but2.TabIndex = 31;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but1
            // 
            this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but1.Location = new System.Drawing.Point(38, 446);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(82, 38);
            this.but1.TabIndex = 30;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // butPlus
            // 
            this.butPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butPlus.Location = new System.Drawing.Point(374, 437);
            this.butPlus.Name = "butPlus";
            this.butPlus.Size = new System.Drawing.Size(58, 106);
            this.butPlus.TabIndex = 29;
            this.butPlus.Text = "+";
            this.butPlus.UseVisualStyleBackColor = true;
            this.butPlus.Click += new System.EventHandler(this.butPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 599);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.butMminus);
            this.Controls.Add(this.butMplus);
            this.Controls.Add(this.butMR);
            this.Controls.Add(this.butMC);
            this.Controls.Add(this.butClearAll);
            this.Controls.Add(this.butSqrt);
            this.Controls.Add(this.butClearCur);
            this.Controls.Add(this.butDev);
            this.Controls.Add(this.butMult);
            this.Controls.Add(this.butMinus);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butDec);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.butPlus);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Button butMminus;
        private System.Windows.Forms.Button butMplus;
        private System.Windows.Forms.Button butMR;
        private System.Windows.Forms.Button butMC;
        private System.Windows.Forms.Button butClearAll;
        private System.Windows.Forms.Button butSqrt;
        private System.Windows.Forms.Button butClearCur;
        private System.Windows.Forms.Button butDev;
        private System.Windows.Forms.Button butMult;
        private System.Windows.Forms.Button butMinus;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butDec;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button butPlus;
    }
}