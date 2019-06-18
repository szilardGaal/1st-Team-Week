namespace ping_pong
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.gameArena = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.levelText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameArena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // gameArena
            // 
            this.gameArena.BackColor = System.Drawing.Color.LawnGreen;
            resources.ApplyResources(this.gameArena, "gameArena");
            this.gameArena.Name = "gameArena";
            this.gameArena.TabStop = false;
            // 
            // player
            // 
            resources.ApplyResources(this.player, "player");
            this.player.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player.Name = "player";
            this.player.TabStop = false;
            // 
            // ball
            // 
            resources.ApplyResources(this.ball, "ball");
            this.ball.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ball.Name = "ball";
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // scoreBox
            // 
            resources.ApplyResources(this.scoreBox, "scoreBox");
            this.scoreBox.ForeColor = System.Drawing.Color.Black;
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // levelText
            // 
            this.levelText.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.levelText, "levelText");
            this.levelText.Name = "levelText";
            this.levelText.ReadOnly = true;
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.levelText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Controls.Add(this.gameArena);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.gameArena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox gameArena;
        public System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox levelText;
    }
}

