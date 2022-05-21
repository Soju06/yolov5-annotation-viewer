using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YOLOv5Label;
public partial class ClassItem : UserControl {
    public ClassItem() {
        InitializeComponent();
    }

    public ClassItem(Color color, string text) {
        InitializeComponent();
        this.text = text;
        this.color = color;
    }

    public string text {
        get { return textLabel.Text; }
        set { textLabel.Text = value; }
    }

    public Color color {
        get { return colorPanel.BackColor; }
        set { colorPanel.BackColor = value; }
    }
}
