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
            this.titleLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.mainScreenLabel = new System.Windows.Forms.Label();
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
            // textLabel
            // 
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.textLabel.Location = new System.Drawing.Point(0, 167);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(1200, 354);
            this.textLabel.TabIndex = 2;
            this.textLabel.Text = "Insert instructions here:";
            // 
            // mainScreenLabel
            // 
            this.mainScreenLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.mainScreenLabel.ForeColor = System.Drawing.Color.Green;
            this.mainScreenLabel.Location = new System.Drawing.Point(0, 554);
            this.mainScreenLabel.Name = "mainScreenLabel";
            this.mainScreenLabel.Size = new System.Drawing.Size(1200, 68);
            this.mainScreenLabel.TabIndex = 13;
            this.mainScreenLabel.Text = "return to main menu";
            this.mainScreenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainScreenLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(1200, 700);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.InstructionScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label mainScreenLabel;
    }
}
