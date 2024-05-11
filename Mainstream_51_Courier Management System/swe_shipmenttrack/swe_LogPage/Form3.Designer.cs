namespace swe_LogPage
{
    partial class Form3
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
            this.ship_send = new System.Windows.Forms.Button();
            this.ship_track = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ship_send
            // 
            this.ship_send.Location = new System.Drawing.Point(104, 108);
            this.ship_send.Name = "ship_send";
            this.ship_send.Size = new System.Drawing.Size(137, 23);
            this.ship_send.TabIndex = 0;
            this.ship_send.Text = "Send Shipment";
            this.ship_send.UseVisualStyleBackColor = true;
            this.ship_send.Click += new System.EventHandler(this.ship_send_Click);
            // 
            // ship_track
            // 
            this.ship_track.Location = new System.Drawing.Point(368, 108);
            this.ship_track.Name = "ship_track";
            this.ship_track.Size = new System.Drawing.Size(131, 23);
            this.ship_track.TabIndex = 1;
            this.ship_track.Text = "Shipment Tracking";
            this.ship_track.UseVisualStyleBackColor = true;
            this.ship_track.Click += new System.EventHandler(this.ship_track_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Customer Service";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Shipment Report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tracking Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ship_track);
            this.Controls.Add(this.ship_send);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ship_send;
        private System.Windows.Forms.Button ship_track;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}