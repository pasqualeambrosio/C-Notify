namespace CustomNotify
{
    partial class Notify
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
            this.components = new System.ComponentModel.Container();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.imgNotify = new System.Windows.Forms.PictureBox();
            this.tmrClose = new System.Windows.Forms.Timer(this.components);
            this.tmrShow = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // imgClose
            // 
            this.imgClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClose.Location = new System.Drawing.Point(340, 25);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(20, 20);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgClose.TabIndex = 1;
            this.imgClose.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(43, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(291, 63);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Success";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgNotify
            // 
            this.imgNotify.Location = new System.Drawing.Point(8, 17);
            this.imgNotify.Name = "imgNotify";
            this.imgNotify.Size = new System.Drawing.Size(28, 28);
            this.imgNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNotify.TabIndex = 3;
            this.imgNotify.TabStop = false;
            // 
            // tmrClose
            // 
            this.tmrClose.Interval = 1000;
            // 
            // tmrShow
            // 
            this.tmrShow.Interval = 20;
            this.tmrShow.Tick += new System.EventHandler(this.tmrShow_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(332, 2);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 15);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "23:59";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(372, 66);
            this.ControlBox = false;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.imgNotify);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.imgClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notify";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notify_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notify_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox imgNotify;
        private System.Windows.Forms.Timer tmrClose;
        private System.Windows.Forms.Timer tmrShow;
        private System.Windows.Forms.Label lblTime;
    }
}