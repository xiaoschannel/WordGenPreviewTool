using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
  }
}
