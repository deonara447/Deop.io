namespace Deop.io
{
    partial class GameScreen
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
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.health1Label = new System.Windows.Forms.Label();
            this.level1Label = new System.Windows.Forms.Label();
            this.xp1Label = new System.Windows.Forms.Label();
            this.health2Label = new System.Windows.Forms.Label();
            this.level2Label = new System.Windows.Forms.Label();
            this.xp2Label = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.healthRegenLabel = new System.Windows.Forms.Label();
            this.bodyDamageLabel = new System.Windows.Forms.Label();
            this.bulletHealthLabel = new System.Windows.Forms.Label();
            this.bulletSpeedLabel = new System.Windows.Forms.Label();
            this.bulletDamageLabel = new System.Windows.Forms.Label();
            this.reloadLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedTwoLabel = new System.Windows.Forms.Label();
            this.reloadTwoLabel = new System.Windows.Forms.Label();
            this.bulletDamageTwoLabel = new System.Windows.Forms.Label();
            this.bulletSpeedTwoLabel = new System.Windows.Forms.Label();
            this.bulletHealthTwoLabel = new System.Windows.Forms.Label();
            this.bodyDamageTwoLabel = new System.Windows.Forms.Label();
            this.healthRegenTwoLabel = new System.Windows.Forms.Label();
            this.healthTwoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Interval = 16;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // health1Label
            // 
            this.health1Label.BackColor = System.Drawing.Color.Transparent;
            this.health1Label.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health1Label.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.health1Label.Location = new System.Drawing.Point(-7, 1692);
            this.health1Label.Name = "health1Label";
            this.health1Label.Size = new System.Drawing.Size(123, 39);
            this.health1Label.TabIndex = 0;
            this.health1Label.Text = "(health)";
            this.health1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // level1Label
            // 
            this.level1Label.BackColor = System.Drawing.Color.Transparent;
            this.level1Label.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1Label.ForeColor = System.Drawing.Color.Coral;
            this.level1Label.Location = new System.Drawing.Point(114, 1692);
            this.level1Label.Name = "level1Label";
            this.level1Label.Size = new System.Drawing.Size(92, 39);
            this.level1Label.TabIndex = 1;
            this.level1Label.Text = "lvl 12";
            this.level1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.xp1Label.TabIndex = 2;
            this.xp1Label.Text = "1234 XP to lvl 13";
            this.xp1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // health2Label
            // 
            this.health2Label.BackColor = System.Drawing.Color.Transparent;
            this.health2Label.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health2Label.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.health2Label.Location = new System.Drawing.Point(3080, 1692);
            this.health2Label.Name = "health2Label";
            this.health2Label.Size = new System.Drawing.Size(123, 39);
            this.health2Label.TabIndex = 3;
            this.health2Label.Text = "(health)";
            this.health2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // level2Label
            // 
            this.level2Label.BackColor = System.Drawing.Color.Transparent;
            this.level2Label.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2Label.ForeColor = System.Drawing.Color.Coral;
            this.level2Label.Location = new System.Drawing.Point(2988, 1692);
            this.level2Label.Name = "level2Label";
            this.level2Label.Size = new System.Drawing.Size(92, 39);
            this.level2Label.TabIndex = 4;
            this.level2Label.Text = "lvl 12";
            this.level2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // xp2Label
            // 
            this.xp2Label.BackColor = System.Drawing.Color.Transparent;
            this.xp2Label.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xp2Label.ForeColor = System.Drawing.Color.LimeGreen;
            this.xp2Label.Location = new System.Drawing.Point(2753, 1692);
            this.xp2Label.Name = "xp2Label";
            this.xp2Label.Size = new System.Drawing.Size(235, 39);
            this.xp2Label.TabIndex = 5;
            this.xp2Label.Text = "1234 XP to lvl 13";
            this.xp2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // healthLabel
            // 
            this.healthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(-5, 0);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(156, 60);
            this.healthLabel.TabIndex = 6;
            this.healthLabel.Text = "Health";
            this.healthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthRegenLabel
            // 
            this.healthRegenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.healthRegenLabel.ForeColor = System.Drawing.Color.White;
            this.healthRegenLabel.Location = new System.Drawing.Point(151, 0);
            this.healthRegenLabel.Name = "healthRegenLabel";
            this.healthRegenLabel.Size = new System.Drawing.Size(156, 60);
            this.healthRegenLabel.TabIndex = 7;
            this.healthRegenLabel.Text = "Health Regen";
            this.healthRegenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bodyDamageLabel
            // 
            this.bodyDamageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bodyDamageLabel.ForeColor = System.Drawing.Color.White;
            this.bodyDamageLabel.Location = new System.Drawing.Point(307, 0);
            this.bodyDamageLabel.Name = "bodyDamageLabel";
            this.bodyDamageLabel.Size = new System.Drawing.Size(156, 60);
            this.bodyDamageLabel.TabIndex = 8;
            this.bodyDamageLabel.Text = "Body Damage";
            this.bodyDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bulletHealthLabel
            // 
            this.bulletHealthLabel.BackColor = System.Drawing.Color.Gold;
            this.bulletHealthLabel.ForeColor = System.Drawing.Color.White;
            this.bulletHealthLabel.Location = new System.Drawing.Point(619, 0);
            this.bulletHealthLabel.Name = "bulletHealthLabel";
            this.bulletHealthLabel.Size = new System.Drawing.Size(156, 60);
            this.bulletHealthLabel.TabIndex = 9;
            this.bulletHealthLabel.Text = "Bullet Health";
            this.bulletHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bulletSpeedLabel
            // 
            this.bulletSpeedLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bulletSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.bulletSpeedLabel.Location = new System.Drawing.Point(463, 0);
            this.bulletSpeedLabel.Name = "bulletSpeedLabel";
            this.bulletSpeedLabel.Size = new System.Drawing.Size(156, 60);
            this.bulletSpeedLabel.TabIndex = 10;
            this.bulletSpeedLabel.Text = "Bullet Speed";
            this.bulletSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bulletDamageLabel
            // 
            this.bulletDamageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bulletDamageLabel.ForeColor = System.Drawing.Color.White;
            this.bulletDamageLabel.Location = new System.Drawing.Point(775, 0);
            this.bulletDamageLabel.Name = "bulletDamageLabel";
            this.bulletDamageLabel.Size = new System.Drawing.Size(156, 60);
            this.bulletDamageLabel.TabIndex = 11;
            this.bulletDamageLabel.Text = "Bullet Damage";
            this.bulletDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reloadLabel
            // 
            this.reloadLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.reloadLabel.ForeColor = System.Drawing.Color.White;
            this.reloadLabel.Location = new System.Drawing.Point(931, 0);
            this.reloadLabel.Name = "reloadLabel";
            this.reloadLabel.Size = new System.Drawing.Size(156, 60);
            this.reloadLabel.TabIndex = 12;
            this.reloadLabel.Text = "Reload";
            this.reloadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedLabel
            // 
            this.speedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Location = new System.Drawing.Point(1087, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(156, 60);
            this.speedLabel.TabIndex = 13;
            this.speedLabel.Text = "Speed";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedTwoLabel
            // 
            this.speedTwoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.speedTwoLabel.ForeColor = System.Drawing.Color.White;
            this.speedTwoLabel.Location = new System.Drawing.Point(3060, 0);
            this.speedTwoLabel.Name = "speedTwoLabel";
            this.speedTwoLabel.Size = new System.Drawing.Size(156, 60);
            this.speedTwoLabel.TabIndex = 21;
            this.speedTwoLabel.Text = "Speed";
            this.speedTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reloadTwoLabel
            // 
            this.reloadTwoLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.reloadTwoLabel.ForeColor = System.Drawing.Color.White;
            this.reloadTwoLabel.Location = new System.Drawing.Point(2904, 0);
            this.reloadTwoLabel.Name = "reloadTwoLabel";
            this.reloadTwoLabel.Size = new System.Drawing.Size(156, 60);
            this.reloadTwoLabel.TabIndex = 20;
            this.reloadTwoLabel.Text = "Reload";
            this.reloadTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bulletDamageTwoLabel
            // 
            this.bulletDamageTwoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bulletDamageTwoLabel.ForeColor = System.Drawing.Color.White;
            this.bulletDamageTwoLabel.Location = new System.Drawing.Point(2748, 0);
            this.bulletDamageTwoLabel.Name = "bulletDamageTwoLabel";
            this.bulletDamageTwoLabel.Size = new System.Drawing.Size(156, 60);
            this.bulletDamageTwoLabel.TabIndex = 19;
            this.bulletDamageTwoLabel.Text = "Bullet Damage";
            this.bulletDamageTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bulletSpeedTwoLabel
            // 
            this.bulletSpeedTwoLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bulletSpeedTwoLabel.ForeColor = System.Drawing.Color.White;
            this.bulletSpeedTwoLabel.Location = new System.Drawing.Point(2436, 0);
            this.bulletSpeedTwoLabel.Name = "bulletSpeedTwoLabel";
            this.bulletSpeedTwoLabel.Size = new System.Drawing.Size(156, 60);
            this.bulletSpeedTwoLabel.TabIndex = 18;
            this.bulletSpeedTwoLabel.Text = "Bullet Speed";
            this.bulletSpeedTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bulletHealthTwoLabel
            // 
            this.bulletHealthTwoLabel.BackColor = System.Drawing.Color.Gold;
            this.bulletHealthTwoLabel.ForeColor = System.Drawing.Color.White;
            this.bulletHealthTwoLabel.Location = new System.Drawing.Point(2592, 0);
            this.bulletHealthTwoLabel.Name = "bulletHealthTwoLabel";
            this.bulletHealthTwoLabel.Size = new System.Drawing.Size(156, 60);
            this.bulletHealthTwoLabel.TabIndex = 17;
            this.bulletHealthTwoLabel.Text = "Bullet Health";
            this.bulletHealthTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bodyDamageTwoLabel
            // 
            this.bodyDamageTwoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bodyDamageTwoLabel.ForeColor = System.Drawing.Color.White;
            this.bodyDamageTwoLabel.Location = new System.Drawing.Point(2280, 0);
            this.bodyDamageTwoLabel.Name = "bodyDamageTwoLabel";
            this.bodyDamageTwoLabel.Size = new System.Drawing.Size(156, 60);
            this.bodyDamageTwoLabel.TabIndex = 16;
            this.bodyDamageTwoLabel.Text = "Body Damage";
            this.bodyDamageTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthRegenTwoLabel
            // 
            this.healthRegenTwoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.healthRegenTwoLabel.ForeColor = System.Drawing.Color.White;
            this.healthRegenTwoLabel.Location = new System.Drawing.Point(2124, 0);
            this.healthRegenTwoLabel.Name = "healthRegenTwoLabel";
            this.healthRegenTwoLabel.Size = new System.Drawing.Size(156, 60);
            this.healthRegenTwoLabel.TabIndex = 15;
            this.healthRegenTwoLabel.Text = "Health Regen";
            this.healthRegenTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthTwoLabel
            // 
            this.healthTwoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.healthTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthTwoLabel.ForeColor = System.Drawing.Color.White;
            this.healthTwoLabel.Location = new System.Drawing.Point(1968, 0);
            this.healthTwoLabel.Name = "healthTwoLabel";
            this.healthTwoLabel.Size = new System.Drawing.Size(156, 60);
            this.healthTwoLabel.TabIndex = 14;
            this.healthTwoLabel.Text = "Health";
            this.healthTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.speedTwoLabel);
            this.Controls.Add(this.reloadTwoLabel);
            this.Controls.Add(this.bulletDamageTwoLabel);
            this.Controls.Add(this.bulletSpeedTwoLabel);
            this.Controls.Add(this.bulletHealthTwoLabel);
            this.Controls.Add(this.bodyDamageTwoLabel);
            this.Controls.Add(this.healthRegenTwoLabel);
            this.Controls.Add(this.healthTwoLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.reloadLabel);
            this.Controls.Add(this.bulletDamageLabel);
            this.Controls.Add(this.bulletSpeedLabel);
            this.Controls.Add(this.bulletHealthLabel);
            this.Controls.Add(this.bodyDamageLabel);
            this.Controls.Add(this.healthRegenLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.xp2Label);
            this.Controls.Add(this.level2Label);
            this.Controls.Add(this.health2Label);
            this.Controls.Add(this.xp1Label);
            this.Controls.Add(this.level1Label);
            this.Controls.Add(this.health1Label);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label health1Label;
        private System.Windows.Forms.Label level1Label;
        private System.Windows.Forms.Label xp1Label;
        private System.Windows.Forms.Label health2Label;
        private System.Windows.Forms.Label level2Label;
        private System.Windows.Forms.Label xp2Label;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label healthRegenLabel;
        private System.Windows.Forms.Label bodyDamageLabel;
        private System.Windows.Forms.Label bulletHealthLabel;
        private System.Windows.Forms.Label bulletSpeedLabel;
        private System.Windows.Forms.Label bulletDamageLabel;
        private System.Windows.Forms.Label reloadLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label speedTwoLabel;
        private System.Windows.Forms.Label reloadTwoLabel;
        private System.Windows.Forms.Label bulletDamageTwoLabel;
        private System.Windows.Forms.Label bulletSpeedTwoLabel;
        private System.Windows.Forms.Label bulletHealthTwoLabel;
        private System.Windows.Forms.Label bodyDamageTwoLabel;
        private System.Windows.Forms.Label healthRegenTwoLabel;
        private System.Windows.Forms.Label healthTwoLabel;
    }
}
