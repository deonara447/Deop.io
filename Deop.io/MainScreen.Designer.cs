namespace Deop.io
{
    partial class MainScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleLabel.Location = new System.Drawing.Point(0, 114);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1200, 167);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Deop.io";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1Label
            // 
            this.player1Label.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.player1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(0)))));
            this.player1Label.Location = new System.Drawing.Point(3, 318);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(1197, 68);
            this.player1Label.TabIndex = 1;
            this.player1Label.Text = "1 Player";
            this.player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player1Label.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            // 
            // player2Label
            // 
            this.player2Label.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.player2Label.ForeColor = System.Drawing.Color.Green;
            this.player2Label.Location = new System.Drawing.Point(0, 386);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(1197, 68);
            this.player2Label.TabIndex = 2;
            this.player2Label.Text = "2 Player";
            this.player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.highScoreLabel.ForeColor = System.Drawing.Color.Blue;
            this.highScoreLabel.Location = new System.Drawing.Point(0, 454);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(1197, 68);
            this.highScoreLabel.TabIndex = 3;
            this.highScoreLabel.Text = "Leaderboards";
            this.highScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.instructionsLabel.ForeColor = System.Drawing.Color.Red;
            this.instructionsLabel.Location = new System.Drawing.Point(0, 522);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(1197, 68);
            this.instructionsLabel.TabIndex = 4;
            this.instructionsLabel.Text = "Instructions";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1200, 700);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label instructionsLabel;
    }
}
