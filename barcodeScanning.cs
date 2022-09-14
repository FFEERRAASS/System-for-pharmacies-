﻿using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace pharmacyEnd
{
    public partial class barcodeScanning : MetroFramework.Forms.MetroForm
    {
        public barcodeScanning()
        {
            InitializeComponent();
            
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void barcodeScanning_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'new_Microsoft_Access_DatabaseDataSet.nmDrug' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'drugDataSet.drug' table. You can move, or remove it, as needed.

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in filterInfoCollection)
                comboBox1.Items.Add(device.Name);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            first first = new first();
            this.Hide();
            first.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result =reader.Decode(bitmap);
            if(result != null)
            {
                textBox1.Invoke(new MethodInvoker(delegate ()
                {
                    textBox1.Text = result.ToString();

                }));
            }
            pictureBox1.Image = bitmap;
        }

        private void barcodeScanning_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if(videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text);
            //clear();

        }
        public void clear()
        {
            textBox1.Text = "";
        }
    }
}
