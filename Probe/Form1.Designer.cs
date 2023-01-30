namespace Probe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl_navigation = new System.Windows.Forms.TabControl();
            this.tabPage_home = new System.Windows.Forms.TabPage();
            this.button_vivaldi = new System.Windows.Forms.Button();
            this.imageList_browserLogo = new System.Windows.Forms.ImageList(this.components);
            this.button_opera = new System.Windows.Forms.Button();
            this.button_firefox = new System.Windows.Forms.Button();
            this.button_edge = new System.Windows.Forms.Button();
            this.button_chrome = new System.Windows.Forms.Button();
            this.button_brave = new System.Windows.Forms.Button();
            this.button_selectDefault = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_mostVisited = new System.Windows.Forms.TabPage();
            this.panel_mostVisited_result1 = new System.Windows.Forms.Panel();
            this.label_mostVisited_result1_lastVisit = new System.Windows.Forms.Label();
            this.label_mostVisited_result1_count = new System.Windows.Forms.Label();
            this.linkLabel_mostVisited_result1_url = new System.Windows.Forms.LinkLabel();
            this.label_mostVisited_result1_title = new System.Windows.Forms.Label();
            this.pictureBox_mostVisited_favicon = new System.Windows.Forms.PictureBox();
            this.tabPage_socialMedia = new System.Windows.Forms.TabPage();
            this.tabPage_timeSpent = new System.Windows.Forms.TabPage();
            this.tabPage_dataUsage = new System.Windows.Forms.TabPage();
            this.tabControl_navigation.SuspendLayout();
            this.tabPage_home.SuspendLayout();
            this.tabPage_mostVisited.SuspendLayout();
            this.panel_mostVisited_result1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mostVisited_favicon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_navigation
            // 
            this.tabControl_navigation.Controls.Add(this.tabPage_home);
            this.tabControl_navigation.Controls.Add(this.tabPage_mostVisited);
            this.tabControl_navigation.Controls.Add(this.tabPage_socialMedia);
            this.tabControl_navigation.Controls.Add(this.tabPage_timeSpent);
            this.tabControl_navigation.Controls.Add(this.tabPage_dataUsage);
            this.tabControl_navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_navigation.Font = new System.Drawing.Font("Open Sauce Two", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_navigation.HotTrack = true;
            this.tabControl_navigation.Location = new System.Drawing.Point(0, 0);
            this.tabControl_navigation.Multiline = true;
            this.tabControl_navigation.Name = "tabControl_navigation";
            this.tabControl_navigation.Padding = new System.Drawing.Point(16, 5);
            this.tabControl_navigation.SelectedIndex = 0;
            this.tabControl_navigation.Size = new System.Drawing.Size(1008, 681);
            this.tabControl_navigation.TabIndex = 0;
            this.tabControl_navigation.TabStop = false;
            // 
            // tabPage_home
            // 
            this.tabPage_home.BackColor = System.Drawing.Color.White;
            this.tabPage_home.Controls.Add(this.button_vivaldi);
            this.tabPage_home.Controls.Add(this.button_opera);
            this.tabPage_home.Controls.Add(this.button_firefox);
            this.tabPage_home.Controls.Add(this.button_edge);
            this.tabPage_home.Controls.Add(this.button_chrome);
            this.tabPage_home.Controls.Add(this.button_brave);
            this.tabPage_home.Controls.Add(this.button_selectDefault);
            this.tabPage_home.Controls.Add(this.label3);
            this.tabPage_home.Controls.Add(this.label2);
            this.tabPage_home.Controls.Add(this.label1);
            this.tabPage_home.Location = new System.Drawing.Point(4, 28);
            this.tabPage_home.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage_home.Name = "tabPage_home";
            this.tabPage_home.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_home.Size = new System.Drawing.Size(1000, 649);
            this.tabPage_home.TabIndex = 0;
            this.tabPage_home.Text = "Home";
            // 
            // button_vivaldi
            // 
            this.button_vivaldi.BackColor = System.Drawing.Color.Transparent;
            this.button_vivaldi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button_vivaldi.ImageIndex = 5;
            this.button_vivaldi.ImageList = this.imageList_browserLogo;
            this.button_vivaldi.Location = new System.Drawing.Point(560, 391);
            this.button_vivaldi.Name = "button_vivaldi";
            this.button_vivaldi.Size = new System.Drawing.Size(64, 64);
            this.button_vivaldi.TabIndex = 2;
            this.button_vivaldi.TabStop = false;
            this.button_vivaldi.UseVisualStyleBackColor = false;
            this.button_vivaldi.Click += new System.EventHandler(this.button_vivaldi_Click);
            // 
            // imageList_browserLogo
            // 
            this.imageList_browserLogo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_browserLogo.ImageStream")));
            this.imageList_browserLogo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_browserLogo.Images.SetKeyName(0, "brave_logo.png");
            this.imageList_browserLogo.Images.SetKeyName(1, "chrome_logo.png");
            this.imageList_browserLogo.Images.SetKeyName(2, "edge_logo.png");
            this.imageList_browserLogo.Images.SetKeyName(3, "Firefox_logo.png");
            this.imageList_browserLogo.Images.SetKeyName(4, "opera_logo.png");
            this.imageList_browserLogo.Images.SetKeyName(5, "vivaldi_logo.png");
            // 
            // button_opera
            // 
            this.button_opera.BackColor = System.Drawing.Color.Transparent;
            this.button_opera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button_opera.ImageIndex = 4;
            this.button_opera.ImageList = this.imageList_browserLogo;
            this.button_opera.Location = new System.Drawing.Point(479, 391);
            this.button_opera.Name = "button_opera";
            this.button_opera.Size = new System.Drawing.Size(64, 64);
            this.button_opera.TabIndex = 2;
            this.button_opera.TabStop = false;
            this.button_opera.UseVisualStyleBackColor = false;
            this.button_opera.Click += new System.EventHandler(this.button_opera_Click);
            // 
            // button_firefox
            // 
            this.button_firefox.BackColor = System.Drawing.Color.Transparent;
            this.button_firefox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button_firefox.ImageIndex = 3;
            this.button_firefox.ImageList = this.imageList_browserLogo;
            this.button_firefox.Location = new System.Drawing.Point(398, 391);
            this.button_firefox.Name = "button_firefox";
            this.button_firefox.Size = new System.Drawing.Size(64, 64);
            this.button_firefox.TabIndex = 2;
            this.button_firefox.TabStop = false;
            this.button_firefox.UseVisualStyleBackColor = false;
            this.button_firefox.Click += new System.EventHandler(this.button_firefox_Click);
            // 
            // button_edge
            // 
            this.button_edge.BackColor = System.Drawing.Color.Transparent;
            this.button_edge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button_edge.ImageIndex = 2;
            this.button_edge.ImageList = this.imageList_browserLogo;
            this.button_edge.Location = new System.Drawing.Point(560, 314);
            this.button_edge.Name = "button_edge";
            this.button_edge.Size = new System.Drawing.Size(64, 64);
            this.button_edge.TabIndex = 2;
            this.button_edge.TabStop = false;
            this.button_edge.UseVisualStyleBackColor = false;
            this.button_edge.Click += new System.EventHandler(this.button_edge_Click);
            // 
            // button_chrome
            // 
            this.button_chrome.BackColor = System.Drawing.Color.Transparent;
            this.button_chrome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button_chrome.ImageIndex = 1;
            this.button_chrome.ImageList = this.imageList_browserLogo;
            this.button_chrome.Location = new System.Drawing.Point(479, 314);
            this.button_chrome.Name = "button_chrome";
            this.button_chrome.Size = new System.Drawing.Size(64, 64);
            this.button_chrome.TabIndex = 2;
            this.button_chrome.TabStop = false;
            this.button_chrome.UseVisualStyleBackColor = false;
            this.button_chrome.Click += new System.EventHandler(this.button_chrome_Click);
            // 
            // button_brave
            // 
            this.button_brave.BackColor = System.Drawing.Color.Transparent;
            this.button_brave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button_brave.ImageIndex = 0;
            this.button_brave.ImageList = this.imageList_browserLogo;
            this.button_brave.Location = new System.Drawing.Point(398, 314);
            this.button_brave.Name = "button_brave";
            this.button_brave.Size = new System.Drawing.Size(64, 64);
            this.button_brave.TabIndex = 2;
            this.button_brave.TabStop = false;
            this.button_brave.UseVisualStyleBackColor = false;
            this.button_brave.Click += new System.EventHandler(this.button_brave_Click);
            // 
            // button_selectDefault
            // 
            this.button_selectDefault.BackColor = System.Drawing.Color.Transparent;
            this.button_selectDefault.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.button_selectDefault.ImageList = this.imageList_browserLogo;
            this.button_selectDefault.Location = new System.Drawing.Point(398, 220);
            this.button_selectDefault.Name = "button_selectDefault";
            this.button_selectDefault.Size = new System.Drawing.Size(64, 64);
            this.button_selectDefault.TabIndex = 2;
            this.button_selectDefault.TabStop = false;
            this.button_selectDefault.UseVisualStyleBackColor = false;
            this.button_selectDefault.Click += new System.EventHandler(this.button_selectDefault_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sauce Two", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(395, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Other supported browsers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sauce Two", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(392, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Default browser:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sauce Two", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(222, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a browser:";
            // 
            // tabPage_mostVisited
            // 
            this.tabPage_mostVisited.BackColor = System.Drawing.Color.White;
            this.tabPage_mostVisited.Controls.Add(this.panel_mostVisited_result1);
            this.tabPage_mostVisited.Location = new System.Drawing.Point(4, 28);
            this.tabPage_mostVisited.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage_mostVisited.Name = "tabPage_mostVisited";
            this.tabPage_mostVisited.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_mostVisited.Size = new System.Drawing.Size(1000, 649);
            this.tabPage_mostVisited.TabIndex = 1;
            this.tabPage_mostVisited.Text = "Most Visited";
            // 
            // panel_mostVisited_result1
            // 
            this.panel_mostVisited_result1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_mostVisited_result1.Controls.Add(this.label_mostVisited_result1_lastVisit);
            this.panel_mostVisited_result1.Controls.Add(this.label_mostVisited_result1_count);
            this.panel_mostVisited_result1.Controls.Add(this.linkLabel_mostVisited_result1_url);
            this.panel_mostVisited_result1.Controls.Add(this.label_mostVisited_result1_title);
            this.panel_mostVisited_result1.Controls.Add(this.pictureBox_mostVisited_favicon);
            this.panel_mostVisited_result1.Location = new System.Drawing.Point(8, 6);
            this.panel_mostVisited_result1.Name = "panel_mostVisited_result1";
            this.panel_mostVisited_result1.Size = new System.Drawing.Size(300, 80);
            this.panel_mostVisited_result1.TabIndex = 0;
            // 
            // label_mostVisited_result1_lastVisit
            // 
            this.label_mostVisited_result1_lastVisit.AutoSize = true;
            this.label_mostVisited_result1_lastVisit.Location = new System.Drawing.Point(68, 54);
            this.label_mostVisited_result1_lastVisit.Name = "label_mostVisited_result1_lastVisit";
            this.label_mostVisited_result1_lastVisit.Size = new System.Drawing.Size(53, 15);
            this.label_mostVisited_result1_lastVisit.TabIndex = 3;
            this.label_mostVisited_result1_lastVisit.Text = "lastVisit";
            this.label_mostVisited_result1_lastVisit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_mostVisited_result1_count
            // 
            this.label_mostVisited_result1_count.AutoSize = true;
            this.label_mostVisited_result1_count.Location = new System.Drawing.Point(68, 41);
            this.label_mostVisited_result1_count.Name = "label_mostVisited_result1_count";
            this.label_mostVisited_result1_count.Size = new System.Drawing.Size(40, 15);
            this.label_mostVisited_result1_count.TabIndex = 3;
            this.label_mostVisited_result1_count.Text = "count";
            this.label_mostVisited_result1_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel_mostVisited_result1_url
            // 
            this.linkLabel_mostVisited_result1_url.AutoSize = true;
            this.linkLabel_mostVisited_result1_url.Location = new System.Drawing.Point(68, 28);
            this.linkLabel_mostVisited_result1_url.Name = "linkLabel_mostVisited_result1_url";
            this.linkLabel_mostVisited_result1_url.Size = new System.Drawing.Size(21, 15);
            this.linkLabel_mostVisited_result1_url.TabIndex = 2;
            this.linkLabel_mostVisited_result1_url.TabStop = true;
            this.linkLabel_mostVisited_result1_url.Text = "url";
            this.linkLabel_mostVisited_result1_url.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_mostVisited_result1_title
            // 
            this.label_mostVisited_result1_title.AutoSize = true;
            this.label_mostVisited_result1_title.Location = new System.Drawing.Point(68, 15);
            this.label_mostVisited_result1_title.Name = "label_mostVisited_result1_title";
            this.label_mostVisited_result1_title.Size = new System.Drawing.Size(29, 15);
            this.label_mostVisited_result1_title.TabIndex = 1;
            this.label_mostVisited_result1_title.Text = "title";
            this.label_mostVisited_result1_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_mostVisited_favicon
            // 
            this.pictureBox_mostVisited_favicon.Location = new System.Drawing.Point(14, 15);
            this.pictureBox_mostVisited_favicon.Name = "pictureBox_mostVisited_favicon";
            this.pictureBox_mostVisited_favicon.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_mostVisited_favicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_mostVisited_favicon.TabIndex = 0;
            this.pictureBox_mostVisited_favicon.TabStop = false;
            // 
            // tabPage_socialMedia
            // 
            this.tabPage_socialMedia.Location = new System.Drawing.Point(4, 28);
            this.tabPage_socialMedia.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage_socialMedia.Name = "tabPage_socialMedia";
            this.tabPage_socialMedia.Size = new System.Drawing.Size(1017, 656);
            this.tabPage_socialMedia.TabIndex = 2;
            this.tabPage_socialMedia.Text = "Social Media";
            this.tabPage_socialMedia.UseVisualStyleBackColor = true;
            // 
            // tabPage_timeSpent
            // 
            this.tabPage_timeSpent.Location = new System.Drawing.Point(4, 28);
            this.tabPage_timeSpent.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage_timeSpent.Name = "tabPage_timeSpent";
            this.tabPage_timeSpent.Size = new System.Drawing.Size(1017, 656);
            this.tabPage_timeSpent.TabIndex = 3;
            this.tabPage_timeSpent.Text = "Time Spent";
            this.tabPage_timeSpent.UseVisualStyleBackColor = true;
            // 
            // tabPage_dataUsage
            // 
            this.tabPage_dataUsage.Location = new System.Drawing.Point(4, 28);
            this.tabPage_dataUsage.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage_dataUsage.Name = "tabPage_dataUsage";
            this.tabPage_dataUsage.Size = new System.Drawing.Size(1017, 656);
            this.tabPage_dataUsage.TabIndex = 4;
            this.tabPage_dataUsage.Text = "Data Usage";
            this.tabPage_dataUsage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.tabControl_navigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Probe - Web browser insights";
            this.tabControl_navigation.ResumeLayout(false);
            this.tabPage_home.ResumeLayout(false);
            this.tabPage_home.PerformLayout();
            this.tabPage_mostVisited.ResumeLayout(false);
            this.panel_mostVisited_result1.ResumeLayout(false);
            this.panel_mostVisited_result1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mostVisited_favicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_navigation;
        private System.Windows.Forms.TabPage tabPage_home;
        private System.Windows.Forms.TabPage tabPage_mostVisited;
        private System.Windows.Forms.TabPage tabPage_socialMedia;
        private System.Windows.Forms.TabPage tabPage_timeSpent;
        private System.Windows.Forms.TabPage tabPage_dataUsage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_vivaldi;
        private System.Windows.Forms.Button button_opera;
        private System.Windows.Forms.Button button_firefox;
        private System.Windows.Forms.Button button_edge;
        private System.Windows.Forms.Button button_chrome;
        private System.Windows.Forms.Button button_brave;
        private System.Windows.Forms.Button button_selectDefault;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ImageList imageList_browserLogo;
        private System.Windows.Forms.Panel panel_mostVisited_result1;
        private System.Windows.Forms.Label label_mostVisited_result1_title;
        private System.Windows.Forms.PictureBox pictureBox_mostVisited_favicon;
        private System.Windows.Forms.Label label_mostVisited_result1_count;
        private System.Windows.Forms.LinkLabel linkLabel_mostVisited_result1_url;
        private System.Windows.Forms.Label label_mostVisited_result1_lastVisit;
    }
}

