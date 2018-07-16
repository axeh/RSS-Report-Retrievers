
// Type: RSS_Report_Retrievers.Forms.IFormSetPolicy




using System.Collections.Generic;

namespace RSS_Report_Retrievers.Forms
{
  internal interface IFormSetPolicy
  {
    void Init(IEnumerable<string> availableRoles, string itemName, Dictionary<string, string> existingPolicies);

    bool Recursive { get; }

    string UserName { get; }
  }
}
