namespace OutputClipBoardImageDuringCharacter
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.CheckNotRemoveSpace = new System.Windows.Forms.CheckBox();
            this.CheckBoxReadTell = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSubmit.Location = new System.Drawing.Point(543, 247);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 0;
            this.BtnSubmit.Text = "文字取得";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.Location = new System.Drawing.Point(30, 12);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(588, 217);
            this.TextBox.TabIndex = 2;
            this.TextBox.Text = "";
            // 
            // CheckNotRemoveSpace
            // 
            this.CheckNotRemoveSpace.AutoSize = true;
            this.CheckNotRemoveSpace.Location = new System.Drawing.Point(30, 251);
            this.CheckNotRemoveSpace.Name = "CheckNotRemoveSpace";
            this.CheckNotRemoveSpace.Size = new System.Drawing.Size(110, 16);
            this.CheckNotRemoveSpace.TabIndex = 3;
            this.CheckNotRemoveSpace.Text = "空白を除去しない";
            this.CheckNotRemoveSpace.UseVisualStyleBackColor = true;
            // 
            // CheckBoxReadTell
            // 
            this.CheckBoxReadTell.AutoSize = true;
            this.CheckBoxReadTell.Location = new System.Drawing.Point(155, 251);
            this.CheckBoxReadTell.Name = "CheckBoxReadTell";
            this.CheckBoxReadTell.Size = new System.Drawing.Size(96, 16);
            this.CheckBoxReadTell.TabIndex = 4;
            this.CheckBoxReadTell.Text = "電話番号読込";
            this.CheckBoxReadTell.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 282);
            this.Controls.Add(this.CheckBoxReadTell);
            this.Controls.Add(this.CheckNotRemoveSpace);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.BtnSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.CheckBox CheckNotRemoveSpace;
        private System.Windows.Forms.CheckBox CheckBoxReadTell;
    }
}

