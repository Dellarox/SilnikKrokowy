using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTD2XX_NET;

namespace SilnikKrokKraKor
{
    public partial class Form1 : Form
    {



        string[] modes = { "Falowy", "Pełnokrokowy", "Półkrokowy" };
        FTDI ftdiDevice;
        FTD2XX_NET.FTDI.FT_STATUS ftstatus;
        byte[] fullStep = { 0x06, 0x0A, 0x09, 0x05 };
        byte[] waveStep = { 0x04, 0x02, 0x08, 0x01 };
        byte[] halfStep = { 0x04, 0x06, 0x02, 0x0A, 0x08, 0x09, 0x01, 0x05 };
        UInt32 numBytesWritten = 0;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e)
     {
            try
            {
                UInt32 ftdiDeviceCount = 0;
                ftdiDevice = new FTDI();
                ftdiDevice.GetNumberOfDevices(ref ftdiDeviceCount);
                FTDI.FT_DEVICE_INFO_NODE[] ftdiDeviceList = new FTDI.FT_DEVICE_INFO_NODE[ftdiDeviceCount];
                ftdiDevice.GetDeviceList(ftdiDeviceList);
                ftdiDevice.OpenBySerialNumber(ftdiDeviceList[0].SerialNumber);
                ftdiDevice.SetBitMode(0xff, 1);
                richTextBoxInfo.Text += "connected\n";
                richTextBoxInfo.SelectionStart = richTextBoxInfo.Text.Length;
                richTextBoxInfo.ScrollToCaret();
                foreach (string name in modes)
                {
                    comboBoxModes.Items.Add(name);
                }
            }
            catch
            {
                richTextBoxInfo.Text = "nieudane connected\n";
            }
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            foreach (string name in modes)
            {
                comboBoxModes.Items.Remove(name);
            }

            byte[] endConnection = { 0x00 };
            Int32 bytesToWrite = 1;
            UInt32 bytesWritten = 0;
            ftstatus = ftdiDevice.Write(endConnection, bytesToWrite, ref bytesWritten);
            comboBoxModes.ResetText();
            richTextBoxInfo.Text += "disconnected\n";
            richTextBoxInfo.SelectionStart = richTextBoxInfo.Text.Length;
            richTextBoxInfo.ScrollToCaret();
        }

        private void buttonStepRight_Click(object sender, EventArgs e)
        {
            int stepAmount = Convert.ToInt32(textBoxStepAmount.Text);
            int stepTime = Convert.ToInt32(textBoxStepTime.Text);
            if (comboBoxModes.Text == modes[1] && ftdiDevice.IsOpen)
            {
                fullStepFunc(stepAmount, -1, fullStep, stepTime);
            }

            if (comboBoxModes.Text == modes[0] && ftdiDevice.IsOpen)
            {
                fullStepFunc(stepAmount, -1, waveStep, stepTime);
            }

            if (comboBoxModes.Text == modes[2] && ftdiDevice.IsOpen)
            {
                halfStepFunc(stepAmount, -1, halfStep, stepTime);
            }
        }

        private void fullStepFunc(int stepAmount, int direction, byte[] tab, int time)
        {
            numBytesWritten = 0;
            Int32 bytesToWrite = 1;
            for (int i = 0; i < stepAmount; i++)
            {
                index += direction;
                if (index > 3)
                {
                    index = 0;
                }
                else if (index < 0)
                {
                    index = 3;
                }

                byte[] x = { tab[index] };
                ftdiDevice.Write(x, bytesToWrite, ref numBytesWritten);
            
                Thread.Sleep(time);
            }
            byte[] y = { 0x00 };

            ftdiDevice.Write(y, bytesToWrite, ref numBytesWritten);
        }

        private void halfStepFunc(int stepAmount, int direction, byte[] tab, int time)
        {
            numBytesWritten = 0;
            Int32 bytesToWrite = 1;
            for (int i = 0; i < stepAmount; i++)
            {
                index += direction;
                if (index > 7)
                {
                    index = 0;
                }
                else if (index < 0)
                {
                    index = 7;
                }

                byte[] x = { tab[index] };
                ftdiDevice.Write(x, bytesToWrite, ref numBytesWritten);

                Thread.Sleep(time);
            }
            byte[] y = { 0x00 };

            ftdiDevice.Write(y, bytesToWrite, ref numBytesWritten);
        }

        private void buttonStepLeft_Click(object sender, EventArgs e)
        {
            int stepAmount = Convert.ToInt32(textBoxStepAmount.Text);
            int stepTime = Convert.ToInt32(textBoxStepTime.Text);

            if (comboBoxModes.Text == modes[1] && ftdiDevice.IsOpen)
            {
                fullStepFunc(stepAmount, 1, fullStep, stepTime);
            }

            if (comboBoxModes.Text == modes[0] && ftdiDevice.IsOpen)
            {
                fullStepFunc(stepAmount, 1, waveStep, stepTime);
            }

            if (comboBoxModes.Text == modes[2] && ftdiDevice.IsOpen)
            {
                halfStepFunc(stepAmount, 1, halfStep, stepTime);
            }
        }

        private void buttonFiveStepsRight_Click(object sender, EventArgs e)
        {
            int stepAmount = 5;
            int stepTime = 1000;
            if (comboBoxModes.Text == modes[1] && ftdiDevice.IsOpen)
            {
                fullStepFunc(stepAmount, -1, fullStep, stepTime);
            }

            if (comboBoxModes.Text == modes[0] && ftdiDevice.IsOpen)
            {
                fullStepFunc(stepAmount, -1, waveStep, stepTime);
            }

            if (comboBoxModes.Text == modes[2] && ftdiDevice.IsOpen)
            {
                halfStepFunc(stepAmount, -1, halfStep, stepTime);
            }
        }

        private void buttonFiveStepsLeft_Click(object sender, EventArgs e)
        {
            int stepAmount = 5;
            int stepTime = 1000;
            if (comboBoxModes.Text == modes[1] && ftdiDevice.IsOpen)
            {
                fullStepFunc(stepAmount, 1, fullStep, stepTime);
            }

            if (comboBoxModes.Text == modes[0] && ftdiDevice.IsOpen)
            {
                fullStepFunc(stepAmount, 1, waveStep, stepTime);
            }

            if (comboBoxModes.Text == modes[2] && ftdiDevice.IsOpen)
            {
                halfStepFunc(stepAmount, 1, halfStep, stepTime);
            }
        
        }
    }
}
