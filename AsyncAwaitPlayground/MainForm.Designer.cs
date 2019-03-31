namespace Playground
{
    partial class MainForm
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
            this.btnExecuteNormal = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExecuteAsync = new System.Windows.Forms.Button();
            this.btnExecuteAsyncParallel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExecuteNormal
            // 
            this.btnExecuteNormal.Location = new System.Drawing.Point(20, 148);
            this.btnExecuteNormal.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnExecuteNormal.Name = "btnExecuteNormal";
            this.btnExecuteNormal.Size = new System.Drawing.Size(744, 50);
            this.btnExecuteNormal.TabIndex = 0;
            this.btnExecuteNormal.Text = "Execute Normal";
            this.btnExecuteNormal.UseVisualStyleBackColor = true;
            this.btnExecuteNormal.Click += new System.EventHandler(this.BtnExecuteNormal_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 367);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(754, 410);
            this.txtLog.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(14, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(750, 73);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Async Await Playground";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExecuteAsync
            // 
            this.btnExecuteAsync.Location = new System.Drawing.Point(20, 221);
            this.btnExecuteAsync.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnExecuteAsync.Name = "btnExecuteAsync";
            this.btnExecuteAsync.Size = new System.Drawing.Size(744, 50);
            this.btnExecuteAsync.TabIndex = 3;
            this.btnExecuteAsync.Text = "Execute Async";
            this.btnExecuteAsync.UseVisualStyleBackColor = true;
            this.btnExecuteAsync.Click += new System.EventHandler(this.BtnExecuteAsync_Click);
            // 
            // btnExecuteAsyncParallel
            // 
            this.btnExecuteAsyncParallel.Location = new System.Drawing.Point(20, 294);
            this.btnExecuteAsyncParallel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnExecuteAsyncParallel.Name = "btnExecuteAsyncParallel";
            this.btnExecuteAsyncParallel.Size = new System.Drawing.Size(744, 50);
            this.btnExecuteAsyncParallel.TabIndex = 4;
            this.btnExecuteAsyncParallel.Text = "Execute Async Parallel";
            this.btnExecuteAsyncParallel.UseVisualStyleBackColor = true;
            this.btnExecuteAsyncParallel.Click += new System.EventHandler(this.BtnExecuteAsyncParallel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 789);
            this.Controls.Add(this.btnExecuteAsyncParallel);
            this.Controls.Add(this.btnExecuteAsync);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnExecuteNormal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 845);
            this.MinimumSize = new System.Drawing.Size(800, 845);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecuteNormal;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExecuteAsync;
        private System.Windows.Forms.Button btnExecuteAsyncParallel;
    }
}

