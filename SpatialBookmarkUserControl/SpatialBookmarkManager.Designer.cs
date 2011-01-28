namespace TimmonsGroup
{
    partial class SpatialBookmarkManager
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
            this.lblBookmarkName = new System.Windows.Forms.Label();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblSpecifyBookmarkName = new System.Windows.Forms.Label();
            this.txtSpatialBookmarkName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoxSpatialBookmarks = new System.Windows.Forms.ListBox();
            this.saveFileDialogBookmarks = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblBookmarkName
            // 
            this.lblBookmarkName.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular);
            this.lblBookmarkName.Location = new System.Drawing.Point(4, 20);
            this.lblBookmarkName.Name = "lblBookmarkName";
            this.lblBookmarkName.Size = new System.Drawing.Size(128, 20);
            this.lblBookmarkName.Text = "Select a Bookmark";
            // 
            // btnZoom
            // 
            this.btnZoom.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.btnZoom.Location = new System.Drawing.Point(4, 194);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(72, 20);
            this.btnZoom.TabIndex = 2;
            this.btnZoom.Text = "Zoom To";
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Location = new System.Drawing.Point(82, 194);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(72, 20);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(160, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 20);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(82, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 20);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Location = new System.Drawing.Point(4, 220);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(72, 20);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblSpecifyBookmarkName
            // 
            this.lblSpecifyBookmarkName.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular);
            this.lblSpecifyBookmarkName.Location = new System.Drawing.Point(3, 144);
            this.lblSpecifyBookmarkName.Name = "lblSpecifyBookmarkName";
            this.lblSpecifyBookmarkName.Size = new System.Drawing.Size(194, 20);
            this.lblSpecifyBookmarkName.Text = "Specify Bookmark Name";
            // 
            // txtSpatialBookmarkName
            // 
            this.txtSpatialBookmarkName.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular);
            this.txtSpatialBookmarkName.Location = new System.Drawing.Point(4, 163);
            this.txtSpatialBookmarkName.Name = "txtSpatialBookmarkName";
            this.txtSpatialBookmarkName.Size = new System.Drawing.Size(228, 19);
            this.txtSpatialBookmarkName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.Text = "Bookmarks Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstBoxSpatialBookmarks
            // 
            this.lstBoxSpatialBookmarks.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular);
            this.lstBoxSpatialBookmarks.Location = new System.Drawing.Point(4, 44);
            this.lstBoxSpatialBookmarks.Name = "lstBoxSpatialBookmarks";
            this.lstBoxSpatialBookmarks.Size = new System.Drawing.Size(228, 93);
            this.lstBoxSpatialBookmarks.TabIndex = 14;
            // 
            // saveFileDialogBookmarks
            // 
            this.saveFileDialogBookmarks.Filter = "\"XML Files|*.xml\"";
            // 
            // SpatialBookmarkManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lstBoxSpatialBookmarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSpatialBookmarkName);
            this.Controls.Add(this.lblSpecifyBookmarkName);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.lblBookmarkName);
            this.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular);
            this.Name = "SpatialBookmarkManager";
            this.Size = new System.Drawing.Size(240, 245);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBookmarkName;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblSpecifyBookmarkName;
        private System.Windows.Forms.TextBox txtSpatialBookmarkName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxSpatialBookmarks;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBookmarks;
    }
}
