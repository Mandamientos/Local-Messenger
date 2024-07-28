namespace Local_Messenger
{
    partial class messengerApp
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
            entryMsg = new TextBox();
            sendButton = new Button();
            infoLabel = new Label();
            msgLog = new RichTextBox();
            SuspendLayout();
            // 
            // entryMsg
            // 
            entryMsg.Location = new Point(12, 383);
            entryMsg.Multiline = true;
            entryMsg.Name = "entryMsg";
            entryMsg.Size = new Size(598, 55);
            entryMsg.TabIndex = 0;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(616, 383);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(172, 55);
            sendButton.TabIndex = 1;
            sendButton.Text = "Enviar";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += SendButton_Click;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.ForeColor = SystemColors.ControlDarkDark;
            infoLabel.Location = new Point(12, 360);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(17, 20);
            infoLabel.TabIndex = 2;
            infoLabel.Text = "a";
            // 
            // msgLog
            // 
            msgLog.Location = new Point(12, 12);
            msgLog.Name = "msgLog";
            msgLog.ReadOnly = true;
            msgLog.Size = new Size(776, 345);
            msgLog.TabIndex = 3;
            msgLog.Text = "";
            // 
            // messengerApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(msgLog);
            Controls.Add(infoLabel);
            Controls.Add(sendButton);
            Controls.Add(entryMsg);
            Name = "messengerApp";
            Text = "Mensajería";
            Load += messenger_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox entryMsg;
        private Button sendButton;
        private Label infoLabel;
        private RichTextBox msgLog;
    }
}