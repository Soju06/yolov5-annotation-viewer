namespace YOLOv5Label;

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dropLabel2 = new YOLOv5Label.DropLabel();
            this.dropLabel1 = new YOLOv5Label.DropLabel();
            this.classItem1 = new YOLOv5Label.ClassItem();
            this.columnsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imageView = new YOLOv5Label.DropLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dropLabel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dropLabel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dropLabel2
            // 
            this.dropLabel2.AllowDrop = true;
            this.dropLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dropLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dropLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dropLabel2.format = "FileDrop";
            this.dropLabel2.Location = new System.Drawing.Point(430, 4);
            this.dropLabel2.Margin = new System.Windows.Forms.Padding(1);
            this.dropLabel2.Name = "dropLabel2";
            this.dropLabel2.Padding = new System.Windows.Forms.Padding(3);
            this.dropLabel2.Size = new System.Drawing.Size(421, 147);
            this.dropLabel2.TabIndex = 1;
            this.dropLabel2.Text = "Drop the source file here";
            this.dropLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dropLabel2.onDrop += new System.EventHandler<object>(this.onSourceDrop);
            // 
            // dropLabel1
            // 
            this.dropLabel1.AllowDrop = true;
            this.dropLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dropLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dropLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dropLabel1.format = "FileDrop";
            this.dropLabel1.Location = new System.Drawing.Point(6, 6);
            this.dropLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.dropLabel1.Name = "dropLabel1";
            this.dropLabel1.Size = new System.Drawing.Size(417, 143);
            this.dropLabel1.TabIndex = 0;
            this.dropLabel1.Text = "Drop the header file here";
            this.dropLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dropLabel1.onDrop += new System.EventHandler<object>(this.onDropHeader);
            // 
            // classItem1
            // 
            this.classItem1.color = System.Drawing.Color.Red;
            this.classItem1.Location = new System.Drawing.Point(0, 0);
            this.classItem1.Margin = new System.Windows.Forms.Padding(0);
            this.classItem1.MaximumSize = new System.Drawing.Size(0, 48);
            this.classItem1.MinimumSize = new System.Drawing.Size(102, 38);
            this.classItem1.Name = "classItem1";
            this.classItem1.Size = new System.Drawing.Size(186, 46);
            this.classItem1.TabIndex = 0;
            this.classItem1.text = "label1";
            // 
            // columnsPanel
            // 
            this.columnsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.columnsPanel.AutoScroll = true;
            this.columnsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.columnsPanel.Location = new System.Drawing.Point(873, 12);
            this.columnsPanel.Name = "columnsPanel";
            this.columnsPanel.Size = new System.Drawing.Size(330, 155);
            this.columnsPanel.TabIndex = 1;
            // 
            // imageView
            // 
            this.imageView.AllowDrop = true;
            this.imageView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imageView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageView.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.imageView.format = "FileDrop";
            this.imageView.Location = new System.Drawing.Point(10, 171);
            this.imageView.Margin = new System.Windows.Forms.Padding(1);
            this.imageView.Name = "imageView";
            this.imageView.Padding = new System.Windows.Forms.Padding(3);
            this.imageView.Size = new System.Drawing.Size(1195, 773);
            this.imageView.TabIndex = 2;
            this.imageView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imageView.onDrop += new System.EventHandler<object>(this.onSourceDrop);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 954);
            this.Controls.Add(this.imageView);
            this.Controls.Add(this.columnsPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private DropLabel dropLabel2;
    private DropLabel dropLabel1;
    private ClassItem classItem1;
    private FlowLayoutPanel columnsPanel;
    private DropLabel imageView;
}
