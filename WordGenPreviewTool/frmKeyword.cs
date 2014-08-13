using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGenPreviewTool
{
  public partial class frmKeyword : Form
  {
    Dictionary<string, List<string>> keymap;
    public frmKeyword()
    {
      InitializeComponent();
      keymap = new Dictionary<string,List<string>>();
    }

    private void frmKeyword_Load(object sender, EventArgs e)
    {
      string resxFile = @".\CharKeywords.resx"; // relative directory to the executable file
      ResXResourceSet rs = new ResXResourceSet(resxFile);

      foreach (DictionaryEntry de in rs)
      {
        string[] keywrds = de.Value.ToString().Split(' ');
        foreach (string s in keywrds)
        {
          if (!keymap.ContainsKey(s)) keymap.Add(s, new List<string>());
          keymap[s].Add(de.Key.ToString());
        }
      }
      foreach (string s in keymap.Keys)
      {
        lstKeyWords.Items.Add(s);
      }

      rs.Close();
      string con = @"Data Source=(LocalDB)\v11.0;
      AttachDbFilename=|DataDirectory|\dbCharKeyword.mdf;
      Integrated Security=True;
      Connect Timeout=30";

      string query = "select * from chars";
      SqlConnection connection = new SqlConnection(con);
      connection.Open();
      SqlDataAdapter adapter = new SqlDataAdapter();
      SqlCommand command = new SqlCommand(query, connection);
      
      adapter.SelectCommand=command;
      DataSet data = new DataSet();
      adapter.Fill(data);
      MessageBox.Show(data.ToString());

      connection.Close();
     //ResXResourceWriter rw = new ResXResourceWriter(resxFile);
     // rw.AddResource("一","一二三");
     // rw.Generate();
     // rw.Close();
    }
  }
}
