using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RakendusteLoomine_Valkrusman
{
    public partial class PildiApp : Form
    {
        
        TableLayoutPanel tableLayoutPanel;
        FlowLayoutPanel flowLayoutPanel;
        PictureBox pictureBox;
        PictureBox pilt;
        CheckBox checkBox;
        Button clear_btn;
        Button show_btn;
        Button close_btn;
        int x = 150;
        int y = 450;

        public PildiApp()
        {
            this.Text = "Pildid";
            this.Size = new System.Drawing.Size(900, 500);
            tableLayoutPanel = new TableLayoutPanel
            {
                AutoSize = true,
                ColumnCount = 2,
                RowCount = 2,
                Location = new System.Drawing.Point(900, 500),
                TabIndex = 0,
                BackColor = System.Drawing.Color.White,
            };
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle
                (System.Windows.Forms.SizeType.Percent, 15f));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle
                (System.Windows.Forms.SizeType.Percent, 85f));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle
                (System.Windows.Forms.SizeType.Percent, 90f));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle
                (System.Windows.Forms.SizeType.Percent, 5f));
            tableLayoutPanel.ResumeLayout(false);

            this.Controls.Add(tableLayoutPanel);


            pilt = new PictureBox
            {
                Image = new Bitmap(@"..\..\france.jpg"),
                Location = new Point(x, y),
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            pictureBox = new System.Windows.Forms.PictureBox
            {
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                Dock = System.Windows.Forms.DockStyle.Fill,
                TabIndex = 0,
                TabStop = false,
            };
            tableLayoutPanel.Controls.Add(pictureBox, 0, 0);
            tableLayoutPanel.SetCellPosition(pictureBox, new TableLayoutPanelCellPosition(0, 0));
            tableLayoutPanel.SetColumnSpan(pictureBox, 2);


            checkBox = new CheckBox
            {
                Text = "Venita",
                Dock = System.Windows.Forms.DockStyle.Fill,
            };
            tableLayoutPanel.Controls.Add(checkBox, 1, 0);
            this.Controls.Add(tableLayoutPanel);

            close_btn = new Button
            {
                Text = "Pane Kinni",
                Dock = System.Windows.Forms.DockStyle.Fill,
            };
            clear_btn = new Button
            {
                Text = "Näita",
                Dock = System.Windows.Forms.DockStyle.Fill,
            };
            show_btn = new Button
            {
                Text = "Näita",
                Dock = System.Windows.Forms.DockStyle.Fill,
            };
            Button[] buttons = { clear_btn, show_btn, close_btn };
            flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                AutoSize = true,
                WrapContents=false,
                AutoScroll=true,
                Location=new System.Drawing.Point(125,420),
                Size=new System.Drawing.Size(300,50),
            };
            foreach(Button button in buttons)
            {
                flowLayoutPanel.Controls.Add(button);
            }
            tableLayoutPanel.Controls.Add(flowLayoutPanel, 1, 1);
            this.Controls.Add(tableLayoutPanel);

        }





        //PictureBox pictureBox1;
        //CheckBox checkBox1;
        //ColorDialog colorDialog1;



        //public PildiApp()
        //{
        //    InitializeComponent();
        //}



        //private void ShowButton_Click(object sender, EventArgs e)
        //{

        //    Location = new System.Drawing.Point(50, 175);
        //    Size = new System.Drawing.Size(100, 20);

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        pictureBox1.Load(openFileDialog1.FileName);
        //    }
        //}

        //private void clearButton_Click(object sender, EventArgs e)
        //{
        //    Location = new System.Drawing.Point(50, 155);
        //    Size = new System.Drawing.Size(100, 20);
        //    pictureBox1.Image = null;
        //}

        //private void backgroundButton_Click(object sender, EventArgs e)
        //{
        //    Location = new System.Drawing.Point(50, 145);
        //    Size = new System.Drawing.Size(100, 20);
        //    if (colorDialog1.ShowDialog() == DialogResult.OK)
        //        pictureBox1.BackColor = colorDialog1.Color;
        //}

        //private void closeButton_Click(object sender, EventArgs e)
        //{
        //    Location = new System.Drawing.Point(50, 135);
        //    Size = new System.Drawing.Size(100, 20);
        //    this.Close();
        //}

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked)
        //        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    else
        //        pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        //}


    } 
}
  


         
