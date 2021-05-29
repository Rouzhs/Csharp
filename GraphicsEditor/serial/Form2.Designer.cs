namespace serialization
{
		partial class Form2
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
						this.menuStrip1 = new System.Windows.Forms.MenuStrip();
						this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
						((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
						this.menuStrip1.SuspendLayout();
						this.SuspendLayout();
						// 
						// menuStrip1
						// 
						this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
						this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
						this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
												this.fileToolStripMenuItem});
						this.menuStrip1.Location = new System.Drawing.Point(0, 741);
						this.menuStrip1.Name = "menuStrip1";
						this.menuStrip1.Size = new System.Drawing.Size(1526, 36);
						this.menuStrip1.TabIndex = 13;
						this.menuStrip1.Text = "menuStrip1";
						// 
						// fileToolStripMenuItem
						// 
						this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
												this.openToolStripMenuItem,
												this.saveToolStripMenuItem});
						this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
						this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 32);
						this.fileToolStripMenuItem.Text = "File";
						// 
						// openToolStripMenuItem
						// 
						this.openToolStripMenuItem.Name = "openToolStripMenuItem";
						this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 32);
						this.openToolStripMenuItem.Text = "Open";
						this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
						// 
						// saveToolStripMenuItem
						// 
						this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
						this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 32);
						this.saveToolStripMenuItem.Text = "Save";
						this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
						// 
						// Form2
						// 
						this.ClientSize = new System.Drawing.Size(1526, 777);
						this.Controls.Add(this.menuStrip1);
						this.MainMenuStrip = this.menuStrip1;
						this.Name = "Form2";
						this.Controls.SetChildIndex(this.pictureBox, 0);
						this.Controls.SetChildIndex(this.menuStrip1, 0);
						((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
						this.menuStrip1.ResumeLayout(false);
						this.menuStrip1.PerformLayout();
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				private System.Windows.Forms.MenuStrip menuStrip1;
				private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

				#endregion

		}
}

