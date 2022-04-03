
namespace JeuxDeDe.Component
{
    partial class AfficherCarteMagique
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
            this.panelSouth = new System.Windows.Forms.Panel();
            this.buttonOui = new System.Windows.Forms.Button();
            this.buttonNon = new System.Windows.Forms.Button();
            this.panelNorth = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelSouth.SuspendLayout();
            this.panelNorth.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSouth
            // 
            this.panelSouth.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSouth.Controls.Add(this.buttonNon);
            this.panelSouth.Controls.Add(this.buttonOui);
            this.panelSouth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSouth.Location = new System.Drawing.Point(0, 409);
            this.panelSouth.Name = "panelSouth";
            this.panelSouth.Size = new System.Drawing.Size(300, 41);
            this.panelSouth.TabIndex = 0;
            // 
            // buttonOui
            // 
            this.buttonOui.Location = new System.Drawing.Point(160, 8);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(75, 23);
            this.buttonOui.TabIndex = 0;
            this.buttonOui.Text = "Oui";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
            // 
            // buttonNon
            // 
            this.buttonNon.Location = new System.Drawing.Point(58, 8);
            this.buttonNon.Name = "buttonNon";
            this.buttonNon.Size = new System.Drawing.Size(75, 23);
            this.buttonNon.TabIndex = 1;
            this.buttonNon.Text = "Non";
            this.buttonNon.UseVisualStyleBackColor = true;
            this.buttonNon.Click += new System.EventHandler(this.buttonNon_Click);
            // 
            // panelNorth
            // 
            this.panelNorth.Controls.Add(this.labelTitle);
            this.panelNorth.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNorth.Location = new System.Drawing.Point(0, 0);
            this.panelNorth.Name = "panelNorth";
            this.panelNorth.Size = new System.Drawing.Size(300, 29);
            this.panelNorth.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(90, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(109, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Carte Bonus";
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 29);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(300, 380);
            this.panelCenter.TabIndex = 3;
            this.panelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCenter_Paint);
            // 
            // AfficherCarteBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelNorth);
            this.Controls.Add(this.panelSouth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AfficherCarteBonus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfficherCarteBonus";
            this.panelSouth.ResumeLayout(false);
            this.panelNorth.ResumeLayout(false);
            this.panelNorth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSouth;
        private System.Windows.Forms.Button buttonNon;
        private System.Windows.Forms.Button buttonOui;
        private System.Windows.Forms.Panel panelNorth;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelCenter;
    }
}