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
            this.btn_setting = new System.Windows.Forms.Button();
            this.nupdo_redmin = new System.Windows.Forms.NumericUpDown();
            this.nupdo_bluemin = new System.Windows.Forms.NumericUpDown();
            this.nupdo_greenmin = new System.Windows.Forms.NumericUpDown();
            this.nupdo_redmax = new System.Windows.Forms.NumericUpDown();
            this.nupdo_fps = new System.Windows.Forms.NumericUpDown();
            this.lbl_fps = new System.Windows.Forms.Label();
            this.nupdo_greenmax = new System.Windows.Forms.NumericUpDown();
            this.nupdo_bluemax = new System.Windows.Forms.NumericUpDown();
            this.lb_count = new System.Windows.Forms.Label();
            this.timer_fpscount = new System.Windows.Forms.Timer(this.components);
            this.lbl_triggerfps = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_mode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.img_red = new System.Windows.Forms.PictureBox();
            this.img_green = new System.Windows.Forms.PictureBox();
            this.img_blue = new System.Windows.Forms.PictureBox();
            this.img_preset = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer_hook = new System.Windows.Forms.Timer(this.components);
            this.lbl_key = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbx_shortcut = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_redmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_bluemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_greenmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_redmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_fps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_greenmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdo_bluemax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_preset)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_activer
            // 
            this.btn_activer.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_activer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_activer.Location = new System.Drawing.Point(9, 8);
            this.btn_activer.Name = "btn_activer";
            this.btn_activer.Size = new System.Drawing.Size(75, 48);
            this.btn_activer.TabIndex = 0;
            this.btn_activer.Text = "Activate";
            this.btn_activer.UseVisualStyleBackColor = false;
            this.btn_activer.Click += new System.EventHandler(this.btn_activer_Click);
            // 
            // lbl_couleur
            // 
            this.lbl_couleur.AutoSize = true;
            this.lbl_couleur.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_couleur.Location = new System.Drawing.Point(90, 12);
            this.lbl_couleur.Name = "lbl_couleur";
            this.lbl_couleur.Size = new System.Drawing.Size(130, 13);
            this.lbl_couleur.TabIndex = 2;
            this.lbl_couleur.Text = "R=255 G=255 B=255";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(152, 32);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(183, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.LightBlue;
            this.btn_setting.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.Location = new System.Drawing.Point(341, 8);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(75, 48);
            this.btn_setting.TabIndex = 5;
            this.btn_setting.Text = "Options";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // nupdo_redmin
            // 
            this.nupdo_redmin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdo_redmin.Location = new System.Drawing.Point(583, 98);
            this.nupdo_redmin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdo_redmin.Name = "nupdo_redmin";
            this.nupdo_redmin.Size = new System.Drawing.Size(42, 21);
            this.nupdo_redmin.TabIndex = 6;
            // 
            // nupdo_bluemin
            // 
            this.nupdo_bluemin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdo_bluemin.Location = new System.Drawing.Point(583, 150);
            this.nupdo_bluemin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdo_bluemin.Name = "nupdo_bluemin";
            this.nupdo_bluemin.Size = new System.Drawing.Size(42, 21);
            this.nupdo_bluemin.TabIndex = 7;
            this.nupdo_bluemin.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nupdo_greenmin
            // 
            this.nupdo_greenmin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdo_greenmin.Location = new System.Drawing.Point(583, 124);
            this.nupdo_greenmin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdo_greenmin.Name = "nupdo_greenmin";
            this.nupdo_greenmin.Size = new System.Drawing.Size(42, 21);
            this.nupdo_greenmin.TabIndex = 8;
            // 
            // nupdo_redmax
            // 
            this.nupdo_redmax.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdo_redmax.Location = new System.Drawing.Point(653, 97);
            this.nupdo_redmax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdo_redmax.Name = "nupdo_redmax";
            this.nupdo_redmax.Size = new System.Drawing.Size(42, 21);
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
            this.nupdo_fps.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdo_fps.Location = new System.Drawing.Point(653, 71);
            this.nupdo_fps.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nupdo_fps.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdo_fps.Name = "nupdo_fps";
            this.nupdo_fps.Size = new System.Drawing.Size(45, 21);
            this.nupdo_fps.TabIndex = 13;
            this.nupdo_fps.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nupdo_fps.Visible = false;
            this.nupdo_fps.ValueChanged += new System.EventHandler(this.nupdo_fps_ValueChanged);
            // 
            // lbl_fps
            // 
            this.lbl_fps.AutoSize = true;
            this.lbl_fps.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fps.Location = new System.Drawing.Point(610, 73);
            this.lbl_fps.Name = "lbl_fps";
            this.lbl_fps.Size = new System.Drawing.Size(37, 13);
            this.lbl_fps.TabIndex = 14;
            this.lbl_fps.Text = "FPS :";
            this.lbl_fps.Visible = false;
            // 
            // nupdo_greenmax
            // 
            this.nupdo_greenmax.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdo_greenmax.Location = new System.Drawing.Point(653, 123);
            this.nupdo_greenmax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdo_greenmax.Name = "nupdo_greenmax";
            this.nupdo_greenmax.Size = new System.Drawing.Size(42, 21);
            this.nupdo_greenmax.TabIndex = 15;
            this.nupdo_greenmax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nupdo_bluemax
            // 
            this.nupdo_bluemax.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdo_bluemax.Location = new System.Drawing.Point(653, 149);
            this.nupdo_bluemax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupdo_bluemax.Name = "nupdo_bluemax";
            this.nupdo_bluemax.Size = new System.Drawing.Size(42, 21);
            this.nupdo_bluemax.TabIndex = 16;
            this.nupdo_bluemax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_count.Location = new System.Drawing.Point(307, 12);
            this.lb_count.Margin = new System.Windows.Forms.Padding(0);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(14, 13);
            this.lb_count.TabIndex = 20;
            this.lb_count.Text = "0";
            // 
            // timer_fpscount
            // 
            this.timer_fpscount.Enabled = true;
            this.timer_fpscount.Interval = 1000;
            this.timer_fpscount.Tick += new System.EventHandler(this.timer_fpscount_Tick);
            // 
            // lbl_triggerfps
            // 
            this.lbl_triggerfps.AutoSize = true;
            this.lbl_triggerfps.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_triggerfps.Location = new System.Drawing.Point(226, 12);
            this.lbl_triggerfps.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_triggerfps.Name = "lbl_triggerfps";
            this.lbl_triggerfps.Size = new System.Drawing.Size(81, 13);
            this.lbl_triggerfps.TabIndex = 21;
            this.lbl_triggerfps.Text = "Trigger FPS :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Color Options";
            // 
            // cbx_mode
            // 
            this.cbx_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_mode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_mode.FormattingEnabled = true;
            this.cbx_mode.Location = new System.Drawing.Point(484, 8);
            this.cbx_mode.Name = "cbx_mode";
            this.cbx_mode.Size = new System.Drawing.Size(121, 21);
            this.cbx_mode.TabIndex = 30;
            this.cbx_mode.SelectedIndexChanged += new System.EventHandler(this.cbx_mode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Opacity :";
            // 
            // img_red
            // 
            this.img_red.BackColor = System.Drawing.Color.Red;
            this.img_red.Location = new System.Drawing.Point(557, 98);
            this.img_red.Name = "img_red";
            this.img_red.Size = new System.Drawing.Size(20, 20);
            this.img_red.TabIndex = 25;
            this.img_red.TabStop = false;
            // 
            // img_green
            // 
            this.img_green.BackColor = System.Drawing.Color.Green;
            this.img_green.Location = new System.Drawing.Point(557, 124);
            this.img_green.Name = "img_green";
            this.img_green.Size = new System.Drawing.Size(20, 20);
            this.img_green.TabIndex = 24;
            this.img_green.TabStop = false;
            // 
            // img_blue
            // 
            this.img_blue.BackColor = System.Drawing.Color.Blue;
            this.img_blue.Location = new System.Drawing.Point(557, 150);
            this.img_blue.Name = "img_blue";
            this.img_blue.Size = new System.Drawing.Size(20, 20);
            this.img_blue.TabIndex = 23;
            this.img_blue.TabStop = false;
            // 
            // img_preset
            // 
            this.img_preset.Location = new System.Drawing.Point(9, 98);
            this.img_preset.Name = "img_preset";
            this.img_preset.Size = new System.Drawing.Size(540, 72);
            this.img_preset.TabIndex = 22;
            this.img_preset.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Mode :";
            // 
            // timer_hook
            // 
            this.timer_hook.Enabled = true;
            this.timer_hook.Interval = 20;
            this.timer_hook.Tick += new System.EventHandler(this.timer_hook_Tick);
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Location = new System.Drawing.Point(422, 43);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(53, 13);
            this.lbl_key.TabIndex = 33;
            this.lbl_key.Text = "Shortcut :";
            // 
            // cbx_shortcut
            // 
            this.cbx_shortcut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_shortcut.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_shortcut.FormattingEnabled = true;
            this.cbx_shortcut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbx_shortcut.Location = new System.Drawing.Point(484, 40);
            this.cbx_shortcut.Name = "cbx_shortcut";
            this.cbx_shortcut.Size = new System.Drawing.Size(121, 21);
            this.cbx_shortcut.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(704, 181);
            this.Controls.Add(this.cbx_shortcut);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_mode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.img_red);
            this.Controls.Add(this.img_green);
            this.Controls.Add(this.img_blue);
            this.Controls.Add(this.img_preset);
            this.Controls.Add(this.lbl_triggerfps);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.nupdo_bluemax);
            this.Controls.Add(this.nupdo_greenmax);
            this.Controls.Add(this.lbl_fps);
            this.Controls.Add(this.nupdo_fps);
            this.Controls.Add(this.nupdo_redmax);
            this.Controls.Add(this.nupdo_greenmin);
            this.Controls.Add(this.nupdo_bluemin);
            this.Controls.Add(this.nupdo_redmin);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lbl_couleur);
            this.Controls.Add(this.btn_activer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 220);
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
            ((System.ComponentModel.ISupportInitialize)(this.img_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_preset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_activer;
        private System.Windows.Forms.Label lbl_couleur;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.NumericUpDown nupdo_redmin;
        private System.Windows.Forms.NumericUpDown nupdo_bluemin;
        private System.Windows.Forms.NumericUpDown nupdo_greenmin;
        private System.Windows.Forms.NumericUpDown nupdo_redmax;
        private System.Windows.Forms.NumericUpDown nupdo_fps;
        private System.Windows.Forms.Label lbl_fps;
        private System.Windows.Forms.NumericUpDown nupdo_greenmax;
        private System.Windows.Forms.NumericUpDown nupdo_bluemax;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Timer timer_fpscount;
        private System.Windows.Forms.Label lbl_triggerfps;
        private System.Windows.Forms.PictureBox img_preset;
        private System.Windows.Forms.PictureBox img_blue;
        private System.Windows.Forms.PictureBox img_green;
        private System.Windows.Forms.PictureBox img_red;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_mode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Timer timer_hook;
        private System.Windows.Forms.Label lbl_key;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbx_shortcut;
    }
}

