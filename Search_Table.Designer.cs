namespace WindowsFormsApp1
{
    partial class Search_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Table));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.VideoButton = new System.Windows.Forms.Button();
            this.TrackButton = new System.Windows.Forms.Button();
            this.FeaturesButton = new System.Windows.Forms.Button();
            this.ChannelButton = new System.Windows.Forms.Button();
            this.AlbumButton = new System.Windows.Forms.Button();
            this.AudioButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(1195, 716);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(323, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 85);
            this.label1.TabIndex = 86;
            this.label1.Text = "Select Table to Search";
            // 
            // VideoButton
            // 
            this.VideoButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoButton.Location = new System.Drawing.Point(519, 619);
            this.VideoButton.Name = "VideoButton";
            this.VideoButton.Size = new System.Drawing.Size(215, 36);
            this.VideoButton.TabIndex = 85;
            this.VideoButton.Text = "Video";
            this.VideoButton.UseVisualStyleBackColor = true;
            this.VideoButton.Click += new System.EventHandler(this.VideoButton_Click);
            // 
            // TrackButton
            // 
            this.TrackButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackButton.Location = new System.Drawing.Point(519, 530);
            this.TrackButton.Name = "TrackButton";
            this.TrackButton.Size = new System.Drawing.Size(215, 36);
            this.TrackButton.TabIndex = 84;
            this.TrackButton.Text = "Track";
            this.TrackButton.UseVisualStyleBackColor = true;
            this.TrackButton.Click += new System.EventHandler(this.TrackButton_Click);
            // 
            // FeaturesButton
            // 
            this.FeaturesButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeaturesButton.Location = new System.Drawing.Point(519, 438);
            this.FeaturesButton.Name = "FeaturesButton";
            this.FeaturesButton.Size = new System.Drawing.Size(215, 36);
            this.FeaturesButton.TabIndex = 83;
            this.FeaturesButton.Text = "Features";
            this.FeaturesButton.UseVisualStyleBackColor = true;
            this.FeaturesButton.Click += new System.EventHandler(this.FeaturesButton_Click);
            // 
            // ChannelButton
            // 
            this.ChannelButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelButton.Location = new System.Drawing.Point(519, 351);
            this.ChannelButton.Name = "ChannelButton";
            this.ChannelButton.Size = new System.Drawing.Size(215, 36);
            this.ChannelButton.TabIndex = 82;
            this.ChannelButton.Text = "Channel";
            this.ChannelButton.UseVisualStyleBackColor = true;
            this.ChannelButton.Click += new System.EventHandler(this.ChannelButton_Click);
            // 
            // AlbumButton
            // 
            this.AlbumButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumButton.Location = new System.Drawing.Point(519, 180);
            this.AlbumButton.Name = "AlbumButton";
            this.AlbumButton.Size = new System.Drawing.Size(215, 36);
            this.AlbumButton.TabIndex = 81;
            this.AlbumButton.Text = "Album";
            this.AlbumButton.UseVisualStyleBackColor = true;
            this.AlbumButton.Click += new System.EventHandler(this.AlbumButton_Click);
            // 
            // AudioButton
            // 
            this.AudioButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioButton.Location = new System.Drawing.Point(519, 261);
            this.AudioButton.Name = "AudioButton";
            this.AudioButton.Size = new System.Drawing.Size(215, 36);
            this.AudioButton.TabIndex = 80;
            this.AudioButton.Text = "Audio";
            this.AudioButton.UseVisualStyleBackColor = true;
            this.AudioButton.Click += new System.EventHandler(this.AudioButton_Click);
            // 
            // Search_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Name = "Search_Table";
            this.Size = new System.Drawing.Size(1195, 716);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VideoButton;
        private System.Windows.Forms.Button TrackButton;
        private System.Windows.Forms.Button FeaturesButton;
        private System.Windows.Forms.Button ChannelButton;
        private System.Windows.Forms.Button AlbumButton;
        private System.Windows.Forms.Button AudioButton;
    }
}
