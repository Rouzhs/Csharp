namespace Studio
{
		partial class SaveForm
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
						this.buttonOK = new System.Windows.Forms.Button();
						this.textBoxName = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.buttonCancel = new System.Windows.Forms.Button();
						this.SuspendLayout();
						// 
						// buttonOK
						// 
						this.buttonOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
						this.buttonOK.Location = new System.Drawing.Point(220, 95);
						this.buttonOK.Name = "buttonOK";
						this.buttonOK.Size = new System.Drawing.Size(75, 27);
						this.buttonOK.TabIndex = 0;
						this.buttonOK.Text = "OK";
						this.buttonOK.UseVisualStyleBackColor = false;
						this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
						// 
						// textBoxName
						// 
						this.textBoxName.Location = new System.Drawing.Point(29, 55);
						this.textBoxName.Name = "textBoxName";
						this.textBoxName.Size = new System.Drawing.Size(266, 22);
						this.textBoxName.TabIndex = 1;
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(26, 35);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(45, 17);
						this.label1.TabIndex = 2;
						this.label1.Text = "Name";
						// 
						// buttonCancel
						// 
						this.buttonCancel.Location = new System.Drawing.Point(29, 95);
						this.buttonCancel.Name = "buttonCancel";
						this.buttonCancel.Size = new System.Drawing.Size(75, 27);
						this.buttonCancel.TabIndex = 3;
						this.buttonCancel.Text = "Cancel";
						this.buttonCancel.UseVisualStyleBackColor = true;
						this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
						// 
						// SaveForm
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(338, 162);
						this.Controls.Add(this.buttonCancel);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.textBoxName);
						this.Controls.Add(this.buttonOK);
						this.Name = "SaveForm";
						this.Text = "Save";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.Button buttonOK;
				private System.Windows.Forms.TextBox textBoxName;
				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.Button buttonCancel;
		}
}