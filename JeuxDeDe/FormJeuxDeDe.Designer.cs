
namespace JeuxDeDe
{
    partial class FormJeuxDeDe
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelSouth = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonReinitialiser = new System.Windows.Forms.Button();
            this.labelNomEquipe = new System.Windows.Forms.Label();
            this.buttonEquipe8 = new System.Windows.Forms.Button();
            this.buttonEquipe1 = new System.Windows.Forms.Button();
            this.buttonEquipe2 = new System.Windows.Forms.Button();
            this.buttonEquipe7 = new System.Windows.Forms.Button();
            this.buttonEquipe6 = new System.Windows.Forms.Button();
            this.buttonEquipe5 = new System.Windows.Forms.Button();
            this.buttonEquipe4 = new System.Windows.Forms.Button();
            this.buttonEquipe3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxJoueurParticipants = new System.Windows.Forms.GroupBox();
            this.numericUpDownNbParticipants = new System.Windows.Forms.NumericUpDown();
            this.buttonInitialisation = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.buttonChoixCarteBonus = new System.Windows.Forms.Button();
            this.panelSouth.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelSouth
            // 
            this.panelSouth.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelSouth.Controls.Add(this.buttonChoixCarteBonus);
            this.panelSouth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSouth.Location = new System.Drawing.Point(0, 591);
            this.panelSouth.Name = "panelSouth";
            this.panelSouth.Size = new System.Drawing.Size(1213, 60);
            this.panelSouth.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelLeft.Controls.Add(this.buttonReinitialiser);
            this.panelLeft.Controls.Add(this.labelNomEquipe);
            this.panelLeft.Controls.Add(this.buttonEquipe8);
            this.panelLeft.Controls.Add(this.buttonEquipe1);
            this.panelLeft.Controls.Add(this.buttonEquipe2);
            this.panelLeft.Controls.Add(this.buttonEquipe7);
            this.panelLeft.Controls.Add(this.buttonEquipe6);
            this.panelLeft.Controls.Add(this.buttonEquipe5);
            this.panelLeft.Controls.Add(this.buttonEquipe4);
            this.panelLeft.Controls.Add(this.buttonEquipe3);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.groupBoxJoueurParticipants);
            this.panelLeft.Controls.Add(this.numericUpDownNbParticipants);
            this.panelLeft.Controls.Add(this.buttonInitialisation);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(103, 591);
            this.panelLeft.TabIndex = 3;
            // 
            // buttonReinitialiser
            // 
            this.buttonReinitialiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReinitialiser.Enabled = false;
            this.buttonReinitialiser.Location = new System.Drawing.Point(12, 556);
            this.buttonReinitialiser.Name = "buttonReinitialiser";
            this.buttonReinitialiser.Size = new System.Drawing.Size(77, 23);
            this.buttonReinitialiser.TabIndex = 13;
            this.buttonReinitialiser.Text = "Réinitialiser";
            this.buttonReinitialiser.UseVisualStyleBackColor = true;
            this.buttonReinitialiser.Click += new System.EventHandler(this.buttonReinitialiser_Click);
            // 
            // labelNomEquipe
            // 
            this.labelNomEquipe.AutoSize = true;
            this.labelNomEquipe.Location = new System.Drawing.Point(25, 189);
            this.labelNomEquipe.Name = "labelNomEquipe";
            this.labelNomEquipe.Size = new System.Drawing.Size(50, 13);
            this.labelNomEquipe.TabIndex = 12;
            this.labelNomEquipe.Text = "Equipe X";
            this.labelNomEquipe.Visible = false;
            // 
            // buttonEquipe8
            // 
            this.buttonEquipe8.Location = new System.Drawing.Point(12, 434);
            this.buttonEquipe8.Name = "buttonEquipe8";
            this.buttonEquipe8.Size = new System.Drawing.Size(77, 23);
            this.buttonEquipe8.TabIndex = 11;
            this.buttonEquipe8.Text = "Equipe8";
            this.buttonEquipe8.UseVisualStyleBackColor = true;
            this.buttonEquipe8.Visible = false;
            this.buttonEquipe8.Click += new System.EventHandler(this.buttonEquipe8_Click);
            // 
            // buttonEquipe1
            // 
            this.buttonEquipe1.Location = new System.Drawing.Point(13, 226);
            this.buttonEquipe1.Name = "buttonEquipe1";
            this.buttonEquipe1.Size = new System.Drawing.Size(77, 23);
            this.buttonEquipe1.TabIndex = 10;
            this.buttonEquipe1.Text = "Equipe 1";
            this.buttonEquipe1.UseVisualStyleBackColor = true;
            this.buttonEquipe1.Visible = false;
            this.buttonEquipe1.Click += new System.EventHandler(this.buttonEquipe1_Click);
            // 
            // buttonEquipe2
            // 
            this.buttonEquipe2.Location = new System.Drawing.Point(12, 256);
            this.buttonEquipe2.Name = "buttonEquipe2";
            this.buttonEquipe2.Size = new System.Drawing.Size(77, 23);
            this.buttonEquipe2.TabIndex = 9;
            this.buttonEquipe2.Text = "Equipe2";
            this.buttonEquipe2.UseVisualStyleBackColor = true;
            this.buttonEquipe2.Visible = false;
            this.buttonEquipe2.Click += new System.EventHandler(this.buttonJoeur2_Click);
            // 
            // buttonEquipe7
            // 
            this.buttonEquipe7.Location = new System.Drawing.Point(12, 407);
            this.buttonEquipe7.Name = "buttonEquipe7";
            this.buttonEquipe7.Size = new System.Drawing.Size(77, 23);
            this.buttonEquipe7.TabIndex = 8;
            this.buttonEquipe7.Text = "Equipe7";
            this.buttonEquipe7.UseVisualStyleBackColor = true;
            this.buttonEquipe7.Visible = false;
            this.buttonEquipe7.Click += new System.EventHandler(this.buttonEquipe7_Click);
            // 
            // buttonEquipe6
            // 
            this.buttonEquipe6.Location = new System.Drawing.Point(12, 377);
            this.buttonEquipe6.Name = "buttonEquipe6";
            this.buttonEquipe6.Size = new System.Drawing.Size(77, 23);
            this.buttonEquipe6.TabIndex = 7;
            this.buttonEquipe6.Text = "Equipe6";
            this.buttonEquipe6.UseVisualStyleBackColor = true;
            this.buttonEquipe6.Visible = false;
            this.buttonEquipe6.Click += new System.EventHandler(this.buttonEquipe6_Click);
            // 
            // buttonEquipe5
            // 
            this.buttonEquipe5.Location = new System.Drawing.Point(13, 346);
            this.buttonEquipe5.Name = "buttonEquipe5";
            this.buttonEquipe5.Size = new System.Drawing.Size(77, 23);
            this.buttonEquipe5.TabIndex = 6;
            this.buttonEquipe5.Text = "Equipe5";
            this.buttonEquipe5.UseVisualStyleBackColor = true;
            this.buttonEquipe5.Visible = false;
            this.buttonEquipe5.Click += new System.EventHandler(this.buttonJoeur5_Click);
            // 
            // buttonEquipe4
            // 
            this.buttonEquipe4.Location = new System.Drawing.Point(12, 317);
            this.buttonEquipe4.Name = "buttonEquipe4";
            this.buttonEquipe4.Size = new System.Drawing.Size(77, 23);
            this.buttonEquipe4.TabIndex = 5;
            this.buttonEquipe4.Text = "Equipe4";
            this.buttonEquipe4.UseVisualStyleBackColor = true;
            this.buttonEquipe4.Visible = false;
            this.buttonEquipe4.Click += new System.EventHandler(this.buttonJoeur4_Click);
            // 
            // buttonEquipe3
            // 
            this.buttonEquipe3.Location = new System.Drawing.Point(13, 286);
            this.buttonEquipe3.Name = "buttonEquipe3";
            this.buttonEquipe3.Size = new System.Drawing.Size(77, 23);
            this.buttonEquipe3.TabIndex = 4;
            this.buttonEquipe3.Text = "Equipe3";
            this.buttonEquipe3.UseVisualStyleBackColor = true;
            this.buttonEquipe3.Visible = false;
            this.buttonEquipe3.Click += new System.EventHandler(this.buttonJoeur3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nb Joueurs";
            // 
            // groupBoxJoueurParticipants
            // 
            this.groupBoxJoueurParticipants.Location = new System.Drawing.Point(12, 83);
            this.groupBoxJoueurParticipants.Name = "groupBoxJoueurParticipants";
            this.groupBoxJoueurParticipants.Size = new System.Drawing.Size(77, 103);
            this.groupBoxJoueurParticipants.TabIndex = 2;
            this.groupBoxJoueurParticipants.TabStop = false;
            this.groupBoxJoueurParticipants.Visible = false;
            this.groupBoxJoueurParticipants.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxJoueur_Paint);
            // 
            // numericUpDownNbParticipants
            // 
            this.numericUpDownNbParticipants.Location = new System.Drawing.Point(12, 28);
            this.numericUpDownNbParticipants.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNbParticipants.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNbParticipants.Name = "numericUpDownNbParticipants";
            this.numericUpDownNbParticipants.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownNbParticipants.TabIndex = 1;
            this.numericUpDownNbParticipants.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNbParticipants.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonInitialisation
            // 
            this.buttonInitialisation.Location = new System.Drawing.Point(12, 53);
            this.buttonInitialisation.Name = "buttonInitialisation";
            this.buttonInitialisation.Size = new System.Drawing.Size(77, 23);
            this.buttonInitialisation.TabIndex = 0;
            this.buttonInitialisation.Text = "Initialisation";
            this.buttonInitialisation.UseVisualStyleBackColor = true;
            this.buttonInitialisation.Click += new System.EventHandler(this.buttonInitialisation_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(103, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1110, 591);
            this.panelCenter.TabIndex = 4;
            this.panelCenter.SizeChanged += new System.EventHandler(this.panelCenter_SizeChanged);
            this.panelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCenter_Paint);
            // 
            // buttonChoixCarteBonus
            // 
            this.buttonChoixCarteBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChoixCarteBonus.Location = new System.Drawing.Point(1124, 10);
            this.buttonChoixCarteBonus.Name = "buttonChoixCarteBonus";
            this.buttonChoixCarteBonus.Size = new System.Drawing.Size(77, 41);
            this.buttonChoixCarteBonus.TabIndex = 14;
            this.buttonChoixCarteBonus.Text = "Choix Carte Bonus";
            this.buttonChoixCarteBonus.UseVisualStyleBackColor = true;
            this.buttonChoixCarteBonus.Click += new System.EventHandler(this.buttonChoixCarteBonus_Click);
            // 
            // FormJeuxDeDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 651);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelSouth);
            this.Name = "FormJeuxDeDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeux DéDé";
            this.panelSouth.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbParticipants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelSouth;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonEquipe8;
        private System.Windows.Forms.Button buttonEquipe1;
        private System.Windows.Forms.Button buttonEquipe2;
        private System.Windows.Forms.Button buttonEquipe7;
        private System.Windows.Forms.Button buttonEquipe6;
        private System.Windows.Forms.Button buttonEquipe5;
        private System.Windows.Forms.Button buttonEquipe4;
        private System.Windows.Forms.Button buttonEquipe3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxJoueurParticipants;
        private System.Windows.Forms.NumericUpDown numericUpDownNbParticipants;
        private System.Windows.Forms.Button buttonInitialisation;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label labelNomEquipe;
        private System.Windows.Forms.Button buttonReinitialiser;
        private System.Windows.Forms.Button buttonChoixCarteBonus;
    }
}

