namespace Listener
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_data = new TextBox();
            label_device = new Label();
            textBox_send_data = new TextBox();
            button_send_data = new Button();
            SuspendLayout();
            // 
            // textBox_data
            // 
            textBox_data.BackColor = Color.Black;
            textBox_data.BorderStyle = BorderStyle.None;
            textBox_data.ForeColor = Color.Yellow;
            textBox_data.Location = new Point(3, 3);
            textBox_data.Multiline = true;
            textBox_data.Name = "textBox_data";
            textBox_data.Size = new Size(332, 40);
            textBox_data.TabIndex = 0;
            // 
            // label_device
            // 
            label_device.ForeColor = Color.FromArgb(255, 255, 128);
            label_device.Location = new Point(555, 3);
            label_device.Name = "label_device";
            label_device.Size = new Size(243, 37);
            label_device.TabIndex = 1;
            // 
            // textBox_send_data
            // 
            textBox_send_data.Location = new Point(12, 61);
            textBox_send_data.Multiline = true;
            textBox_send_data.Name = "textBox_send_data";
            textBox_send_data.Size = new Size(585, 52);
            textBox_send_data.TabIndex = 2;
            // 
            // button_send_data
            // 
            button_send_data.Location = new Point(614, 61);
            button_send_data.Name = "button_send_data";
            button_send_data.Size = new Size(184, 52);
            button_send_data.TabIndex = 3;
            button_send_data.Text = "Gönder";
            button_send_data.UseVisualStyleBackColor = true;
            button_send_data.Click += button_send_data_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(816, 125);
            Controls.Add(button_send_data);
            Controls.Add(textBox_send_data);
            Controls.Add(label_device);
            Controls.Add(textBox_data);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Text = "Listener";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_data;
        private Label label_device;
        private TextBox textBox_send_data;
        private Button button_send_data;
    }
}
