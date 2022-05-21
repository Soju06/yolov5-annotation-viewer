namespace YOLOv5Label;
public class DropLabel : Label {
    public event EventHandler<object>? onDrop;

    public DropLabel() {
        AllowDrop = true;
        AutoSize = false;
    }

    public string format { get; set; } = DataFormats.FileDrop;
    
    protected override void OnDragDrop(DragEventArgs e) =>
        onDrop?.Invoke(this, e.Data!.GetData(format));

    protected override void OnDragEnter(DragEventArgs e) {
        if (e.Data?.GetDataPresent(format) == true)
            e.Effect = DragDropEffects.Copy;
    }
}
