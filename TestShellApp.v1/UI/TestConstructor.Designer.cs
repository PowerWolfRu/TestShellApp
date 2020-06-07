namespace TestShellApp.v1
{
    partial class TestConstructor
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
            this.label1 = new System.Windows.Forms.Label();
            this.QuestBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AnswBox1 = new System.Windows.Forms.TextBox();
            this.AnswBox2 = new System.Windows.Forms.TextBox();
            this.AnswBox3 = new System.Windows.Forms.TextBox();
            this.AnswBox4 = new System.Windows.Forms.TextBox();
            this.RightAnswBox = new System.Windows.Forms.TextBox();
            this.NextQuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вопрос:";
            // 
            // QuestBox
            // 
            this.QuestBox.Location = new System.Drawing.Point(13, 30);
            this.QuestBox.Multiline = true;
            this.QuestBox.Name = "QuestBox";
            this.QuestBox.Size = new System.Drawing.Size(366, 34);
            this.QuestBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ответ №1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ответ №2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ответ №3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ответ №4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Правильный ответ:";
            // 
            // AnswBox1
            // 
            this.AnswBox1.Location = new System.Drawing.Point(79, 87);
            this.AnswBox1.Name = "AnswBox1";
            this.AnswBox1.Size = new System.Drawing.Size(300, 20);
            this.AnswBox1.TabIndex = 7;
            // 
            // AnswBox2
            // 
            this.AnswBox2.Location = new System.Drawing.Point(79, 120);
            this.AnswBox2.Name = "AnswBox2";
            this.AnswBox2.Size = new System.Drawing.Size(300, 20);
            this.AnswBox2.TabIndex = 8;
            // 
            // AnswBox3
            // 
            this.AnswBox3.Location = new System.Drawing.Point(79, 152);
            this.AnswBox3.Name = "AnswBox3";
            this.AnswBox3.Size = new System.Drawing.Size(300, 20);
            this.AnswBox3.TabIndex = 9;
            // 
            // AnswBox4
            // 
            this.AnswBox4.Location = new System.Drawing.Point(79, 189);
            this.AnswBox4.Name = "AnswBox4";
            this.AnswBox4.Size = new System.Drawing.Size(300, 20);
            this.AnswBox4.TabIndex = 10;
            // 
            // RightAnswBox
            // 
            this.RightAnswBox.Location = new System.Drawing.Point(125, 236);
            this.RightAnswBox.Name = "RightAnswBox";
            this.RightAnswBox.Size = new System.Drawing.Size(254, 20);
            this.RightAnswBox.TabIndex = 11;
            // 
            // NextQuest
            // 
            this.NextQuest.Location = new System.Drawing.Point(290, 280);
            this.NextQuest.Name = "NextQuest";
            this.NextQuest.Size = new System.Drawing.Size(89, 23);
            this.NextQuest.TabIndex = 12;
            this.NextQuest.Text = "Далее";
            this.NextQuest.UseVisualStyleBackColor = true;
            this.NextQuest.Click += new System.EventHandler(this.NextQuest_Click);
            // 
            // TestConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 315);
            this.Controls.Add(this.NextQuest);
            this.Controls.Add(this.RightAnswBox);
            this.Controls.Add(this.AnswBox4);
            this.Controls.Add(this.AnswBox3);
            this.Controls.Add(this.AnswBox2);
            this.Controls.Add(this.AnswBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuestBox);
            this.Controls.Add(this.label1);
            this.Name = "TestConstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "x";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestConstructor_FormClosing);
            this.Load += new System.EventHandler(this.TestConstructor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuestBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AnswBox1;
        private System.Windows.Forms.TextBox AnswBox2;
        private System.Windows.Forms.TextBox AnswBox3;
        private System.Windows.Forms.TextBox AnswBox4;
        private System.Windows.Forms.TextBox RightAnswBox;
        private System.Windows.Forms.Button NextQuest;
    }
}