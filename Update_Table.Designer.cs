namespace WindowsFormsApp1
{
    partial class Update_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Table));
            this.AudioButton = new System.Windows.Forms.Button();
            this.AlbumButton = new System.Windows.Forms.Button();
            this.ChannelButton = new System.Windows.Forms.Button();
            this.FeaturesButton = new System.Windows.Forms.Button();
            this.TrackButton = new System.Windows.Forms.Button();
            this.VideoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AudioButton
            // 
            this.AudioButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioButton.Location = new System.Drawing.Point(538, 251);
            this.AudioButton.Name = "AudioButton";
            this.AudioButton.Size = new System.Drawing.Size(240, 34);
            this.AudioButton.TabIndex = 1;
            this.AudioButton.Text = "Audio";
            this.AudioButton.UseVisualStyleBackColor = true;
            this.AudioButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlbumButton
            // 
            this.AlbumButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumButton.Location = new System.Drawing.Point(538, 170);
            this.AlbumButton.Name = "AlbumButton";
            this.AlbumButton.Size = new System.Drawing.Size(240, 34);
            this.AlbumButton.TabIndex = 2;
            this.AlbumButton.Text = "Album";
            this.AlbumButton.UseVisualStyleBackColor = true;
            this.AlbumButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChannelButton
            // 
            this.ChannelButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelButton.Location = new System.Drawing.Point(538, 341);
            this.ChannelButton.Name = "ChannelButton";
            this.ChannelButton.Size = new System.Drawing.Size(240, 34);
            this.ChannelButton.TabIndex = 3;
            this.ChannelButton.Text = "Channel";
            this.ChannelButton.UseVisualStyleBackColor = true;
            this.ChannelButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // FeaturesButton
            // 
            this.FeaturesButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeaturesButton.Location = new System.Drawing.Point(538, 428);
            this.FeaturesButton.Name = "FeaturesButton";
            this.FeaturesButton.Size = new System.Drawing.Size(240, 34);
            this.FeaturesButton.TabIndex = 4;
            this.FeaturesButton.Text = "Features";
            this.FeaturesButton.UseVisualStyleBackColor = true;
            this.FeaturesButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // TrackButton
            // 
            this.TrackButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackButton.Location = new System.Drawing.Point(538, 520);
            this.TrackButton.Name = "TrackButton";
            this.TrackButton.Size = new System.Drawing.Size(240, 34);
            this.TrackButton.TabIndex = 5;
            this.TrackButton.Text = "Track";
            this.TrackButton.UseVisualStyleBackColor = true;
            this.TrackButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // VideoButton
            // 
            this.VideoButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoButton.Location = new System.Drawing.Point(538, 609);
            this.VideoButton.Name = "VideoButton";
            this.VideoButton.Size = new System.Drawing.Size(240, 34);
            this.VideoButton.TabIndex = 6;
            this.VideoButton.Text = "Video";
            this.VideoButton.UseVisualStyleBackColor = true;
            this.VideoButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 85);
            this.label1.TabIndex = 79;
            this.label1.Text = "Select Table To Update";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.VideoButton);
            this.panel2.Controls.Add(this.TrackButton);
            this.panel2.Controls.Add(this.FeaturesButton);
            this.panel2.Controls.Add(this.ChannelButton);
            this.panel2.Controls.Add(this.AlbumButton);
            this.panel2.Controls.Add(this.AudioButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1341, 755);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Update_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Name = "Update_Table";
            this.Size = new System.Drawing.Size(1341, 755);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AudioButton;
        private System.Windows.Forms.Button AlbumButton;
        private System.Windows.Forms.Button ChannelButton;
        private System.Windows.Forms.Button FeaturesButton;
        private System.Windows.Forms.Button TrackButton;
        private System.Windows.Forms.Button VideoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}
