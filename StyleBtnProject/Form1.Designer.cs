namespace StyleBtnProject
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.styleableButton1 = new StyleBtnProject.StyleableButton();
            this.styleableButton2 = new StyleBtnProject.StyleableButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // styleableButton1
            // 
            this.styleableButton1.BackColor = System.Drawing.Color.Red;
            this.styleableButton1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.styleableButton1.Location = new System.Drawing.Point(12, 50);
            this.styleableButton1.Name = "styleableButton1";
            this.styleableButton1.Size = new System.Drawing.Size(75, 23);
            this.styleableButton1.StylePattern = StyleBtnProject.StyleableButton.StylePatternEnum.none;
            this.styleableButton1.TabIndex = 1;
            this.styleableButton1.Text = "テスト";
            this.styleableButton1.UseVisualStyleBackColor = true;
            this.styleableButton1.Click += new System.EventHandler(this.styleableButton1_Click);
            // 
            // styleableButton2
            // 
            this.styleableButton2.Location = new System.Drawing.Point(12, 94);
            this.styleableButton2.Name = "styleableButton2";
            this.styleableButton2.Size = new System.Drawing.Size(75, 23);
            this.styleableButton2.StylePattern = StyleBtnProject.StyleableButton.StylePatternEnum.none;
            this.styleableButton2.TabIndex = 3;
            this.styleableButton2.Text = "styleableButton2";
            this.styleableButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 157);
            this.Controls.Add(this.styleableButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.styleableButton1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StyleableButton styleableButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private StyleableButton styleableButton2;
    }
}

