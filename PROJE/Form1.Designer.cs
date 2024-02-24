namespace PROJE
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boxerHealthBar = new System.Windows.Forms.ProgressBar();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.isim = new System.Windows.Forms.Label();
            this.isim2 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.boxer = new System.Windows.Forms.PictureBox();
            this.BoxerAttackTimer = new System.Windows.Forms.Timer(this.components);
            this.BoxerMoveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxer)).BeginInit();
            this.SuspendLayout();
            // 
            // boxerHealthBar
            // 
            this.boxerHealthBar.Location = new System.Drawing.Point(97, 12);
            this.boxerHealthBar.Name = "boxerHealthBar";
            this.boxerHealthBar.Size = new System.Drawing.Size(164, 23);
            this.boxerHealthBar.TabIndex = 1;
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.playerHealthBar.Location = new System.Drawing.Point(583, 12);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(164, 23);
            this.playerHealthBar.TabIndex = 2;
            // 
            // isim
            // 
            this.isim.BackColor = System.Drawing.Color.Green;
            this.isim.Location = new System.Drawing.Point(617, 38);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(100, 23);
            this.isim.TabIndex = 3;
            this.isim.Text = "YOU";
            this.isim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // isim2
            // 
            this.isim2.BackColor = System.Drawing.Color.Green;
            this.isim2.Location = new System.Drawing.Point(131, 38);
            this.isim2.Name = "isim2";
            this.isim2.Size = new System.Drawing.Size(100, 23);
            this.isim2.TabIndex = 4;
            this.isim2.Text = "ENEMY";
            this.isim2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(521, 396);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(61, 153);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // boxer
            // 
            this.boxer.BackColor = System.Drawing.Color.Transparent;
            this.boxer.Image = ((System.Drawing.Image)(resources.GetObject("boxer.Image")));
            this.boxer.Location = new System.Drawing.Point(521, 238);
            this.boxer.Name = "boxer";
            this.boxer.Size = new System.Drawing.Size(77, 185);
            this.boxer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.boxer.TabIndex = 6;
            this.boxer.TabStop = false;
            // 
            // BoxerAttackTimer
            // 
            this.BoxerAttackTimer.Enabled = true;
            this.BoxerAttackTimer.Interval = 500;
            this.BoxerAttackTimer.Tick += new System.EventHandler(this.BoxerAttackTimerEvent);
            // 
            // BoxerMoveTimer
            // 
            this.BoxerMoveTimer.Enabled = true;
            this.BoxerMoveTimer.Interval = 20;
            this.BoxerMoveTimer.Tick += new System.EventHandler(this.BoxerMoveTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJE.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 630);
            this.Controls.Add(this.player);
            this.Controls.Add(this.isim2);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.boxerHealthBar);
            this.Controls.Add(this.boxer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar boxerHealthBar;
        private System.Windows.Forms.ProgressBar playerHealthBar;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.Label isim2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox boxer;
        private System.Windows.Forms.Timer BoxerAttackTimer;
        private System.Windows.Forms.Timer BoxerMoveTimer;
    }
}

