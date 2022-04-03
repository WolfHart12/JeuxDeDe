
using JeuxDeDe.Component;

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
            this.buttonFinDeJeux = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxActions = new System.Windows.Forms.TextBox();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelWP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMouseY = new System.Windows.Forms.Label();
            this.labelMouseX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChoixCarteBonus = new System.Windows.Forms.Button();
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
            this.timerCartePersonnage = new System.Windows.Forms.Timer(this.components);
            this.panelCenter = new JeuxDeDe.Component.PanelCenter();
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
            this.panelSouth.Controls.Add(this.buttonFinDeJeux);
            this.panelSouth.Controls.Add(this.button1);
            this.panelSouth.Controls.Add(this.textBoxActions);
            this.panelSouth.Controls.Add(this.labelHP);
            this.panelSouth.Controls.Add(this.labelWP);
            this.panelSouth.Controls.Add(this.label6);
            this.panelSouth.Controls.Add(this.label7);
            this.panelSouth.Controls.Add(this.labelMouseY);
            this.panelSouth.Controls.Add(this.labelMouseX);
            this.panelSouth.Controls.Add(this.label3);
            this.panelSouth.Controls.Add(this.label2);
            this.panelSouth.Controls.Add(this.buttonChoixCarteBonus);
            this.panelSouth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSouth.Location = new System.Drawing.Point(0, 620);
            this.panelSouth.Name = "panelSouth";
            this.panelSouth.Size = new System.Drawing.Size(1213, 60);
            this.panelSouth.TabIndex = 1;
            // 
            // buttonFinDeJeux
            // 
            this.buttonFinDeJeux.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinDeJeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinDeJeux.ForeColor = System.Drawing.Color.Olive;
            this.buttonFinDeJeux.Location = new System.Drawing.Point(1124, 3);
            this.buttonFinDeJeux.Name = "buttonFinDeJeux";
            this.buttonFinDeJeux.Size = new System.Drawing.Size(77, 54);
            this.buttonFinDeJeux.TabIndex = 25;
            this.buttonFinDeJeux.Text = "Fin de Jeux";
            this.buttonFinDeJeux.UseVisualStyleBackColor = true;
            this.buttonFinDeJeux.Click += new System.EventHandler(this.buttonFinDeJeux_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(7, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 54);
            this.button1.TabIndex = 24;
            this.button1.Text = "Fermer le jeux";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxActions
            // 
            this.textBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxActions.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxActions.Location = new System.Drawing.Point(544, 3);
            this.textBoxActions.Multiline = true;
            this.textBoxActions.Name = "textBoxActions";
            this.textBoxActions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxActions.Size = new System.Drawing.Size(574, 54);
            this.textBoxActions.TabIndex = 23;
            // 
            // labelHP
            // 
            this.labelHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(276, 38);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(13, 13);
            this.labelHP.TabIndex = 22;
            this.labelHP.Text = "0";
            this.labelHP.Visible = false;
            // 
            // labelWP
            // 
            this.labelWP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWP.AutoSize = true;
            this.labelWP.Location = new System.Drawing.Point(276, 22);
            this.labelWP.Name = "labelWP";
            this.labelWP.Size = new System.Drawing.Size(13, 13);
            this.labelWP.TabIndex = 21;
            this.labelWP.Text = "0";
            this.labelWP.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "HP:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "WP:";
            this.label7.Visible = false;
            // 
            // labelMouseY
            // 
            this.labelMouseY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMouseY.AutoSize = true;
            this.labelMouseY.Location = new System.Drawing.Point(219, 38);
            this.labelMouseY.Name = "labelMouseY";
            this.labelMouseY.Size = new System.Drawing.Size(13, 13);
            this.labelMouseY.TabIndex = 18;
            this.labelMouseY.Text = "0";
            this.labelMouseY.Visible = false;
            // 
            // labelMouseX
            // 
            this.labelMouseX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMouseX.AutoSize = true;
            this.labelMouseX.Location = new System.Drawing.Point(219, 22);
            this.labelMouseX.Name = "labelMouseX";
            this.labelMouseX.Size = new System.Drawing.Size(13, 13);
            this.labelMouseX.TabIndex = 17;
            this.labelMouseX.Text = "0";
            this.labelMouseX.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Y:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "X:";
            this.label2.Visible = false;
            // 
            // buttonChoixCarteBonus
            // 
            this.buttonChoixCarteBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChoixCarteBonus.Enabled = false;
            this.buttonChoixCarteBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoixCarteBonus.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonChoixCarteBonus.Location = new System.Drawing.Point(461, 3);
            this.buttonChoixCarteBonus.Name = "buttonChoixCarteBonus";
            this.buttonChoixCarteBonus.Size = new System.Drawing.Size(77, 54);
            this.buttonChoixCarteBonus.TabIndex = 14;
            this.buttonChoixCarteBonus.Text = "Carte Magique";
            this.buttonChoixCarteBonus.UseVisualStyleBackColor = true;
            this.buttonChoixCarteBonus.Click += new System.EventHandler(this.buttonChoixCarteBonus_Click);
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
            this.panelLeft.Size = new System.Drawing.Size(136, 620);
            this.panelLeft.TabIndex = 3;
            // 
            // buttonReinitialiser
            // 
            this.buttonReinitialiser.Enabled = false;
            this.buttonReinitialiser.Location = new System.Drawing.Point(28, 80);
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
            this.labelNomEquipe.Location = new System.Drawing.Point(44, 276);
            this.labelNomEquipe.Name = "labelNomEquipe";
            this.labelNomEquipe.Size = new System.Drawing.Size(50, 13);
            this.labelNomEquipe.TabIndex = 12;
            this.labelNomEquipe.Text = "Equipe X";
            this.labelNomEquipe.Visible = false;
            // 
            // buttonEquipe8
            // 
            this.buttonEquipe8.Location = new System.Drawing.Point(20, 573);
            this.buttonEquipe8.Name = "buttonEquipe8";
            this.buttonEquipe8.Size = new System.Drawing.Size(94, 36);
            this.buttonEquipe8.TabIndex = 11;
            this.buttonEquipe8.Text = "Equipe8";
            this.buttonEquipe8.UseVisualStyleBackColor = true;
            this.buttonEquipe8.Visible = false;
            this.buttonEquipe8.Click += new System.EventHandler(this.buttonEquipe8_Click);
            // 
            // buttonEquipe1
            // 
            this.buttonEquipe1.Location = new System.Drawing.Point(20, 301);
            this.buttonEquipe1.Name = "buttonEquipe1";
            this.buttonEquipe1.Size = new System.Drawing.Size(94, 36);
            this.buttonEquipe1.TabIndex = 10;
            this.buttonEquipe1.Text = "Equipe 1";
            this.buttonEquipe1.UseVisualStyleBackColor = true;
            this.buttonEquipe1.Visible = false;
            this.buttonEquipe1.Click += new System.EventHandler(this.buttonEquipe1_Click);
            // 
            // buttonEquipe2
            // 
            this.buttonEquipe2.Location = new System.Drawing.Point(20, 340);
            this.buttonEquipe2.Name = "buttonEquipe2";
            this.buttonEquipe2.Size = new System.Drawing.Size(94, 36);
            this.buttonEquipe2.TabIndex = 9;
            this.buttonEquipe2.Text = "Equipe2";
            this.buttonEquipe2.UseVisualStyleBackColor = true;
            this.buttonEquipe2.Visible = false;
            this.buttonEquipe2.Click += new System.EventHandler(this.buttonJoeur2_Click);
            // 
            // buttonEquipe7
            // 
            this.buttonEquipe7.Location = new System.Drawing.Point(20, 533);
            this.buttonEquipe7.Name = "buttonEquipe7";
            this.buttonEquipe7.Size = new System.Drawing.Size(94, 36);
            this.buttonEquipe7.TabIndex = 8;
            this.buttonEquipe7.Text = "Equipe7";
            this.buttonEquipe7.UseVisualStyleBackColor = true;
            this.buttonEquipe7.Visible = false;
            this.buttonEquipe7.Click += new System.EventHandler(this.buttonEquipe7_Click);
            // 
            // buttonEquipe6
            // 
            this.buttonEquipe6.Location = new System.Drawing.Point(20, 496);
            this.buttonEquipe6.Name = "buttonEquipe6";
            this.buttonEquipe6.Size = new System.Drawing.Size(94, 36);
            this.buttonEquipe6.TabIndex = 7;
            this.buttonEquipe6.Text = "Equipe6";
            this.buttonEquipe6.UseVisualStyleBackColor = true;
            this.buttonEquipe6.Visible = false;
            this.buttonEquipe6.Click += new System.EventHandler(this.buttonEquipe6_Click);
            // 
            // buttonEquipe5
            // 
            this.buttonEquipe5.Location = new System.Drawing.Point(20, 458);
            this.buttonEquipe5.Name = "buttonEquipe5";
            this.buttonEquipe5.Size = new System.Drawing.Size(94, 36);
            this.buttonEquipe5.TabIndex = 6;
            this.buttonEquipe5.Text = "Equipe5";
            this.buttonEquipe5.UseVisualStyleBackColor = true;
            this.buttonEquipe5.Visible = false;
            this.buttonEquipe5.Click += new System.EventHandler(this.buttonJoeur5_Click);
            // 
            // buttonEquipe4
            // 
            this.buttonEquipe4.Location = new System.Drawing.Point(20, 419);
            this.buttonEquipe4.Name = "buttonEquipe4";
            this.buttonEquipe4.Size = new System.Drawing.Size(94, 36);
            this.buttonEquipe4.TabIndex = 5;
            this.buttonEquipe4.Text = "Equipe4";
            this.buttonEquipe4.UseVisualStyleBackColor = true;
            this.buttonEquipe4.Visible = false;
            this.buttonEquipe4.Click += new System.EventHandler(this.buttonJoeur4_Click);
            // 
            // buttonEquipe3
            // 
            this.buttonEquipe3.Location = new System.Drawing.Point(20, 379);
            this.buttonEquipe3.Name = "buttonEquipe3";
            this.buttonEquipe3.Size = new System.Drawing.Size(94, 36);
            this.buttonEquipe3.TabIndex = 4;
            this.buttonEquipe3.Text = "Equipe3";
            this.buttonEquipe3.UseVisualStyleBackColor = true;
            this.buttonEquipe3.Visible = false;
            this.buttonEquipe3.Click += new System.EventHandler(this.buttonJoeur3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nb Joueurs";
            // 
            // groupBoxJoueurParticipants
            // 
            this.groupBoxJoueurParticipants.Location = new System.Drawing.Point(12, 129);
            this.groupBoxJoueurParticipants.Name = "groupBoxJoueurParticipants";
            this.groupBoxJoueurParticipants.Size = new System.Drawing.Size(114, 144);
            this.groupBoxJoueurParticipants.TabIndex = 2;
            this.groupBoxJoueurParticipants.TabStop = false;
            this.groupBoxJoueurParticipants.Visible = false;
            this.groupBoxJoueurParticipants.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxJoueur_Paint);
            // 
            // numericUpDownNbParticipants
            // 
            this.numericUpDownNbParticipants.Location = new System.Drawing.Point(28, 28);
            this.numericUpDownNbParticipants.Maximum = new decimal(new int[] {
            8,
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
            this.buttonInitialisation.Location = new System.Drawing.Point(28, 53);
            this.buttonInitialisation.Name = "buttonInitialisation";
            this.buttonInitialisation.Size = new System.Drawing.Size(77, 23);
            this.buttonInitialisation.TabIndex = 0;
            this.buttonInitialisation.Text = "Initialisation";
            this.buttonInitialisation.UseVisualStyleBackColor = true;
            this.buttonInitialisation.Click += new System.EventHandler(this.buttonInitialisation_Click);
            // 
            // timerCartePersonnage
            // 
            this.timerCartePersonnage.Interval = 600;
            this.timerCartePersonnage.Tick += new System.EventHandler(this.timerCartePersonnage_Tick);
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(136, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1077, 620);
            this.panelCenter.TabIndex = 4;
            this.panelCenter.SizeChanged += new System.EventHandler(this.panelCenter_SizeChanged);
            this.panelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCenter_Paint);
            this.panelCenter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCenter_MouseClick);
            this.panelCenter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCenter_MouseMove);
            // 
            // FormJeuxDeDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 680);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelSouth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormJeuxDeDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeux DéDé";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSouth.ResumeLayout(false);
            this.panelSouth.PerformLayout();
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
        private System.Windows.Forms.Label labelNomEquipe;
        private System.Windows.Forms.Button buttonReinitialiser;
        private System.Windows.Forms.Button buttonChoixCarteBonus;
        private System.Windows.Forms.Label labelMouseY;
        private System.Windows.Forms.Label labelMouseX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelWP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxActions;
        private System.Windows.Forms.Button button1;
        private PanelCenter panelCenter;
        private System.Windows.Forms.Button buttonFinDeJeux;
        private System.Windows.Forms.Timer timerCartePersonnage;
    }
}

