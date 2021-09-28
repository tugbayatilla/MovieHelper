namespace MovieHelper
{
    partial class FormDrawShapes
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
            this.txtSquareValue = new System.Windows.Forms.TextBox();
            this.gbDraw = new System.Windows.Forms.GroupBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.lblSquareValue = new System.Windows.Forms.Label();
            this.btnDrawSquare = new System.Windows.Forms.Button();
            this.gbDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSquareValue
            // 
            this.txtSquareValue.Location = new System.Drawing.Point(48, 19);
            this.txtSquareValue.MaxLength = 3;
            this.txtSquareValue.Name = "txtSquareValue";
            this.txtSquareValue.Size = new System.Drawing.Size(70, 20);
            this.txtSquareValue.TabIndex = 0;
            // 
            // gbDraw
            // 
            this.gbDraw.Controls.Add(this.btnCircle);
            this.gbDraw.Controls.Add(this.lblSquareValue);
            this.gbDraw.Controls.Add(this.btnDrawSquare);
            this.gbDraw.Controls.Add(this.txtSquareValue);
            this.gbDraw.Location = new System.Drawing.Point(12, 12);
            this.gbDraw.Name = "gbDraw";
            this.gbDraw.Size = new System.Drawing.Size(228, 97);
            this.gbDraw.TabIndex = 1;
            this.gbDraw.TabStop = false;
            this.gbDraw.Text = "Draw Group";
            // 
            // btnCircle
            // 
            this.btnCircle.Enabled = false;
            this.btnCircle.Location = new System.Drawing.Point(124, 50);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // lblSquareValue
            // 
            this.lblSquareValue.AutoSize = true;
            this.lblSquareValue.Location = new System.Drawing.Point(7, 20);
            this.lblSquareValue.Name = "lblSquareValue";
            this.lblSquareValue.Size = new System.Drawing.Size(34, 13);
            this.lblSquareValue.TabIndex = 2;
            this.lblSquareValue.Text = "Value";
            // 
            // btnDrawSquare
            // 
            this.btnDrawSquare.Location = new System.Drawing.Point(124, 20);
            this.btnDrawSquare.Name = "btnDrawSquare";
            this.btnDrawSquare.Size = new System.Drawing.Size(75, 23);
            this.btnDrawSquare.TabIndex = 1;
            this.btnDrawSquare.Text = "Squire";
            this.btnDrawSquare.UseVisualStyleBackColor = true;
            this.btnDrawSquare.Click += new System.EventHandler(this.btnDrawSquare_Click);
            // 
            // FormDrawShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 126);
            this.Controls.Add(this.gbDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.Name = "FormDrawShapes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Actions";
            this.gbDraw.ResumeLayout(false);
            this.gbDraw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSquareValue;
        private System.Windows.Forms.GroupBox gbDraw;
        private System.Windows.Forms.Label lblSquareValue;
        private System.Windows.Forms.Button btnDrawSquare;
        private System.Windows.Forms.Button btnCircle;
    }
}