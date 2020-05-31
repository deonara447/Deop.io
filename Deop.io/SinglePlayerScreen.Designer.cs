namespace Deop.io
{
    partial class SinglePlayerScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.speedLabel = new System.Windows.Forms.Label();
            this.reloadLabel = new System.Windows.Forms.Label();
            this.bulletDamageLabel = new System.Windows.Forms.Label();
            this.bulletSpeedLabel = new System.Windows.Forms.Label();
            this.bulletHealthLabel = new System.Windows.Forms.Label();
            this.bodyDamageLabel = new System.Windows.Forms.Label();
            this.healthRegenLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.health1Label = new System.Windows.Forms.Label();
            this.xp1Label = new System.Windows.Forms.Label();
            this.level1Label = new System.Windows.Forms.Label();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // speedLabel
            // 
            this.speedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Location = new System.Drawing.Point(1093, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(156, 44);
            this.speedLabel.TabIndex = 21;
            this.speedLabel.Text = "Speed";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reloadLabel
            // 
            this.reloadLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.reloadLabel.ForeColor = System.Drawing.Color.White;
            this.reloadLabel.Location = new System.Drawing.Point(937, 0);
            this.reloadLabel.Name = "reloadLabel";
            this.reloadLabel.Size = new System.Drawing.Size(156, 44);
            this.reloadLabel.TabIndex = 20;
            this.reloadLabel.Text = "Reload";
            this.reloadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bulletDamageLabel
            // 
            this.bulletDamageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bulletDamageLabel.ForeColor = System.Drawing.Color.White;
            this.bulletDamageLabel.Location = new System.Drawing.Point(781, 0);
            this.bulletDamageLabel.Name = "bulletDamageLabel";
            this.bulletDamageLabel.Size = new System.Drawing.Size(156, 44);
            this.bulletDamageLabel.TabIndex = 19;
            this.bulletDamageLabel.Text = "Bullet Damage";
            this.bulletDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bulletSpeedLabel
            // 
            this.bulletSpeedLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bulletSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.bulletSpeedLabel.Location = new System.Drawing.Point(469, 0);
            this.bulletSpeedLabel.Name = "bulletSpeedLabel";
            this.bulletSpeedLabel.Size = new System.Drawing.Size(156, 44);
            this.bulletSpeedLabel.TabIndex = 18;
            this.bulletSpeedLabel.Text = "Bullet Speed";
            this.bulletSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bulletHealthLabel
            // 
            this.bulletHealthLabel.BackColor = System.Drawing.Color.Gold;
            this.bulletHealthLabel.ForeColor = System.Drawing.Color.White;
            this.bulletHealthLabel.Location = new System.Drawing.Point(625, 0);
            this.bulletHealthLabel.Name = "bulletHealthLabel";
            this.bulletHealthLabel.Size = new System.Drawing.Size(156, 44);
            this.bulletHealthLabel.TabIndex = 17;
            this.bulletHealthLabel.Text = "Bullet Health";
            this.bulletHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bodyDamageLabel
            // 
            this.bodyDamageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bodyDamageLabel.ForeColor = System.Drawing.Color.White;
            this.bodyDamageLabel.Location = new System.Drawing.Point(313, 0);
            this.bodyDamageLabel.Name = "bodyDamageLabel";
            this.bodyDamageLabel.Size = new System.Drawing.Size(156, 44);
            this.bodyDamageLabel.TabIndex = 16;
            this.bodyDamageLabel.Text = "Body Damage";
            this.bodyDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthRegenLabel
            // 
            this.healthRegenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.healthRegenLabel.ForeColor = System.Drawing.Color.White;
            this.healthRegenLabel.Location = new System.Drawing.Point(157, 0);
            this.healthRegenLabel.Name = "healthRegenLabel";
            this.healthRegenLabel.Size = new System.Drawing.Size(156, 44);
            this.healthRegenLabel.TabIndex = 15;
            this.healthRegenLabel.Text = "Health Regen";
            this.healthRegenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthLabel
            // 
            this.healthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(1, 0);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(156, 44);
            this.healthLabel.TabIndex = 14;
            this.healthLabel.Text = "Health";
            this.healthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // health1Label
            // 
            this.health1Label.BackColor = System.Drawing.Color.Transparent;
            this.health1Label.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health1Label.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.health1Label.Location = new System.Drawing.Point(-7, 1692);
            this.health1Label.Name = "health1Label";
            this.health1Label.Size = new System.Drawing.Size(123, 39);
            this.health1Label.TabIndex = 22;
            this.health1Label.Text = "(health)";
            this.health1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xp1Label
            // 
            this.xp1Label.AutoSize = true;
            this.xp1Label.BackColor = System.Drawing.Color.Transparent;
            this.xp1Label.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xp1Label.ForeColor = System.Drawing.Color.LimeGreen;
            this.xp1Label.Location = new System.Drawing.Point(205, 1692);
            this.xp1Label.Name = "xp1Label";
            this.xp1Label.Size = new System.Drawing.Size(233, 40);
            this.xp1Label.TabIndex = 23;
            this.xp1Label.Text = "1234 XP to lvl 13";
            this.xp1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // level1Label
            // 
            this.level1Label.BackColor = System.Drawing.Color.Transparent;
            this.level1Label.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1Label.ForeColor = System.Drawing.Color.Coral;
            this.level1Label.Location = new System.Drawing.Point(114, 1692);
            this.level1Label.Name = "level1Label";
            this.level1Label.Size = new System.Drawing.Size(92, 39);
            this.level1Label.TabIndex = 24;
            this.level1Label.Text = "lvl 12";
            this.level1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 16;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // SinglePlayerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.level1Label);
            this.Controls.Add(this.xp1Label);
            this.Controls.Add(this.health1Label);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.reloadLabel);
            this.Controls.Add(this.bulletDamageLabel);
            this.Controls.Add(this.bulletSpeedLabel);
            this.Controls.Add(this.bulletHealthLabel);
            this.Controls.Add(this.bodyDamageLabel);
            this.Controls.Add(this.healthRegenLabel);
            this.Controls.Add(this.healthLabel);
            this.DoubleBuffered = true;
            this.Name = "SinglePlayerScreen";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label reloadLabel;
        private System.Windows.Forms.Label bulletDamageLabel;
        private System.Windows.Forms.Label bulletSpeedLabel;
        private System.Windows.Forms.Label bulletHealthLabel;
        private System.Windows.Forms.Label bodyDamageLabel;
        private System.Windows.Forms.Label healthRegenLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label health1Label;
        private System.Windows.Forms.Label xp1Label;
        private System.Windows.Forms.Label level1Label;
        private System.Windows.Forms.Timer gameLoop;
    }
}
