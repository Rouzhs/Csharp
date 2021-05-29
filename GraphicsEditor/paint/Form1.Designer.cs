namespace paint
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
						this.components = new System.ComponentModel.Container();
						this.colorDialog1 = new System.Windows.Forms.ColorDialog();
						this.imageList1 = new System.Windows.Forms.ImageList(this.components);
						this.buttonChangeSelectedColor = new System.Windows.Forms.Button();
						this.pictureBox = new System.Windows.Forms.PictureBox();
						this.buttonCurve = new System.Windows.Forms.Button();
						this.buttonStraight = new System.Windows.Forms.Button();
						this.buttonCircle = new System.Windows.Forms.Button();
						this.buttonRectangle = new System.Windows.Forms.Button();
						this.labelFigure = new System.Windows.Forms.Label();
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.panelSelectedColor = new System.Windows.Forms.Panel();
						this.panel2 = new System.Windows.Forms.Panel();
						this.label3 = new System.Windows.Forms.Label();
						this.panel3 = new System.Windows.Forms.Panel();
						this.vScrollBar = new System.Windows.Forms.VScrollBar();
						this.hScrollBar = new System.Windows.Forms.HScrollBar();
						this.label4 = new System.Windows.Forms.Label();
						this.panelCurrentColor = new System.Windows.Forms.Panel();
						this.label5 = new System.Windows.Forms.Label();
						this.buttonChangeCurrentColor = new System.Windows.Forms.Button();
						((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
						this.panel2.SuspendLayout();
						this.panel3.SuspendLayout();
						this.SuspendLayout();
						// 
						// imageList1
						// 
						this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
						this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
						this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
						// 
						// buttonChangeSelectedColor
						// 
						this.buttonChangeSelectedColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.buttonChangeSelectedColor.Location = new System.Drawing.Point(52, 305);
						this.buttonChangeSelectedColor.Name = "buttonChangeSelectedColor";
						this.buttonChangeSelectedColor.Size = new System.Drawing.Size(301, 42);
						this.buttonChangeSelectedColor.TabIndex = 0;
						this.buttonChangeSelectedColor.Text = "Change Color";
						this.buttonChangeSelectedColor.UseVisualStyleBackColor = true;
						this.buttonChangeSelectedColor.Click += new System.EventHandler(this.buttonChangeSelectedColor_Click);
						// 
						// pictureBox
						// 
						this.pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
						this.pictureBox.Location = new System.Drawing.Point(12, 12);
						this.pictureBox.Name = "pictureBox";
						this.pictureBox.Size = new System.Drawing.Size(1080, 720);
						this.pictureBox.TabIndex = 2;
						this.pictureBox.TabStop = false;
						this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
						this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
						this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
						// 
						// buttonCurve
						// 
						this.buttonCurve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.buttonCurve.Location = new System.Drawing.Point(52, 53);
						this.buttonCurve.Name = "buttonCurve";
						this.buttonCurve.Size = new System.Drawing.Size(155, 61);
						this.buttonCurve.TabIndex = 3;
						this.buttonCurve.Text = "Curve";
						this.buttonCurve.UseVisualStyleBackColor = true;
						this.buttonCurve.Click += new System.EventHandler(this.buttonSomeFigure_Click);
						// 
						// buttonStraight
						// 
						this.buttonStraight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.buttonStraight.Location = new System.Drawing.Point(225, 53);
						this.buttonStraight.Name = "buttonStraight";
						this.buttonStraight.Size = new System.Drawing.Size(155, 61);
						this.buttonStraight.TabIndex = 4;
						this.buttonStraight.Text = "Straight";
						this.buttonStraight.UseVisualStyleBackColor = true;
						this.buttonStraight.Click += new System.EventHandler(this.buttonSomeFigure_Click);
						// 
						// buttonCircle
						// 
						this.buttonCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.buttonCircle.Location = new System.Drawing.Point(52, 130);
						this.buttonCircle.Name = "buttonCircle";
						this.buttonCircle.Size = new System.Drawing.Size(155, 61);
						this.buttonCircle.TabIndex = 5;
						this.buttonCircle.Text = "Circle";
						this.buttonCircle.UseVisualStyleBackColor = true;
						this.buttonCircle.Click += new System.EventHandler(this.buttonSomeFigure_Click);
						// 
						// buttonRectangle
						// 
						this.buttonRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.buttonRectangle.Location = new System.Drawing.Point(225, 130);
						this.buttonRectangle.Name = "buttonRectangle";
						this.buttonRectangle.Size = new System.Drawing.Size(155, 61);
						this.buttonRectangle.TabIndex = 6;
						this.buttonRectangle.Text = "Rectangle";
						this.buttonRectangle.UseVisualStyleBackColor = true;
						this.buttonRectangle.Click += new System.EventHandler(this.buttonSomeFigure_Click);
						// 
						// labelFigure
						// 
						this.labelFigure.AutoSize = true;
						this.labelFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.labelFigure.Location = new System.Drawing.Point(178, 219);
						this.labelFigure.Name = "labelFigure";
						this.labelFigure.Size = new System.Drawing.Size(81, 29);
						this.labelFigure.TabIndex = 7;
						this.labelFigure.Text = "Curve";
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.label1.Location = new System.Drawing.Point(47, 219);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(115, 29);
						this.label1.TabIndex = 8;
						this.label1.Text = "Selected:";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.label2.Location = new System.Drawing.Point(47, 260);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(175, 29);
						this.label2.TabIndex = 9;
						this.label2.Text = "Selected color:";
						// 
						// panelSelectedColor
						// 
						this.panelSelectedColor.BackColor = System.Drawing.Color.Black;
						this.panelSelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
						this.panelSelectedColor.ForeColor = System.Drawing.SystemColors.ControlText;
						this.panelSelectedColor.Location = new System.Drawing.Point(225, 261);
						this.panelSelectedColor.Name = "panelSelectedColor";
						this.panelSelectedColor.Size = new System.Drawing.Size(99, 28);
						this.panelSelectedColor.TabIndex = 10;
						// 
						// panel2
						// 
						this.panel2.BackColor = System.Drawing.Color.Silver;
						this.panel2.Controls.Add(this.label3);
						this.panel2.Controls.Add(this.buttonCircle);
						this.panel2.Controls.Add(this.panelSelectedColor);
						this.panel2.Controls.Add(this.buttonCurve);
						this.panel2.Controls.Add(this.label2);
						this.panel2.Controls.Add(this.buttonStraight);
						this.panel2.Controls.Add(this.label1);
						this.panel2.Controls.Add(this.labelFigure);
						this.panel2.Controls.Add(this.buttonRectangle);
						this.panel2.Controls.Add(this.buttonChangeSelectedColor);
						this.panel2.Location = new System.Drawing.Point(1103, 12);
						this.panel2.Name = "panel2";
						this.panel2.Size = new System.Drawing.Size(410, 371);
						this.panel2.TabIndex = 11;
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label3.Location = new System.Drawing.Point(155, 13);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(104, 24);
						this.label3.TabIndex = 11;
						this.label3.Text = "Painting";
						// 
						// panel3
						// 
						this.panel3.BackColor = System.Drawing.Color.Silver;
						this.panel3.Controls.Add(this.vScrollBar);
						this.panel3.Controls.Add(this.hScrollBar);
						this.panel3.Controls.Add(this.label4);
						this.panel3.Controls.Add(this.panelCurrentColor);
						this.panel3.Controls.Add(this.label5);
						this.panel3.Controls.Add(this.buttonChangeCurrentColor);
						this.panel3.Location = new System.Drawing.Point(1103, 467);
						this.panel3.Name = "panel3";
						this.panel3.Size = new System.Drawing.Size(410, 265);
						this.panel3.TabIndex = 12;
						// 
						// vScrollBar
						// 
						this.vScrollBar.Location = new System.Drawing.Point(346, 17);
						this.vScrollBar.Maximum = 720;
						this.vScrollBar.Name = "vScrollBar";
						this.vScrollBar.Size = new System.Drawing.Size(47, 222);
						this.vScrollBar.TabIndex = 13;
						this.vScrollBar.Value = 1;
						this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
						// 
						// hScrollBar
						// 
						this.hScrollBar.Location = new System.Drawing.Point(23, 198);
						this.hScrollBar.Maximum = 1080;
						this.hScrollBar.Name = "hScrollBar";
						this.hScrollBar.Size = new System.Drawing.Size(301, 41);
						this.hScrollBar.TabIndex = 12;
						this.hScrollBar.Value = 1;
						this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label4.Location = new System.Drawing.Point(82, 17);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(159, 24);
						this.label4.TabIndex = 11;
						this.label4.Text = "Modification";
						// 
						// panelCurrentColor
						// 
						this.panelCurrentColor.BackColor = System.Drawing.Color.Black;
						this.panelCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
						this.panelCurrentColor.ForeColor = System.Drawing.SystemColors.ControlText;
						this.panelCurrentColor.Location = new System.Drawing.Point(225, 66);
						this.panelCurrentColor.Name = "panelCurrentColor";
						this.panelCurrentColor.Size = new System.Drawing.Size(99, 28);
						this.panelCurrentColor.TabIndex = 10;
						// 
						// label5
						// 
						this.label5.AutoSize = true;
						this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.label5.Location = new System.Drawing.Point(18, 66);
						this.label5.Name = "label5";
						this.label5.Size = new System.Drawing.Size(158, 29);
						this.label5.TabIndex = 9;
						this.label5.Text = "Сurrent color:";
						// 
						// buttonChangeCurrentColor
						// 
						this.buttonChangeCurrentColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.buttonChangeCurrentColor.Location = new System.Drawing.Point(23, 111);
						this.buttonChangeCurrentColor.Name = "buttonChangeCurrentColor";
						this.buttonChangeCurrentColor.Size = new System.Drawing.Size(301, 43);
						this.buttonChangeCurrentColor.TabIndex = 0;
						this.buttonChangeCurrentColor.Text = "Change Color";
						this.buttonChangeCurrentColor.UseVisualStyleBackColor = true;
						this.buttonChangeCurrentColor.Click += new System.EventHandler(this.buttonChangeCurrentColor_Click);
						// 
						// Form1
						// 
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
						this.BackColor = System.Drawing.Color.DarkGray;
						this.ClientSize = new System.Drawing.Size(1525, 747);
						this.Controls.Add(this.panel3);
						this.Controls.Add(this.panel2);
						this.Controls.Add(this.pictureBox);
						this.Name = "Form1";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
						this.Text = "Paint";
						((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
						this.panel2.ResumeLayout(false);
						this.panel2.PerformLayout();
						this.panel3.ResumeLayout(false);
						this.panel3.PerformLayout();
						this.ResumeLayout(false);

				}

				#endregion

				private System.Windows.Forms.ColorDialog colorDialog1;
				private System.Windows.Forms.ImageList imageList1;
				private System.Windows.Forms.Button buttonChangeSelectedColor;
				private System.Windows.Forms.Button buttonCurve;
				private System.Windows.Forms.Button buttonStraight;
				private System.Windows.Forms.Button buttonCircle;
				private System.Windows.Forms.Button buttonRectangle;
				private System.Windows.Forms.Label labelFigure;
				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Panel panelSelectedColor;
				private System.Windows.Forms.Panel panel2;
				private System.Windows.Forms.Label label3;
				private System.Windows.Forms.Panel panel3;
				private System.Windows.Forms.Label label4;
				private System.Windows.Forms.Panel panelCurrentColor;
				private System.Windows.Forms.Label label5;
				private System.Windows.Forms.Button buttonChangeCurrentColor;
				private System.Windows.Forms.HScrollBar hScrollBar;
				private System.Windows.Forms.VScrollBar vScrollBar;
				public System.Windows.Forms.PictureBox pictureBox;
		}
}

