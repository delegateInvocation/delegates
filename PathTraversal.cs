using System.IO;
using System.Text;

namespace delegates {
  public class PathTraversalVuln {
    public PathTraversalVuln(string fullPath) {
      
	string wf = System.IO.File.ReadAllText(fullPath, Encoding.UTF8);
	Console.WriteLine(wf);

    }

    public string Vuln(string fullPath) {
        string x = System.IO.File.ReadAllText(fullPath, Encoding.UTF8);
	return x;
    }
  }
}
