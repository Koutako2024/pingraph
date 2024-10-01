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
            lblGraph = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblGraph
            // 
            lblGraph.AutoSize = true;
            lblGraph.Location = new Point(12, 9);
            lblGraph.Name = "lblGraph";
            lblGraph.Size = new Size(66, 20);
            lblGraph.TabIndex = 0;
            lblGraph.Text = "lblGraph";
            lblGraph.Click += lblGraph_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGraph);
            Name = "Form1";
            Text = "PinGraph";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGraph;
        private System.Windows.Forms.Timer timer1;
    }
}
