namespace WindowsFormsApp1
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.btnSetForm1Title = new System.Windows.Forms.Button();
            this.checkBoxForm1StatusBar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(12, 12);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 21);
            this.text1.TabIndex = 0;
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);
            // 
            // btnSetForm1Title
            // 
            this.btnSetForm1Title.Location = new System.Drawing.Point(119, 12);
            this.btnSetForm1Title.Name = "btnSetForm1Title";
            this.btnSetForm1Title.Size = new System.Drawing.Size(124, 23);
            this.btnSetForm1Title.TabIndex = 1;
            this.btnSetForm1Title.Text = "设置窗口1文字";
            this.btnSetForm1Title.UseVisualStyleBackColor = true;
            this.btnSetForm1Title.Click += new System.EventHandler(this.btnSetForm1Title_Click);
            // 
            // checkBoxForm1StatusBar
            // 
            this.checkBoxForm1StatusBar.AutoSize = true;
            this.checkBoxForm1StatusBar.Location = new System.Drawing.Point(13, 40);
            this.checkBoxForm1StatusBar.Name = "checkBoxForm1StatusBar";
            this.checkBoxForm1StatusBar.Size = new System.Drawing.Size(138, 16);
            this.checkBoxForm1StatusBar.TabIndex = 2;
            this.checkBoxForm1StatusBar.Text = "是否显示窗口1状态栏";
            this.checkBoxForm1StatusBar.UseVisualStyleBackColor = true;
            this.checkBoxForm1StatusBar.CheckedChanged += new System.EventHandler(this.checkBoxForm1StatusBar_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxForm1StatusBar);
            this.Controls.Add(this.btnSetForm1Title);
            this.Controls.Add(this.text1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button btnSetForm1Title;
        private System.Windows.Forms.CheckBox checkBoxForm1StatusBar;
    }
}