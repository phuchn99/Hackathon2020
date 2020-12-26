namespace TATeam.WinformUI
{
    partial class MainGUI
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
            this.btnNewActivity = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnNewActivity
            // 
            this.btnNewActivity.Location = new System.Drawing.Point(12, 12);
            this.btnNewActivity.Name = "btnNewActivity";
            this.btnNewActivity.Size = new System.Drawing.Size(144, 45);
            this.btnNewActivity.TabIndex = 0;
            this.btnNewActivity.Text = "New Activity";
            this.btnNewActivity.UseVisualStyleBackColor = true;
            this.btnNewActivity.Click += new System.EventHandler(this.btnNewActivity_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlContent.Location = new System.Drawing.Point(12, 63);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(754, 369);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnNewActivity);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainGUI";
            this.Text = "Universal Teaching Course Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewActivity;
        private System.Windows.Forms.FlowLayoutPanel pnlContent;
    }
}

