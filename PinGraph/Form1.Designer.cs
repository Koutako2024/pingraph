namespace PinGraph
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
            timer1 = new System.Windows.Forms.Timer(components);
            BoxMeter = new PictureBox();
            BoxFrame = new PictureBox();
            label1 = new Label();
            LblDebug = new Label();
            ((System.ComponentModel.ISupportInitialize)BoxMeter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoxFrame).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // BoxMeter
            // 
            BoxMeter.BackColor = Color.White;
            BoxMeter.Location = new Point(12, 12);
            BoxMeter.Name = "BoxMeter";
            BoxMeter.Size = new Size(124, 426);
            BoxMeter.TabIndex = 1;
            BoxMeter.TabStop = false;
            // 
            // BoxFrame
            // 
            BoxFrame.BackColor = Color.DimGray;
            BoxFrame.Location = new Point(12, 12);
            BoxFrame.Name = "BoxFrame";
            BoxFrame.Size = new Size(124, 426);
            BoxFrame.TabIndex = 2;
            BoxFrame.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 62);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // LblDebug
            // 
            LblDebug.AutoSize = true;
            LblDebug.ForeColor = SystemColors.ControlLightLight;
            LblDebug.Location = new Point(153, 16);
            LblDebug.Name = "LblDebug";
            LblDebug.Size = new Size(225, 60);
            LblDebug.TabIndex = 4;
            LblDebug.Text = "For Debug\r\nYes this is a label for only debug.\r\nI'm only so.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(404, 450);
            Controls.Add(LblDebug);
            Controls.Add(label1);
            Controls.Add(BoxMeter);
            Controls.Add(BoxFrame);
            Name = "Form1";
            Text = "PinGraph";
            ((System.ComponentModel.ISupportInitialize)BoxMeter).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoxFrame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox BoxMeter;
        private PictureBox BoxFrame;
        private Label label1;
        private Label LblDebug;
    }
}
