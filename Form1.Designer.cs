
namespace livewheel
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
            this.cpb_Countdown = new CircularProgressBar.CircularProgressBar();
            this.tmr_Countdown = new System.Windows.Forms.Timer(this.components);
            this.btn_Start = new System.Windows.Forms.Button();
            this.tmr_showVideo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cpb_Countdown
            // 
            this.cpb_Countdown.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpb_Countdown.AnimationSpeed = 500;
            this.cpb_Countdown.BackColor = System.Drawing.Color.Transparent;
            this.cpb_Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpb_Countdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpb_Countdown.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpb_Countdown.InnerMargin = 2;
            this.cpb_Countdown.InnerWidth = -1;
            this.cpb_Countdown.Location = new System.Drawing.Point(48, 27);
            this.cpb_Countdown.MarqueeAnimationSpeed = 2000;
            this.cpb_Countdown.Name = "cpb_Countdown";
            this.cpb_Countdown.OuterColor = System.Drawing.Color.Gray;
            this.cpb_Countdown.OuterMargin = -25;
            this.cpb_Countdown.OuterWidth = 26;
            this.cpb_Countdown.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpb_Countdown.ProgressWidth = 25;
            this.cpb_Countdown.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpb_Countdown.Size = new System.Drawing.Size(524, 524);
            this.cpb_Countdown.StartAngle = 270;
            this.cpb_Countdown.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpb_Countdown.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpb_Countdown.SubscriptText = "";
            this.cpb_Countdown.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpb_Countdown.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpb_Countdown.SuperscriptText = "";
            this.cpb_Countdown.TabIndex = 0;
            this.cpb_Countdown.Text = "0";
            this.cpb_Countdown.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpb_Countdown.Value = 68;
            // 
            // tmr_Countdown
            // 
            this.tmr_Countdown.Interval = 1000;
            this.tmr_Countdown.Tick += new System.EventHandler(this.tmr_Countdown_Tick);
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(849, 36);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(153, 66);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // tmr_showVideo
            // 
            this.tmr_showVideo.Interval = 3000;
            this.tmr_showVideo.Tick += new System.EventHandler(this.tmr_showVideo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 710);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.cpb_Countdown);
            this.Name = "Form1";
            this.Text = "Live Wheel PID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cpb_Countdown;
        private System.Windows.Forms.Timer tmr_Countdown;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Timer tmr_showVideo;
    }
}

