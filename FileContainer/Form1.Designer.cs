namespace container
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
						this.label2 = new System.Windows.Forms.Label();
						this.labelOpenedContainer = new System.Windows.Forms.Label();
						this.buttonExtract = new System.Windows.Forms.Button();
						this.textBoxNewContainerName = new System.Windows.Forms.TextBox();
						this.buttonCreateContainer = new System.Windows.Forms.Button();
						this.label4 = new System.Windows.Forms.Label();
						this.buttonOpenContainer = new System.Windows.Forms.Button();
						this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
						this.buttonAddFile = new System.Windows.Forms.Button();
						this.dataGridView = new System.Windows.Forms.DataGridView();
						this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
						this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
						this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
						((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
						this.SuspendLayout();
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.BackColor = System.Drawing.Color.Transparent;
						this.label2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.label2.ForeColor = System.Drawing.Color.White;
						this.label2.Location = new System.Drawing.Point(499, 33);
						this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(150, 31);
						this.label2.TabIndex = 4;
						this.label2.Text = "Is open:";
						//this.label2.Click += new System.EventHandler(this.label2_Click);
						// 
						// labelOpenedContainer
						// 
						this.labelOpenedContainer.AutoSize = true;
						this.labelOpenedContainer.BackColor = System.Drawing.Color.Transparent;
						this.labelOpenedContainer.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
						this.labelOpenedContainer.ForeColor = System.Drawing.Color.White;
						this.labelOpenedContainer.Location = new System.Drawing.Point(657, 33);
						this.labelOpenedContainer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
						this.labelOpenedContainer.Name = "labelOpenedContainer";
						this.labelOpenedContainer.Size = new System.Drawing.Size(31, 31);
						this.labelOpenedContainer.TabIndex = 5;
						this.labelOpenedContainer.Text = " ";
						// 
						// buttonExtract
						// 
						this.buttonExtract.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.buttonExtract.Location = new System.Drawing.Point(907, 143);
						this.buttonExtract.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
						this.buttonExtract.Name = "buttonExtract";
						this.buttonExtract.Size = new System.Drawing.Size(322, 66);
						this.buttonExtract.TabIndex = 6;
						this.buttonExtract.Text = "Extract file";
						this.buttonExtract.UseVisualStyleBackColor = true;
						this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
						// 
						// textBoxNewContainerName
						// 
						this.textBoxNewContainerName.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.textBoxNewContainerName.Location = new System.Drawing.Point(907, 456);
						this.textBoxNewContainerName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
						this.textBoxNewContainerName.Name = "textBoxNewContainerName";
						this.textBoxNewContainerName.Size = new System.Drawing.Size(321, 33);
						this.textBoxNewContainerName.TabIndex = 7;
						// 
						// buttonCreateContainer
						// 
						this.buttonCreateContainer.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.buttonCreateContainer.Location = new System.Drawing.Point(907, 499);
						this.buttonCreateContainer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
						this.buttonCreateContainer.Name = "buttonCreateContainer";
						this.buttonCreateContainer.Size = new System.Drawing.Size(322, 58);
						this.buttonCreateContainer.TabIndex = 8;
						this.buttonCreateContainer.Text = "CreateContainer";
						this.buttonCreateContainer.UseVisualStyleBackColor = true;
						this.buttonCreateContainer.Click += new System.EventHandler(this.buttonCreateContainer_Click);
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.BackColor = System.Drawing.Color.Transparent;
						this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.label4.ForeColor = System.Drawing.Color.Black;
						this.label4.Location = new System.Drawing.Point(903, 423);
						this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(214, 19);
						this.label4.TabIndex = 9;
						this.label4.Text = "New container name:";
						// 
						// buttonOpenContainer
						// 
						this.buttonOpenContainer.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.buttonOpenContainer.Location = new System.Drawing.Point(23, 33);
						this.buttonOpenContainer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
						this.buttonOpenContainer.Name = "buttonOpenContainer";
						this.buttonOpenContainer.Size = new System.Drawing.Size(351, 61);
						this.buttonOpenContainer.TabIndex = 12;
						this.buttonOpenContainer.Text = "Open Container";
						this.buttonOpenContainer.UseVisualStyleBackColor = true;
						this.buttonOpenContainer.Click += new System.EventHandler(this.buttonOpenContainer_Click);
						// 
						// openFileDialog1
						// 
						this.openFileDialog1.FileName = "openFileDialog1";
						// 
						// buttonAddFile
						// 
						this.buttonAddFile.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.buttonAddFile.Location = new System.Drawing.Point(907, 231);
						this.buttonAddFile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
						this.buttonAddFile.Name = "buttonAddFile";
						this.buttonAddFile.Size = new System.Drawing.Size(322, 66);
						this.buttonAddFile.TabIndex = 13;
						this.buttonAddFile.Text = "Add file";
						this.buttonAddFile.UseVisualStyleBackColor = true;
						this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
						// 
						// dataGridView
						// 
						this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
						this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FileSize});
						this.dataGridView.Location = new System.Drawing.Point(23, 143);
						this.dataGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
						this.dataGridView.Name = "dataGridView";
						this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
						this.dataGridView.RowHeadersWidth = 51;
						this.dataGridView.RowTemplate.Height = 24;
						this.dataGridView.Size = new System.Drawing.Size(832, 414);
						this.dataGridView.TabIndex = 14;
						// 
						// FileName
						// 
						this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
						this.FileName.HeaderText = "Name";
						this.FileName.MinimumWidth = 6;
						this.FileName.Name = "FileName";
						this.FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
						// 
						// FileSize
						// 
						this.FileSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
						this.FileSize.HeaderText = "Size (bytes)";
						this.FileSize.MinimumWidth = 6;
						this.FileSize.Name = "FileSize";
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 23F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
						this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
						this.ClientSize = new System.Drawing.Size(1273, 583);
						this.Controls.Add(this.dataGridView);
						this.Controls.Add(this.buttonAddFile);
						this.Controls.Add(this.buttonOpenContainer);
						this.Controls.Add(this.label4);
						this.Controls.Add(this.buttonCreateContainer);
						this.Controls.Add(this.textBoxNewContainerName);
						this.Controls.Add(this.buttonExtract);
						this.Controls.Add(this.labelOpenedContainer);
						this.Controls.Add(this.label2);
						this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
						this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
						this.Name = "Form1";
						this.Text = "Container Explorer";
						//this.Load += new System.EventHandler(this.Form1_Load);
						((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Label labelOpenedContainer;
				private System.Windows.Forms.Button buttonExtract;
				private System.Windows.Forms.TextBox textBoxNewContainerName;
				private System.Windows.Forms.Button buttonCreateContainer;
				private System.Windows.Forms.Label label4;
				private System.Windows.Forms.Button buttonOpenContainer;
				private System.Windows.Forms.OpenFileDialog openFileDialog1;
				private System.Windows.Forms.Button buttonAddFile;
				private System.Windows.Forms.DataGridView dataGridView;
				private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
				private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
				private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
		}
}

