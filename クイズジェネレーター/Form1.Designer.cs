namespace クイズジェネレーター
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
            this.questionBox = new System.Windows.Forms.TextBox();
            this.answerBox0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answerBox1 = new System.Windows.Forms.TextBox();
            this.answerBox2 = new System.Windows.Forms.TextBox();
            this.answerBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.presenterBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.appendButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.answer)).BeginInit();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(83, 26);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(416, 19);
            this.questionBox.TabIndex = 0;
            // 
            // answerBox0
            // 
            this.answerBox0.Location = new System.Drawing.Point(82, 67);
            this.answerBox0.Name = "answerBox0";
            this.answerBox0.Size = new System.Drawing.Size(416, 19);
            this.answerBox0.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "問題";
            // 
            // answerBox1
            // 
            this.answerBox1.Location = new System.Drawing.Point(83, 99);
            this.answerBox1.Name = "answerBox1";
            this.answerBox1.Size = new System.Drawing.Size(416, 19);
            this.answerBox1.TabIndex = 3;
            // 
            // answerBox2
            // 
            this.answerBox2.Location = new System.Drawing.Point(83, 132);
            this.answerBox2.Name = "answerBox2";
            this.answerBox2.Size = new System.Drawing.Size(416, 19);
            this.answerBox2.TabIndex = 4;
            // 
            // answerBox3
            // 
            this.answerBox3.Location = new System.Drawing.Point(82, 165);
            this.answerBox3.Name = "answerBox3";
            this.answerBox3.Size = new System.Drawing.Size(417, 19);
            this.answerBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "選択肢0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "選択肢3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "選択肢1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "選択肢2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "制作者";
            // 
            // presenterBox
            // 
            this.presenterBox.Location = new System.Drawing.Point(312, 224);
            this.presenterBox.Name = "presenterBox";
            this.presenterBox.Size = new System.Drawing.Size(85, 19);
            this.presenterBox.TabIndex = 13;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(186, 224);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(89, 19);
            this.genreBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "ジャンル";
            // 
            // appendButton
            // 
            this.appendButton.Location = new System.Drawing.Point(424, 220);
            this.appendButton.Name = "appendButton";
            this.appendButton.Size = new System.Drawing.Size(75, 23);
            this.appendButton.TabIndex = 16;
            this.appendButton.Text = "作成";
            this.appendButton.UseVisualStyleBackColor = true;
            this.appendButton.Click += new System.EventHandler(this.append_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "正解の番号";
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.answer.Location = new System.Drawing.Point(80, 224);
            this.answer.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(50, 22);
            this.answer.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 264);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.appendButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.presenterBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answerBox3);
            this.Controls.Add(this.answerBox2);
            this.Controls.Add(this.answerBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerBox0);
            this.Controls.Add(this.questionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "クイズジェネレータ";
            ((System.ComponentModel.ISupportInitialize)(this.answer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.TextBox answerBox0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answerBox1;
        private System.Windows.Forms.TextBox answerBox2;
        private System.Windows.Forms.TextBox answerBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox presenterBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button appendButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown answer;
    }
}

