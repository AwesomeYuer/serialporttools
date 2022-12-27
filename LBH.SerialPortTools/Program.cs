using Gtk;
using LBH.SerialPortTools;

class Program
{
    public static Application App;
    public static MainWindow2 mainWindow;
    [STAThread]
    public static void Main(string[] args)
    {
        Application.Init();

        App = new Application("LBH.SerialPortTools", GLib.ApplicationFlags.None);
        App.Register(GLib.Cancellable.Current);

        CssProvider provider = new CssProvider();
        provider.LoadFromPath("sp.css");
        StyleContext.AddProviderForScreen(Gdk.Screen.Default, provider, 800);

        mainWindow = new MainWindow2();
        mainWindow.SetIconFromFile("logo.png");
        App.AddWindow(mainWindow);
        
        Application.Run();
    }
}