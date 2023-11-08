namespace BookSystemDevexpress
{
  partial class FrmBookSystem
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
      this.gridBooks = new DevExpress.XtraGrid.GridControl();
      this.viewBooks = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colISBN = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPublisher = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
      this.bookDS = new BookSystemDevexpress.BookDataSet();
      this.btnAddBook = new DevExpress.XtraEditors.SimpleButton();
      this.btnEditBook = new DevExpress.XtraEditors.SimpleButton();
      this.btnSave = new DevExpress.XtraEditors.SimpleButton();
      this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewBooks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bookDS)).BeginInit();
      this.SuspendLayout();
      // 
      // gridBooks
      // 
      this.gridBooks.Location = new System.Drawing.Point(12, 37);
      this.gridBooks.MainView = this.viewBooks;
      this.gridBooks.Name = "gridBooks";
      this.gridBooks.Size = new System.Drawing.Size(776, 401);
      this.gridBooks.TabIndex = 0;
      this.gridBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewBooks});
      // 
      // viewBooks
      // 
      this.viewBooks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTitle,
            this.colISBN,
            this.colAuthor,
            this.colPublisher,
            this.colCategory});
      this.viewBooks.GridControl = this.gridBooks;
      this.viewBooks.Name = "viewBooks";
      this.viewBooks.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.viewBooks_CustomUnboundColumnData);
      // 
      // colTitle
      // 
      this.colTitle.Caption = "Title";
      this.colTitle.FieldName = "Title";
      this.colTitle.Name = "colTitle";
      this.colTitle.Visible = true;
      this.colTitle.VisibleIndex = 0;
      // 
      // colISBN
      // 
      this.colISBN.Caption = "ISBN";
      this.colISBN.FieldName = "ISBN";
      this.colISBN.Name = "colISBN";
      this.colISBN.Visible = true;
      this.colISBN.VisibleIndex = 1;
      // 
      // colAuthor
      // 
      this.colAuthor.Caption = "Author";
      this.colAuthor.FieldName = "AuthorName";
      this.colAuthor.Name = "colAuthor";
      this.colAuthor.UnboundDataType = typeof(string);
      this.colAuthor.Visible = true;
      this.colAuthor.VisibleIndex = 2;
      // 
      // colPublisher
      // 
      this.colPublisher.Caption = "Publisher";
      this.colPublisher.FieldName = "PublisherName";
      this.colPublisher.Name = "colPublisher";
      this.colPublisher.UnboundDataType = typeof(string);
      this.colPublisher.Visible = true;
      this.colPublisher.VisibleIndex = 3;
      // 
      // colCategory
      // 
      this.colCategory.Caption = "Category";
      this.colCategory.FieldName = "CategoryName";
      this.colCategory.Name = "colCategory";
      this.colCategory.UnboundDataType = typeof(string);
      this.colCategory.Visible = true;
      this.colCategory.VisibleIndex = 4;
      // 
      // bookDS
      // 
      this.bookDS.DataSetName = "BookDataSet";
      this.bookDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // btnAddBook
      // 
      this.btnAddBook.Location = new System.Drawing.Point(12, 8);
      this.btnAddBook.Name = "btnAddBook";
      this.btnAddBook.Size = new System.Drawing.Size(75, 23);
      this.btnAddBook.TabIndex = 1;
      this.btnAddBook.Text = "Add Book";
      this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
      // 
      // btnEditBook
      // 
      this.btnEditBook.Location = new System.Drawing.Point(93, 8);
      this.btnEditBook.Name = "btnEditBook";
      this.btnEditBook.Size = new System.Drawing.Size(75, 23);
      this.btnEditBook.TabIndex = 2;
      this.btnEditBook.Text = "Edit Book";
      this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(174, 8);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "Save";
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(255, 8);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(75, 23);
      this.btnRefresh.TabIndex = 4;
      this.btnRefresh.Text = "Refresh";
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // FrmBookSystem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.btnEditBook);
      this.Controls.Add(this.btnAddBook);
      this.Controls.Add(this.gridBooks);
      this.MaximizeBox = false;
      this.Name = "FrmBookSystem";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Book System";
      ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viewBooks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bookDS)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridBooks;
    private DevExpress.XtraGrid.Views.Grid.GridView viewBooks;
    private BookDataSet bookDS;
    private DevExpress.XtraGrid.Columns.GridColumn colTitle;
    private DevExpress.XtraGrid.Columns.GridColumn colISBN;
    private DevExpress.XtraGrid.Columns.GridColumn colAuthor;
    private DevExpress.XtraGrid.Columns.GridColumn colPublisher;
    private DevExpress.XtraGrid.Columns.GridColumn colCategory;
    private DevExpress.XtraEditors.SimpleButton btnAddBook;
    private DevExpress.XtraEditors.SimpleButton btnEditBook;
    private DevExpress.XtraEditors.SimpleButton btnSave;
    private DevExpress.XtraEditors.SimpleButton btnRefresh;
  }
}

