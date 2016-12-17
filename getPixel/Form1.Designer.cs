namespace getPixel
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_activer = new System.Windows.Forms.Button();
            this.lbl_couleur = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_trackbar = new System.Windows.Forms.Label();
            this.btn_setting = new System.Windows.Forms.Button();
            this.nupdo_redmin = new System.Windows.Forms.NumericUpDown();
            this.nupdo_bluemin = new System.Windows.Forms.NumericUpDown();
            this.nupdo_greenmin = new System.Windows.Forms.NumericUpDown();
            this.lbl_red = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.nupdo_redmax = new System.Windows.Forms.NumericUpDown();
            this.nupdo_fps = new System.Windows.Forms.NumericUpDown();
            this.lbl_fps = new System.Windows.Forms.Label();
            this.nupdo_greenmax = new System.Windows.Forms.NumericUpDown();
            this.nupdo_bluemax = new System.Windows.Forms.NumericUpDown();
            this.lbl_bluemax = new System.Windows.Forms.Label();
            this.lbl_greenmax = new System.Windows.Forms.Label();
            this.lbl_redmax = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.timer_fpscount = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_redmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_bluemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_greenmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_redmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_fps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_greenmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_bluemax)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_activer
            // 
            this.btn_activer.Location = new System.Drawing.Point(12, 4);
            this.btn_activer.Name = "btn_activer";
            this.btn_activer.Size = new System.Drawing.Size(75, 23);
            this.btn_activer.TabIndex = 0;
            this.btn_activer.Text = "Enable";
            this.btn_activer.UseVisualStyleBackColor = true;
            this.btn_activer.Click += new System.EventHandler(this.btn_activer_Click);
            // 
            // lbl_couleur
            // 
            this.lbl_couleur.AutoSize = true;
            this.lbl_couleur.Location = new System.Drawing.Point(93, 9);
            this.lbl_couleur.Name = "lbl_couleur";
            this.lbl_couleur.Size = new System.Drawing.Size(114, 13);
            this.lbl_couleur.TabIndex = 2;
            this.lbl_couleur.Text = "R: ### G:### B: ###";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 33);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(248, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lbl_trackbar
            // 
            this.lbl_trackbar.AutoSize = true;
            this.lbl_trackbar.Location = new System.Drawing.Point(266, 39);
            this.lbl_trackbar.Name = "lbl_trackbar";
            this.lbl_trackbar.Size = new System.Drawing.Size(33, 13);
            this.lbl_trackbar.TabIndex = 4;
            this.lbl_trackbar.Text = "100%";
            // 
            // btn_setting
            // 
            this.btn_setting.Location = new System.Drawing.Point(305, 33);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(67, 23);
            this.btn_setting.TabIndex = 5;
            this.btn_setting.Text = "Option >>";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // nupdo_redmin
            // 
            this.nupdo_redmin.Location = new System.Drawing.Point(428, 10);
            this.nupdo_redmin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdo_redmin.Name = "nupdo_redmin";
            this.nupdo_redmin.Size = new System.Drawing.Size(37, 20);
            this.nupdo_redmin.TabIndex = 6;
            // 
            // nupdo_bluemin
            // 
            this.nupdo_bluemin.Location = new System.Drawing.Point(599, 10);
            this.nupdo_bluemin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdo_bluemin.Name = "nupdo_bluemin";
            this.nupdo_bluemin.Size = new System.Drawing.Size(37, 20);
            this.nupdo_bluemin.TabIndex = 7;
            this.nupdo_bluemin.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nupdo_greenmin
            // 
            this.nupdo_greenmin.Location = new System.Drawing.Point(514, 10);
            this.nupdo_greenmin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdo_greenmin.Name = "nupdo_greenmin";
            this.nupdo_greenmin.Size = new System.Drawing.Size(37, 20);
            this.nupdo_greenmin.TabIndex = 8;
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Location = new System.Drawing.Point(385, 14);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(37, 13);
            this.lbl_red.TabIndex = 9;
            this.lbl_red.Text = "Rmin=";
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Location = new System.Drawing.Point(557, 12);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(36, 13);
            this.lbl_blue.TabIndex = 10;
            this.lbl_blue.Text = "Bmin=";
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Location = new System.Drawing.Point(471, 14);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(37, 13);
            this.lbl_green.TabIndex = 11;
            this.lbl_green.Text = "Gmin=";
            // 
            // nupdo_redmax
            // 
            this.nupdo_redmax.Location = new System.Drawing.Point(428, 32);
            this.nupdo_redmax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdo_redmax.Name = "nupdo_redmax";
            this.nupdo_redmax.Size = new System.Drawing.Size(37, 20);
            this.nupdo_redmax.TabIndex = 12;
            this.nupdo_redmax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nupdo_fps
            // 
            this.nupdo_fps.Enabled = false;
            this.nupdo_fps.Location = new System.Drawing.Point(650, 32);
            this.nupdo_fps.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nupdo_fps.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdo_fps.Name = "nupdo_fps";
            this.nupdo_fps.Size = new System.Drawing.Size(45, 20);
            this.nupdo_fps.TabIndex = 13;
            this.nupdo_fps.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nupdo_fps.ValueChanged += new System.EventHandler(this.nupdo_fps_ValueChanged);
            // 
            // lbl_fps
            // 
            this.lbl_fps.AutoSize = true;
            this.lbl_fps.Location = new System.Drawing.Point(658, 17);
            this.lbl_fps.Name = "lbl_fps";
            this.lbl_fps.Size = new System.Drawing.Size(27, 13);
            this.lbl_fps.TabIndex = 14;
            this.lbl_fps.Text = "FPS";
            // 
            // nupdo_greenmax
            // 
            this.nupdo_greenmax.Location = new System.Drawing.Point(514, 32);
            this.nupdo_greenmax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdo_greenmax.Name = "nupdo_greenmax";
            this.nupdo_greenmax.Size = new System.Drawing.Size(37, 20);
            this.nupdo_greenmax.TabIndex = 15;
            this.nupdo_greenmax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nupdo_bluemax
            // 
            this.nupdo_bluemax.Location = new System.Drawing.Point(599, 32);
            this.nupdo_bluemax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdo_bluemax.Name = "nupdo_bluemax";
            this.nupdo_bluemax.Size = new System.Drawing.Size(37, 20);
            this.nupdo_bluemax.TabIndex = 16;
            this.nupdo_bluemax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // lbl_bluemax
            // 
            this.lbl_bluemax.AutoSize = true;
            this.lbl_bluemax.Location = new System.Drawing.Point(556, 34);
            this.lbl_bluemax.Name = "lbl_bluemax";
            this.lbl_bluemax.Size = new System.Drawing.Size(39, 13);
            this.lbl_bluemax.TabIndex = 17;
            this.lbl_bluemax.Text = "Bmax=";
            // 
            // lbl_greenmax
            // 
            this.lbl_greenmax.AutoSize = true;
            this.lbl_greenmax.Location = new System.Drawing.Point(471, 34);
            this.lbl_greenmax.Name = "lbl_greenmax";
            this.lbl_greenmax.Size = new System.Drawing.Size(40, 13);
            this.lbl_greenmax.TabIndex = 18;
            this.lbl_greenmax.Text = "Gmax=";
            // 
            // lbl_redmax
            // 
            this.lbl_redmax.AutoSize = true;
            this.lbl_redmax.Location = new System.Drawing.Point(385, 34);
            this.lbl_redmax.Name = "lbl_redmax";
            this.lbl_redmax.Size = new System.Drawing.Size(40, 13);
            this.lbl_redmax.TabIndex = 19;
            this.lbl_redmax.Text = "Rmax=";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(338, 9);
            this.lb_count.Margin = new System.Windows.Forms.Padding(0);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(13, 13);
            this.lb_count.TabIndex = 20;
            this.lb_count.Text = "0";
            // 
            // timer_fpscount
            // 
            this.timer_fpscount.Enabled = true;
            this.timer_fpscount.Interval = 1000;
            this.timer_fpscount.Tick += new System.EventHandler(this.timer_fpscount_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Trigger FPS :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(704, 61);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.lbl_redmax);
            this.Controls.Add(this.lbl_greenmax);
            this.Controls.Add(this.lbl_bluemax);
            this.Controls.Add(this.nupdo_bluemax);
            this.Controls.Add(this.nupdo_greenmax);
            this.Controls.Add(this.lbl_fps);
            this.Controls.Add(this.nupdo_fps);
            this.Controls.Add(this.nupdo_redmax);
            this.Controls.Add(this.lbl_green);
            this.Controls.Add(this.lbl_blue);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.nupdo_greenmin);
            this.Controls.Add(this.nupdo_bluemin);
            this.Controls.Add(this.nupdo_redmin);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.lbl_trackbar);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lbl_couleur);
            this.Controls.Add(this.btn_activer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 100);
            this.MinimumSize = new System.Drawing.Size(397, 100);
            this.Name = "Form1";
            this.Text = "Cheat : OFF";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_redmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_bluemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_greenmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_redmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_fps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_greenmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_bluemax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_activer;
        private System.Windows.Forms.Label lbl_couleur;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_trackbar;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.NumericUpDown nupdo_redmin;
        private System.Windows.Forms.NumericUpDown nupdo_bluemin;
        private System.Windows.Forms.NumericUpDown nupdo_greenmin;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.NumericUpDown nupdo_redmax;
        private System.Windows.Forms.NumericUpDown nupdo_fps;
        private System.Windows.Forms.Label lbl_fps;
        private System.Windows.Forms.NumericUpDown nupdo_greenmax;
        private System.Windows.Forms.NumericUpDown nupdo_bluemax;
        private System.Windows.Forms.Label lbl_bluemax;
        private System.Windows.Forms.Label lbl_greenmax;
        private System.Windows.Forms.Label lbl_redmax;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Timer timer_fpscount;
        private System.Windows.Forms.Label label1;
    }
}

