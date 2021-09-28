namespace MovieHelper
{
    partial class TimePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSecond
            // 
            this.nudSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudSecond.Location = new System.Drawing.Point(80, 13);
            this.nudSecond.Margin = new System.Windows.Forms.Padding(0);
            this.nudSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSecond.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(40, 16);
            this.nudSecond.TabIndex = 0;
            this.nudSecond.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.nudSecond.ValueChanged += new System.EventHandler(this.nudSecond_ValueChanged);
            // 
            // nudMinute
            // 
            this.nudMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudMinute.Location = new System.Drawing.Point(40, 13);
            this.nudMinute.Margin = new System.Windows.Forms.Padding(0);
            this.nudMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinute.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(40, 16);
            this.nudMinute.TabIndex = 1;
            this.nudMinute.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudMinute.ValueChanged += new System.EventHandler(this.nudMinute_ValueChanged);
            // 
            // nudHour
            // 
            this.nudHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudHour.Location = new System.Drawing.Point(0, 13);
            this.nudHour.Margin = new System.Windows.Forms.Padding(0);
            this.nudHour.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(40, 16);
            this.nudHour.TabIndex = 2;
            this.nudHour.ValueChanged += new System.EventHandler(this.nudHour_ValueChanged);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(0, 0);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(30, 13);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "Hour";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(40, 0);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(24, 13);
            this.lblMinute.TabIndex = 4;
            this.lblMinute.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sec";
            // 
            // TimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.nudSecond);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TimePicker";
            this.Size = new System.Drawing.Size(120, 29);
            this.Load += new System.EventHandler(this.TimePicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label label1;
    }
}
