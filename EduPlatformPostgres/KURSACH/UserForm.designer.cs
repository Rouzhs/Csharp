namespace KURSACH
{
    partial class UserForm
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
            this.textBoxDecision = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseTask = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьРешениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxProblem = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRunCode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.RichTextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDecision
            // 
            this.textBoxDecision.Location = new System.Drawing.Point(653, 64);
            this.textBoxDecision.Name = "textBoxDecision";
            this.textBoxDecision.Size = new System.Drawing.Size(573, 201);
            this.textBoxDecision.TabIndex = 0;
            this.textBoxDecision.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem,
            this.ChooseTask,
            this.просмотретьРешениеToolStripMenuItem,
            this.личныйКабинетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.toolStripMenuItem.Text = "Выйти";
            // 
            // ChooseTask
            // 
            this.ChooseTask.Name = "ChooseTask";
            this.ChooseTask.Size = new System.Drawing.Size(133, 24);
            this.ChooseTask.Text = "Выбрать задачу";
            this.ChooseTask.Click += new System.EventHandler(this.ChooseTask_Click);
            // 
            // просмотретьРешениеToolStripMenuItem
            // 
            this.просмотретьРешениеToolStripMenuItem.Name = "просмотретьРешениеToolStripMenuItem";
            this.просмотретьРешениеToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.просмотретьРешениеToolStripMenuItem.Text = "Опции";
            // 
            // личныйКабинетToolStripMenuItem
            // 
            this.личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            this.личныйКабинетToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.личныйКабинетToolStripMenuItem.Text = "Личный кабинет";
            // 
            // textBoxProblem
            // 
            this.textBoxProblem.Location = new System.Drawing.Point(12, 64);
            this.textBoxProblem.Name = "textBoxProblem";
            this.textBoxProblem.Size = new System.Drawing.Size(608, 201);
            this.textBoxProblem.TabIndex = 2;
            this.textBoxProblem.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Условие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Решение";
            // 
            // buttonRunCode
            // 
            this.buttonRunCode.Location = new System.Drawing.Point(1115, 275);
            this.buttonRunCode.Name = "buttonRunCode";
            this.buttonRunCode.Size = new System.Drawing.Size(111, 30);
            this.buttonRunCode.TabIndex = 6;
            this.buttonRunCode.Text = "Проверить";
            this.buttonRunCode.UseVisualStyleBackColor = true;
            this.buttonRunCode.Click += new System.EventHandler(this.buttonRunCode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 321);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(608, 115);
            this.textBoxResult.TabIndex = 8;
            this.textBoxResult.Text = "";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(653, 321);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(573, 263);
            this.dataGrid.TabIndex = 9;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 596);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRunCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProblem);
            this.Controls.Add(this.textBoxDecision);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserForm";
            this.Text = "Рожков Вячеслав, участник";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxDecision;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChooseTask;
        private System.Windows.Forms.ToolStripMenuItem просмотретьРешениеToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBoxProblem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRunCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textBoxResult;
        private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}

