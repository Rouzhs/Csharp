﻿namespace Studio
{
		partial class ReferForm
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
						this.button1 = new System.Windows.Forms.Button();
						this.label1 = new System.Windows.Forms.Label();
						this.SuspendLayout();
						// 
						// textBox1
						// 
						this.textBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.textBox1.Location = new System.Drawing.Point(27, 74);
						this.textBox1.Multiline = true;
						this.textBox1.Name = "textBox1";
						this.textBox1.Size = new System.Drawing.Size(440, 34);
						this.textBox1.TabIndex = 0;
						// 
						// button1
						// 
						this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.button1.Location = new System.Drawing.Point(373, 124);
						this.button1.Name = "button1";
						this.button1.Size = new System.Drawing.Size(94, 29);
						this.button1.TabIndex = 1;
						this.button1.Text = "Add";
						this.button1.UseVisualStyleBackColor = true;
						this.button1.Click += new System.EventHandler(this.buttonAdd_Click);
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.label1.Location = new System.Drawing.Point(24, 45);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(127, 20);
						this.label1.TabIndex = 2;
						this.label1.Text = "Enter Assembly";
						// 
						// ReferForm
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(495, 191);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.button1);
						this.Controls.Add(this.textBox1);
						this.Name = "ReferForm";
						this.Text = "Add reference";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.TextBox textBox1;
				private System.Windows.Forms.Button button1;
				private System.Windows.Forms.Label label1;
		}
}