namespace DA_Pjct_01
{
    partial class Pepe01
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit_Button = new System.Windows.Forms.PictureBox();
            this.Trial_02_Button = new System.Windows.Forms.Button();
            this.Theta_02 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_probability = new System.Windows.Forms.Label();
            this.l_expeTimes = new System.Windows.Forms.Label();
            this.ExpeTimes_02 = new System.Windows.Forms.TextBox();
            this.l_trialTimes = new System.Windows.Forms.Label();
            this.TrialTimes_02 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TrialTimes_01 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpeTimes_01 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Theta_01 = new System.Windows.Forms.TextBox();
            this.Trial_01_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.Image = global::DA_Pjct_01.Properties.Resources._5845cd230b2a3b54fdbaecf7;
            this.Exit_Button.Location = new System.Drawing.Point(-2, 467);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(28, 26);
            this.Exit_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.TabStop = false;
            this.Exit_Button.DoubleClick += new System.EventHandler(this.Exit_Button_DoubleClick);
            // 
            // Trial_02_Button
            // 
            this.Trial_02_Button.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Trial_02_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
            this.Trial_02_Button.FlatAppearance.BorderSize = 3;
            this.Trial_02_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.Trial_02_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.Trial_02_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trial_02_Button.Font = new System.Drawing.Font("Andalus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Trial_02_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
            this.Trial_02_Button.Location = new System.Drawing.Point(1192, 451);
            this.Trial_02_Button.Name = "Trial_02_Button";
            this.Trial_02_Button.Size = new System.Drawing.Size(59, 28);
            this.Trial_02_Button.TabIndex = 1;
            this.Trial_02_Button.Text = "Flip";
            this.Trial_02_Button.UseVisualStyleBackColor = false;
            this.Trial_02_Button.Click += new System.EventHandler(this.Trial_Button_Click);
            // 
            // Theta_02
            // 
            this.Theta_02.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Theta_02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Theta_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Theta_02.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Theta_02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
            this.Theta_02.Location = new System.Drawing.Point(1114, 452);
            this.Theta_02.Multiline = true;
            this.Theta_02.Name = "Theta_02";
            this.Theta_02.Size = new System.Drawing.Size(59, 25);
            this.Theta_02.TabIndex = 2;
            this.Theta_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Theta_02.TextChanged += new System.EventHandler(this.Theta_TextChanged);
            this.Theta_02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Theta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // l_probability
            // 
            this.l_probability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l_probability.Font = new System.Drawing.Font("Andalus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l_probability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
            this.l_probability.Location = new System.Drawing.Point(1079, 452);
            this.l_probability.Name = "l_probability";
            this.l_probability.Size = new System.Drawing.Size(29, 25);
            this.l_probability.TabIndex = 4;
            this.l_probability.Text = "P :";
            this.l_probability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_expeTimes
            // 
            this.l_expeTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l_expeTimes.Font = new System.Drawing.Font("Andalus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l_expeTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
            this.l_expeTimes.Location = new System.Drawing.Point(974, 452);
            this.l_expeTimes.Name = "l_expeTimes";
            this.l_expeTimes.Size = new System.Drawing.Size(34, 25);
            this.l_expeTimes.TabIndex = 6;
            this.l_expeTimes.Text = "N :";
            this.l_expeTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpeTimes_02
            // 
            this.ExpeTimes_02.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ExpeTimes_02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpeTimes_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpeTimes_02.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExpeTimes_02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
            this.ExpeTimes_02.Location = new System.Drawing.Point(1014, 452);
            this.ExpeTimes_02.Multiline = true;
            this.ExpeTimes_02.Name = "ExpeTimes_02";
            this.ExpeTimes_02.Size = new System.Drawing.Size(59, 25);
            this.ExpeTimes_02.TabIndex = 5;
            this.ExpeTimes_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExpeTimes_02.TextChanged += new System.EventHandler(this.ExpeTimes_TextChanged);
            this.ExpeTimes_02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExpeTimes_KeyPress);
            // 
            // l_trialTimes
            // 
            this.l_trialTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l_trialTimes.Font = new System.Drawing.Font("Andalus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.l_trialTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
            this.l_trialTimes.Location = new System.Drawing.Point(870, 451);
            this.l_trialTimes.Name = "l_trialTimes";
            this.l_trialTimes.Size = new System.Drawing.Size(33, 25);
            this.l_trialTimes.TabIndex = 8;
            this.l_trialTimes.Text = "D :";
            this.l_trialTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrialTimes_02
            // 
            this.TrialTimes_02.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TrialTimes_02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrialTimes_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrialTimes_02.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TrialTimes_02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(70)))), ((int)(((byte)(112)))));
            this.TrialTimes_02.Location = new System.Drawing.Point(909, 451);
            this.TrialTimes_02.Multiline = true;
            this.TrialTimes_02.Name = "TrialTimes_02";
            this.TrialTimes_02.Size = new System.Drawing.Size(59, 25);
            this.TrialTimes_02.TabIndex = 7;
            this.TrialTimes_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TrialTimes_02.TextChanged += new System.EventHandler(this.TrialTimes_TextChanged);
            this.TrialTimes_02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrialTimes_KeyPress);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Andalus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(438, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "D :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrialTimes_01
            // 
            this.TrialTimes_01.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TrialTimes_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrialTimes_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrialTimes_01.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TrialTimes_01.ForeColor = System.Drawing.Color.GreenYellow;
            this.TrialTimes_01.Location = new System.Drawing.Point(477, 450);
            this.TrialTimes_01.Multiline = true;
            this.TrialTimes_01.Name = "TrialTimes_01";
            this.TrialTimes_01.Size = new System.Drawing.Size(59, 25);
            this.TrialTimes_01.TabIndex = 14;
            this.TrialTimes_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TrialTimes_01.TextChanged += new System.EventHandler(this.TrialTimes_01_TextChanged);
            this.TrialTimes_01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrialTimes_01_KeyPress);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Andalus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(542, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "N :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpeTimes_01
            // 
            this.ExpeTimes_01.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ExpeTimes_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpeTimes_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpeTimes_01.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExpeTimes_01.ForeColor = System.Drawing.Color.GreenYellow;
            this.ExpeTimes_01.Location = new System.Drawing.Point(582, 451);
            this.ExpeTimes_01.Multiline = true;
            this.ExpeTimes_01.Name = "ExpeTimes_01";
            this.ExpeTimes_01.Size = new System.Drawing.Size(59, 25);
            this.ExpeTimes_01.TabIndex = 12;
            this.ExpeTimes_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExpeTimes_01.TextChanged += new System.EventHandler(this.ExpeTimes_01_TextChanged);
            this.ExpeTimes_01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExpeTimes_01_KeyPress);
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Andalus", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(647, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "P :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Theta_01
            // 
            this.Theta_01.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Theta_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Theta_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Theta_01.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Theta_01.ForeColor = System.Drawing.Color.GreenYellow;
            this.Theta_01.Location = new System.Drawing.Point(682, 451);
            this.Theta_01.Multiline = true;
            this.Theta_01.Name = "Theta_01";
            this.Theta_01.Size = new System.Drawing.Size(59, 25);
            this.Theta_01.TabIndex = 10;
            this.Theta_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Theta_01.TextChanged += new System.EventHandler(this.Theta_01_TextChanged);
            this.Theta_01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Theta_01_KeyPress);
            // 
            // Trial_01_Button
            // 
            this.Trial_01_Button.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Trial_01_Button.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.Trial_01_Button.FlatAppearance.BorderSize = 3;
            this.Trial_01_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.Trial_01_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.Trial_01_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trial_01_Button.Font = new System.Drawing.Font("Andalus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Trial_01_Button.ForeColor = System.Drawing.Color.GreenYellow;
            this.Trial_01_Button.Location = new System.Drawing.Point(760, 450);
            this.Trial_01_Button.Name = "Trial_01_Button";
            this.Trial_01_Button.Size = new System.Drawing.Size(59, 28);
            this.Trial_01_Button.TabIndex = 9;
            this.Trial_01_Button.Text = "Flip";
            this.Trial_01_Button.UseVisualStyleBackColor = false;
            this.Trial_01_Button.Click += new System.EventHandler(this.Trial_01_Button_Click);
            // 
            // Pepe01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1263, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrialTimes_01);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExpeTimes_01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Theta_01);
            this.Controls.Add(this.Trial_01_Button);
            this.Controls.Add(this.l_trialTimes);
            this.Controls.Add(this.TrialTimes_02);
            this.Controls.Add(this.l_expeTimes);
            this.Controls.Add(this.ExpeTimes_02);
            this.Controls.Add(this.l_probability);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Theta_02);
            this.Controls.Add(this.Trial_02_Button);
            this.Controls.Add(this.Exit_Button);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pepe01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Pepe01_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pepe01_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Pepe01_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pepe01_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pepe01_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox Exit_Button;
        private System.Windows.Forms.Button Trial_02_Button;
        private System.Windows.Forms.TextBox Theta_02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_probability;
        private System.Windows.Forms.Label l_expeTimes;
        private System.Windows.Forms.TextBox ExpeTimes_02;
        private System.Windows.Forms.Label l_trialTimes;
        private System.Windows.Forms.TextBox TrialTimes_02;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TrialTimes_01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExpeTimes_01;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Theta_01;
        private System.Windows.Forms.Button Trial_01_Button;
    }
}

