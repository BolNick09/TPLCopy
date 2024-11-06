namespace TPLCopy
{
    partial class FrmCopy
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
            pbCopy1 = new ProgressBar();
            pbCopy2 = new ProgressBar();
            pbCopy3 = new ProgressBar();
            pbCopy4 = new ProgressBar();
            btnStart = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // pbCopy1
            // 
            pbCopy1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbCopy1.Location = new Point(12, 12);
            pbCopy1.Maximum = 100000;
            pbCopy1.Name = "pbCopy1";
            pbCopy1.Size = new Size(382, 29);
            pbCopy1.TabIndex = 0;
            // 
            // pbCopy2
            // 
            pbCopy2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbCopy2.Location = new Point(12, 47);
            pbCopy2.Maximum = 100000;
            pbCopy2.Name = "pbCopy2";
            pbCopy2.Size = new Size(382, 29);
            pbCopy2.TabIndex = 1;
            // 
            // pbCopy3
            // 
            pbCopy3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbCopy3.Location = new Point(12, 82);
            pbCopy3.Maximum = 100000;
            pbCopy3.Name = "pbCopy3";
            pbCopy3.Size = new Size(382, 29);
            pbCopy3.TabIndex = 2;
            // 
            // pbCopy4
            // 
            pbCopy4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbCopy4.Location = new Point(12, 117);
            pbCopy4.Maximum = 100000;
            pbCopy4.Name = "pbCopy4";
            pbCopy4.Size = new Size(382, 29);
            pbCopy4.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStart.Location = new Point(288, 152);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(106, 29);
            btnStart.TabIndex = 4;
            btnStart.Text = "Копировать";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnStop.Location = new Point(12, 152);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(106, 29);
            btnStop.TabIndex = 5;
            btnStop.Text = "Отменить";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // FrmCopy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 188);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(pbCopy4);
            Controls.Add(pbCopy3);
            Controls.Add(pbCopy2);
            Controls.Add(pbCopy1);
            MinimumSize = new Size(424, 235);
            Name = "FrmCopy";
            Text = "Имитация копирования файлов";
            Load += FrmCopy_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar pbCopy1;
        private ProgressBar pbCopy2;
        private ProgressBar pbCopy3;
        private ProgressBar pbCopy4;
        private Button btnStart;
        private Button btnStop;
    }
}
