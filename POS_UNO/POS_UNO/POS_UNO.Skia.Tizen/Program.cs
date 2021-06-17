using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace POS_UNO.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new POS_UNO.App(), args);
            host.Run();
        }
    }
}
