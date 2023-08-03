namespace KURS
{
    partial class AuthorForm
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
            this.выбратьЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьРешениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxProblem = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.выбратьЗадачуToolStripMenuItem,
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
            // выбратьЗадачуToolStripMenuItem
            // 
            this.выбратьЗадачуToolStripMenuItem.Name = "выбратьЗадачуToolStripMenuItem";
            this.выбратьЗадачуToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.выбратьЗадачуToolStripMenuItem.Text = "Выбрать задачу";
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
            // AddTask
            // 
            this.AddTask.Location = new System.Drawing.Point(1053, 282);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(173, 37);
            this.AddTask.TabIndex = 6;
            this.AddTask.Text = "Сохранить задачу";
            this.AddTask.UseVisualStyleBackColor = true;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Входные данные";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 321);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(608, 75);
            this.textBoxInput.TabIndex = 8;
            this.textBoxInput.Text = "";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 444);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(608, 75);
            this.textBoxOutput.TabIndex = 10;
            this.textBoxOutput.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выходные данные";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1053, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Удалить задачу";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 596);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProblem);
            this.Controls.Add(this.textBoxDecision);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AuthorForm";
            this.Text = "Рожков Вячеслав, автор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxDecision;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьРешениеToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBoxProblem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textBoxInput;
        private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}

