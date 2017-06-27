﻿namespace SanityArchiver
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.filesImageList = new System.Windows.Forms.ImageList(this.components);
            this.fileSplitContainer = new System.Windows.Forms.SplitContainer();
            this.filesTreeView = new System.Windows.Forms.TreeView();
            this.filesListView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.fwdBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSplitContainer)).BeginInit();
            this.fileSplitContainer.Panel1.SuspendLayout();
            this.fileSplitContainer.Panel2.SuspendLayout();
            this.fileSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesImageList
            // 
            this.filesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("filesImageList.ImageStream")));
            this.filesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.filesImageList.Images.SetKeyName(0, "folder_icon.png");
            this.filesImageList.Images.SetKeyName(1, "file_icon.png");
            // 
            // fileSplitContainer
            // 
            this.fileSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSplitContainer.Location = new System.Drawing.Point(12, 43);
            this.fileSplitContainer.Name = "fileSplitContainer";
            // 
            // fileSplitContainer.Panel1
            // 
            this.fileSplitContainer.Panel1.Controls.Add(this.filesTreeView);
            // 
            // fileSplitContainer.Panel2
            // 
            this.fileSplitContainer.Panel2.Controls.Add(this.filesListView);
            this.fileSplitContainer.Size = new System.Drawing.Size(720, 436);
            this.fileSplitContainer.SplitterDistance = 188;
            this.fileSplitContainer.TabIndex = 0;
            // 
            // filesTreeView
            // 
            this.filesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesTreeView.ImageIndex = 0;
            this.filesTreeView.ImageList = this.filesImageList;
            this.filesTreeView.Location = new System.Drawing.Point(0, 0);
            this.filesTreeView.Name = "filesTreeView";
            this.filesTreeView.SelectedImageIndex = 0;
            this.filesTreeView.Size = new System.Drawing.Size(188, 436);
            this.filesTreeView.TabIndex = 0;
            this.filesTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.filesTreeView_NodeMouseClick);
            // 
            // filesListView
            // 
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnType,
            this.columnLastModified});
            this.filesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesListView.Location = new System.Drawing.Point(0, 0);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(528, 436);
            this.filesListView.SmallImageList = this.filesImageList;
            this.filesListView.TabIndex = 0;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            // 
            // columnLastModified
            // 
            this.columnLastModified.Text = "Last Modified";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 20);
            this.textBox1.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(13, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(40, 23);
            this.backBtn.TabIndex = 2;
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // fwdBtn
            // 
            this.fwdBtn.Image = ((System.Drawing.Image)(resources.GetObject("fwdBtn.Image")));
            this.fwdBtn.Location = new System.Drawing.Point(59, 12);
            this.fwdBtn.Name = "fwdBtn";
            this.fwdBtn.Size = new System.Drawing.Size(40, 23);
            this.fwdBtn.TabIndex = 3;
            this.fwdBtn.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 491);
            this.Controls.Add(this.fwdBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fileSplitContainer);
            this.Name = "MainWindow";
            this.Text = "Sanity Archiver Turbo 3000";
            this.fileSplitContainer.Panel1.ResumeLayout(false);
            this.fileSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSplitContainer)).EndInit();
            this.fileSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList filesImageList;
        private System.Windows.Forms.SplitContainer fileSplitContainer;
        private System.Windows.Forms.TreeView filesTreeView;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnLastModified;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button fwdBtn;
    }
}
