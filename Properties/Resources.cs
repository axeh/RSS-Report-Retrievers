
// Type: RSS_Report_Retrievers.Properties.Resources




using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace RSS_Report_Retrievers.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) RSS_Report_Retrievers.Properties.Resources.resourceMan, (object) null))
          RSS_Report_Retrievers.Properties.Resources.resourceMan = new ResourceManager("RSS_Report_Retrievers.Properties.Resources", typeof (RSS_Report_Retrievers.Properties.Resources).Assembly);
        return RSS_Report_Retrievers.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return RSS_Report_Retrievers.Properties.Resources.resourceCulture;
      }
      set
      {
        RSS_Report_Retrievers.Properties.Resources.resourceCulture = value;
      }
    }

    internal static Bitmap folderopen
    {
      get
      {
        return (Bitmap) RSS_Report_Retrievers.Properties.Resources.ResourceManager.GetObject(nameof (folderopen), RSS_Report_Retrievers.Properties.Resources.resourceCulture);
      }
    }

    internal static Bitmap openfolderHS
    {
      get
      {
        return (Bitmap) RSS_Report_Retrievers.Properties.Resources.ResourceManager.GetObject(nameof (openfolderHS), RSS_Report_Retrievers.Properties.Resources.resourceCulture);
      }
    }
  }
}
