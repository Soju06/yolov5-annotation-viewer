namespace YOLOv5Label;

internal static class Program {
    [STAThread]
    static void Main() {
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}