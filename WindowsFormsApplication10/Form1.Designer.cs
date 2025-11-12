namespace WindowsFormsApplication10
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnstop = new System.Windows.Forms.Button();
            this.btnrun = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnkahesh = new System.Windows.Forms.Button();
            this.btnafzayesh = new System.Windows.Forms.Button();
            this.btnaghab = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.LightCoral;
            this.btnstop.Location = new System.Drawing.Point(30, 361);
            this.btnstop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(100, 28);
            this.btnstop.TabIndex = 0;
            this.btnstop.Text = "توقف";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnrun
            // 
            this.btnrun.BackColor = System.Drawing.Color.LightGreen;
            this.btnrun.Location = new System.Drawing.Point(325, 361);
            this.btnrun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(100, 28);
            this.btnrun.TabIndex = 1;
            this.btnrun.Text = "حرکت";
            this.btnrun.UseVisualStyleBackColor = false;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 180);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnkahesh
            // 
            this.btnkahesh.BackColor = System.Drawing.Color.Violet;
            this.btnkahesh.Location = new System.Drawing.Point(633, 361);
            this.btnkahesh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnkahesh.Name = "btnkahesh";
            this.btnkahesh.Size = new System.Drawing.Size(100, 28);
            this.btnkahesh.TabIndex = 3;
            this.btnkahesh.Text = "کاهش حرکت";
            this.btnkahesh.UseVisualStyleBackColor = false;
            this.btnkahesh.Click += new System.EventHandler(this.btnkahesh_Click);
            // 
            // btnafzayesh
            // 
            this.btnafzayesh.BackColor = System.Drawing.Color.SkyBlue;
            this.btnafzayesh.Location = new System.Drawing.Point(484, 361);
            this.btnafzayesh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnafzayesh.Name = "btnafzayesh";
            this.btnafzayesh.Size = new System.Drawing.Size(100, 28);
            this.btnafzayesh.TabIndex = 4;
            this.btnafzayesh.Text = "افزایش حرکت";
            this.btnafzayesh.UseVisualStyleBackColor = false;
            this.btnafzayesh.Click += new System.EventHandler(this.btnafzayesh_Click);
            // 
            // btnaghab
            // 
            this.btnaghab.BackColor = System.Drawing.Color.Pink;
            this.btnaghab.Location = new System.Drawing.Point(182, 365);
            this.btnaghab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnaghab.Name = "btnaghab";
            this.btnaghab.Size = new System.Drawing.Size(100, 28);
            this.btnaghab.TabIndex = 5;
            this.btnaghab.Text = "عقب";
            this.btnaghab.UseVisualStyleBackColor = false;
            this.btnaghab.Click += new System.EventHandler(this.btnaghab_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(753, 463);
            this.Controls.Add(this.btnaghab);
            this.Controls.Add(this.btnafzayesh);
            this.Controls.Add(this.btnkahesh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnrun);
            this.Controls.Add(this.btnstop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnrun;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnkahesh;
        private System.Windows.Forms.Button btnafzayesh;
        private System.Windows.Forms.Button btnaghab;
        private System.Windows.Forms.Timer timer2;
    }
}

