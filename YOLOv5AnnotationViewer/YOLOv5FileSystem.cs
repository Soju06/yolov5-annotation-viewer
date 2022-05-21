using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace YOLOv5Label;
public static class YOLOv5FileSystem {
    static IDeserializer yamlDeserializer = new DeserializerBuilder()
        .WithNamingConvention(UnderscoredNamingConvention.Instance).Build();

    public static string[] getEstimatedPath(string path, bool label = false) {
        var fi = new FileInfo(path);
        var fn = Path.GetFileNameWithoutExtension(fi.Name);
        var isLabel = fi.Extension.ToLower() == ".txt";

        return new[] {
            isLabel == label ? path : Path.Combine(fi.Directory!.Parent!.FullName, (label ? $"labels/{fn}.txt" : $"images/{fn}.jpg"))
        };
    }

    public static float[,] parseLabel(string path) {
        var lines = File.ReadAllLines(path);
        var linesLen = lines.Length;
        var classes = new float[linesLen, 5];

        for (int li = 0; li < linesLen; li++) {
            var line = lines[li];
            var parts = line.Split(' ');
            var partsLen = parts.Length;

            for (int pi = 0; pi < partsLen; pi++) {
                var part = parts[pi];

                if (string.IsNullOrWhiteSpace(part))
                    continue;

                classes[li, pi] = float.Parse(part);
            }
        }

        return classes;
    }

    public static YOLOv5Config parseConfig(string path) =>
        yamlDeserializer.Deserialize<YOLOv5Config>(File.ReadAllText(path));
}

public class YOLOv5Config {
    public string path { get; set; }
    public string train { get; set; }
    public string val { get; set; }
    public string test { get; set; }
    public int nc { get; set; }
    public string[]? names { get; set; }
}