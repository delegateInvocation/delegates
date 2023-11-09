using System.IO;
using System.Text;

namespace Abc {
  public class PathTraversalVuln {
    public PathTraversalVuln(string fullPath) {
      
	string wf = System.IO.File.ReadAllText(fullPath, Encoding.UTF8);
	Console.WriteLine(wf);
    }
  }
}
