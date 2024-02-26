using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEaserDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private HalconDotNet.HWindowControl hWindowControl1=new HWindowControl();
        private HWindow hw;
        private HDevelopExport a = new HDevelopExport();
        private void button1_Click(object sender, EventArgs e)
        {
            HObject ho_Image;
            HTuple hv_WindowHandle = new HTuple();
            HOperatorSet.GenEmptyObj(out ho_Image);
            HOperatorSet.ReadImage(out ho_Image, "printer_chip/printer_chip_01");
            HOperatorSet.DispObj(ho_Image, hw);
            //HOperatorSet.GenEmptyObj(out ho_Image);
            a.Eraser(ho_Image, hw);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            hWindowControl1.BackColor = System.Drawing.Color.Blue;
            hWindowControl1.BorderColor = System.Drawing.Color.Blue;
            panel1.Controls.Add(hWindowControl1);
            hw = hWindowControl1.HalconWindow;


            //this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            //this.hWindowControl1.Location = new System.Drawing.Point(12, 12);
            //this.hWindowControl1.Name = "hWindowControl1";
            //this.hWindowControl1.Size = new System.Drawing.Size(427, 389);
            //this.hWindowControl1.TabIndex = 1;
            //this.hWindowControl1.WindowSize = new System.Drawing.Size(427, 389);

        }
    }
}
