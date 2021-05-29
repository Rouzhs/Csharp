namespace serialization
{
		partial class FormSaveImage
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
						this.textBox1 = new System.Windows.Forms.TextBox();
						this.buttonOKsaveImage = new System.Windows.Forms.Button();
						this.label1 = new System.Windows.Forms.Label();
						this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
						this.SuspendLayout();
						// 
						// textBox1
						// 
						this.textBox1.Location = new System.Drawing.Point(12, 52);
						this.textBox1.Name = "textBox1";
						this.textBox1.Size = new System.Drawing.Size(262, 22);
						this.textBox1.TabIndex = 0;
						// 
						// buttonOKsaveImage
						// 
						this.buttonOKsaveImage.Location = new System.Drawing.Point(199, 89);
						this.buttonOKsaveImage.Name = "buttonOKsaveImage";
						this.buttonOKsaveImage.Size = new System.Drawing.Size(75, 23);
						this.buttonOKsaveImage.TabIndex = 1;
						this.buttonOKsaveImage.Text = "OK";
						this.buttonOKsaveImage.UseVisualStyleBackColor = true;
						this.buttonOKsaveImage.Click += new System.EventHandler(this.buttonOKsaveImage_Click);
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(12, 32);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(74, 17);
						this.label1.TabIndex = 2;
						this.label1.Text = "New name";
						// 
						// FormSaveImage
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(308, 132);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.buttonOKsaveImage);
						this.Controls.Add(this.textBox1);
						this.Name = "FormSaveImage";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
						this.Text = "Save image";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.TextBox textBox1;
				private System.Windows.Forms.Button buttonOKsaveImage;
				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		}
}