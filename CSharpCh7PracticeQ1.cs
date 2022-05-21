using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7PracticeQ1 {
		public partial class Form1:Form {
				public Form1() {
						InitializeComponent();
				}
				public static int total=0;
				public static int[] money= { 50, 40, 30, 20};
				private void Form1_Load(object sender,EventArgs e) {
						listBox1.Items.Insert(0, "A $50");
						listBox1.Items.Insert(1, "B $40");
						listBox1.Items.Insert(2, "C $30");
						listBox1.Items.Insert(3, "D $20");
						button1.Text = "-->>";
						button2.Text = "<<--";
						label1.Text = $"Total : {total}";
				}

				private void button1_Click(object sender,EventArgs e) {
						for(int i = 0; i < listBox1.Items.Count; i++) {
								if(listBox1.GetSelected(i)) {
										listBox2.Items.Add(listBox1.Items[i]);
								}
						}
						total+= money[listBox1.SelectedIndex];
						label1.Text = $"Total : {total}";
				}

				private void button2_Click(object sender,EventArgs e) {
						for(int i = 0; i < listBox1.Items.Count; i++) {
								if(listBox2.SelectedItem == listBox1.Items[i]) {
										total-= money[i];
								}
						}
						for(int i = 0; i < listBox2.Items.Count; i++) {
								if(listBox2.GetSelected(i)) {
										listBox2.Items.Remove(listBox2.SelectedItem);
								}
						}
						label1.Text = $"Total : {total}";
				}
		}
}
