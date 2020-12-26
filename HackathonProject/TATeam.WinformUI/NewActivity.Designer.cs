namespace TATeam.WinformUI
{
    partial class NewActivity
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
            this.activitiesControl = new System.Windows.Forms.TabControl();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.txtVideoTitle = new System.Windows.Forms.TextBox();
            this.lblVideoTitle = new System.Windows.Forms.Label();
            this.btnSubmitVideo = new System.Windows.Forms.Button();
            this.lblVideoUrl = new System.Windows.Forms.Label();
            this.btnBrowseVideo = new System.Windows.Forms.Button();
            this.tabQuiz = new System.Windows.Forms.TabPage();
            this.txtTitleQuiz = new System.Windows.Forms.TextBox();
            this.lblTitleQuiz = new System.Windows.Forms.Label();
            this.btnSubmitQuiz = new System.Windows.Forms.Button();
            this.lblBrowseQuiz = new System.Windows.Forms.Label();
            this.btnBrowseQuiz = new System.Windows.Forms.Button();
            this.activitiesControl.SuspendLayout();
            this.tabVideo.SuspendLayout();
            this.tabQuiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // activitiesControl
            // 
            this.activitiesControl.Controls.Add(this.tabVideo);
            this.activitiesControl.Controls.Add(this.tabQuiz);
            this.activitiesControl.Location = new System.Drawing.Point(0, 1);
            this.activitiesControl.Name = "activitiesControl";
            this.activitiesControl.SelectedIndex = 0;
            this.activitiesControl.Size = new System.Drawing.Size(511, 269);
            this.activitiesControl.TabIndex = 0;
            // 
            // tabVideo
            // 
            this.tabVideo.Controls.Add(this.txtVideoTitle);
            this.tabVideo.Controls.Add(this.lblVideoTitle);
            this.tabVideo.Controls.Add(this.btnSubmitVideo);
            this.tabVideo.Controls.Add(this.lblVideoUrl);
            this.tabVideo.Controls.Add(this.btnBrowseVideo);
            this.tabVideo.Location = new System.Drawing.Point(4, 24);
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideo.Size = new System.Drawing.Size(503, 241);
            this.tabVideo.TabIndex = 0;
            this.tabVideo.Text = "Video";
            this.tabVideo.UseVisualStyleBackColor = true;
            this.tabVideo.UseWaitCursor = true;
            // 
            // txtVideoTitle
            // 
            this.txtVideoTitle.Location = new System.Drawing.Point(56, 14);
            this.txtVideoTitle.Name = "txtVideoTitle";
            this.txtVideoTitle.Size = new System.Drawing.Size(428, 21);
            this.txtVideoTitle.TabIndex = 4;
            this.txtVideoTitle.UseWaitCursor = true;
            // 
            // lblVideoTitle
            // 
            this.lblVideoTitle.AutoSize = true;
            this.lblVideoTitle.Location = new System.Drawing.Point(9, 17);
            this.lblVideoTitle.Name = "lblVideoTitle";
            this.lblVideoTitle.Size = new System.Drawing.Size(30, 15);
            this.lblVideoTitle.TabIndex = 3;
            this.lblVideoTitle.Text = "Title";
            this.lblVideoTitle.UseWaitCursor = true;
            // 
            // btnSubmitVideo
            // 
            this.btnSubmitVideo.Location = new System.Drawing.Point(364, 179);
            this.btnSubmitVideo.Name = "btnSubmitVideo";
            this.btnSubmitVideo.Size = new System.Drawing.Size(120, 46);
            this.btnSubmitVideo.TabIndex = 2;
            this.btnSubmitVideo.Text = "Submit";
            this.btnSubmitVideo.UseVisualStyleBackColor = true;
            this.btnSubmitVideo.UseWaitCursor = true;
            this.btnSubmitVideo.Click += new System.EventHandler(this.btnSubmitVideo_Click);
            // 
            // lblVideoUrl
            // 
            this.lblVideoUrl.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoUrl.Location = new System.Drawing.Point(120, 53);
            this.lblVideoUrl.Name = "lblVideoUrl";
            this.lblVideoUrl.Size = new System.Drawing.Size(364, 123);
            this.lblVideoUrl.TabIndex = 1;
            this.lblVideoUrl.Text = "Browse a video";
            this.lblVideoUrl.UseWaitCursor = true;
            this.lblVideoUrl.Click += new System.EventHandler(this.lblVideoUrl_Click);
            // 
            // btnBrowseVideo
            // 
            this.btnBrowseVideo.Location = new System.Drawing.Point(6, 50);
            this.btnBrowseVideo.Name = "btnBrowseVideo";
            this.btnBrowseVideo.Size = new System.Drawing.Size(108, 34);
            this.btnBrowseVideo.TabIndex = 0;
            this.btnBrowseVideo.Text = "Browse";
            this.btnBrowseVideo.UseVisualStyleBackColor = true;
            this.btnBrowseVideo.UseWaitCursor = true;
            this.btnBrowseVideo.Click += new System.EventHandler(this.btnBrowseVideo_Click);
            // 
            // tabQuiz
            // 
            this.tabQuiz.Controls.Add(this.txtTitleQuiz);
            this.tabQuiz.Controls.Add(this.lblTitleQuiz);
            this.tabQuiz.Controls.Add(this.btnSubmitQuiz);
            this.tabQuiz.Controls.Add(this.lblBrowseQuiz);
            this.tabQuiz.Controls.Add(this.btnBrowseQuiz);
            this.tabQuiz.Location = new System.Drawing.Point(4, 24);
            this.tabQuiz.Name = "tabQuiz";
            this.tabQuiz.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuiz.Size = new System.Drawing.Size(503, 241);
            this.tabQuiz.TabIndex = 1;
            this.tabQuiz.Text = "Quiz";
            this.tabQuiz.UseVisualStyleBackColor = true;
            // 
            // txtTitleQuiz
            // 
            this.txtTitleQuiz.Location = new System.Drawing.Point(62, 13);
            this.txtTitleQuiz.Name = "txtTitleQuiz";
            this.txtTitleQuiz.Size = new System.Drawing.Size(428, 21);
            this.txtTitleQuiz.TabIndex = 9;
            this.txtTitleQuiz.UseWaitCursor = true;
            // 
            // lblTitleQuiz
            // 
            this.lblTitleQuiz.AutoSize = true;
            this.lblTitleQuiz.Location = new System.Drawing.Point(15, 16);
            this.lblTitleQuiz.Name = "lblTitleQuiz";
            this.lblTitleQuiz.Size = new System.Drawing.Size(30, 15);
            this.lblTitleQuiz.TabIndex = 8;
            this.lblTitleQuiz.Text = "Title";
            this.lblTitleQuiz.UseWaitCursor = true;
            // 
            // btnSubmitQuiz
            // 
            this.btnSubmitQuiz.Location = new System.Drawing.Point(370, 178);
            this.btnSubmitQuiz.Name = "btnSubmitQuiz";
            this.btnSubmitQuiz.Size = new System.Drawing.Size(120, 46);
            this.btnSubmitQuiz.TabIndex = 7;
            this.btnSubmitQuiz.Text = "Submit";
            this.btnSubmitQuiz.UseVisualStyleBackColor = true;
            this.btnSubmitQuiz.UseWaitCursor = true;
            this.btnSubmitQuiz.Click += new System.EventHandler(this.btnSubmitQuiz_Click);
            // 
            // lblBrowseQuiz
            // 
            this.lblBrowseQuiz.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowseQuiz.Location = new System.Drawing.Point(126, 52);
            this.lblBrowseQuiz.Name = "lblBrowseQuiz";
            this.lblBrowseQuiz.Size = new System.Drawing.Size(364, 123);
            this.lblBrowseQuiz.TabIndex = 6;
            this.lblBrowseQuiz.Text = "Browse a file";
            this.lblBrowseQuiz.UseWaitCursor = true;
            this.lblBrowseQuiz.Click += new System.EventHandler(this.lblBrowseQuiz_Click);
            // 
            // btnBrowseQuiz
            // 
            this.btnBrowseQuiz.Location = new System.Drawing.Point(12, 49);
            this.btnBrowseQuiz.Name = "btnBrowseQuiz";
            this.btnBrowseQuiz.Size = new System.Drawing.Size(108, 34);
            this.btnBrowseQuiz.TabIndex = 5;
            this.btnBrowseQuiz.Text = "Browse";
            this.btnBrowseQuiz.UseVisualStyleBackColor = true;
            this.btnBrowseQuiz.UseWaitCursor = true;
            this.btnBrowseQuiz.Click += new System.EventHandler(this.btnBrowseQuiz_Click);
            // 
            // NewActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 267);
            this.Controls.Add(this.activitiesControl);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NewActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Activity";
            this.activitiesControl.ResumeLayout(false);
            this.tabVideo.ResumeLayout(false);
            this.tabVideo.PerformLayout();
            this.tabQuiz.ResumeLayout(false);
            this.tabQuiz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl activitiesControl;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.Label lblVideoUrl;
        private System.Windows.Forms.Button btnBrowseVideo;
        private System.Windows.Forms.TabPage tabQuiz;
        private System.Windows.Forms.TextBox txtVideoTitle;
        private System.Windows.Forms.Label lblVideoTitle;
        private System.Windows.Forms.Button btnSubmitVideo;
        private System.Windows.Forms.TextBox txtTitleQuiz;
        private System.Windows.Forms.Label lblTitleQuiz;
        private System.Windows.Forms.Button btnSubmitQuiz;
        private System.Windows.Forms.Label lblBrowseQuiz;
        private System.Windows.Forms.Button btnBrowseQuiz;
    }
}