namespace Ch7PracticeQ2 {
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
						this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
						this.comboBox1 = new System.Windows.Forms.ComboBox();
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.label3 = new System.Windows.Forms.Label();
						this.SuspendLayout();
						// 
						// checkedListBox1
						// 
						this.checkedListBox1.FormattingEnabled = true;
						this.checkedListBox1.Location = new System.Drawing.Point(367, 166);
						this.checkedListBox1.Name = "checkedListBox1";
						this.checkedListBox1.Size = new System.Drawing.Size(120, 84);
						this.checkedListBox1.TabIndex = 0;
						this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
						// 
						// comboBox1
						// 
						this.comboBox1.FormattingEnabled = true;
						this.comboBox1.Location = new System.Drawing.Point(367, 63);
						this.comboBox1.Name = "comboBox1";
						this.comboBox1.Size = new System.Drawing.Size(121, 23);
						this.comboBox1.TabIndex = 1;
						this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(255, 63);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(41, 15);
						this.label1.TabIndex = 2;
						this.label1.Text = "label1";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Location = new System.Drawing.Point(255, 166);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(41, 15);
						this.label2.TabIndex = 3;
						this.label2.Text = "label2";
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Location = new System.Drawing.Point(317, 316);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(41, 15);
						this.label3.TabIndex = 4;
						this.label3.Text = "label3";
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(800, 450);
						this.Controls.Add(this.label3);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.comboBox1);
						this.Controls.Add(this.checkedListBox1);
						this.Name = "Form1";
						this.Text = "Form1";
						this.Load += new System.EventHandler(this.Form1_Load);
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.CheckedListBox checkedListBox1;
				private System.Windows.Forms.ComboBox comboBox1;
				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Label label3;
		}
}

