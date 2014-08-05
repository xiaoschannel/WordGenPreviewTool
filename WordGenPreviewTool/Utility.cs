using System.Collections.Generic;
using System.Windows.Forms;
namespace WordGenPreviewTool
{
  public static class Utility
  {
    /// <summary>
    /// Remove all selected items in given ListView.
    /// </summary>
    /// <param name="v">ListView to remove item.</param>
    /// <returns>Number of selected items.</returns>
    public static int ListView_RemoveSelected(ListView v)
    {
      int answer = v.SelectedIndices.Count;
      foreach (ListViewItem i in v.SelectedItems)
      {
        v.Items.RemoveAt(i.Index);
      }
      return answer;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static bool ListView_ContainsItemWithText(ListView v, string text)
    {
      bool answer = false;
      foreach (ListViewItem i in v.Items)
      {
        if (i.Text == text)
        {
          answer = true;
          break;
        }
      }
      return answer;
    }
  }
}