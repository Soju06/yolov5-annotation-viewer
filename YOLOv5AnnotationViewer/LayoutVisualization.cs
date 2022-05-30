namespace YOLOv5Label;
class LayoutVisualization {
    public Dictionary<int, string> labels { get; } = new();

    public void process(Size size, Graphics graphics, float[,] values, bool drawName = true, float penWidth = 2f, float fontWidth = 10f, FontFamily? fontf = null) {
        var rects = new Dictionary<int, List<RectangleF>>();
        var valuesLen = values.GetLength(0);

        for (int ci = 0; ci < valuesLen; ci++) {
            var classId = (int)Math.Floor(values[ci, 0]);
            var width = size.Width * values[ci, 3];
            var height = size.Height * values[ci, 4];
            var xc = size.Width * values[ci, 1];
            var yc = size.Height * values[ci, 2];
            var x = xc - width / 2;
            var y = yc - height / 2;

            var rect = new RectangleF(x, y, width, height);

            append(classId, rect);
        }

        using var font = drawName ? new Font(fontf ?? new FontFamily("Arial"), fontWidth) : null;

        foreach (var (classId, rect) in rects) {
            var label = labels.ContainsKey(classId) ? labels[classId] : $"Unknown {classId}";
            var color = getColor(classId);
            using var pen = new Pen(color, penWidth);
            using var backBrush = pen.Brush;
            using var textBrush = new SolidBrush((color.R + color.G + color.B) / 3 > 127 ? Color.Black : Color.White);

            if (drawName) {
                foreach (var rec in rect) {
                    const float textBackMargin = 1f;

                    var text = label;
                    var textSize = graphics.MeasureString(text, font!);
                    var textX = rec.X + (rec.Width - textSize.Width) / 2;
                    var textY = rec.Y - textSize.Height;

                    graphics.FillRectangle(
                        backBrush,
                        textX - textBackMargin,
                        textY - textBackMargin,
                        textSize.Width + (textBackMargin * 2),
                        textSize.Height + (textBackMargin * 2)
                    );
                    graphics.DrawString(text, font!, textBrush, textX, textY);
                }
            }

            graphics.DrawRectangles(pen, rect.ToArray());
        }

        void append(int classId, RectangleF rect) {
            if (rects!.TryGetValue(classId, out var list))
                list.Add(rect);
            else
                rects[classId] = new List<RectangleF> { rect };
        }
    }

    public static Color getColor(int classId) =>
        colors.ContainsKey(classId) ? colors[classId] : Color.White;

    static Dictionary<int, Color> colors = new() {
            { 0, Color.Red },
            { 1, Color.Green },
            { 2, Color.Blue },
            { 3, Color.Yellow },
            { 4, Color.Purple },
            { 5, Color.Cyan },
            { 6, Color.Orange },
            { 7, Color.Pink },
            { 8, Color.Brown },
            { 9, Color.LightBlue },
            { 10, Color.LightGreen },
            { 11, Color.LightGray },
            { 12, Color.LightYellow },
            { 13, Color.LightCyan },
            { 14, Color.LightPink },
            { 15, Color.DarkBlue },
            { 16, Color.DarkGreen },
            { 17, Color.DarkGray },
            { 18, Color.DarkCyan },
            { 19, Color.DarkOrange }
        };
}
