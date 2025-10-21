namespace YilanOyunu
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidePanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnLastScore = new System.Windows.Forms.Button();
            this.btnDev = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(5);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1050, 48);
            this.topPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(999, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 48);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "PUAN";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtScore.Font = new System.Drawing.Font("Yu Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtScore.Location = new System.Drawing.Point(930, 152);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(30, 35);
            this.txtScore.TabIndex = 3;
            this.txtScore.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(12, 213);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(165, 30);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Font = new System.Drawing.Font("Yu Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMessage.Location = new System.Drawing.Point(84, 212);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(168, 61);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.Text = "label2";
            this.txtMessage.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidePanel.Controls.Add(this.btnDev);
            this.sidePanel.Controls.Add(this.btnLastScore);
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Controls.Add(this.btnInfo);
            this.sidePanel.Controls.Add(this.btnStart);
            this.sidePanel.Location = new System.Drawing.Point(861, 47);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(189, 557);
            this.sidePanel.TabIndex = 6;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.txtMessage);
            this.gamePanel.Location = new System.Drawing.Point(0, 47);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(855, 554);
            this.gamePanel.TabIndex = 7;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfo.Location = new System.Drawing.Point(12, 267);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(165, 30);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "Oyun Bilgisi";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnLastScore
            // 
            this.btnLastScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLastScore.Location = new System.Drawing.Point(12, 320);
            this.btnLastScore.Name = "btnLastScore";
            this.btnLastScore.Size = new System.Drawing.Size(165, 30);
            this.btnLastScore.TabIndex = 6;
            this.btnLastScore.Text = "Son Yüksek Skor";
            this.btnLastScore.UseVisualStyleBackColor = true;
            this.btnLastScore.Click += new System.EventHandler(this.btnLastScore_Click);
            // 
            // btnDev
            // 
            this.btnDev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDev.Location = new System.Drawing.Point(12, 376);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(165, 30);
            this.btnDev.TabIndex = 7;
            this.btnDev.Text = "Geliştirici";
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.btnDev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.topPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtMessage;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button btnDev;
        private System.Windows.Forms.Button btnLastScore;
        private System.Windows.Forms.Button btnInfo;
    }
}

