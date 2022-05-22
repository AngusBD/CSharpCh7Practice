using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7PracticeQ2 {
		public partial class Form1:Form {
				public Form1() {
						InitializeComponent();
				}
				public static int total = 0;
				public static string[] roomList=new string[] {"Exquisite Double Room $3000", "Landscape Double Room $4000", "Luxury Double Room $6000"};
				public static string[] servicesList = new string[] { "Breakfast $200","Linch $400","Dinner $600","Mountain guide $300" };
				private void Form1_Load(object sender,EventArgs e) {
						label1.Text = "Room : ";
						label2.Text = "Extra Services : ";
						label3.Text = $"Total : ${total}";
						comboBox1.Size = new Size(170, 30);
						comboBox1.Items.AddRange(roomList);
						checkedListBox1.Size = new Size(170, 90);
						checkedListBox1.Items.AddRange(servicesList);
				}

				private void comboBox1_SelectedIndexChanged(object sender,EventArgs e) {
						if(comboBox1.SelectedIndex == 0) {
								total = 3000;
						}
						else if(comboBox1.SelectedIndex == 1) {
								total = 4000;
						}
						else if(comboBox1.SelectedIndex == 2) {
								total = 6000;
						}
						if(checkedListBox1.GetItemChecked(0) == true) {
								total += 200;
						}
						if(checkedListBox1.GetItemChecked(1) == true) {
								total += 400;
						}
						if(checkedListBox1.GetItemChecked(2) == true) {
								total += 600;
						}
						if(checkedListBox1.GetItemChecked(3) == true) {
								total += 300;
						}
						label3.Text = $"Total : ${total}";
				}

				private void checkedListBox1_SelectedIndexChanged(object sender,EventArgs e) {
						comboBox1_SelectedIndexChanged(sender, e);
				}
		}
}
