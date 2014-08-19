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
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.SaveLampShowBtn = new System.Windows.Forms.Button();
      this.DefineLampNamesBtn = new System.Windows.Forms.Button();
      this.LoadBtn = new System.Windows.Forms.Button();
      this.CreateStatesBtn = new System.Windows.Forms.Button();
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
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.SaveLampShowBtn);
      this.splitContainer1.Panel2.Controls.Add(this.DefineLampNamesBtn);
      this.splitContainer1.Panel2.Controls.Add(this.LoadBtn);
      this.splitContainer1.Panel2.Controls.Add(this.CreateStatesBtn);
      this.splitContainer1.Size = new System.Drawing.Size(568, 565);
      this.splitContainer1.SplitterDistance = 520;
      this.splitContainer1.TabIndex = 1;
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
      // SaveLampShowBtn
      // 
      this.SaveLampShowBtn.Dock = System.Windows.Forms.DockStyle.Right;
      this.SaveLampShowBtn.Location = new System.Drawing.Point(233, 0);
      this.SaveLampShowBtn.Name = "SaveLampShowBtn";
      this.SaveLampShowBtn.Size = new System.Drawing.Size(106, 41);
      this.SaveLampShowBtn.TabIndex = 3;
      this.SaveLampShowBtn.Text = "Save Lamp Show";
      this.SaveLampShowBtn.UseVisualStyleBackColor = true;
      // 
      // DefineLampNamesBtn
      // 
      this.DefineLampNamesBtn.Dock = System.Windows.Forms.DockStyle.Left;
      this.DefineLampNamesBtn.Location = new System.Drawing.Point(0, 0);
      this.DefineLampNamesBtn.Name = "DefineLampNamesBtn";
      this.DefineLampNamesBtn.Size = new System.Drawing.Size(128, 41);
      this.DefineLampNamesBtn.TabIndex = 2;
      this.DefineLampNamesBtn.Text = "Define Lamp Names";
      this.DefineLampNamesBtn.UseVisualStyleBackColor = true;
      // 
      // LoadBtn
      // 
      this.LoadBtn.Dock = System.Windows.Forms.DockStyle.Right;
      this.LoadBtn.Location = new System.Drawing.Point(339, 0);
      this.LoadBtn.Name = "LoadBtn";
      this.LoadBtn.Size = new System.Drawing.Size(108, 41);
      this.LoadBtn.TabIndex = 1;
      this.LoadBtn.Text = "Load Lamp Show";
      this.LoadBtn.UseVisualStyleBackColor = true;
      // 
      // CreateStatesBtn
      // 
      this.CreateStatesBtn.Dock = System.Windows.Forms.DockStyle.Right;
      this.CreateStatesBtn.Location = new System.Drawing.Point(447, 0);
      this.CreateStatesBtn.Name = "CreateStatesBtn";
      this.CreateStatesBtn.Size = new System.Drawing.Size(121, 41);
      this.CreateStatesBtn.TabIndex = 0;
      this.CreateStatesBtn.Text = "Create Lamp States";
      this.CreateStatesBtn.UseVisualStyleBackColor = true;
      this.CreateStatesBtn.Click += new System.EventHandler(this.CreateStatesBtn_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(568, 565);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "LampShowCreator";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button LoadBtn;
    private System.Windows.Forms.Button CreateStatesBtn;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Button DefineLampNamesBtn;
    private System.Windows.Forms.Button SaveLampShowBtn;
  }
}

