namespace YOLOv5Label;

public partial class Form1 : Form {
    LayoutVisualization visual = new();
    Image? image;
    float[,]? labels;
    public Form1() {
        InitializeComponent();
    }

    private void onDropHeader(object sender, object e) {
        var path = (e as string[])?.First();

        if (path == null)
            return;

        YOLOv5Config? cfg = null;

        try {
            cfg = YOLOv5FileSystem.parseConfig(path);
        } catch { }

        if (cfg == null || cfg.names == null)
            return;

        lock (visual) {
            var i = 0;
            
            visual.labels.Clear();

            foreach (var name in cfg.names)
                visual.labels[i++] = name;

            updateColumns();
        }
    }

    void updateColumns() {
        columnsPanel.SuspendLayout();

        while (columnsPanel.Controls.Count > 0) {
            var ctrl = columnsPanel.Controls[0];

            columnsPanel.Controls.Remove(ctrl);
            ctrl.Dispose();
        }

        foreach (var (classId, name) in visual.labels)
            columnsPanel.Controls.Add(new ClassItem(LayoutVisualization.getColor(name), $"{classId} - {name}") {
                Margin = new(0),
                Size = new(columnsPanel.Width - 25, 38),
            });
        
        columnsPanel.ResumeLayout();
        updateView();
    }

    private void onSourceDrop(object sender, object e) {
        var path = (e as string[])?.First();

        if (path == null)
            return;

        var imgPath = YOLOv5FileSystem.getEstimatedPath(path, false).FirstOrDefault(p => File.Exists(p));
        var labelPath = YOLOv5FileSystem.getEstimatedPath(path, true).FirstOrDefault(p =>
        File.Exists(p));

        if (imgPath == null || labelPath == null)
            return;

        Image? oimg = null;

        try {
            using var stream = File.OpenRead(imgPath);
            oimg = Image.FromStream(stream);
        } catch { }
        
        if (oimg == null)
            return;

        image = oimg;
        labels = YOLOv5FileSystem.parseLabel(labelPath);
        updateView();
    }

    protected override void OnResize(EventArgs e) {
        base.OnResize(e);
        updateView();
    }

    void updateView() {
        if (image == null || labels == null)
            return;
        lock (visual) {
            var scale = Math.Min((float)imageView.Width / image.Width, (float)imageView.Height / image.Height);

            if (scale <= 0)
                return;
            
            var img = new Bitmap(image, new((int)(scale * image.Width), (int)(scale * image.Height)));

            using var graphics = Graphics.FromImage(img);

            using (var i = imageView.Image)
                imageView.Image = null;

            visual.process(
                img.Size,
                graphics,
                values: labels,
                drawName: true,
                penWidth: 3f,
                fontWidth: 10f,
                fontf: dropLabel1.Font.FontFamily
            );

            imageView.Image = img;
        }
    }
}
