namespace ColorSliderTest
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colorSlider4 = new MB.Controls.ColorSlider();
            this.colorSlider3 = new MB.Controls.ColorSlider();
            this.colorSlider2 = new MB.Controls.ColorSlider();
            this.colorSlider1 = new MB.Controls.ColorSlider();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorSliderCustomThumbSinus = new MB.Controls.ColorSlider();
            this.colorSliderCustomThumbStar = new MB.Controls.ColorSlider();
            this.colorSliderCustomThumbSpiral = new MB.Controls.ColorSlider();
            this.colorSliderCustomThumbTrackBar = new MB.Controls.ColorSlider();
            this.colorSliderCustomThumbText = new MB.Controls.ColorSlider();
            this.edEventLog = new System.Windows.Forms.TextBox();
            this.cbEventLog = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.colorSlider4);
            this.groupBox1.Controls.Add(this.colorSlider3);
            this.groupBox1.Controls.Add(this.colorSlider2);
            this.groupBox1.Controls.Add(this.colorSlider1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ColorSlider examples";
            // 
            // colorSlider4
            // 
            this.colorSlider4.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider4.BorderRoundRectSize = new System.Drawing.Size(10, 10);
            this.colorSlider4.LargeChange = ((uint)(5u));
            this.colorSlider4.Location = new System.Drawing.Point(6, 81);
            this.colorSlider4.Name = "colorSlider4";
            this.colorSlider4.Size = new System.Drawing.Size(254, 16);
            this.colorSlider4.SmallChange = ((uint)(1u));
            this.colorSlider4.TabIndex = 3;
            this.colorSlider4.Text = "colorSlider4";
            this.colorSlider4.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider4.ThumbSize = 25;
            this.colorSlider4.ValueChanged += new System.EventHandler(this.SlidersValueChanged);
            this.colorSlider4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SlidersScroll);
            // 
            // colorSlider3
            // 
            this.colorSlider3.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider3.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider3.LargeChange = ((uint)(5u));
            this.colorSlider3.Location = new System.Drawing.Point(6, 60);
            this.colorSlider3.MouseEffects = false;
            this.colorSlider3.Name = "colorSlider3";
            this.colorSlider3.Size = new System.Drawing.Size(254, 16);
            this.colorSlider3.SmallChange = ((uint)(1u));
            this.colorSlider3.TabIndex = 2;
            this.colorSlider3.Text = "colorSlider3";
            this.colorSlider3.ThumbInnerColor = System.Drawing.Color.Yellow;
            this.colorSlider3.ThumbOuterColor = System.Drawing.Color.Orange;
            this.colorSlider3.ThumbPenColor = System.Drawing.Color.Gold;
            this.colorSlider3.ThumbRoundRectSize = new System.Drawing.Size(2, 2);
            this.colorSlider3.ThumbSize = 25;
            this.colorSlider3.ValueChanged += new System.EventHandler(this.SlidersValueChanged);
            this.colorSlider3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SlidersScroll);
            // 
            // colorSlider2
            // 
            this.colorSlider2.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider2.BarInnerColor = System.Drawing.Color.Maroon;
            this.colorSlider2.BarOuterColor = System.Drawing.Color.LightCoral;
            this.colorSlider2.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider2.ElapsedInnerColor = System.Drawing.Color.Yellow;
            this.colorSlider2.ElapsedOuterColor = System.Drawing.Color.Orange;
            this.colorSlider2.LargeChange = ((uint)(5u));
            this.colorSlider2.Location = new System.Drawing.Point(6, 39);
            this.colorSlider2.MouseEffects = false;
            this.colorSlider2.Name = "colorSlider2";
            this.colorSlider2.Size = new System.Drawing.Size(254, 16);
            this.colorSlider2.SmallChange = ((uint)(1u));
            this.colorSlider2.TabIndex = 1;
            this.colorSlider2.Text = "colorSlider2";
            this.colorSlider2.ThumbRoundRectSize = new System.Drawing.Size(2, 2);
            this.colorSlider2.ThumbSize = 25;
            this.colorSlider2.ValueChanged += new System.EventHandler(this.SlidersValueChanged);
            this.colorSlider2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SlidersScroll);
            // 
            // colorSlider1
            // 
            this.colorSlider1.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider1.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider1.LargeChange = ((uint)(5u));
            this.colorSlider1.Location = new System.Drawing.Point(6, 18);
            this.colorSlider1.Name = "colorSlider1";
            this.colorSlider1.Size = new System.Drawing.Size(254, 16);
            this.colorSlider1.SmallChange = ((uint)(1u));
            this.colorSlider1.TabIndex = 0;
            this.colorSlider1.Text = "/";
            this.colorSlider1.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.colorSlider1.ThumbRoundRectSize = new System.Drawing.Size(2, 2);
            this.colorSlider1.ThumbSize = 25;
            this.colorSlider1.ValueChanged += new System.EventHandler(this.SlidersValueChanged);
            this.colorSlider1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SlidersScroll);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.colorSliderCustomThumbSinus);
            this.groupBox2.Controls.Add(this.colorSliderCustomThumbStar);
            this.groupBox2.Controls.Add(this.colorSliderCustomThumbSpiral);
            this.groupBox2.Controls.Add(this.colorSliderCustomThumbTrackBar);
            this.groupBox2.Controls.Add(this.colorSliderCustomThumbText);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom thumb examples (run application for effects)";
            // 
            // colorSliderCustomThumbSinus
            // 
            this.colorSliderCustomThumbSinus.BackColor = System.Drawing.Color.Transparent;
            this.colorSliderCustomThumbSinus.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSliderCustomThumbSinus.LargeChange = ((uint)(5u));
            this.colorSliderCustomThumbSinus.Location = new System.Drawing.Point(6, 147);
            this.colorSliderCustomThumbSinus.Name = "colorSliderCustomThumbSinus";
            this.colorSliderCustomThumbSinus.Size = new System.Drawing.Size(254, 34);
            this.colorSliderCustomThumbSinus.SmallChange = ((uint)(1u));
            this.colorSliderCustomThumbSinus.TabIndex = 4;
            this.colorSliderCustomThumbSinus.Text = "/";
            this.colorSliderCustomThumbSinus.ThumbInnerColor = System.Drawing.Color.Red;
            this.colorSliderCustomThumbSinus.ThumbOuterColor = System.Drawing.Color.Firebrick;
            this.colorSliderCustomThumbSinus.ThumbPenColor = System.Drawing.Color.IndianRed;
            this.colorSliderCustomThumbSinus.ThumbRoundRectSize = new System.Drawing.Size(2, 2);
            this.colorSliderCustomThumbSinus.ThumbSize = 25;
            this.colorSliderCustomThumbSinus.ValueChanged += new System.EventHandler(this.SlidersValueChanged);
            this.colorSliderCustomThumbSinus.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SlidersScroll);
            // 
            // colorSliderCustomThumbStar
            // 
            this.colorSliderCustomThumbStar.BackColor = System.Drawing.Color.Transparent;
            this.colorSliderCustomThumbStar.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSliderCustomThumbStar.LargeChange = ((uint)(5u));
            this.colorSliderCustomThumbStar.Location = new System.Drawing.Point(6, 107);
            this.colorSliderCustomThumbStar.MouseEffects = false;
            this.colorSliderCustomThumbStar.Name = "colorSliderCustomThumbStar";
            this.colorSliderCustomThumbStar.Size = new System.Drawing.Size(254, 34);
            this.colorSliderCustomThumbStar.SmallChange = ((uint)(1u));
            this.colorSliderCustomThumbStar.TabIndex = 3;
            this.colorSliderCustomThumbStar.Text = "/";
            this.colorSliderCustomThumbStar.ThumbInnerColor = System.Drawing.Color.Goldenrod;
            this.colorSliderCustomThumbStar.ThumbOuterColor = System.Drawing.Color.Yellow;
            this.colorSliderCustomThumbStar.ThumbPenColor = System.Drawing.Color.Gold;
            this.colorSliderCustomThumbStar.ThumbRoundRectSize = new System.Drawing.Size(2, 2);
            this.colorSliderCustomThumbStar.ThumbSize = 25;
            this.colorSliderCustomThumbStar.ValueChanged += new System.EventHandler(this.SlidersValueChanged);
            this.colorSliderCustomThumbStar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SlidersScroll);
            // 
            // colorSliderCustomThumbSpiral
            // 
            this.colorSliderCustomThumbSpiral.BackColor = System.Drawing.Color.Transparent;
            this.colorSliderCustomThumbSpiral.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSliderCustomThumbSpiral.LargeChange = ((uint)(5u));
            this.colorSliderCustomThumbSpiral.Location = new System.Drawing.Point(6, 67);
            this.colorSliderCustomThumbSpiral.Name = "colorSliderCustomThumbSpiral";
            this.colorSliderCustomThumbSpiral.Size = new System.Drawing.Size(254, 34);
            this.colorSliderCustomThumbSpiral.SmallChange = ((uint)(1u));
            this.colorSliderCustomThumbSpiral.TabIndex = 2;
            this.colorSliderCustomThumbSpiral.Text = "/";
            this.colorSliderCustomThumbSpiral.ThumbInnerColor = System.Drawing.Color.Red;
            this.colorSliderCustomThumbSpiral.ThumbOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.colorSliderCustomThumbSpiral.ThumbPenColor = System.Drawing.Color.IndianRed;
            this.colorSliderCustomThumbSpiral.ThumbRoundRectSize = new System.Drawing.Size(2, 2);
            this.colorSliderCustomThumbSpiral.ThumbSize = 25;
            this.colorSliderCustomThumbSpiral.ValueChanged += new System.EventHandler(this.SlidersValueChanged);
            this.colorSliderCustomThumbSpiral.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SlidersScroll);
            // 
            // colorSliderCustomThumbTrackBar
            // 
            this.colorSliderCustomThumbTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.colorSliderCustomThumbTrackBar.BarInnerColor = System.Drawing.Color.Silver;
            this.colorSliderCustomThumbTrackBar.BarOuterColor = System.Drawing.Color.Transparent;
            this.colorSliderCustomThumbTrackBar.BarPenColor = System.Drawing.Color.Transparent;
            this.colorSliderCustomThumbTrackBar.BorderRoundRectSize = new System.Drawing.Size(1, 1);
            this.colorSliderCustomThumbTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorSliderCustomThumbTrackBar.DrawFocusRectangle = false;
            this.colorSliderCustomThumbTrackBar.ElapsedInnerColor = System.Drawing.Color.CornflowerBlue;
            this.colorSliderCustomThumbTrackBar.ElapsedOuterColor = System.Drawing.Color.RoyalBlue;
            this.colorSliderCustomThumbTrackBar.LargeChange = ((uint)(5u));
            this.colorSliderCustomThumbTrackBar.Location = new System.Drawing.Point(6, 39);
            this.colorSliderCustomThumbTrackBar.MouseEffects = false;
            this.colorSliderCustomThumbTrackBar.MouseWheelBarPartitions = 100;
            this.colorSliderCustomThumbTrackBar.Name = "colorSliderCustomThumbTrackBar";
            this.colorSliderCustomThumbTrackBar.Size = new System.Drawing.Size(254, 15);
            this.colorSliderCustomThumbTrackBar.SmallChange = ((uint)(1u));
            this.colorSliderCustomThumbTrackBar.TabIndex = 1;
            this.colorSliderCustomThumbTrackBar.Text = "/";
            this.colorSliderCustomThumbTrackBar.ThumbInnerColor = System.Drawing.Color.Transparent;
            this.colorSliderCustomThumbTrackBar.ThumbOuterColor = System.Drawing.Color.Transparent;
            this.colorSliderCustomThumbTrackBar.ThumbPenColor = System.Drawing.Color.Transparent;
            this.colorSliderCustomThumbTrackBar.ThumbRoundRectSize = new System.Drawing.Size(10, 10);
            this.colorSliderCustomThumbTrackBar.ThumbSize = 12;
            this.colorSliderCustomThumbTrackBar.ValueChanged += new System.EventHandler(this.SlidersValueChanged);
            this.colorSliderCustomThumbTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SlidersScroll);
            this.colorSliderCustomThumbTrackBar.MouseEnter += new System.EventHandler(this.colorSliderCustomThumbTrackBar_MouseEnter);
            this.colorSliderCustomThumbTrackBar.MouseLeave += new System.EventHandler(this.colorSliderCustomThumbTrackBar_MouseLeave);
            // 
            // colorSliderCustomThumbText
            // 
            this.colorSliderCustomThumbText.BackColor = System.Drawing.Color.Transparent;
            this.colorSliderCustomThumbText.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSliderCustomThumbText.LargeChange = ((uint)(5u));
            this.colorSliderCustomThumbText.Location = new System.Drawing.Point(6, 18);
            this.colorSliderCustomThumbText.Name = "colorSliderCustomThumbText";
            this.colorSliderCustomThumbText.Size = new System.Drawing.Size(254, 16);
            this.colorSliderCustomThumbText.SmallChange = ((uint)(1u));
            this.colorSliderCustomThumbText.TabIndex = 0;
            this.colorSliderCustomThumbText.Text = "/";
            this.colorSliderCustomThumbText.ThumbInnerColor = System.Drawing.Color.BlueViolet;
            this.colorSliderCustomThumbText.ThumbOuterColor = System.Drawing.Color.Indigo;
            this.colorSliderCustomThumbText.ThumbPenColor = System.Drawing.Color.Fuchsia;
            this.colorSliderCustomThumbText.ThumbRoundRectSize = new System.Drawing.Size(2, 2);
            this.colorSliderCustomThumbText.ThumbSize = 25;
            this.colorSliderCustomThumbText.ValueChanged += new System.EventHandler(this.SlidersValueChanged);
            this.colorSliderCustomThumbText.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SlidersScroll);
            // 
            // edEventLog
            // 
            this.edEventLog.Location = new System.Drawing.Point(307, 26);
            this.edEventLog.Multiline = true;
            this.edEventLog.Name = "edEventLog";
            this.edEventLog.ReadOnly = true;
            this.edEventLog.Size = new System.Drawing.Size(256, 288);
            this.edEventLog.TabIndex = 2;
            // 
            // cbEventLog
            // 
            this.cbEventLog.AutoSize = true;
            this.cbEventLog.BackColor = System.Drawing.Color.Transparent;
            this.cbEventLog.Location = new System.Drawing.Point(302, 6);
            this.cbEventLog.Name = "cbEventLog";
            this.cbEventLog.Size = new System.Drawing.Size(234, 16);
            this.cbEventLog.TabIndex = 3;
            this.cbEventLog.Text = "Event log (may degrade performance)";
            this.cbEventLog.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ColorSliderTest.Properties.Resources.Na_rybkach;
            this.ClientSize = new System.Drawing.Size(572, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbEventLog);
            this.Controls.Add(this.edEventLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "ColorSlider Test";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MB.Controls.ColorSlider colorSlider4;
        private MB.Controls.ColorSlider colorSlider3;
        private MB.Controls.ColorSlider colorSlider2;
        private MB.Controls.ColorSlider colorSlider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MB.Controls.ColorSlider colorSliderCustomThumbText;
        private MB.Controls.ColorSlider colorSliderCustomThumbTrackBar;
        private MB.Controls.ColorSlider colorSliderCustomThumbSpiral;
        private MB.Controls.ColorSlider colorSliderCustomThumbStar;
        private MB.Controls.ColorSlider colorSliderCustomThumbSinus;
        private System.Windows.Forms.TextBox edEventLog;
        private System.Windows.Forms.CheckBox cbEventLog;
        private System.Windows.Forms.Button button1;

    }
}

