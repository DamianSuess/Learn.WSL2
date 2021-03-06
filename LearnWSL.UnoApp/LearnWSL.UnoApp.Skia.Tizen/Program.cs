using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace LearnWSL.UnoApp.Skia.Tizen
{
  class Program
  {
    static void Main(string[] args)
    {
      var host = new TizenHost(() => new LearnWSL.UnoApp.App(), args);
      host.Run();
    }
  }
}
