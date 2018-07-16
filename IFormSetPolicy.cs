
// Type: RSS_Report_Retrievers.IFormSetPolicy




using System.Collections.Generic;
using System.Windows.Forms;

namespace RSS_Report_Retrievers
{
  public interface IFormSetPolicy
  {
    void Init(IEnumerable<string> availableRoles, string itemName);

    string UserName { get; }

    DialogResult ShowDialog();

    List<string> SelectedRoles { get; }
  }
}
