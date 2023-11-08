using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystemDevexpress
{
  internal class BookDataAccess
  {
    private string connectionString = "Data Source=DESKTOP-6MHQP1B\\SQLEXPRESS;Initial Catalog=BookSystem;Integrated Security=True";

    private SqlDataAdapter bookDataAdapter;
    private SqlDataAdapter authorDataAdapter;
    private SqlDataAdapter categoryDataAdapter;
    private SqlDataAdapter publisherDataAdapter;

    private SqlConnection _connection;

    public BookDataAccess()
    {
      Initialize();
    }

    private SqlCommand CreateCommand(string cmdText)
    {
      SqlCommand sqlCommand = new SqlCommand(cmdText);
      sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
      sqlCommand.Connection = _connection;

      return sqlCommand;
    }

    private void Initialize()
    {
      _connection = new SqlConnection(connectionString);

      #region bookDataAdapter

      bookDataAdapter = new SqlDataAdapter();

      bookDataAdapter.SelectCommand = CreateCommand("ProcBookSelect");
      bookDataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

      bookDataAdapter.InsertCommand = CreateCommand("ProcBookInsert");
      bookDataAdapter.InsertCommand.CommandType = System.Data.CommandType.StoredProcedure;
      bookDataAdapter.InsertCommand.Parameters.Add("@BookId", System.Data.SqlDbType.Int, 0, "BookId");
      bookDataAdapter.InsertCommand.Parameters.Add("@Title", System.Data.SqlDbType.VarChar, 50, "Title");
      bookDataAdapter.InsertCommand.Parameters.Add("@ISBN", System.Data.SqlDbType.VarChar, 50, "ISBN");
      bookDataAdapter.InsertCommand.Parameters.Add("@AuthorId", System.Data.SqlDbType.Int, 0, "AuthorId");
      bookDataAdapter.InsertCommand.Parameters.Add("@PublisherId", System.Data.SqlDbType.Int, 0, "PublisherId");
      bookDataAdapter.InsertCommand.Parameters.Add("@CategoryId", System.Data.SqlDbType.Int, 0, "CategoryId");
      bookDataAdapter.InsertCommand.Parameters["@BookId"].Direction = System.Data.ParameterDirection.Output;

      bookDataAdapter.UpdateCommand = CreateCommand("ProcBookUpdate");
      bookDataAdapter.UpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;
      bookDataAdapter.UpdateCommand.Parameters.Add("@BookId", System.Data.SqlDbType.Int, 0, "BookId");
      bookDataAdapter.UpdateCommand.Parameters.Add("@Title", System.Data.SqlDbType.VarChar, 50, "Title");
      bookDataAdapter.UpdateCommand.Parameters.Add("@ISBN", System.Data.SqlDbType.VarChar, 50, "ISBN");
      bookDataAdapter.UpdateCommand.Parameters.Add("@AuthorId", System.Data.SqlDbType.Int, 0, "AuthorId");
      bookDataAdapter.UpdateCommand.Parameters.Add("@PublisherId", System.Data.SqlDbType.Int, 0, "PublisherId");
      bookDataAdapter.UpdateCommand.Parameters.Add("@CategoryId", System.Data.SqlDbType.Int, 0, "CategoryId");

      bookDataAdapter.DeleteCommand = CreateCommand("ProcBookDelete");
      bookDataAdapter.DeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;
      bookDataAdapter.DeleteCommand.Parameters.Add("@BookId", System.Data.SqlDbType.Int, 0, "BookId");

      #endregion bookDataAdapter

      #region authorDataAdapter

      authorDataAdapter = new SqlDataAdapter();

      authorDataAdapter.SelectCommand = CreateCommand("ProcAuthorSelect");
      authorDataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

      authorDataAdapter.InsertCommand = CreateCommand("ProcAuthorInsert");
      authorDataAdapter.InsertCommand.CommandType = System.Data.CommandType.StoredProcedure;
      authorDataAdapter.InsertCommand.Parameters.Add("@AuthorId", System.Data.SqlDbType.Int, 0, "AuthorId");
      authorDataAdapter.InsertCommand.Parameters.Add("@AuthorName", System.Data.SqlDbType.VarChar, 50, "AuthorName");
      authorDataAdapter.InsertCommand.Parameters["@AuthorId"].Direction = System.Data.ParameterDirection.Output;

      authorDataAdapter.UpdateCommand = CreateCommand("ProcAuthorUpdate");
      authorDataAdapter.UpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;
      authorDataAdapter.UpdateCommand.Parameters.Add("@AuthorId", System.Data.SqlDbType.Int, 0, "AuthorId");
      authorDataAdapter.UpdateCommand.Parameters.Add("@AuthorName", System.Data.SqlDbType.VarChar, 50, "AuthorName");

      authorDataAdapter.DeleteCommand = CreateCommand("ProcAuthorDelete");
      authorDataAdapter.DeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;
      authorDataAdapter.DeleteCommand.Parameters.Add("@AuthorId", System.Data.SqlDbType.Int, 0, "AuthorId");

      #endregion authorDataAdapter

      #region publisherDataAdapter

      publisherDataAdapter = new SqlDataAdapter();

      publisherDataAdapter.SelectCommand = CreateCommand("ProcPublisherSelect");
      publisherDataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

      publisherDataAdapter.InsertCommand = CreateCommand("ProcPublisherInsert");
      publisherDataAdapter.InsertCommand.CommandType = System.Data.CommandType.StoredProcedure;
      publisherDataAdapter.InsertCommand.Parameters.Add("@PublisherId", System.Data.SqlDbType.Int, 0, "PublisherId");
      publisherDataAdapter.InsertCommand.Parameters.Add("@PublisherName", System.Data.SqlDbType.VarChar, 50, "PublisherName");
      publisherDataAdapter.InsertCommand.Parameters["@PublisherId"].Direction = System.Data.ParameterDirection.Output;

      publisherDataAdapter.UpdateCommand = CreateCommand("ProcPublisherUpdate");
      publisherDataAdapter.UpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;
      publisherDataAdapter.UpdateCommand.Parameters.Add("@PublisherId", System.Data.SqlDbType.Int, 0, "PublisherId");
      publisherDataAdapter.UpdateCommand.Parameters.Add("@PublisherName", System.Data.SqlDbType.VarChar, 50, "PublisherName");

      publisherDataAdapter.DeleteCommand = CreateCommand("ProcPublisherDelete");
      publisherDataAdapter.DeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;
      publisherDataAdapter.DeleteCommand.Parameters.Add("@PublisherId", System.Data.SqlDbType.Int, 0, "PublisherId");

      #endregion publisherDataAdapter

      #region categoryDataAdapter

      categoryDataAdapter = new SqlDataAdapter();

      categoryDataAdapter.SelectCommand = CreateCommand("ProcCategorySelect");
      categoryDataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

      categoryDataAdapter.InsertCommand = CreateCommand("ProcCategoryInsert");
      categoryDataAdapter.InsertCommand.CommandType = System.Data.CommandType.StoredProcedure;
      categoryDataAdapter.InsertCommand.Parameters.Add("@CategoryId", System.Data.SqlDbType.Int, 0, "CategoryId");
      categoryDataAdapter.InsertCommand.Parameters.Add("@CategoryName", System.Data.SqlDbType.VarChar, 50, "CategoryName");
      categoryDataAdapter.InsertCommand.Parameters["@CategoryId"].Direction = System.Data.ParameterDirection.Output;

      categoryDataAdapter.UpdateCommand = CreateCommand("ProcCategoryUpdate");
      categoryDataAdapter.UpdateCommand.CommandType = System.Data.CommandType.StoredProcedure;
      categoryDataAdapter.UpdateCommand.Parameters.Add("@CategoryId", System.Data.SqlDbType.Int, 0, "CategoryId");
      categoryDataAdapter.UpdateCommand.Parameters.Add("@CategoryName", System.Data.SqlDbType.VarChar, 50, "CategoryName");

      categoryDataAdapter.DeleteCommand = CreateCommand("ProcCategoryDelete");
      categoryDataAdapter.DeleteCommand.CommandType = System.Data.CommandType.StoredProcedure;
      categoryDataAdapter.DeleteCommand.Parameters.Add("@CategoryId", System.Data.SqlDbType.Int, 0, "CategoryId");

      #endregion categoryDataAdapter
    }

    public BookDataSet ReadBookData()
    {
      BookDataSet bookDataSet = new BookDataSet();
      try
      {
        _connection.Open();
        authorDataAdapter.Fill(bookDataSet.Author);
        categoryDataAdapter.Fill(bookDataSet.Category);
        publisherDataAdapter.Fill(bookDataSet.Publisher);
        bookDataAdapter.Fill(bookDataSet.Book);
      }
      catch
      {
      }
      finally
      {
        _connection.Close();
      }

      return bookDataSet;
    }

    public void WriteBookData(BookDataSet bookDS)
    {
      authorDataAdapter.Update(bookDS.Author.Select(null, null, System.Data.DataViewRowState.Deleted));
      categoryDataAdapter.Update(bookDS.Category.Select(null, null, System.Data.DataViewRowState.Deleted));
      publisherDataAdapter.Update(bookDS.Publisher.Select(null, null, System.Data.DataViewRowState.Deleted));
      bookDataAdapter.Update(bookDS.Book.Select(null, null, System.Data.DataViewRowState.Deleted));

      authorDataAdapter.Update(bookDS.Author.Select(null, null, System.Data.DataViewRowState.ModifiedCurrent));
      authorDataAdapter.Update(bookDS.Author.Select(null, null, System.Data.DataViewRowState.Added));

      categoryDataAdapter.Update(bookDS.Category.Select(null, null, System.Data.DataViewRowState.ModifiedCurrent));
      categoryDataAdapter.Update(bookDS.Category.Select(null, null, System.Data.DataViewRowState.Added));

      publisherDataAdapter.Update(bookDS.Publisher.Select(null, null, System.Data.DataViewRowState.ModifiedCurrent));
      publisherDataAdapter.Update(bookDS.Publisher.Select(null, null, System.Data.DataViewRowState.Added));

      bookDataAdapter.Update(bookDS.Book.Select(null, null, System.Data.DataViewRowState.ModifiedCurrent));
      bookDataAdapter.Update(bookDS.Book.Select(null, null, System.Data.DataViewRowState.Added));
    }
  }
}
