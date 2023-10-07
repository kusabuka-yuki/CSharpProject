namespace ClipBordSaveSupport
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
            this.btn_saveShopName = new System.Windows.Forms.Button();
            this.btn_Tel = new System.Windows.Forms.Button();
            this.btn_Date = new System.Windows.Forms.Button();
            this.btn_AmountSum = new System.Windows.Forms.Button();
            this.btn_Tax10 = new System.Windows.Forms.Button();
            this.btn_Tax8 = new System.Windows.Forms.Button();
            this.btn_Free = new System.Windows.Forms.Button();
            this.btn_No = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_saveShopName
            // 
            this.btn_saveShopName.Location = new System.Drawing.Point(46, 55);
            this.btn_saveShopName.Name = "btn_saveShopName";
            this.btn_saveShopName.Size = new System.Drawing.Size(131, 65);
            this.btn_saveShopName.TabIndex = 0;
            this.btn_saveShopName.Text = "社名を保存する。";
            this.btn_saveShopName.UseVisualStyleBackColor = true;
            this.btn_saveShopName.Click += new System.EventHandler(this.saveShopNameClick);
            // 
            // btn_Tel
            // 
            this.btn_Tel.Location = new System.Drawing.Point(220, 55);
            this.btn_Tel.Name = "btn_Tel";
            this.btn_Tel.Size = new System.Drawing.Size(135, 65);
            this.btn_Tel.TabIndex = 0;
            this.btn_Tel.Text = "電話番号を保存する。";
            this.btn_Tel.UseVisualStyleBackColor = true;
            this.btn_Tel.Click += new System.EventHandler(this.btn_Tel_Click);
            // 
            // btn_Date
            // 
            this.btn_Date.Location = new System.Drawing.Point(399, 55);
            this.btn_Date.Name = "btn_Date";
            this.btn_Date.Size = new System.Drawing.Size(135, 65);
            this.btn_Date.TabIndex = 0;
            this.btn_Date.Text = "日付を保存する。";
            this.btn_Date.UseVisualStyleBackColor = true;
            this.btn_Date.Click += new System.EventHandler(this.btn_Date_Click);
            // 
            // btn_AmountSum
            // 
            this.btn_AmountSum.Location = new System.Drawing.Point(590, 55);
            this.btn_AmountSum.Name = "btn_AmountSum";
            this.btn_AmountSum.Size = new System.Drawing.Size(135, 65);
            this.btn_AmountSum.TabIndex = 0;
            this.btn_AmountSum.Text = "合計金額を保存する。";
            this.btn_AmountSum.UseVisualStyleBackColor = true;
            this.btn_AmountSum.Click += new System.EventHandler(this.btn_AmountSum_Click);
            // 
            // btn_Tax10
            // 
            this.btn_Tax10.Location = new System.Drawing.Point(46, 146);
            this.btn_Tax10.Name = "btn_Tax10";
            this.btn_Tax10.Size = new System.Drawing.Size(131, 65);
            this.btn_Tax10.TabIndex = 0;
            this.btn_Tax10.Text = "10％税込を保存する。";
            this.btn_Tax10.UseVisualStyleBackColor = true;
            this.btn_Tax10.Click += new System.EventHandler(this.btn_Tax10_Click);
            // 
            // btn_Tax8
            // 
            this.btn_Tax8.Location = new System.Drawing.Point(224, 146);
            this.btn_Tax8.Name = "btn_Tax8";
            this.btn_Tax8.Size = new System.Drawing.Size(131, 65);
            this.btn_Tax8.TabIndex = 0;
            this.btn_Tax8.Text = "8％税込を保存する。";
            this.btn_Tax8.UseVisualStyleBackColor = true;
            this.btn_Tax8.Click += new System.EventHandler(this.btn_Tax8_Click);
            // 
            // btn_Free
            // 
            this.btn_Free.Location = new System.Drawing.Point(403, 146);
            this.btn_Free.Name = "btn_Free";
            this.btn_Free.Size = new System.Drawing.Size(131, 65);
            this.btn_Free.TabIndex = 0;
            this.btn_Free.Text = "非課税対象を保存する。";
            this.btn_Free.UseVisualStyleBackColor = true;
            this.btn_Free.Click += new System.EventHandler(this.btn_Free_Click);
            // 
            // btn_No
            // 
            this.btn_No.Location = new System.Drawing.Point(594, 146);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(131, 65);
            this.btn_No.TabIndex = 0;
            this.btn_No.Text = "登録番号を保存する。";
            this.btn_No.UseVisualStyleBackColor = true;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(281, 323);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(109, 44);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "リセット";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(506, 323);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(109, 44);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "閉じる";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_AmountSum);
            this.Controls.Add(this.btn_Date);
            this.Controls.Add(this.btn_Tel);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Free);
            this.Controls.Add(this.btn_Tax8);
            this.Controls.Add(this.btn_Tax10);
            this.Controls.Add(this.btn_saveShopName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_saveShopName;
        private System.Windows.Forms.Button btn_Tel;
        private System.Windows.Forms.Button btn_Date;
        private System.Windows.Forms.Button btn_AmountSum;
        private System.Windows.Forms.Button btn_Tax10;
        private System.Windows.Forms.Button btn_Tax8;
        private System.Windows.Forms.Button btn_Free;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Close;
    }
}

