namespace MovieHelper
{
    partial class FormRegistryWorker
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
            this.lblScreenSaverStatus = new System.Windows.Forms.Label();
            this.btnScreenSaverStatusChange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnScreenSaverTimeout = new System.Windows.Forms.Button();
            this.txtScreenSaverTimeout = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScreenSaverStatus
            // 
            this.lblScreenSaverStatus.AutoSize = true;
            this.lblScreenSaverStatus.Location = new System.Drawing.Point(9, 19);
            this.lblScreenSaverStatus.Name = "lblScreenSaverStatus";
            this.lblScreenSaverStatus.Size = new System.Drawing.Size(37, 13);
            this.lblScreenSaverStatus.TabIndex = 0;
            this.lblScreenSaverStatus.Text = "Status";
            // 
            // btnScreenSaverStatusChange
            // 
            this.btnScreenSaverStatusChange.Location = new System.Drawing.Point(52, 14);
            this.btnScreenSaverStatusChange.Name = "btnScreenSaverStatusChange";
            this.btnScreenSaverStatusChange.Size = new System.Drawing.Size(75, 23);
            this.btnScreenSaverStatusChange.TabIndex = 1;
            this.btnScreenSaverStatusChange.Text = "Active";
            this.btnScreenSaverStatusChange.UseVisualStyleBackColor = true;
            this.btnScreenSaverStatusChange.Click += new System.EventHandler(this.btnScreenSaverStatusChange_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnScreenSaverTimeout);
            this.groupBox1.Controls.Add(this.txtScreenSaverTimeout);
            this.groupBox1.Controls.Add(this.btnScreenSaverStatusChange);
            this.groupBox1.Controls.Add(this.lblScreenSaverStatus);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Screen Saver";
            // 
            // btnScreenSaverTimeout
            // 
            this.btnScreenSaverTimeout.Location = new System.Drawing.Point(52, 48);
            this.btnScreenSaverTimeout.Name = "btnScreenSaverTimeout";
            this.btnScreenSaverTimeout.Size = new System.Drawing.Size(75, 23);
            this.btnScreenSaverTimeout.TabIndex = 3;
            this.btnScreenSaverTimeout.Text = "Set Timeout";
            this.btnScreenSaverTimeout.UseVisualStyleBackColor = true;
            this.btnScreenSaverTimeout.Click += new System.EventHandler(this.btnScreenSaverTimeout_Click);
            // 
            // txtScreenSaverTimeout
            // 
            this.txtScreenSaverTimeout.Location = new System.Drawing.Point(12, 48);
            this.txtScreenSaverTimeout.MaxLength = 6;
            this.txtScreenSaverTimeout.Name = "txtScreenSaverTimeout";
            this.txtScreenSaverTimeout.Size = new System.Drawing.Size(34, 20);
            this.txtScreenSaverTimeout.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 108);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(205, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // FormRegistryWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(205, 130);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegistryWorker";
            this.Text = "Registry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScreenSaverStatus;
        private System.Windows.Forms.Button btnScreenSaverStatusChange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnScreenSaverTimeout;
        private System.Windows.Forms.TextBox txtScreenSaverTimeout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
    }
}
