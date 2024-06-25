namespace ConcurrencyAcademyWinForms
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
            workButton = new Button();
            stopButton = new Button();
            label1 = new Label();
            statusLabel = new Label();
            SuspendLayout();
            // 
            // workButton
            // 
            workButton.Location = new Point(12, 12);
            workButton.Name = "workButton";
            workButton.Size = new Size(131, 40);
            workButton.TabIndex = 0;
            workButton.Text = "Work";
            workButton.UseVisualStyleBackColor = true;
            workButton.Click += WorkButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(149, 12);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(131, 40);
            stopButton.TabIndex = 1;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += StopButton_Click;
            stopButton.Enabled = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 2;
            label1.Text = "Status:";
            // 
            // statusLable
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(86, 72);
            statusLabel.Name = "statusLable";
            statusLabel.Size = new Size(0, 30);
            statusLabel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusLabel);
            Controls.Add(label1);
            Controls.Add(stopButton);
            Controls.Add(workButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button workButton;
        private Button stopButton;
        private Label label1;
        private Label statusLabel;
    }
}
