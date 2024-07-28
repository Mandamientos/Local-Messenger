namespace Local_Messenger
{
    partial class askPort
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
            askPortLabel = new Label();
            askPortButton = new Button();
            askPortEntry = new TextBox();
            SuspendLayout();
            // 
            // askPortLabel
            // 
            askPortLabel.AutoSize = true;
            askPortLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            askPortLabel.ImageAlign = ContentAlignment.TopCenter;
            askPortLabel.Location = new Point(12, 9);
            askPortLabel.Name = "askPortLabel";
            askPortLabel.Size = new Size(491, 31);
            askPortLabel.TabIndex = 0;
            askPortLabel.Text = "Ingrese el puerto con el que se quiera comunicar.";
            askPortLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // askPortButton
            // 
            askPortButton.Location = new Point(196, 91);
            askPortButton.Name = "askPortButton";
            askPortButton.Size = new Size(120, 40);
            askPortButton.TabIndex = 1;
            askPortButton.Text = "Continuar";
            askPortButton.UseVisualStyleBackColor = true;
            askPortButton.Click += askPortButton_Click;
            // 
            // askPortEntry
            // 
            askPortEntry.Location = new Point(205, 55);
            askPortEntry.Name = "askPortEntry";
            askPortEntry.Size = new Size(102, 27);
            askPortEntry.TabIndex = 2;
            // 
            // askPort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 150);
            Controls.Add(askPortEntry);
            Controls.Add(askPortButton);
            Controls.Add(askPortLabel);
            Name = "askPort";
            Text = "Configuración";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label askPortLabel;
        private Button askPortButton;
        private TextBox askPortEntry;
    }
}
