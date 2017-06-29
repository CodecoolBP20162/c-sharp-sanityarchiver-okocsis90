namespace SanityArchiver
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
            this.searchBar = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.getIntoBtn = new System.Windows.Forms.Button();
            this.fileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.compressFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.fileSplitContainer)).BeginInit();
            this.fileSplitContainer.Panel1.SuspendLayout();
            this.fileSplitContainer.Panel2.SuspendLayout();
            this.fileSplitContainer.SuspendLayout();
            this.fileMenu.SuspendLayout();
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
            this.fileSplitContainer.Size = new System.Drawing.Size(785, 484);
            this.fileSplitContainer.SplitterDistance = 204;
            this.fileSplitContainer.TabIndex = 0;
            // 
            // filesTreeView
            // 
            this.filesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesTreeView.HideSelection = false;
            this.filesTreeView.ImageIndex = 0;
            this.filesTreeView.ImageList = this.filesImageList;
            this.filesTreeView.Location = new System.Drawing.Point(0, 0);
            this.filesTreeView.Name = "filesTreeView";
            this.filesTreeView.SelectedImageIndex = 0;
            this.filesTreeView.ShowRootLines = false;
            this.filesTreeView.Size = new System.Drawing.Size(204, 484);
            this.filesTreeView.TabIndex = 0;
            this.filesTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.filesTreeView_NodeMouseClick);
            // 
            // filesListView
            // 
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnType,
            this.columnLastModified,
            this.columnSize});
            this.filesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesListView.Location = new System.Drawing.Point(0, 0);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(577, 484);
            this.filesListView.SmallImageList = this.filesImageList;
            this.filesListView.TabIndex = 0;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            this.filesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filesListView_MouseClick);
            this.filesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filesListView_MouseDoubleClick);
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
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(59, 14);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(345, 20);
            this.searchBar.TabIndex = 1;
            this.searchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBar_KeyDown);
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(13, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(40, 23);
            this.backBtn.TabIndex = 2;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // getIntoBtn
            // 
            this.getIntoBtn.Location = new System.Drawing.Point(410, 11);
            this.getIntoBtn.Name = "getIntoBtn";
            this.getIntoBtn.Size = new System.Drawing.Size(75, 23);
            this.getIntoBtn.TabIndex = 4;
            this.getIntoBtn.Text = "Get into";
            this.getIntoBtn.UseVisualStyleBackColor = true;
            this.getIntoBtn.Click += new System.EventHandler(this.getIntoBtn_Click);
            // 
            // fileMenu
            // 
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compressFileToolStripMenuItem,
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(149, 70);
            // 
            // compressFileToolStripMenuItem
            // 
            this.compressFileToolStripMenuItem.Name = "compressFileToolStripMenuItem";
            this.compressFileToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.compressFileToolStripMenuItem.Text = "Compress File";
            this.compressFileToolStripMenuItem.Click += new System.EventHandler(this.compressFileToolStripMenuItem_Click);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // columnSize
            // 
            this.columnSize.Text = "Size";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 539);
            this.Controls.Add(this.getIntoBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.fileSplitContainer);
            this.Name = "MainWindow";
            this.Text = "Sanity Archiver Turbo 3000";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.fileSplitContainer.Panel1.ResumeLayout(false);
            this.fileSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSplitContainer)).EndInit();
            this.fileSplitContainer.ResumeLayout(false);
            this.fileMenu.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button getIntoBtn;
        private System.Windows.Forms.ContextMenuStrip fileMenu;
        private System.Windows.Forms.ToolStripMenuItem compressFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ColumnHeader columnSize;
    }
}

