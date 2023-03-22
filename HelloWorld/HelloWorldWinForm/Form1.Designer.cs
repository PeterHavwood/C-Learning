namespace HelloWorldWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2SayHello = new System.Windows.Forms.TextBox();
            this.buttonClick2Hello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2SayHello
            // 
            this.textBox2SayHello.Location = new System.Drawing.Point(12, 54);
            this.textBox2SayHello.Name = "textBox2SayHello";
            this.textBox2SayHello.Size = new System.Drawing.Size(263, 25);
            this.textBox2SayHello.TabIndex = 0;
            this.textBox2SayHello.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonClick2Hello
            // 
            this.buttonClick2Hello.Location = new System.Drawing.Point(99, 151);
            this.buttonClick2Hello.Name = "buttonClick2Hello";
            this.buttonClick2Hello.Size = new System.Drawing.Size(75, 23);
            this.buttonClick2Hello.TabIndex = 1;
            this.buttonClick2Hello.Text = "Click";
            this.buttonClick2Hello.UseVisualStyleBackColor = true;
            this.buttonClick2Hello.Click += new System.EventHandler(this.buttonClick2Hello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 256);
            this.Controls.Add(this.buttonClick2Hello);
            this.Controls.Add(this.textBox2SayHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2SayHello;
        private System.Windows.Forms.Button buttonClick2Hello;
    }
}

