namespace YOLOv5Label;

partial class ClassItem {
    /// <summary> 
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region 구성 요소 디자이너에서 생성한 코드

    /// <summary> 
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent() {
            this.colorPanel = new System.Windows.Forms.Panel();
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.colorPanel.BackColor = System.Drawing.Color.Red;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(8, 8);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(8);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(32, 30);
            this.colorPanel.TabIndex = 0;
            // 
            // textLabel
            // 
            this.textLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLabel.Location = new System.Drawing.Point(51, 8);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(122, 30);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "label1";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClassItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.colorPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(0, 48);
            this.MinimumSize = new System.Drawing.Size(102, 38);
            this.Name = "ClassItem";
            this.Size = new System.Drawing.Size(219, 46);
            this.ResumeLayout(false);

    }

    #endregion

    private Panel colorPanel;
    private Label textLabel;
}
