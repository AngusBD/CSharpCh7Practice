﻿namespace Ch7PracticeQ1 {
		partial class Form1 {
				/// <summary>
				/// 設計工具所需的變數。
				/// </summary>
				private System.ComponentModel.IContainer components = null;

				/// <summary>
				/// 清除任何使用中的資源。
				/// </summary>
				/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
				protected override void Dispose(bool disposing) {
						if(disposing && (components != null)) {
								components.Dispose();
						}
						base.Dispose(disposing);
				}

				#region Windows Form 設計工具產生的程式碼

				/// <summary>
				/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
				/// 這個方法的內容。
				/// </summary>
				private void InitializeComponent() {
						this.listBox1 = new System.Windows.Forms.ListBox();
						this.listBox2 = new System.Windows.Forms.ListBox();
						this.button1 = new System.Windows.Forms.Button();
						this.button2 = new System.Windows.Forms.Button();
						this.label1 = new System.Windows.Forms.Label();
						this.SuspendLayout();
						// 
						// listBox1
						// 
						this.listBox1.FormattingEnabled = true;
						this.listBox1.ItemHeight = 15;
						this.listBox1.Location = new System.Drawing.Point(126, 81);
						this.listBox1.Name = "listBox1";
						this.listBox1.Size = new System.Drawing.Size(120, 94);
						this.listBox1.TabIndex = 0;
						// 
						// listBox2
						// 
						this.listBox2.FormattingEnabled = true;
						this.listBox2.ItemHeight = 15;
						this.listBox2.Location = new System.Drawing.Point(520, 81);
						this.listBox2.Name = "listBox2";
						this.listBox2.Size = new System.Drawing.Size(120, 94);
						this.listBox2.TabIndex = 1;
						// 
						// button1
						// 
						this.button1.Location = new System.Drawing.Point(348, 81);
						this.button1.Name = "button1";
						this.button1.Size = new System.Drawing.Size(75, 23);
						this.button1.TabIndex = 2;
						this.button1.Text = "button1";
						this.button1.UseVisualStyleBackColor = true;
						this.button1.Click += new System.EventHandler(this.button1_Click);
						// 
						// button2
						// 
						this.button2.Location = new System.Drawing.Point(348, 152);
						this.button2.Name = "button2";
						this.button2.Size = new System.Drawing.Size(75, 23);
						this.button2.TabIndex = 3;
						this.button2.Text = "button2";
						this.button2.UseVisualStyleBackColor = true;
						this.button2.Click += new System.EventHandler(this.button2_Click);
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(345, 266);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(41, 15);
						this.label1.TabIndex = 4;
						this.label1.Text = "label1";
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(800, 450);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.button2);
						this.Controls.Add(this.button1);
						this.Controls.Add(this.listBox2);
						this.Controls.Add(this.listBox1);
						this.Name = "Form1";
						this.Text = "Form1";
						this.Load += new System.EventHandler(this.Form1_Load);
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.ListBox listBox1;
				private System.Windows.Forms.ListBox listBox2;
				private System.Windows.Forms.Button button1;
				private System.Windows.Forms.Button button2;
				private System.Windows.Forms.Label label1;
		}
}

