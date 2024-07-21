namespace Restaurant
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            MyProgress = new ProgressBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            lbl_percentage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(95, 20);
            label1.Name = "label1";
            label1.Size = new Size(562, 55);
            label1.TabIndex = 1;
            label1.Text = "Engineer's Restaurant";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(178, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MyProgress
            // 
            MyProgress.ForeColor = Color.Red;
            MyProgress.Location = new Point(12, 356);
            MyProgress.Name = "MyProgress";
            MyProgress.Size = new Size(743, 15);
            MyProgress.Step = 1;
            MyProgress.TabIndex = 3;
            MyProgress.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 329);
            label2.Name = "label2";
            label2.Size = new Size(131, 27);
            label2.TabIndex = 4;
            label2.Text = "Loading...";
            // 
            // lbl_percentage
            // 
            lbl_percentage.AutoSize = true;
            lbl_percentage.BackColor = Color.White;
            lbl_percentage.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_percentage.ForeColor = Color.Red;
            lbl_percentage.Location = new Point(149, 329);
            lbl_percentage.Name = "lbl_percentage";
            lbl_percentage.Size = new Size(31, 27);
            lbl_percentage.TabIndex = 5;
            lbl_percentage.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(767, 383);
            Controls.Add(lbl_percentage);
            Controls.Add(label2);
            Controls.Add(MyProgress);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar MyProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Label lbl_percentage;
        private System.Windows.Forms.Timer timer1;
    }
}