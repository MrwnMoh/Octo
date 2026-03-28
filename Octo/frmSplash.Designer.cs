namespace Octo
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.LpMaxPlayer2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LpMaxPlayer1 = new System.Windows.Forms.Label();
            this.rbPlayerVsAi = new System.Windows.Forms.RadioButton();
            this.rbPlayerVsPlayer = new System.Windows.Forms.RadioButton();
            this.chkAiAnimation = new System.Windows.Forms.CheckBox();
            this.rbAivsAi = new System.Windows.Forms.RadioButton();
            this.cbAiSpeed = new System.Windows.Forms.ComboBox();
            this.lpSpeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbPanel = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.tbPlayer1.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbPlayer1.Location = new System.Drawing.Point(593, 349);
            this.tbPlayer1.MaxLength = 10;
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(571, 49);
            this.tbPlayer1.TabIndex = 82;
            this.tbPlayer1.Text = "Player1";
            this.tbPlayer1.TextChanged += new System.EventHandler(this.tbPlayer1_TextChanged);
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.tbPlayer2.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbPlayer2.Location = new System.Drawing.Point(593, 508);
            this.tbPlayer2.MaxLength = 10;
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(571, 49);
            this.tbPlayer2.TabIndex = 83;
            this.tbPlayer2.Text = "Player2";
            this.tbPlayer2.TextChanged += new System.EventHandler(this.tbPlayer2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.label1.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(586, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 41);
            this.label1.TabIndex = 84;
            this.label1.Text = "White player name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.label2.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(586, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 41);
            this.label2.TabIndex = 85;
            this.label2.Text = "Black player name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.label3.Font = new System.Drawing.Font("Helvetica Rounded", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(607, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(528, 56);
            this.label3.TabIndex = 91;
            this.label3.Text = "_____________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(841, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 90);
            this.label4.TabIndex = 92;
            this.label4.Text = "Octo";
            // 
            // LpMaxPlayer2
            // 
            this.LpMaxPlayer2.AutoSize = true;
            this.LpMaxPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.LpMaxPlayer2.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LpMaxPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(120)))));
            this.LpMaxPlayer2.Location = new System.Drawing.Point(1054, 560);
            this.LpMaxPlayer2.Name = "LpMaxPlayer2";
            this.LpMaxPlayer2.Size = new System.Drawing.Size(38, 41);
            this.LpMaxPlayer2.TabIndex = 93;
            this.LpMaxPlayer2.Text = "7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.label5.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(1098, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 41);
            this.label5.TabIndex = 94;
            this.label5.Text = "/10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.label6.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(1098, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 41);
            this.label6.TabIndex = 96;
            this.label6.Text = "/10";
            // 
            // LpMaxPlayer1
            // 
            this.LpMaxPlayer1.AutoSize = true;
            this.LpMaxPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.LpMaxPlayer1.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LpMaxPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(120)))));
            this.LpMaxPlayer1.Location = new System.Drawing.Point(1054, 404);
            this.LpMaxPlayer1.Name = "LpMaxPlayer1";
            this.LpMaxPlayer1.Size = new System.Drawing.Size(38, 41);
            this.LpMaxPlayer1.TabIndex = 95;
            this.LpMaxPlayer1.Text = "7";
            // 
            // rbPlayerVsAi
            // 
            this.rbPlayerVsAi.AutoSize = true;
            this.rbPlayerVsAi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.rbPlayerVsAi.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold);
            this.rbPlayerVsAi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.rbPlayerVsAi.Location = new System.Drawing.Point(593, 700);
            this.rbPlayerVsAi.Name = "rbPlayerVsAi";
            this.rbPlayerVsAi.Size = new System.Drawing.Size(242, 45);
            this.rbPlayerVsAi.TabIndex = 97;
            this.rbPlayerVsAi.Text = "Player Vs Ai";
            this.rbPlayerVsAi.UseVisualStyleBackColor = false;
            this.rbPlayerVsAi.CheckedChanged += new System.EventHandler(this.rbPlayerVsAi_CheckedChanged);
            // 
            // rbPlayerVsPlayer
            // 
            this.rbPlayerVsPlayer.AutoSize = true;
            this.rbPlayerVsPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.rbPlayerVsPlayer.Checked = true;
            this.rbPlayerVsPlayer.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold);
            this.rbPlayerVsPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.rbPlayerVsPlayer.Location = new System.Drawing.Point(593, 629);
            this.rbPlayerVsPlayer.Name = "rbPlayerVsPlayer";
            this.rbPlayerVsPlayer.Size = new System.Drawing.Size(313, 45);
            this.rbPlayerVsPlayer.TabIndex = 98;
            this.rbPlayerVsPlayer.TabStop = true;
            this.rbPlayerVsPlayer.Text = "Player vs Player";
            this.rbPlayerVsPlayer.UseVisualStyleBackColor = false;
            // 
            // chkAiAnimation
            // 
            this.chkAiAnimation.AutoSize = true;
            this.chkAiAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.chkAiAnimation.Checked = true;
            this.chkAiAnimation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAiAnimation.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold);
            this.chkAiAnimation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.chkAiAnimation.Location = new System.Drawing.Point(593, 843);
            this.chkAiAnimation.Name = "chkAiAnimation";
            this.chkAiAnimation.Size = new System.Drawing.Size(253, 45);
            this.chkAiAnimation.TabIndex = 99;
            this.chkAiAnimation.Text = "Ai Animation";
            this.chkAiAnimation.UseVisualStyleBackColor = false;
            this.chkAiAnimation.Visible = false;
            // 
            // rbAivsAi
            // 
            this.rbAivsAi.AutoSize = true;
            this.rbAivsAi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.rbAivsAi.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold);
            this.rbAivsAi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.rbAivsAi.Location = new System.Drawing.Point(593, 771);
            this.rbAivsAi.Name = "rbAivsAi";
            this.rbAivsAi.Size = new System.Drawing.Size(166, 45);
            this.rbAivsAi.TabIndex = 100;
            this.rbAivsAi.Text = "Ai Vs Ai";
            this.rbAivsAi.UseVisualStyleBackColor = false;
            this.rbAivsAi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cbAiSpeed
            // 
            this.cbAiSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbAiSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAiSpeed.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold);
            this.cbAiSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbAiSpeed.FormattingEnabled = true;
            this.cbAiSpeed.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x3"});
            this.cbAiSpeed.Location = new System.Drawing.Point(1003, 698);
            this.cbAiSpeed.Name = "cbAiSpeed";
            this.cbAiSpeed.Size = new System.Drawing.Size(121, 49);
            this.cbAiSpeed.TabIndex = 105;
            this.cbAiSpeed.Visible = false;
            this.cbAiSpeed.SelectedIndexChanged += new System.EventHandler(this.cbAiSpeed_SelectedIndexChanged);
            // 
            // lpSpeed
            // 
            this.lpSpeed.AutoSize = true;
            this.lpSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.lpSpeed.Font = new System.Drawing.Font("Helvetica Rounded", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lpSpeed.Location = new System.Drawing.Point(978, 654);
            this.lpSpeed.Name = "lpSpeed";
            this.lpSpeed.Size = new System.Drawing.Size(170, 41);
            this.lpSpeed.TabIndex = 106;
            this.lpSpeed.Text = "Ai Speed";
            this.lpSpeed.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(872, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 27);
            this.label7.TabIndex = 109;
            this.label7.Text = "Race to win";
            // 
            // btnInfo
            // 
            this.btnInfo.AutoSize = true;
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnInfo.BackgroundImage = global::Octo.Properties.Resources.Info1;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(1176, 912);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(51, 91);
            this.btnInfo.TabIndex = 111;
            this.btnInfo.UseMnemonic = false;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            this.btnInfo.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnInfo.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-111, -7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(550, 1077);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 110;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.pictureBox3.Image = global::Octo.Properties.Resources.BlackPlayer_Plane;
            this.pictureBox3.Location = new System.Drawing.Point(1085, 459);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 90;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "G 0|0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.pictureBox4.Image = global::Octo.Properties.Resources.WhitePlayer_Plane;
            this.pictureBox4.Location = new System.Drawing.Point(1085, 300);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 89;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "G 0|0";
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnPlay.BackgroundImage = global::Octo.Properties.Resources.PlayBtn;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(566, 912);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(582, 91);
            this.btnPlay.TabIndex = 81;
            this.btnPlay.UseMnemonic = false;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnPlay.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
            // 
            // pbPanel
            // 
            this.pbPanel.BackColor = System.Drawing.Color.Transparent;
            this.pbPanel.Image = global::Octo.Properties.Resources.RetangleBlueWhite;
            this.pbPanel.Location = new System.Drawing.Point(464, 200);
            this.pbPanel.Name = "pbPanel";
            this.pbPanel.Size = new System.Drawing.Size(800, 829);
            this.pbPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPanel.TabIndex = 4;
            this.pbPanel.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(529, -39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 321);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1216, 404);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(550, 572);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 108;
            this.pictureBox6.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1778, 1041);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lpSpeed);
            this.Controls.Add(this.cbAiSpeed);
            this.Controls.Add(this.rbAivsAi);
            this.Controls.Add(this.chkAiAnimation);
            this.Controls.Add(this.rbPlayerVsPlayer);
            this.Controls.Add(this.rbPlayerVsAi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LpMaxPlayer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LpMaxPlayer2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPlayer2);
            this.Controls.Add(this.tbPlayer1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pbPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.Text = "Octo";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbPanel;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LpMaxPlayer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LpMaxPlayer1;
        private System.Windows.Forms.RadioButton rbPlayerVsAi;
        private System.Windows.Forms.RadioButton rbPlayerVsPlayer;
        private System.Windows.Forms.CheckBox chkAiAnimation;
        private System.Windows.Forms.RadioButton rbAivsAi;
        private System.Windows.Forms.ComboBox cbAiSpeed;
        private System.Windows.Forms.Label lpSpeed;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnInfo;
    }
}