
namespace JeuxDeDe.Component
{
    partial class AppliquerCarteMagique
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
            this.buttonAppliquer = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.checkedListBoxEquipes = new System.Windows.Forms.CheckedListBox();
            this.panelSouth.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSouth
            // 
            this.panelSouth.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSouth.Controls.Add(this.buttonAppliquer);
            this.panelSouth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSouth.Location = new System.Drawing.Point(0, 126);
            this.panelSouth.Name = "panelSouth";
            this.panelSouth.Size = new System.Drawing.Size(209, 42);
            this.panelSouth.TabIndex = 0;
            // 
            // buttonAppliquer
            // 
            this.buttonAppliquer.Location = new System.Drawing.Point(59, 7);
            this.buttonAppliquer.Name = "buttonAppliquer";
            this.buttonAppliquer.Size = new System.Drawing.Size(75, 23);
            this.buttonAppliquer.TabIndex = 0;
            this.buttonAppliquer.Text = "Appliquer";
            this.buttonAppliquer.UseVisualStyleBackColor = true;
            this.buttonAppliquer.Click += new System.EventHandler(this.buttonAppliquer_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.checkedListBoxEquipes);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(209, 126);
            this.panelCenter.TabIndex = 1;
            // 
            // checkedListBoxEquipes
            // 
            this.checkedListBoxEquipes.FormattingEnabled = true;
            this.checkedListBoxEquipes.Location = new System.Drawing.Point(35, 9);
            this.checkedListBoxEquipes.Name = "checkedListBoxEquipes";
            this.checkedListBoxEquipes.Size = new System.Drawing.Size(120, 109);
            this.checkedListBoxEquipes.TabIndex = 0;
            this.checkedListBoxEquipes.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxEquipes_SelectedIndexChanged);
            // 
            // AppliquerCarteMagique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 168);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelSouth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppliquerCarteMagique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppliquerCarteMagique";
            this.panelSouth.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSouth;
        private System.Windows.Forms.Button buttonAppliquer;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.CheckedListBox checkedListBoxEquipes;
    }
}