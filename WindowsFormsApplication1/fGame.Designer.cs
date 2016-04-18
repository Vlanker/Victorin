namespace WindowsFormsApplication1
{
    partial class fGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCout1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCount2 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContiny = new System.Windows.Forms.Button();
            this.lbMelodyCount = new System.Windows.Forms.Label();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.tTime = new System.Windows.Forms.Timer(this.components);
            this.lbmusDuration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(83, 169);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(224, 84);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(162, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Следущая";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Игрок 1";
            // 
            // lbCout1
            // 
            this.lbCout1.AutoSize = true;
            this.lbCout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCout1.Location = new System.Drawing.Point(60, 58);
            this.lbCout1.Name = "lbCout1";
            this.lbCout1.Size = new System.Drawing.Size(29, 31);
            this.lbCout1.TabIndex = 3;
            this.lbCout1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(266, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Игрок 2";
            // 
            // lbCount2
            // 
            this.lbCount2.AutoSize = true;
            this.lbCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount2.Location = new System.Drawing.Point(310, 58);
            this.lbCount2.Name = "lbCount2";
            this.lbCount2.Size = new System.Drawing.Size(29, 31);
            this.lbCount2.TabIndex = 5;
            this.lbCount2.Text = "0";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(162, 41);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnContiny
            // 
            this.btnContiny.Location = new System.Drawing.Point(162, 69);
            this.btnContiny.Name = "btnContiny";
            this.btnContiny.Size = new System.Drawing.Size(75, 23);
            this.btnContiny.TabIndex = 7;
            this.btnContiny.Text = "Продолжить";
            this.btnContiny.UseVisualStyleBackColor = true;
            this.btnContiny.Click += new System.EventHandler(this.btnContiny_Click);
            // 
            // lbMelodyCount
            // 
            this.lbMelodyCount.AutoSize = true;
            this.lbMelodyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMelodyCount.Location = new System.Drawing.Point(190, 95);
            this.lbMelodyCount.Name = "lbMelodyCount";
            this.lbMelodyCount.Size = new System.Drawing.Size(16, 18);
            this.lbMelodyCount.TabIndex = 8;
            this.lbMelodyCount.Text = "0";
            // 
            // pbTime
            // 
            this.pbTime.Location = new System.Drawing.Point(13, 122);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(363, 10);
            this.pbTime.TabIndex = 9;
            // 
            // tTime
            // 
            this.tTime.Interval = 1000;
            this.tTime.Tick += new System.EventHandler(this.tTime_Tick);
            // 
            // lbmusDuration
            // 
            this.lbmusDuration.AutoSize = true;
            this.lbmusDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbmusDuration.Location = new System.Drawing.Point(341, 135);
            this.lbmusDuration.Name = "lbmusDuration";
            this.lbmusDuration.Size = new System.Drawing.Size(16, 18);
            this.lbmusDuration.TabIndex = 10;
            this.lbmusDuration.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Оставшееся время проигрываемой мелодии:";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 190);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbmusDuration);
            this.Controls.Add(this.pbTime);
            this.Controls.Add(this.lbMelodyCount);
            this.Controls.Add(this.btnContiny);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lbCount2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCout1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCout1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCount2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContiny;
        private System.Windows.Forms.Label lbMelodyCount;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.Timer tTime;
        private System.Windows.Forms.Label lbmusDuration;
        private System.Windows.Forms.Label label1;
    }
}