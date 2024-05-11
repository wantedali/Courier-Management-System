namespace swe_LogPage
{
    partial class Form4
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
            this.ship_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.track = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.star_ship = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arrival_ship = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ship_id
            // 
            this.ship_id.Location = new System.Drawing.Point(148, 67);
            this.ship_id.Name = "ship_id";
            this.ship_id.Size = new System.Drawing.Size(100, 20);
            this.ship_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shipment_ID";
            // 
            // track
            // 
            this.track.Location = new System.Drawing.Point(87, 368);
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(184, 23);
            this.track.TabIndex = 2;
            this.track.Text = "Track Shipment";
            this.track.UseVisualStyleBackColor = true;
            this.track.Click += new System.EventHandler(this.track_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status : ";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(105, 162);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(25, 13);
            this.status.TabIndex = 4;
            this.status.Text = "Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start Shipment Date :";
            // 
            // star_ship
            // 
            this.star_ship.AutoSize = true;
            this.star_ship.Location = new System.Drawing.Point(167, 213);
            this.star_ship.Name = "star_ship";
            this.star_ship.Size = new System.Drawing.Size(25, 13);
            this.star_ship.TabIndex = 6;
            this.star_ship.Text = "Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arrival Shipment Date :";
            // 
            // arrival_ship
            // 
            this.arrival_ship.AutoSize = true;
            this.arrival_ship.Location = new System.Drawing.Point(174, 270);
            this.arrival_ship.Name = "arrival_ship";
            this.arrival_ship.Size = new System.Drawing.Size(25, 13);
            this.arrival_ship.TabIndex = 8;
            this.arrival_ship.Text = "Null";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Return Main";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arrival_ship);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.star_ship);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.track);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ship_id);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ship_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button track;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label star_ship;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label arrival_ship;
        private System.Windows.Forms.Button button1;
    }
}