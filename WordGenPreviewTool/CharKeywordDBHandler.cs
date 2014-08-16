using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WordGenPreviewTool
{
  class CharKeywordDBHandler
  {
    public static readonly string DB_NAME = "dbCharKeyword.mdf";
    public static readonly string COLUMN_CHAR = "char";
    public static readonly string COLUMN_KEYWORD = "keyword";

    public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\v11.0;
      AttachDbFilename=|DataDirectory|\" + DB_NAME + @";
      Integrated Security=True;
      Connect Timeout=10";

    public static readonly string PARAM_CHAR = "@charval";
    public static readonly string PARAM_KEYWORD = "@keywordval";
    public static readonly string QUERY_CHARS_SELECT_ALL = "select * from chars";
    public static readonly string QUERY_CHARS_ADD = "insert into chars (char) values (@charval)";
    public static readonly string QUERY_CHARS_REMOVE = "delete from chars where char=(@charval)";
    public static readonly string QUERY_KEYWORDS_SELECT_ALL = "select * from keywords";
    public static readonly string QUERY_KEYWORDS_ADD = "insert into keywords (keyword) values (@charval)";
    public static readonly string QUERY_KEYWORDS_REMOVE = "delete from keywords where keyword=(@charval)";
    public static readonly string QUERY_CHARKEYWORDS_SELECT_ALL = "select * from charkeywords";
    public static readonly string QUERY_CHARKEYWORDS_ADD = "insert into charkeywords (char, keyword) values (@charval, @keywordval)";
    public static readonly string QUERY_CHARKEYWORDS_REMOVE = "delete from charkeywords where char=(@charval) and keyword=(@keywordval)";

    public Dictionary<string, List<string>> charKeywords = new Dictionary<string, List<string>>();
    public List<string> chars = new List<string>();
    public List<string> keywords = new List<string>();

    /// <summary>
    /// fills 
    /// </summary>
    public void loadCharsByKeyword()
    {
      DataTable ckw = helper_queryDB(QUERY_CHARKEYWORDS_SELECT_ALL);
      foreach (DataRow i in ckw.Rows)
      {
        string k = i[COLUMN_KEYWORD].ToString();
        if (!charKeywords.ContainsKey(k))
          charKeywords.Add(k, new List<string>());//create a new entry if this keyword is not seen before.

        charKeywords[k].Add(i[COLUMN_CHAR].ToString());//add the char we've found that's associated.
      }
    }
    //public void updateKeywords(string char)
    public void addCKWPairs(List<KeyValuePair<string, string>> l)
    {
      List<KeyValuePair<string, string>> filtered = new List<KeyValuePair<string, string>>();
      foreach (KeyValuePair<string, string> i in l)
      {
        if (chars.Contains(i.Key) && keywords.Contains(i.Value)) filtered.Add(i);
      }

      helper_2param_non_query(filtered, QUERY_CHARKEYWORDS_ADD, PARAM_CHAR, PARAM_KEYWORD);

      foreach (KeyValuePair<string, string> i in filtered)
      {
        if (!charKeywords.ContainsKey(i.Key)) charKeywords.Add(i.Key, new List<string>());
        charKeywords[i.Key].Add(i.Value);
      }
    }
    public void removeCKWPairs(List<KeyValuePair<string, string>> l)
    {
      List<KeyValuePair<string, string>> filtered = new List<KeyValuePair<string, string>>();
      foreach (KeyValuePair<string, string> i in l)
      {
        if (chars.Contains(i.Key) && keywords.Contains(i.Value) &&
          charKeywords.ContainsKey(i.Key) && charKeywords[i.Key].Contains(i.Value)) 
            filtered.Add(i);
      }

      helper_2param_non_query(filtered, QUERY_CHARKEYWORDS_REMOVE, PARAM_CHAR, PARAM_KEYWORD);

      foreach (KeyValuePair<string, string> i in filtered)
      {
        charKeywords[i.Key].Remove(i.Value);
        if (charKeywords[i.Key].Count==0) charKeywords.Remove(i.Key);
      }
    }

    public void loadAllKeywords()
    {
      DataTable ckw = helper_queryDB(QUERY_KEYWORDS_SELECT_ALL);
      Console.WriteLine("Loading "+ckw.Rows.Count+" Keywords");
      foreach (DataRow i in ckw.Rows)
      {
        keywords.Add(i[COLUMN_KEYWORD].ToString());
      }
    }
    public void addKeywords(List<string> s)
    {
      List<string> filtered = new List<string>();
      foreach (string i in s)
      {
        if (!keywords.Contains(i) && i.Length <= 64)
          filtered.Add(i);
      }

      helper_1param_non_query(filtered, QUERY_KEYWORDS_ADD, PARAM_KEYWORD);

      foreach (string i in filtered)
        chars.Add(i);
    }
    public void deleteKeywords(List<string> s)
    {
      List<string> filtered = new List<string>();
      foreach (string i in s)
        if (keywords.Contains(i)) filtered.Add(i);

      helper_1param_non_query(filtered, QUERY_KEYWORDS_REMOVE, PARAM_KEYWORD);

      foreach (string i in filtered)
        chars.Remove(i);
    }
    public void loadAllChars()
    {
      DataTable ckw = helper_queryDB(QUERY_CHARS_SELECT_ALL);
      foreach (DataRow i in ckw.Rows)
      {
        chars.Add(i[COLUMN_CHAR].ToString());
      }
    }

    public void addChars(List<string> s)
    {
      List<string> filtered = new List<string>();
      foreach (string i in s)
      {
        if (!chars.Contains(i) && i.Length == 1)
          filtered.Add(i);
      }

      helper_1param_non_query(filtered, QUERY_CHARS_ADD, PARAM_CHAR);

      foreach (string i in filtered)
        chars.Add(i);
    }
    public void deleteChars(List<string> s)
    {
      List<string> filtered = new List<string>();
      foreach (string i in s)
        if (chars.Contains(i)) filtered.Add(i);

      helper_1param_non_query(filtered, QUERY_CHARS_REMOVE, PARAM_CHAR);

      foreach (string i in filtered)
        chars.Remove(i);
    }



    /// <summary>
    /// query database with given query string. 
    /// It's your responsibility to make it safe, so dont put parameters from the user directly here!
    /// </summary>
    /// <param name="query"></param>
    /// <returns>table[0] of the dataset.</returns>
    private DataTable helper_queryDB(string query)
    {
      using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
      {
        SqlCommand command = new SqlCommand(query, connection);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet data = new DataSet();

        adapter.SelectCommand = command;

        connection.Open();
        adapter.Fill(data);

        return data.Tables[0];
      }
    }
    /// <summary>
    /// Please do your own filtering
    /// </summary>
    /// <param name="s"></param>
    /// <param name="query"></param>
    /// <param name="paramName"></param>
    private void helper_1param_non_query(List<string> s, string query, string paramName)
    {
      using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
      {
        connection.Open();
        foreach (string i in s)
        {
          SqlCommand command = new SqlCommand(query, connection);
          command.Parameters.AddWithValue(paramName, i);
          command.CommandType = CommandType.Text;
          command.ExecuteNonQuery();
        }
      }
    }
    private void helper_2param_non_query(List<KeyValuePair<string, string>> s, string query, string param1Name, string param2Name)
    {
      using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
      {
        connection.Open();
        foreach (KeyValuePair<string, string> i in s)
        {
          SqlCommand command = new SqlCommand(query, connection);
          command.Parameters.AddWithValue(param1Name, i.Key);
          command.Parameters.AddWithValue(param2Name, i.Value);
          command.CommandType = CommandType.Text;
          command.ExecuteNonQuery();
        }
      }
    }
  }
}
