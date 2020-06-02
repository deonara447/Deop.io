namespace Deop.io
{
    partial class InstructionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionScreen));
            this.titleLabel = new System.Windows.Forms.Label();
            this.player1TextLabel = new System.Windows.Forms.Label();
            this.mainScreenLabel = new System.Windows.Forms.Label();
            this.player2TextLabel = new System.Windows.Forms.Label();
            this.player2TitleLabel = new System.Windows.Forms.Label();
            this.player1TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1200, 167);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Instructions";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1TextLabel
            // 
            this.player1TextLabel.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1TextLabel.Location = new System.Drawing.Point(3, 188);
            this.player1TextLabel.Name = "player1TextLabel";
            this.player1TextLabel.Size = new System.Drawing.Size(1203, 206);
            this.player1TextLabel.TabIndex = 2;
            this.player1TextLabel.Text = resources.GetString("player1TextLabel.Text");
            // 
            // mainScreenLabel
            // 
            this.mainScreenLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.mainScreenLabel.ForeColor = System.Drawing.Color.Green;
            this.mainScreenLabel.Location = new System.Drawing.Point(-3, 633);
            this.mainScreenLabel.Name = "mainScreenLabel";
            this.mainScreenLabel.Size = new System.Drawing.Size(1200, 68);
            this.mainScreenLabel.TabIndex = 13;
            this.mainScreenLabel.Text = "return to main menu";
            this.mainScreenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2TextLabel
            // 
            this.player2TextLabel.Font = new System.Drawing.Font("Verdana", 10.125F);
            this.player2TextLabel.Location = new System.Drawing.Point(3, 434);
            this.player2TextLabel.Name = "player2TextLabel";
            this.player2TextLabel.Size = new System.Drawing.Size(1197, 199);
            this.player2TextLabel.TabIndex = 14;
            this.player2TextLabel.Text = resources.GetString("player2TextLabel.Text");
            // 
            // player2TitleLabel
            // 
            this.player2TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.player2TitleLabel.Location = new System.Drawing.Point(6, 394);
            this.player2TitleLabel.Name = "player2TitleLabel";
            this.player2TitleLabel.Size = new System.Drawing.Size(1200, 40);
            this.player2TitleLabel.TabIndex = 15;
            this.player2TitleLabel.Text = "2 Player";
            this.player2TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1TitleLabel
            // 
            this.player1TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.player1TitleLabel.Location = new System.Drawing.Point(3, 148);
            this.player1TitleLabel.Name = "player1TitleLabel";
            this.player1TitleLabel.Size = new System.Drawing.Size(1200, 40);
            this.player1TitleLabel.TabIndex = 16;
            this.player1TitleLabel.Text = "1 Player";
            this.player1TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.player1TitleLabel);
            this.Controls.Add(this.player2TitleLabel);
            this.Controls.Add(this.player1TextLabel);
            this.Controls.Add(this.player2TextLabel);
            this.Controls.Add(this.mainScreenLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(1200, 700);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.InstructionScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label player1TextLabel;
        private System.Windows.Forms.Label mainScreenLabel;
        private System.Windows.Forms.Label player2TextLabel;
        private System.Windows.Forms.Label player2TitleLabel;
        private System.Windows.Forms.Label player1TitleLabel;
    }
}
