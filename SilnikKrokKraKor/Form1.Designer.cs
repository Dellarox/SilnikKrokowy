namespace SilnikKrokKraKor
{
    partial class Form1
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
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.comboBoxModes = new System.Windows.Forms.ComboBox();
            this.textBoxStepAmount = new System.Windows.Forms.TextBox();
            this.textBoxStepTime = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelStepAmount = new System.Windows.Forms.Label();
            this.buttonStepRight = new System.Windows.Forms.Button();
            this.buttonStepLeft = new System.Windows.Forms.Button();
            this.labelSteptime = new System.Windows.Forms.Label();
            this.buttonFiveStepsRight = new System.Windows.Forms.Button();
            this.buttonFiveStepsLeft = new System.Windows.Forms.Button();
            this.comboBoxChooseDevice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(49, 159);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(265, 95);
            this.richTextBoxInfo.TabIndex = 0;
            this.richTextBoxInfo.Text = "";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(49, 97);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(121, 41);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "PODLACZ";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(193, 97);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(121, 41);
            this.button_disconnect.TabIndex = 2;
            this.button_disconnect.Text = "ODLACZ";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // comboBoxModes
            // 
            this.comboBoxModes.FormattingEnabled = true;
            this.comboBoxModes.Location = new System.Drawing.Point(526, 46);
            this.comboBoxModes.Name = "comboBoxModes";
            this.comboBoxModes.Size = new System.Drawing.Size(250, 28);
            this.comboBoxModes.TabIndex = 3;
            // 
            // textBoxStepAmount
            // 
            this.textBoxStepAmount.Location = new System.Drawing.Point(526, 126);
            this.textBoxStepAmount.Name = "textBoxStepAmount";
            this.textBoxStepAmount.Size = new System.Drawing.Size(250, 26);
            this.textBoxStepAmount.TabIndex = 4;
            this.textBoxStepAmount.Text = "10";
            // 
            // textBoxStepTime
            // 
            this.textBoxStepTime.Location = new System.Drawing.Point(526, 185);
            this.textBoxStepTime.Name = "textBoxStepTime";
            this.textBoxStepTime.Size = new System.Drawing.Size(250, 26);
            this.textBoxStepTime.TabIndex = 5;
            this.textBoxStepTime.Text = "100";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(526, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 26);
            this.textBox3.TabIndex = 6;
            // 
            // labelStepAmount
            // 
            this.labelStepAmount.AutoSize = true;
            this.labelStepAmount.Location = new System.Drawing.Point(373, 129);
            this.labelStepAmount.Name = "labelStepAmount";
            this.labelStepAmount.Size = new System.Drawing.Size(113, 20);
            this.labelStepAmount.TabIndex = 7;
            this.labelStepAmount.Text = "Liczba krokow:";
            // 
            // buttonStepRight
            // 
            this.buttonStepRight.Location = new System.Drawing.Point(35, 272);
            this.buttonStepRight.Name = "buttonStepRight";
            this.buttonStepRight.Size = new System.Drawing.Size(127, 57);
            this.buttonStepRight.TabIndex = 8;
            this.buttonStepRight.Text = "Krok w prawo";
            this.buttonStepRight.UseVisualStyleBackColor = true;
            this.buttonStepRight.Click += new System.EventHandler(this.buttonStepRight_Click);
            // 
            // buttonStepLeft
            // 
            this.buttonStepLeft.Location = new System.Drawing.Point(212, 272);
            this.buttonStepLeft.Name = "buttonStepLeft";
            this.buttonStepLeft.Size = new System.Drawing.Size(127, 57);
            this.buttonStepLeft.TabIndex = 9;
            this.buttonStepLeft.Text = "Krok w  lewo";
            this.buttonStepLeft.UseVisualStyleBackColor = true;
            this.buttonStepLeft.Click += new System.EventHandler(this.buttonStepLeft_Click);
            // 
            // labelSteptime
            // 
            this.labelSteptime.AutoSize = true;
            this.labelSteptime.Location = new System.Drawing.Point(373, 191);
            this.labelSteptime.Name = "labelSteptime";
            this.labelSteptime.Size = new System.Drawing.Size(92, 20);
            this.labelSteptime.TabIndex = 10;
            this.labelSteptime.Text = "Czas kroku:";
            // 
            // buttonFiveStepsRight
            // 
            this.buttonFiveStepsRight.Location = new System.Drawing.Point(35, 349);
            this.buttonFiveStepsRight.Name = "buttonFiveStepsRight";
            this.buttonFiveStepsRight.Size = new System.Drawing.Size(127, 57);
            this.buttonFiveStepsRight.TabIndex = 11;
            this.buttonFiveStepsRight.Text = "5 Krokow w prawo";
            this.buttonFiveStepsRight.UseVisualStyleBackColor = true;
            this.buttonFiveStepsRight.Click += new System.EventHandler(this.buttonFiveStepsRight_Click);
            // 
            // buttonFiveStepsLeft
            // 
            this.buttonFiveStepsLeft.Location = new System.Drawing.Point(212, 349);
            this.buttonFiveStepsLeft.Name = "buttonFiveStepsLeft";
            this.buttonFiveStepsLeft.Size = new System.Drawing.Size(127, 57);
            this.buttonFiveStepsLeft.TabIndex = 12;
            this.buttonFiveStepsLeft.Text = "5 Krokow w lewo";
            this.buttonFiveStepsLeft.UseVisualStyleBackColor = true;
            this.buttonFiveStepsLeft.Click += new System.EventHandler(this.buttonFiveStepsLeft_Click);
            // 
            // comboBoxChooseDevice
            // 
            this.comboBoxChooseDevice.FormattingEnabled = true;
            this.comboBoxChooseDevice.Location = new System.Drawing.Point(270, 46);
            this.comboBoxChooseDevice.Name = "comboBoxChooseDevice";
            this.comboBoxChooseDevice.Size = new System.Drawing.Size(250, 28);
            this.comboBoxChooseDevice.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxChooseDevice);
            this.Controls.Add(this.buttonFiveStepsLeft);
            this.Controls.Add(this.buttonFiveStepsRight);
            this.Controls.Add(this.labelSteptime);
            this.Controls.Add(this.buttonStepLeft);
            this.Controls.Add(this.buttonStepRight);
            this.Controls.Add(this.labelStepAmount);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxStepTime);
            this.Controls.Add(this.textBoxStepAmount);
            this.Controls.Add(this.comboBoxModes);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.richTextBoxInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.ComboBox comboBoxModes;
        private System.Windows.Forms.TextBox textBoxStepAmount;
        private System.Windows.Forms.TextBox textBoxStepTime;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelStepAmount;
        private System.Windows.Forms.Button buttonStepRight;
        private System.Windows.Forms.Button buttonStepLeft;
        private System.Windows.Forms.Label labelSteptime;
        private System.Windows.Forms.Button buttonFiveStepsRight;
        private System.Windows.Forms.Button buttonFiveStepsLeft;
        private System.Windows.Forms.ComboBox comboBoxChooseDevice;
    }
}

