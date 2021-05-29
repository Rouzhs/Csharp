namespace Studio
{
		partial class Form1
		{
				/// <summary>
				/// Required designer variable.
				/// </summary>
				private System.ComponentModel.IContainer components = null;

				/// <summary>
				/// Clean up any resources being used.
				/// </summary>
				/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
				protected override void Dispose(bool disposing)
				{
						if (disposing && (components != null))
						{
								components.Dispose();
						}
						base.Dispose(disposing);
				}

				#region Windows Form Designer generated code

				/// <summary>
				/// Required method for Designer support - do not modify
				/// the contents of this method with the code editor.
				/// </summary>
				private void InitializeComponent()
				{
						System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
						this.textBoxCode = new System.Windows.Forms.RichTextBox();
						this.menuStrip1 = new System.Windows.Forms.MenuStrip();
						this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						this.pasteTheBaseCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						this.textBoxErrors = new System.Windows.Forms.RichTextBox();
						this.toolStrip = new System.Windows.Forms.ToolStrip();
						this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
						this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
						this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.assembliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						this.menuStrip1.SuspendLayout();
						this.toolStrip.SuspendLayout();
						this.SuspendLayout();
						// 
						// textBoxCode
						// 
						this.textBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.textBoxCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
						this.textBoxCode.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.textBoxCode.ForeColor = System.Drawing.SystemColors.Control;
						this.textBoxCode.Location = new System.Drawing.Point(12, 100);
						this.textBoxCode.Name = "textBoxCode";
						this.textBoxCode.Size = new System.Drawing.Size(766, 527);
						this.textBoxCode.TabIndex = 0;
						this.textBoxCode.Text = "";
						this.textBoxCode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formMouseMove);
						// 
						// menuStrip1
						// 
						this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
						this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.assembliesToolStripMenuItem});
						this.menuStrip1.Location = new System.Drawing.Point(0, 0);
						this.menuStrip1.Name = "menuStrip1";
						this.menuStrip1.Size = new System.Drawing.Size(1222, 28);
						this.menuStrip1.TabIndex = 2;
						this.menuStrip1.Text = "menuStrip1";
						this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formMouseMove);
						// 
						// fileToolStripMenuItem
						// 
						this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveFileToolStripMenuItem});
						this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
						this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
						this.fileToolStripMenuItem.Text = "File";
						// 
						// openToolStripMenuItem
						// 
						this.openToolStripMenuItem.Name = "openToolStripMenuItem";
						this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
						this.openToolStripMenuItem.Text = "Open";
						this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
						// 
						// saveFileToolStripMenuItem
						// 
						this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
						this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
						this.saveFileToolStripMenuItem.Text = "Save";
						this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveNewFile_Click);
						// 
						// viewToolStripMenuItem
						// 
						this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteTheBaseCodeToolStripMenuItem});
						this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
						this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
						this.viewToolStripMenuItem.Text = "Help";
						// 
						// pasteTheBaseCodeToolStripMenuItem
						// 
						this.pasteTheBaseCodeToolStripMenuItem.Name = "pasteTheBaseCodeToolStripMenuItem";
						this.pasteTheBaseCodeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
						this.pasteTheBaseCodeToolStripMenuItem.Text = "Paste the base code";
						this.pasteTheBaseCodeToolStripMenuItem.Click += new System.EventHandler(this.pasteTheBaseCode_Click);
						// 
						// textBoxErrors
						// 
						this.textBoxErrors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
						this.textBoxErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
						this.textBoxErrors.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.textBoxErrors.ForeColor = System.Drawing.SystemColors.Control;
						this.textBoxErrors.Location = new System.Drawing.Point(810, 100);
						this.textBoxErrors.Name = "textBoxErrors";
						this.textBoxErrors.ReadOnly = true;
						this.textBoxErrors.Size = new System.Drawing.Size(386, 527);
						this.textBoxErrors.TabIndex = 3;
						this.textBoxErrors.Text = "";
						this.textBoxErrors.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formMouseMove);
						// 
						// toolStrip
						// 
						this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
						this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonStop,
            this.toolStripButtonSave});
						this.toolStrip.Location = new System.Drawing.Point(0, 28);
						this.toolStrip.Name = "toolStrip";
						this.toolStrip.Size = new System.Drawing.Size(1222, 27);
						this.toolStrip.TabIndex = 4;
						this.toolStrip.Text = "toolStrip1";
						this.toolStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formMouseMove);
						// 
						// toolStripButtonStart
						// 
						this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
						this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
						this.toolStripButtonStart.Name = "toolStripButtonStart";
						this.toolStripButtonStart.Size = new System.Drawing.Size(64, 24);
						this.toolStripButtonStart.Text = "Start";
						this.toolStripButtonStart.Click += new System.EventHandler(this.Start_Click);
						// 
						// toolStripButtonStop
						// 
						this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
						this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
						this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
						this.toolStripButtonStop.Name = "toolStripButtonStop";
						this.toolStripButtonStop.Size = new System.Drawing.Size(29, 24);
						this.toolStripButtonStop.Text = "Stop";
						this.toolStripButtonStop.Visible = false;
						this.toolStripButtonStop.Click += new System.EventHandler(this.Stop_Click);
						// 
						// toolStripButtonSave
						// 
						this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
						this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
						this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
						this.toolStripButtonSave.Name = "toolStripButtonSave";
						this.toolStripButtonSave.Size = new System.Drawing.Size(29, 24);
						this.toolStripButtonSave.Text = "Save";
						this.toolStripButtonSave.Visible = false;
						this.toolStripButtonSave.Click += new System.EventHandler(this.SaveOpenedFile_Click);
						// 
						// label1
						// 
						this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
						this.label1.AutoSize = true;
						this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.label1.Location = new System.Drawing.Point(970, 72);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(70, 25);
						this.label1.TabIndex = 5;
						this.label1.Text = "Errors:";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.label2.Location = new System.Drawing.Point(333, 72);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(66, 25);
						this.label2.TabIndex = 6;
						this.label2.Text = "Code:";
						// 
						// assembliesToolStripMenuItem
						// 
						this.assembliesToolStripMenuItem.Name = "assembliesToolStripMenuItem";
						this.assembliesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
						this.assembliesToolStripMenuItem.Text = "Assemblies";
						this.assembliesToolStripMenuItem.Click += new System.EventHandler(this.assembliesToolStripMenuItem_Click);
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.BackColor = System.Drawing.Color.Gray;
						this.ClientSize = new System.Drawing.Size(1222, 663);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.toolStrip);
						this.Controls.Add(this.textBoxErrors);
						this.Controls.Add(this.textBoxCode);
						this.Controls.Add(this.menuStrip1);
						this.MainMenuStrip = this.menuStrip1;
						this.Name = "Form1";
						this.Text = "Stusual Vidio";
						this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formMouseMove);
						this.menuStrip1.ResumeLayout(false);
						this.menuStrip1.PerformLayout();
						this.toolStrip.ResumeLayout(false);
						this.toolStrip.PerformLayout();
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.RichTextBox textBoxCode;
				private System.Windows.Forms.MenuStrip menuStrip1;
				private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
				private System.Windows.Forms.RichTextBox textBoxErrors;
				private System.Windows.Forms.ToolStrip toolStrip;
				private System.Windows.Forms.ToolStripButton toolStripButtonStop;
				private System.Windows.Forms.ToolStripButton toolStripButtonStart;
				private System.Windows.Forms.ToolStripButton toolStripButtonSave;
				private System.Windows.Forms.ToolStripMenuItem pasteTheBaseCodeToolStripMenuItem;
				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.ToolStripMenuItem assembliesToolStripMenuItem;
		}
}

