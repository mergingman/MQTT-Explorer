namespace MQTT_Explorer
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxSetMessage = new TextBox();
            textBox2 = new TextBox();
            textBoxMqttBroker = new TextBox();
            buttonConnect = new Button();
            buttonDisconnect = new Button();
            labelMqttBroker = new Label();
            labelSetTopic = new Label();
            labelMessage = new Label();
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel2 = new Panel();
            panelMqttBroker = new Panel();
            panelTopic = new Panel();
            panelSubscribe = new Panel();
            textBoxSubscriberTopic = new TextBox();
            labelSubscriberTopic = new Label();
            labelReceivedMessage = new Label();
            labelStatusMessage = new Label();
            listBoxReceivedMessage = new ListBox();
            listBoxStatusMessage = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMqttBroker.SuspendLayout();
            panelTopic.SuspendLayout();
            panelSubscribe.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSetMessage
            // 
            textBoxSetMessage.Location = new Point(25, 224);
            textBoxSetMessage.Margin = new Padding(4, 5, 4, 5);
            textBoxSetMessage.Name = "textBoxSetMessage";
            textBoxSetMessage.Size = new Size(233, 31);
            textBoxSetMessage.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 116);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 31);
            textBox2.TabIndex = 1;
            // 
            // textBoxMqttBroker
            // 
            textBoxMqttBroker.Location = new Point(35, 116);
            textBoxMqttBroker.Margin = new Padding(4, 5, 4, 5);
            textBoxMqttBroker.Name = "textBoxMqttBroker";
            textBoxMqttBroker.Size = new Size(207, 31);
            textBoxMqttBroker.TabIndex = 2;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(35, 195);
            buttonConnect.Margin = new Padding(4, 5, 4, 5);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(234, 48);
            buttonConnect.TabIndex = 3;
            buttonConnect.Text = "Verbindung herstellen";
            buttonConnect.UseVisualStyleBackColor = true;
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Location = new Point(35, 276);
            buttonDisconnect.Margin = new Padding(4, 5, 4, 5);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(234, 48);
            buttonDisconnect.TabIndex = 4;
            buttonDisconnect.Text = "Verbindung abbrechen";
            buttonDisconnect.UseVisualStyleBackColor = true;
            // 
            // labelMqttBroker
            // 
            labelMqttBroker.AutoSize = true;
            labelMqttBroker.ForeColor = SystemColors.AppWorkspace;
            labelMqttBroker.Location = new Point(35, 72);
            labelMqttBroker.Margin = new Padding(4, 0, 4, 0);
            labelMqttBroker.Name = "labelMqttBroker";
            labelMqttBroker.Size = new Size(117, 25);
            labelMqttBroker.TabIndex = 5;
            labelMqttBroker.Text = "MQTT-Broker";
            labelMqttBroker.Click += label1_Click;
            // 
            // labelSetTopic
            // 
            labelSetTopic.AutoSize = true;
            labelSetTopic.ForeColor = SystemColors.AppWorkspace;
            labelSetTopic.Location = new Point(25, 72);
            labelSetTopic.Margin = new Padding(4, 0, 4, 0);
            labelSetTopic.Name = "labelSetTopic";
            labelSetTopic.Size = new Size(164, 25);
            labelSetTopic.TabIndex = 6;
            labelSetTopic.Text = "Festlegen der Topic";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.ForeColor = SystemColors.AppWorkspace;
            labelMessage.Location = new Point(25, 183);
            labelMessage.Margin = new Padding(4, 0, 4, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(86, 25);
            labelMessage.TabIndex = 7;
            labelMessage.Text = "Nachricht";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-7, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1419, 78);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(62, 26);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 32);
            label5.TabIndex = 6;
            label5.Text = "Connection";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1193, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 1073);
            panel2.TabIndex = 10;
            // 
            // panelMqttBroker
            // 
            panelMqttBroker.Controls.Add(textBoxMqttBroker);
            panelMqttBroker.Controls.Add(buttonDisconnect);
            panelMqttBroker.Controls.Add(labelMqttBroker);
            panelMqttBroker.Controls.Add(buttonConnect);
            panelMqttBroker.Location = new Point(809, 133);
            panelMqttBroker.Name = "panelMqttBroker";
            panelMqttBroker.Size = new Size(361, 384);
            panelMqttBroker.TabIndex = 11;
            // 
            // panelTopic
            // 
            panelTopic.Controls.Add(labelSetTopic);
            panelTopic.Controls.Add(labelMessage);
            panelTopic.Controls.Add(textBox2);
            panelTopic.Controls.Add(textBoxSetMessage);
            panelTopic.Location = new Point(415, 133);
            panelTopic.Name = "panelTopic";
            panelTopic.Size = new Size(361, 384);
            panelTopic.TabIndex = 12;
            // 
            // panelSubscribe
            // 
            panelSubscribe.Controls.Add(textBoxSubscriberTopic);
            panelSubscribe.Controls.Add(labelSubscriberTopic);
            panelSubscribe.Location = new Point(21, 133);
            panelSubscribe.Name = "panelSubscribe";
            panelSubscribe.Size = new Size(361, 384);
            panelSubscribe.TabIndex = 13;
            // 
            // textBoxSubscriberTopic
            // 
            textBoxSubscriberTopic.Location = new Point(35, 116);
            textBoxSubscriberTopic.Margin = new Padding(4, 5, 4, 5);
            textBoxSubscriberTopic.Name = "textBoxSubscriberTopic";
            textBoxSubscriberTopic.Size = new Size(207, 31);
            textBoxSubscriberTopic.TabIndex = 2;
            // 
            // labelSubscriberTopic
            // 
            labelSubscriberTopic.AutoSize = true;
            labelSubscriberTopic.ForeColor = SystemColors.AppWorkspace;
            labelSubscriberTopic.Location = new Point(35, 72);
            labelSubscriberTopic.Margin = new Padding(4, 0, 4, 0);
            labelSubscriberTopic.Name = "labelSubscriberTopic";
            labelSubscriberTopic.Size = new Size(141, 25);
            labelSubscriberTopic.TabIndex = 5;
            labelSubscriberTopic.Text = "Subscriber Topic";
            // 
            // labelReceivedMessage
            // 
            labelReceivedMessage.AutoSize = true;
            labelReceivedMessage.ForeColor = SystemColors.AppWorkspace;
            labelReceivedMessage.Location = new Point(949, 545);
            labelReceivedMessage.Margin = new Padding(4, 0, 4, 0);
            labelReceivedMessage.Name = "labelReceivedMessage";
            labelReceivedMessage.Size = new Size(186, 25);
            labelReceivedMessage.TabIndex = 14;
            labelReceivedMessage.Text = "Empfangen der Daten";
            labelReceivedMessage.Click += label6_Click;
            // 
            // labelStatusMessage
            // 
            labelStatusMessage.AutoSize = true;
            labelStatusMessage.ForeColor = SystemColors.AppWorkspace;
            labelStatusMessage.Location = new Point(519, 545);
            labelStatusMessage.Margin = new Padding(4, 0, 4, 0);
            labelStatusMessage.Name = "labelStatusMessage";
            labelStatusMessage.Size = new Size(131, 25);
            labelStatusMessage.TabIndex = 15;
            labelStatusMessage.Text = "Statusmeldung";
            labelStatusMessage.Click += label7_Click;
            // 
            // listBoxReceivedMessage
            // 
            listBoxReceivedMessage.FormattingEnabled = true;
            listBoxReceivedMessage.ItemHeight = 25;
            listBoxReceivedMessage.Location = new Point(665, 588);
            listBoxReceivedMessage.Name = "listBoxReceivedMessage";
            listBoxReceivedMessage.Size = new Size(470, 254);
            listBoxReceivedMessage.TabIndex = 16;
            listBoxReceivedMessage.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBoxStatusMessage
            // 
            listBoxStatusMessage.FormattingEnabled = true;
            listBoxStatusMessage.ItemHeight = 25;
            listBoxStatusMessage.Location = new Point(140, 588);
            listBoxStatusMessage.Name = "listBoxStatusMessage";
            listBoxStatusMessage.Size = new Size(510, 254);
            listBoxStatusMessage.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1413, 1073);
            Controls.Add(listBoxStatusMessage);
            Controls.Add(listBoxReceivedMessage);
            Controls.Add(labelStatusMessage);
            Controls.Add(labelReceivedMessage);
            Controls.Add(panelSubscribe);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panelMqttBroker);
            Controls.Add(panelTopic);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "MQTT Explorer";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMqttBroker.ResumeLayout(false);
            panelMqttBroker.PerformLayout();
            panelTopic.ResumeLayout(false);
            panelTopic.PerformLayout();
            panelSubscribe.ResumeLayout(false);
            panelSubscribe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSetMessage;
        private TextBox textBox2;
        private TextBox textBoxMqttBroker;
        private Button buttonConnect;
        private Button buttonDisconnect;
        private Label labelMqttBroker;
        private Label labelSetTopic;
        private Label labelMessage;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel2;
        private PictureBox pictureBox1;
        public Panel panelMqttBroker;
        private Label label5;
        public Panel panelTopic;
        public Panel panelSubscribe;
        private TextBox textBoxSubscriberTopic;
        private Label labelSubscriberTopic;
        private Label labelReceivedMessage;
        private Label labelStatusMessage;
        private ListBox listBoxReceivedMessage;
        private ListBox listBoxStatusMessage;
    }
}