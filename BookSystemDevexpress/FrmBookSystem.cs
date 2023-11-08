using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSystemDevexpress
{
  public partial class FrmBookSystem : Form
  {
    private BookDataAccess bookDataAccess = new BookDataAccess();
    public FrmBookSystem()
    {
      InitializeComponent();
      FillGridView();
    }

    private void FillGridView()
    {
      bookDS = bookDataAccess.ReadBookData();

      gridBooks.DataSource = bookDS.Book;
    }

    private void btnAddBook_Click(object sender, EventArgs e)
    {
      BookDataSet bookDSCopy = bookDS.Copy() as BookDataSet;
      using (FrmAddEditBook frmAddBook = new FrmAddEditBook(bookDSCopy, null))
      {
        if(frmAddBook.ShowDialog() == DialogResult.OK && bookDSCopy.HasChanges())
        {
          gridBooks.DataSource = null;
          bookDS = bookDSCopy.Copy() as BookDataSet;
          gridBooks.DataSource = bookDS.Book;
        }
      }
    }

    private void viewBooks_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
    {
      if (e.IsGetData)
      {
        int rowHandle = viewBooks.GetRowHandle(e.ListSourceRowIndex);
        BookDataSet.BookRow bookRow = viewBooks.GetDataRow(rowHandle) as BookDataSet.BookRow;
        if (bookRow == null)
        {
          return;
        }

        if (e.Column == colPublisher)
        {
          e.Value = bookRow.PublisherRow.PublisherName;
        }
        if (e.Column == colAuthor)
        {
          e.Value = bookRow.AuthorRow.AuthorName;
        }
        if (e.Column == colCategory)
        {
          e.Value = bookRow.CategoryRow.CategoryName;
        }
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if(bookDS.HasChanges())
      {
        BookDataSet changesDS = bookDS.GetChanges() as BookDataSet;
        bookDataAccess.WriteBookData(changesDS);
        bookDS.AcceptChanges();
        bookDS = bookDataAccess.ReadBookData();
        gridBooks.DataSource = bookDS.Book;
      }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      bookDS = bookDataAccess.ReadBookData();
      gridBooks.DataSource = bookDS.Book;
    }  

    private void btnEditBook_Click(object sender, EventArgs e)
    {
      BookDataSet bookDSCopy = bookDS.Copy() as BookDataSet;
      BookDataSet.BookRow bookRow = viewBooks.GetDataRow(viewBooks.FocusedRowHandle) as BookDataSet.BookRow;
      
      if(bookRow != null)
      {
        using (FrmAddEditBook frmAddEditBook = new FrmAddEditBook(bookDSCopy, bookRow))
        {
          if (frmAddEditBook.ShowDialog() == DialogResult.OK && bookDSCopy.HasChanges())
          {
            gridBooks.DataSource = null;
            bookDS = bookDSCopy.Copy() as BookDataSet;
            gridBooks.DataSource = bookDS.Book;
          }
        }
      }
    }
  }
}
 