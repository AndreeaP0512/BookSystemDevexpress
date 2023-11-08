namespace BookSystemDevexpress
{
  partial class FrmAddEditBook
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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
      this.lookUpCategory = new DevExpress.XtraEditors.LookUpEdit();
      this.lookUpPublisher = new DevExpress.XtraEditors.LookUpEdit();
      this.lookUpAuthor = new DevExpress.XtraEditors.LookUpEdit();
      this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
      this.btnSave = new DevExpress.XtraEditors.SimpleButton();
      this.txtISBN = new DevExpress.XtraEditors.TextEdit();
      this.txtTitle = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
      this.dataLayoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpPublisher.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpAuthor.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtISBN.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Location = new System.Drawing.Point(283, 114);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new System.Drawing.Size(180, 120);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(180, 120);
      this.Root.TextVisible = false;
      // 
      // dataLayoutControl1
      // 
      this.dataLayoutControl1.Controls.Add(this.lookUpCategory);
      this.dataLayoutControl1.Controls.Add(this.lookUpPublisher);
      this.dataLayoutControl1.Controls.Add(this.lookUpAuthor);
      this.dataLayoutControl1.Controls.Add(this.btnCancel);
      this.dataLayoutControl1.Controls.Add(this.btnSave);
      this.dataLayoutControl1.Controls.Add(this.txtISBN);
      this.dataLayoutControl1.Controls.Add(this.txtTitle);
      this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
      this.dataLayoutControl1.Name = "dataLayoutControl1";
      this.dataLayoutControl1.Root = this.layoutControlGroup1;
      this.dataLayoutControl1.Size = new System.Drawing.Size(298, 268);
      this.dataLayoutControl1.TabIndex = 1;
      this.dataLayoutControl1.Text = "dataLayoutControl1";
      // 
      // lookUpCategory
      // 
      this.lookUpCategory.Location = new System.Drawing.Point(69, 108);
      this.lookUpCategory.Name = "lookUpCategory";
      this.lookUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpCategory.Properties.DisplayMember = "CategoryName";
      this.lookUpCategory.Properties.NullText = "";
      this.lookUpCategory.Properties.ValueMember = "CategoryId";
      this.lookUpCategory.Size = new System.Drawing.Size(217, 20);
      this.lookUpCategory.StyleController = this.dataLayoutControl1;
      this.lookUpCategory.TabIndex = 13;
      // 
      // lookUpPublisher
      // 
      this.lookUpPublisher.Location = new System.Drawing.Point(69, 84);
      this.lookUpPublisher.Name = "lookUpPublisher";
      this.lookUpPublisher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpPublisher.Properties.DisplayMember = "PublisherName";
      this.lookUpPublisher.Properties.NullText = "";
      this.lookUpPublisher.Properties.ValueMember = "PublisherId";
      this.lookUpPublisher.Size = new System.Drawing.Size(217, 20);
      this.lookUpPublisher.StyleController = this.dataLayoutControl1;
      this.lookUpPublisher.TabIndex = 12;
      // 
      // lookUpAuthor
      // 
      this.lookUpAuthor.Location = new System.Drawing.Point(69, 60);
      this.lookUpAuthor.Name = "lookUpAuthor";
      this.lookUpAuthor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lookUpAuthor.Properties.DisplayMember = "AuthorName";
      this.lookUpAuthor.Properties.NullText = "";
      this.lookUpAuthor.Properties.ValueMember = "AuthorId";
      this.lookUpAuthor.Size = new System.Drawing.Size(217, 20);
      this.lookUpAuthor.StyleController = this.dataLayoutControl1;
      this.lookUpAuthor.TabIndex = 11;
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(151, 234);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(135, 22);
      this.btnCancel.StyleController = this.dataLayoutControl1;
      this.btnCancel.TabIndex = 10;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(12, 234);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(135, 22);
      this.btnSave.StyleController = this.dataLayoutControl1;
      this.btnSave.TabIndex = 9;
      this.btnSave.Text = "Save";
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // txtISBN
      // 
      this.txtISBN.Location = new System.Drawing.Point(69, 36);
      this.txtISBN.Name = "txtISBN";
      this.txtISBN.Size = new System.Drawing.Size(217, 20);
      this.txtISBN.StyleController = this.dataLayoutControl1;
      this.txtISBN.TabIndex = 5;
      // 
      // txtTitle
      // 
      this.txtTitle.Location = new System.Drawing.Point(69, 12);
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Size = new System.Drawing.Size(217, 20);
      this.txtTitle.StyleController = this.dataLayoutControl1;
      this.txtTitle.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(298, 268);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.txtTitle;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(278, 24);
      this.layoutControlItem1.Text = "Title";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(0, 120);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(278, 102);
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.txtISBN;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(278, 24);
      this.layoutControlItem2.Text = "ISBN";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(45, 13);
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.btnCancel;
      this.layoutControlItem7.Location = new System.Drawing.Point(139, 222);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(139, 26);
      this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem7.TextVisible = false;
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.btnSave;
      this.layoutControlItem6.Location = new System.Drawing.Point(0, 222);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(139, 26);
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.lookUpAuthor;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(278, 24);
      this.layoutControlItem3.Text = "Author";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(45, 13);
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.lookUpPublisher;
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(278, 24);
      this.layoutControlItem4.Text = "Publisher";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(45, 13);
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.lookUpCategory;
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(278, 24);
      this.layoutControlItem5.Text = "Category";
      this.layoutControlItem5.TextSize = new System.Drawing.Size(45, 13);
      // 
      // FrmAddEditBook
      // 
      this.AcceptButton = this.btnSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(298, 268);
      this.Controls.Add(this.dataLayoutControl1);
      this.Controls.Add(this.layoutControl1);
      this.MaximizeBox = false;
      this.Name = "FrmAddEditBook";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Add Book";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
      this.dataLayoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.lookUpCategory.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpPublisher.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpAuthor.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtISBN.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.TextEdit txtISBN;
    private DevExpress.XtraEditors.TextEdit txtTitle;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.SimpleButton btnCancel;
    private DevExpress.XtraEditors.SimpleButton btnSave;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraEditors.LookUpEdit lookUpAuthor;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraEditors.LookUpEdit lookUpCategory;
    private DevExpress.XtraEditors.LookUpEdit lookUpPublisher;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
  }
}