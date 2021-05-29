namespace encryption
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
      this.textBoxPath = new System.Windows.Forms.TextBox();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.buttonEncrypt = new System.Windows.Forms.Button();
      this.buttonDecrypt = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.labelinfo = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBoxPath
      // 
      this.textBoxPath.BackColor = System.Drawing.SystemColors.Window;
      this.textBoxPath.Location = new System.Drawing.Point(278, 90);
      this.textBoxPath.Name = "textBoxPath";
      this.textBoxPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.textBoxPath.Size = new System.Drawing.Size(323, 22);
      this.textBoxPath.TabIndex = 0;
      this.textBoxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.Location = new System.Drawing.Point(278, 130);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.textBoxPassword.Size = new System.Drawing.Size(323, 22);
      this.textBoxPassword.TabIndex = 1;
      this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // buttonEncrypt
      // 
      this.buttonEncrypt.BackColor = System.Drawing.Color.Transparent;
      this.buttonEncrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEncrypt.BackgroundImage")));
      this.buttonEncrypt.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonEncrypt.ForeColor = System.Drawing.Color.Red;
      this.buttonEncrypt.Location = new System.Drawing.Point(278, 167);
      this.buttonEncrypt.Name = "buttonEncrypt";
      this.buttonEncrypt.Size = new System.Drawing.Size(158, 46);
      this.buttonEncrypt.TabIndex = 2;
      this.buttonEncrypt.Text = "Encrypt";
      this.buttonEncrypt.UseVisualStyleBackColor = false;
      this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
      // 
      // buttonDecrypt
      // 
      this.buttonDecrypt.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonDecrypt.ForeColor = System.Drawing.Color.Red;
      this.buttonDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("buttonDecrypt.Image")));
      this.buttonDecrypt.Location = new System.Drawing.Point(443, 167);
      this.buttonDecrypt.Name = "buttonDecrypt";
      this.buttonDecrypt.Size = new System.Drawing.Size(158, 46);
      this.buttonDecrypt.TabIndex = 3;
      this.buttonDecrypt.Text = "Decrypt";
      this.buttonDecrypt.UseVisualStyleBackColor = true;
      this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(100, 88);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(161, 24);
      this.label1.TabIndex = 4;
      this.label1.Text = "Path to the file";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new System.Drawing.Point(152, 128);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(109, 24);
      this.label2.TabIndex = 5;
      this.label2.Text = "Password";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.ForeColor = System.Drawing.Color.Maroon;
      this.label3.Location = new System.Drawing.Point(667, 288);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Rouzhs";
      // 
      // button3
      // 
      this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.button3.BackColor = System.Drawing.Color.Maroon;
      this.button3.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.button3.Location = new System.Drawing.Point(664, 2);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(56, 32);
      this.button3.TabIndex = 7;
      this.button3.Text = "Exit";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.ButtonExitClick);
      // 
      // labelinfo
      // 
      this.labelinfo.AutoSize = true;
      this.labelinfo.BackColor = System.Drawing.Color.Transparent;
      this.labelinfo.Font = new System.Drawing.Font("Lucida Calligraphy", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelinfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.labelinfo.Location = new System.Drawing.Point(278, 247);
      this.labelinfo.Name = "labelinfo";
      this.labelinfo.Size = new System.Drawing.Size(0, 24);
      this.labelinfo.TabIndex = 8;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.MintCream;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(721, 310);
      this.Controls.Add(this.labelinfo);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonDecrypt);
      this.Controls.Add(this.buttonEncrypt);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.textBoxPath);
      this.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Cryptographer";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxPath;
    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.Button buttonEncrypt;
    private System.Windows.Forms.Button buttonDecrypt;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label labelinfo;
  }
}

