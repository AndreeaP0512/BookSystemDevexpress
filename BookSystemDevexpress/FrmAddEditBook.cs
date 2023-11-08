using DevExpress.XtraEditors;
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
  public partial class FrmAddEditBook : DevExpress.XtraEditors.XtraForm
  {
    private BookDataSet _bookDataSet;
    private BookDataSet.BookRow _bookRow;
    public FrmAddEditBook(BookDataSet bookDS, BookDataSet.BookRow bookRow)
    {
      InitializeComponent();
      _bookDataSet = bookDS;

      lookUpAuthor.Properties.DataSource = bookDS.Author;
      lookUpCategory.Properties.DataSource = bookDS.Category;
      lookUpPublisher.Properties.DataSource = bookDS.Publisher;

      if (bookRow == null)
      {
        _bookRow = _bookDataSet.Book.NewBookRow();
        _bookRow.Title = "";
        _bookRow.ISBN = "";
        _bookRow.AuthorId = 1;
        _bookRow.PublisherId = 1;
        _bookRow.CategoryId = 1;

        bookDS.Book.AddBookRow(_bookRow);
      }
      else
      {
        this.Text = "Edit Book";
        _bookRow = bookRow;
        txtTitle.Text = _bookRow.Title;
        txtISBN.Text = _bookRow.ISBN;

        lookUpAuthor.EditValue = _bookRow.AuthorId;
        lookUpCategory.EditValue = _bookRow.CategoryId;
        lookUpPublisher.EditValue = _bookRow.PublisherId;
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      _bookRow.Title = txtTitle.Text;
      _bookRow.ISBN= txtISBN.Text;
      _bookRow.PublisherId = (int)lookUpPublisher.EditValue;
      _bookRow.AuthorId = (int)lookUpAuthor.EditValue;
      _bookRow.CategoryId = (int)lookUpCategory.EditValue;
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }
}