namespace WindowManipulator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbProcessName = new System.Windows.Forms.ComboBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbProcessName
            // 
            this.cmbProcessName.FormattingEnabled = true;
            this.cmbProcessName.Location = new System.Drawing.Point(8, 8);
            this.cmbProcessName.Name = "cmbProcessName";
            this.cmbProcessName.Size = new System.Drawing.Size(200, 20);
            this.cmbProcessName.TabIndex = 0;
            this.cmbProcessName.Text = "notepad";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(144, 32);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(64, 23);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "設定";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(8, 33);
            this.txtW.MaxLength = 8;
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(56, 19);
            this.txtW.TabIndex = 2;
            this.txtW.Text = "320";
            this.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(80, 33);
            this.txtH.MaxLength = 8;
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(56, 19);
            this.txtH.TabIndex = 3;
            this.txtH.Text = "320";
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "×";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 64);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.cmbProcessName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Manipulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProcessName;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label1;
    }
}

