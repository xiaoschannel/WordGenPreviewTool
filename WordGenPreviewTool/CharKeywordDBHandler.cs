using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WordGenPreviewTool
{
  class CharKeywordDBHandler
  {
    public static readonly string DB_NAME = "dbCharKeyword.mdf";
    public static readonly string CKW_COLUMN_CHAR = "char";
    public static readonly string CKW_COLUMN_KEYWORD = "keyword";

    public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\v11.0;
      AttachDbFilename=|DataDirectory|\" + DB_NAME + @";
      Integrated Security=True;
      Connect Timeout=10";

    public static readonly string QUERY_SELECT_ALL_CHARS = "select * from chars";
    public static readonly string QUERY_SELECT_ALL_KEYWORDS = "select * from keywords";
    public static readonly string QUERY_SELECT_ALL_CHAR_KEYWORD_RELATIONS = "select * from charkeywords";

    public Dictionary<string, List<string>> charKeywords = new Dictionary<string, List<string>>();
    public List<string> chars = new List<string>();
    public List<string> keywords = new List<string>();

    /// <summary>
    /// fills 
    /// </summary>
    public void loadCharsByKeyword()
    {
      DataTable ckw = queryDB(QUERY_SELECT_ALL_CHAR_KEYWORD_RELATIONS);
      foreach (DataRow i in ckw.Rows)
      {
        string k = i[CKW_COLUMN_KEYWORD].ToString();
        if (!charKeywords.ContainsKey(k))
          charKeywords.Add(k, new List<string>());//create a new entry if this keyword is not seen before.

        charKeywords[k].Add(i[CKW_COLUMN_CHAR].ToString());//add the char we've found that's associated.
      }
    }
    public void loadAllKeywords()
    {
      DataTable ckw = queryDB(QUERY_SELECT_ALL_CHAR_KEYWORD_RELATIONS);
      foreach (DataRow i in ckw.Rows)
      {
        keywords.Add(i[CKW_COLUMN_KEYWORD].ToString());
      }
    }
    public void loadAllChars()
    {
      DataTable ckw = queryDB(QUERY_SELECT_ALL_CHAR_KEYWORD_RELATIONS);
      foreach (DataRow i in ckw.Rows)
      {
        chars.Add(i[CKW_COLUMN_CHAR].ToString());
      }
    }
    /// <summary>
    /// query database with given query string. 
    /// It's your responsibility to make it safe, so dont put parameters from the user directly here!
    /// </summary>
    /// <param name="query"></param>
    /// <returns>table[0] of the dataset.</returns>
    private DataTable queryDB(string query)
    {
      SqlConnection connection = new SqlConnection(CONNECTION_STRING);
      SqlCommand command = new SqlCommand(query, connection);
      SqlDataAdapter adapter = new SqlDataAdapter();
      DataSet data = new DataSet();

      adapter.SelectCommand = command;

      connection.Open();
      adapter.Fill(data);
      connection.Close();

      return data.Tables[0];
    }
  }
}
