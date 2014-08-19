namespace LampShowCreator {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.SaveAsBtn = new System.Windows.Forms.Button();
      this.LoadBtn = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
      this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.LoadBtn);
      this.splitContainer1.Panel2.Controls.Add(this.SaveAsBtn);
      this.splitContainer1.Size = new System.Drawing.Size(568, 565);
      this.splitContainer1.SplitterDistance = 520;
      this.splitContainer1.TabIndex = 1;
      // 
      // SaveAsBtn
      // 
      this.SaveAsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.SaveAsBtn.Location = new System.Drawing.Point(481, 6);
      this.SaveAsBtn.Name = "SaveAsBtn";
      this.SaveAsBtn.Size = new System.Drawing.Size(75, 23);
      this.SaveAsBtn.TabIndex = 0;
      this.SaveAsBtn.Text = "Save as...";
      this.SaveAsBtn.UseVisualStyleBackColor = true;
      // 
      // LoadBtn
      // 
      this.LoadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.LoadBtn.Location = new System.Drawing.Point(400, 6);
      this.LoadBtn.Name = "LoadBtn";
      this.LoadBtn.Size = new System.Drawing.Size(75, 23);
      this.LoadBtn.TabIndex = 1;
      this.LoadBtn.Text = "Load from file...";
      this.LoadBtn.UseVisualStyleBackColor = true;
      // 
      // richTextBox1
      // 
      this.richTextBox1.AcceptsTab = true;
      this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.richTextBox1.Location = new System.Drawing.Point(0, 0);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(568, 520);
      this.richTextBox1.TabIndex = 0;
      this.richTextBox1.Text = "";
      this.richTextBox1.WordWrap = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(568, 565);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button LoadBtn;
    private System.Windows.Forms.Button SaveAsBtn;
    private System.Windows.Forms.RichTextBox richTextBox1;
  }
}

