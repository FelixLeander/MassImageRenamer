namespace MassImageSorter;

partial class MassImageSorter
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.textBoxPath = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.pictureBoxMain = new System.Windows.Forms.PictureBox();
        this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        this.label2 = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.buttonRenameFile = new System.Windows.Forms.Button();
        this.buttonSkipRename = new System.Windows.Forms.Button();
        this.labelFileExtension = new System.Windows.Forms.Label();
        this.buttonBrowseFolder = new System.Windows.Forms.Button();
        this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        this.listBoxImageFiles = new System.Windows.Forms.ListBox();
        this.labelListTop = new System.Windows.Forms.Label();
        this.splitter1 = new System.Windows.Forms.Splitter();
        this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.splitter2 = new System.Windows.Forms.Splitter();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
        this.tableLayoutPanel2.SuspendLayout();
        this.tableLayoutPanel3.SuspendLayout();
        this.tableLayoutPanel4.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // textBoxPath
        // 
        this.textBoxPath.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textBoxPath.Location = new System.Drawing.Point(152, 3);
        this.textBoxPath.Name = "textBoxPath";
        this.textBoxPath.Size = new System.Drawing.Size(461, 23);
        this.textBoxPath.TabIndex = 0;
        this.textBoxPath.TextChanged += new System.EventHandler(this.TextBoxPath_TextChanged);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.label1.Location = new System.Drawing.Point(3, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(143, 29);
        this.label1.TabIndex = 1;
        this.label1.Text = "Folder Containing Images";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBoxMain
        // 
        this.pictureBoxMain.BackColor = System.Drawing.Color.Silver;
        this.pictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.tableLayoutPanel4.SetColumnSpan(this.pictureBoxMain, 3);
        this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pictureBoxMain.Location = new System.Drawing.Point(3, 32);
        this.pictureBoxMain.Name = "pictureBoxMain";
        this.pictureBoxMain.Size = new System.Drawing.Size(691, 603);
        this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pictureBoxMain.TabIndex = 4;
        this.pictureBoxMain.TabStop = false;
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.AutoSize = true;
        this.tableLayoutPanel2.ColumnCount = 5;
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
        this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
        this.tableLayoutPanel2.Controls.Add(this.buttonRenameFile, 2, 1);
        this.tableLayoutPanel2.Controls.Add(this.buttonSkipRename, 1, 1);
        this.tableLayoutPanel2.Controls.Add(this.labelFileExtension, 3, 0);
        this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 194);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 4;
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel2.Size = new System.Drawing.Size(326, 58);
        this.tableLayoutPanel2.TabIndex = 6;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.label2.Location = new System.Drawing.Point(3, 0);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(67, 29);
        this.label2.TabIndex = 2;
        this.label2.Text = "Rename to:";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // textBox1
        // 
        this.tableLayoutPanel2.SetColumnSpan(this.textBox1, 2);
        this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textBox1.Location = new System.Drawing.Point(76, 3);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(176, 23);
        this.textBox1.TabIndex = 0;
        // 
        // buttonRenameFile
        // 
        this.buttonRenameFile.Dock = System.Windows.Forms.DockStyle.Fill;
        this.buttonRenameFile.Location = new System.Drawing.Point(157, 32);
        this.buttonRenameFile.Name = "buttonRenameFile";
        this.buttonRenameFile.Size = new System.Drawing.Size(95, 23);
        this.buttonRenameFile.TabIndex = 4;
        this.buttonRenameFile.Text = "Rename File";
        this.buttonRenameFile.UseVisualStyleBackColor = true;
        this.buttonRenameFile.Click += new System.EventHandler(this.ButtonRenameFile_Click);
        // 
        // buttonSkipRename
        // 
        this.buttonSkipRename.Dock = System.Windows.Forms.DockStyle.Fill;
        this.buttonSkipRename.Location = new System.Drawing.Point(76, 32);
        this.buttonSkipRename.Name = "buttonSkipRename";
        this.buttonSkipRename.Size = new System.Drawing.Size(75, 23);
        this.buttonSkipRename.TabIndex = 3;
        this.buttonSkipRename.Text = "Skip Rename";
        this.buttonSkipRename.UseVisualStyleBackColor = true;
        this.buttonSkipRename.Click += new System.EventHandler(this.ButtonSkipRename_Click);
        // 
        // labelFileExtension
        // 
        this.labelFileExtension.AutoSize = true;
        this.labelFileExtension.Dock = System.Windows.Forms.DockStyle.Left;
        this.labelFileExtension.Location = new System.Drawing.Point(258, 0);
        this.labelFileExtension.Name = "labelFileExtension";
        this.labelFileExtension.Size = new System.Drawing.Size(61, 29);
        this.labelFileExtension.TabIndex = 5;
        this.labelFileExtension.Text = ".extension";
        this.labelFileExtension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // buttonBrowseFolder
        // 
        this.buttonBrowseFolder.Dock = System.Windows.Forms.DockStyle.Fill;
        this.buttonBrowseFolder.Location = new System.Drawing.Point(619, 3);
        this.buttonBrowseFolder.Name = "buttonBrowseFolder";
        this.buttonBrowseFolder.Size = new System.Drawing.Size(75, 23);
        this.buttonBrowseFolder.TabIndex = 2;
        this.buttonBrowseFolder.Text = "Browse";
        this.buttonBrowseFolder.UseVisualStyleBackColor = true;
        this.buttonBrowseFolder.Click += new System.EventHandler(this.ButtonBrowseFolder_Click);
        // 
        // tableLayoutPanel3
        // 
        this.tableLayoutPanel3.BackColor = System.Drawing.Color.DarkGray;
        this.tableLayoutPanel3.ColumnCount = 1;
        this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel3.Controls.Add(this.listBoxImageFiles, 0, 1);
        this.tableLayoutPanel3.Controls.Add(this.labelListTop, 0, 0);
        this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
        this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel3.Name = "tableLayoutPanel3";
        this.tableLayoutPanel3.RowCount = 2;
        this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 638);
        this.tableLayoutPanel3.TabIndex = 2;
        // 
        // listBoxImageFiles
        // 
        this.listBoxImageFiles.Dock = System.Windows.Forms.DockStyle.Fill;
        this.listBoxImageFiles.FormattingEnabled = true;
        this.listBoxImageFiles.HorizontalScrollbar = true;
        this.listBoxImageFiles.ItemHeight = 15;
        this.listBoxImageFiles.Location = new System.Drawing.Point(3, 18);
        this.listBoxImageFiles.Name = "listBoxImageFiles";
        this.listBoxImageFiles.Size = new System.Drawing.Size(194, 617);
        this.listBoxImageFiles.TabIndex = 3;
        this.listBoxImageFiles.SelectedValueChanged += new System.EventHandler(this.ListBoxImageFiles_SelectedValueChanged);
        // 
        // labelListTop
        // 
        this.labelListTop.AutoSize = true;
        this.labelListTop.Dock = System.Windows.Forms.DockStyle.Fill;
        this.labelListTop.Location = new System.Drawing.Point(3, 0);
        this.labelListTop.Name = "labelListTop";
        this.labelListTop.Size = new System.Drawing.Size(194, 15);
        this.labelListTop.TabIndex = 7;
        this.labelListTop.Text = "Found image Files";
        this.labelListTop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        // 
        // splitter1
        // 
        this.splitter1.BackColor = System.Drawing.Color.Black;
        this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.splitter1.Location = new System.Drawing.Point(200, 0);
        this.splitter1.Name = "splitter1";
        this.splitter1.Size = new System.Drawing.Size(8, 638);
        this.splitter1.TabIndex = 3;
        this.splitter1.TabStop = false;
        // 
        // tableLayoutPanel4
        // 
        this.tableLayoutPanel4.ColumnCount = 4;
        this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
        this.tableLayoutPanel4.Controls.Add(this.textBoxPath, 1, 0);
        this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
        this.tableLayoutPanel4.Controls.Add(this.buttonBrowseFolder, 2, 0);
        this.tableLayoutPanel4.Controls.Add(this.pictureBoxMain, 0, 1);
        this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel4.Location = new System.Drawing.Point(208, 0);
        this.tableLayoutPanel4.Name = "tableLayoutPanel4";
        this.tableLayoutPanel4.RowCount = 2;
        this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel4.Size = new System.Drawing.Size(701, 638);
        this.tableLayoutPanel4.TabIndex = 4;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
        this.tableLayoutPanel1.ColumnCount = 1;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(909, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 3;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 638);
        this.tableLayoutPanel1.TabIndex = 7;
        // 
        // pictureBox1
        // 
        this.pictureBox1.BackColor = System.Drawing.Color.Silver;
        this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pictureBox1.Location = new System.Drawing.Point(3, 3);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(326, 185);
        this.pictureBox1.TabIndex = 7;
        this.pictureBox1.TabStop = false;
        // 
        // splitter2
        // 
        this.splitter2.BackColor = System.Drawing.Color.Black;
        this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
        this.splitter2.Location = new System.Drawing.Point(901, 0);
        this.splitter2.Name = "splitter2";
        this.splitter2.Size = new System.Drawing.Size(8, 638);
        this.splitter2.TabIndex = 8;
        this.splitter2.TabStop = false;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.Gainsboro;
        this.ClientSize = new System.Drawing.Size(1241, 638);
        this.Controls.Add(this.splitter2);
        this.Controls.Add(this.tableLayoutPanel4);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Controls.Add(this.splitter1);
        this.Controls.Add(this.tableLayoutPanel3);
        this.Name = "Form1";
        this.Text = "Form1";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
        this.tableLayoutPanel2.ResumeLayout(false);
        this.tableLayoutPanel2.PerformLayout();
        this.tableLayoutPanel3.ResumeLayout(false);
        this.tableLayoutPanel3.PerformLayout();
        this.tableLayoutPanel4.ResumeLayout(false);
        this.tableLayoutPanel4.PerformLayout();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private TextBox textBoxPath;
    private Label label1;
    private Button buttonBrowseFolder;
    private PictureBox pictureBoxMain;
    private TableLayoutPanel tableLayoutPanel2;
    private Label label2;
    private TextBox textBox1;
    private Button buttonRenameFile;
    private Button buttonSkipRename;
    private Label labelFileExtension;
    private TableLayoutPanel tableLayoutPanel4;
    private TableLayoutPanel tableLayoutPanel1;
    private PictureBox pictureBox1;
    private TableLayoutPanel tableLayoutPanel3;
    private ListBox listBoxImageFiles;
    private Label labelListTop;
    private Splitter splitter1;
    private Splitter splitter2;
}