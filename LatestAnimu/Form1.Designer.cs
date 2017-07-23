namespace LatestAnimu
{
    partial class Form1
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
            this.lvReleases = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvReleases
            // 
            this.lvReleases.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvReleases.Location = new System.Drawing.Point(42, 34);
            this.lvReleases.Name = "lvReleases";
            this.lvReleases.Size = new System.Drawing.Size(506, 388);
            this.lvReleases.TabIndex = 0;
            this.lvReleases.UseCompatibleStateImageBehavior = false;
            this.lvReleases.View = System.Windows.Forms.View.Details;
            this.lvReleases.DoubleClick += new System.EventHandler(this.lvReleases_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Latest Anime Releases";
            this.columnHeader1.Width = 234;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 458);
            this.Controls.Add(this.lvReleases);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvReleases;
        public System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

