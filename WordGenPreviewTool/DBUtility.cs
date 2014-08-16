using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGenPreviewTool
{
  class DBUtility
  {
    private static string[] SPECIAL_CHARECTERS = { "-", ";", "'" };
    public bool hasSpecialCharecters(string s)
    {
      foreach (string i in SPECIAL_CHARECTERS)
        if (s.Contains(i)) return true;
      return false;
    }
  }
}
