namespace WMNX2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.numAvatar = new System.Windows.Forms.NumericUpDown();
            this.btnSerial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentMission = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCurrentLand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToolCRC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAMCRC = new System.Windows.Forms.TextBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.groupCheat = new System.Windows.Forms.GroupBox();
            this.panelPortal = new System.Windows.Forms.GroupBox();
            this.ckBarharn = new System.Windows.Forms.CheckBox();
            this.ckCryomiston = new System.Windows.Forms.CheckBox();
            this.ckHarena = new System.Windows.Forms.CheckBox();
            this.ckMorigin = new System.Windows.Forms.CheckBox();
            this.ckRootinia = new System.Windows.Forms.CheckBox();
            this.ckShantomia = new System.Windows.Forms.CheckBox();
            this.ckMirtain = new System.Windows.Forms.CheckBox();
            this.panelBarricade = new System.Windows.Forms.GroupBox();
            this.ckWhite = new System.Windows.Forms.CheckBox();
            this.ckRed = new System.Windows.Forms.CheckBox();
            this.ckYellow = new System.Windows.Forms.CheckBox();
            this.ckLightG = new System.Windows.Forms.CheckBox();
            this.ckGreen = new System.Windows.Forms.CheckBox();
            this.ckSkyBlue = new System.Windows.Forms.CheckBox();
            this.ckBlue = new System.Windows.Forms.CheckBox();
            this.ckViolet = new System.Windows.Forms.CheckBox();
            this.ckPink = new System.Windows.Forms.CheckBox();
            this.ckGrey = new System.Windows.Forms.CheckBox();
            this.ckBlack = new System.Windows.Forms.CheckBox();
            this.ckDarkYellow = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.btnMission = new System.Windows.Forms.Button();
            this.groupInfo.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.groupCheat.SuspendLayout();
            this.panelPortal.SuspendLayout();
            this.panelBarricade.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.btnSave);
            this.groupInfo.Controls.Add(this.panelData);
            this.groupInfo.Controls.Add(this.btnPick);
            this.groupInfo.Location = new System.Drawing.Point(13, 13);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(326, 318);
            this.groupInfo.TabIndex = 0;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "My Info";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(6, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(314, 65);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Profile";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.numAvatar);
            this.panelData.Controls.Add(this.btnSerial);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.picAvatar);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Controls.Add(this.txtCurrentMission);
            this.panelData.Controls.Add(this.txtName);
            this.panelData.Controls.Add(this.txtCurrentLand);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.label7);
            this.panelData.Controls.Add(this.txtSerial);
            this.panelData.Controls.Add(this.label6);
            this.panelData.Controls.Add(this.label4);
            this.panelData.Controls.Add(this.txtToolCRC);
            this.panelData.Controls.Add(this.label5);
            this.panelData.Controls.Add(this.txtAMCRC);
            this.panelData.Enabled = false;
            this.panelData.Location = new System.Drawing.Point(6, 51);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(314, 186);
            this.panelData.TabIndex = 17;
            // 
            // numAvatar
            // 
            this.numAvatar.Location = new System.Drawing.Point(64, 4);
            this.numAvatar.Maximum = new decimal(new int[] {
            216,
            0,
            0,
            0});
            this.numAvatar.Name = "numAvatar";
            this.numAvatar.Size = new System.Drawing.Size(54, 20);
            this.numAvatar.TabIndex = 18;
            this.numAvatar.ValueChanged += new System.EventHandler(this.numAvatar_ValueChanged);
            // 
            // btnSerial
            // 
            this.btnSerial.Location = new System.Drawing.Point(281, 52);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(20, 20);
            this.btnSerial.TabIndex = 17;
            this.btnSerial.Text = "?";
            this.btnSerial.UseVisualStyleBackColor = true;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avatar";
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(3, 30);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(115, 116);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtCurrentMission
            // 
            this.txtCurrentMission.Location = new System.Drawing.Point(204, 153);
            this.txtCurrentMission.Name = "txtCurrentMission";
            this.txtCurrentMission.ReadOnly = true;
            this.txtCurrentMission.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentMission.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 25);
            this.txtName.MaxLength = 8;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtCurrentLand
            // 
            this.txtCurrentLand.Location = new System.Drawing.Point(204, 129);
            this.txtCurrentLand.Name = "txtCurrentLand";
            this.txtCurrentLand.ReadOnly = true;
            this.txtCurrentLand.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentLand.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Current Mission";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(162, 52);
            this.txtSerial.MaxLength = 24;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(117, 20);
            this.txtSerial.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CurrentLand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Andamiro CRC";
            // 
            // txtToolCRC
            // 
            this.txtToolCRC.Location = new System.Drawing.Point(204, 105);
            this.txtToolCRC.Name = "txtToolCRC";
            this.txtToolCRC.ReadOnly = true;
            this.txtToolCRC.Size = new System.Drawing.Size(100, 20);
            this.txtToolCRC.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ReHash CRC";
            // 
            // txtAMCRC
            // 
            this.txtAMCRC.Location = new System.Drawing.Point(204, 78);
            this.txtAMCRC.Name = "txtAMCRC";
            this.txtAMCRC.ReadOnly = true;
            this.txtAMCRC.Size = new System.Drawing.Size(100, 20);
            this.txtAMCRC.TabIndex = 9;
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(6, 19);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 6;
            this.btnPick.Text = "Pick Data";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // groupCheat
            // 
            this.groupCheat.Controls.Add(this.panelPortal);
            this.groupCheat.Controls.Add(this.panelBarricade);
            this.groupCheat.Controls.Add(this.label8);
            this.groupCheat.Controls.Add(this.txtPosition);
            this.groupCheat.Controls.Add(this.label10);
            this.groupCheat.Controls.Add(this.label9);
            this.groupCheat.Controls.Add(this.txtMileage);
            this.groupCheat.Controls.Add(this.btnMission);
            this.groupCheat.Enabled = false;
            this.groupCheat.Location = new System.Drawing.Point(345, 13);
            this.groupCheat.Name = "groupCheat";
            this.groupCheat.Size = new System.Drawing.Size(267, 318);
            this.groupCheat.TabIndex = 1;
            this.groupCheat.TabStop = false;
            this.groupCheat.Text = "Cheat Info";
            // 
            // panelPortal
            // 
            this.panelPortal.Controls.Add(this.ckBarharn);
            this.panelPortal.Controls.Add(this.ckCryomiston);
            this.panelPortal.Controls.Add(this.ckHarena);
            this.panelPortal.Controls.Add(this.ckMorigin);
            this.panelPortal.Controls.Add(this.ckRootinia);
            this.panelPortal.Controls.Add(this.ckShantomia);
            this.panelPortal.Controls.Add(this.ckMirtain);
            this.panelPortal.Enabled = false;
            this.panelPortal.Location = new System.Drawing.Point(6, 138);
            this.panelPortal.Name = "panelPortal";
            this.panelPortal.Size = new System.Drawing.Size(255, 88);
            this.panelPortal.TabIndex = 22;
            this.panelPortal.TabStop = false;
            this.panelPortal.Text = "Portal";
            // 
            // ckBarharn
            // 
            this.ckBarharn.AutoSize = true;
            this.ckBarharn.Location = new System.Drawing.Point(6, 19);
            this.ckBarharn.Name = "ckBarharn";
            this.ckBarharn.Size = new System.Drawing.Size(63, 17);
            this.ckBarharn.TabIndex = 26;
            this.ckBarharn.Text = "Barharn";
            this.ckBarharn.UseVisualStyleBackColor = true;
            // 
            // ckCryomiston
            // 
            this.ckCryomiston.AutoSize = true;
            this.ckCryomiston.Location = new System.Drawing.Point(5, 65);
            this.ckCryomiston.Name = "ckCryomiston";
            this.ckCryomiston.Size = new System.Drawing.Size(77, 17);
            this.ckCryomiston.TabIndex = 32;
            this.ckCryomiston.Text = "Cryomiston";
            this.ckCryomiston.UseVisualStyleBackColor = true;
            // 
            // ckHarena
            // 
            this.ckHarena.AutoSize = true;
            this.ckHarena.Location = new System.Drawing.Point(6, 42);
            this.ckHarena.Name = "ckHarena";
            this.ckHarena.Size = new System.Drawing.Size(61, 17);
            this.ckHarena.TabIndex = 27;
            this.ckHarena.Text = "Harena";
            this.ckHarena.UseVisualStyleBackColor = true;
            // 
            // ckMorigin
            // 
            this.ckMorigin.AutoSize = true;
            this.ckMorigin.Location = new System.Drawing.Point(174, 42);
            this.ckMorigin.Name = "ckMorigin";
            this.ckMorigin.Size = new System.Drawing.Size(60, 17);
            this.ckMorigin.TabIndex = 31;
            this.ckMorigin.Text = "Morigin";
            this.ckMorigin.UseVisualStyleBackColor = true;
            // 
            // ckRootinia
            // 
            this.ckRootinia.AutoSize = true;
            this.ckRootinia.Location = new System.Drawing.Point(98, 21);
            this.ckRootinia.Name = "ckRootinia";
            this.ckRootinia.Size = new System.Drawing.Size(65, 17);
            this.ckRootinia.TabIndex = 28;
            this.ckRootinia.Text = "Rootinia";
            this.ckRootinia.UseVisualStyleBackColor = true;
            // 
            // ckShantomia
            // 
            this.ckShantomia.AutoSize = true;
            this.ckShantomia.Location = new System.Drawing.Point(174, 21);
            this.ckShantomia.Name = "ckShantomia";
            this.ckShantomia.Size = new System.Drawing.Size(76, 17);
            this.ckShantomia.TabIndex = 30;
            this.ckShantomia.Text = "Shantomia";
            this.ckShantomia.UseVisualStyleBackColor = true;
            // 
            // ckMirtain
            // 
            this.ckMirtain.AutoSize = true;
            this.ckMirtain.Location = new System.Drawing.Point(98, 42);
            this.ckMirtain.Name = "ckMirtain";
            this.ckMirtain.Size = new System.Drawing.Size(57, 17);
            this.ckMirtain.TabIndex = 29;
            this.ckMirtain.Text = "Mirtain";
            this.ckMirtain.UseVisualStyleBackColor = true;
            // 
            // panelBarricade
            // 
            this.panelBarricade.Controls.Add(this.ckWhite);
            this.panelBarricade.Controls.Add(this.ckRed);
            this.panelBarricade.Controls.Add(this.ckYellow);
            this.panelBarricade.Controls.Add(this.ckLightG);
            this.panelBarricade.Controls.Add(this.ckGreen);
            this.panelBarricade.Controls.Add(this.ckSkyBlue);
            this.panelBarricade.Controls.Add(this.ckBlue);
            this.panelBarricade.Controls.Add(this.ckViolet);
            this.panelBarricade.Controls.Add(this.ckPink);
            this.panelBarricade.Controls.Add(this.ckGrey);
            this.panelBarricade.Controls.Add(this.ckBlack);
            this.panelBarricade.Controls.Add(this.ckDarkYellow);
            this.panelBarricade.Enabled = false;
            this.panelBarricade.Location = new System.Drawing.Point(6, 19);
            this.panelBarricade.Name = "panelBarricade";
            this.panelBarricade.Size = new System.Drawing.Size(255, 113);
            this.panelBarricade.TabIndex = 3;
            this.panelBarricade.TabStop = false;
            this.panelBarricade.Text = "Barricade";
            // 
            // ckWhite
            // 
            this.ckWhite.AutoSize = true;
            this.ckWhite.Location = new System.Drawing.Point(6, 19);
            this.ckWhite.Name = "ckWhite";
            this.ckWhite.Size = new System.Drawing.Size(54, 17);
            this.ckWhite.TabIndex = 10;
            this.ckWhite.Text = "White";
            this.ckWhite.UseVisualStyleBackColor = true;
            // 
            // ckRed
            // 
            this.ckRed.AutoSize = true;
            this.ckRed.Location = new System.Drawing.Point(6, 42);
            this.ckRed.Name = "ckRed";
            this.ckRed.Size = new System.Drawing.Size(46, 17);
            this.ckRed.TabIndex = 11;
            this.ckRed.Text = "Red";
            this.ckRed.UseVisualStyleBackColor = true;
            // 
            // ckYellow
            // 
            this.ckYellow.AutoSize = true;
            this.ckYellow.Location = new System.Drawing.Point(6, 65);
            this.ckYellow.Name = "ckYellow";
            this.ckYellow.Size = new System.Drawing.Size(57, 17);
            this.ckYellow.TabIndex = 12;
            this.ckYellow.Text = "Yellow";
            this.ckYellow.UseVisualStyleBackColor = true;
            // 
            // ckLightG
            // 
            this.ckLightG.AutoSize = true;
            this.ckLightG.Location = new System.Drawing.Point(6, 88);
            this.ckLightG.Name = "ckLightG";
            this.ckLightG.Size = new System.Drawing.Size(81, 17);
            this.ckLightG.TabIndex = 13;
            this.ckLightG.Text = "Light Green";
            this.ckLightG.UseVisualStyleBackColor = true;
            // 
            // ckGreen
            // 
            this.ckGreen.AutoSize = true;
            this.ckGreen.Location = new System.Drawing.Point(99, 19);
            this.ckGreen.Name = "ckGreen";
            this.ckGreen.Size = new System.Drawing.Size(55, 17);
            this.ckGreen.TabIndex = 14;
            this.ckGreen.Text = "Green";
            this.ckGreen.UseVisualStyleBackColor = true;
            // 
            // ckSkyBlue
            // 
            this.ckSkyBlue.AutoSize = true;
            this.ckSkyBlue.Location = new System.Drawing.Point(99, 42);
            this.ckSkyBlue.Name = "ckSkyBlue";
            this.ckSkyBlue.Size = new System.Drawing.Size(68, 17);
            this.ckSkyBlue.TabIndex = 15;
            this.ckSkyBlue.Text = "Sky Blue";
            this.ckSkyBlue.UseVisualStyleBackColor = true;
            // 
            // ckBlue
            // 
            this.ckBlue.AutoSize = true;
            this.ckBlue.Location = new System.Drawing.Point(99, 65);
            this.ckBlue.Name = "ckBlue";
            this.ckBlue.Size = new System.Drawing.Size(47, 17);
            this.ckBlue.TabIndex = 16;
            this.ckBlue.Text = "Blue";
            this.ckBlue.UseVisualStyleBackColor = true;
            // 
            // ckViolet
            // 
            this.ckViolet.AutoSize = true;
            this.ckViolet.Location = new System.Drawing.Point(99, 88);
            this.ckViolet.Name = "ckViolet";
            this.ckViolet.Size = new System.Drawing.Size(52, 17);
            this.ckViolet.TabIndex = 17;
            this.ckViolet.Text = "Violet";
            this.ckViolet.UseVisualStyleBackColor = true;
            // 
            // ckPink
            // 
            this.ckPink.AutoSize = true;
            this.ckPink.Location = new System.Drawing.Point(175, 19);
            this.ckPink.Name = "ckPink";
            this.ckPink.Size = new System.Drawing.Size(47, 17);
            this.ckPink.TabIndex = 18;
            this.ckPink.Text = "Pink";
            this.ckPink.UseVisualStyleBackColor = true;
            // 
            // ckGrey
            // 
            this.ckGrey.AutoSize = true;
            this.ckGrey.Location = new System.Drawing.Point(175, 42);
            this.ckGrey.Name = "ckGrey";
            this.ckGrey.Size = new System.Drawing.Size(48, 17);
            this.ckGrey.TabIndex = 19;
            this.ckGrey.Text = "Grey";
            this.ckGrey.UseVisualStyleBackColor = true;
            // 
            // ckBlack
            // 
            this.ckBlack.AutoSize = true;
            this.ckBlack.Location = new System.Drawing.Point(175, 65);
            this.ckBlack.Name = "ckBlack";
            this.ckBlack.Size = new System.Drawing.Size(53, 17);
            this.ckBlack.TabIndex = 20;
            this.ckBlack.Text = "Black";
            this.ckBlack.UseVisualStyleBackColor = true;
            // 
            // ckDarkYellow
            // 
            this.ckDarkYellow.AutoSize = true;
            this.ckDarkYellow.Location = new System.Drawing.Point(175, 88);
            this.ckDarkYellow.Name = "ckDarkYellow";
            this.ckDarkYellow.Size = new System.Drawing.Size(80, 17);
            this.ckDarkYellow.TabIndex = 21;
            this.ckDarkYellow.Text = "DarkYellow";
            this.ckDarkYellow.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Get your position ID from the review mission list";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(184, 238);
            this.txtPosition.MaxLength = 8;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(68, 20);
            this.txtPosition.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mileage";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(60, 238);
            this.txtMileage.MaxLength = 8;
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(68, 20);
            this.txtMileage.TabIndex = 22;
            // 
            // btnMission
            // 
            this.btnMission.Location = new System.Drawing.Point(10, 287);
            this.btnMission.Name = "btnMission";
            this.btnMission.Size = new System.Drawing.Size(246, 23);
            this.btnMission.TabIndex = 5;
            this.btnMission.Text = "Review Mission >>>>";
            this.btnMission.UseVisualStyleBackColor = true;
            this.btnMission.Click += new System.EventHandler(this.btnMission_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.groupCheat);
            this.Controls.Add(this.groupInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WMNX2 by Hans";
            this.groupInfo.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.groupCheat.ResumeLayout(false);
            this.groupCheat.PerformLayout();
            this.panelPortal.ResumeLayout(false);
            this.panelPortal.PerformLayout();
            this.panelBarricade.ResumeLayout(false);
            this.panelBarricade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToolCRC;
        private System.Windows.Forms.TextBox txtAMCRC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentMission;
        private System.Windows.Forms.TextBox txtCurrentLand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupCheat;
        private System.Windows.Forms.Button btnMission;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.NumericUpDown numAvatar;
        private System.Windows.Forms.CheckBox ckWhite;
        private System.Windows.Forms.CheckBox ckRed;
        private System.Windows.Forms.CheckBox ckViolet;
        private System.Windows.Forms.CheckBox ckBlue;
        private System.Windows.Forms.CheckBox ckSkyBlue;
        private System.Windows.Forms.CheckBox ckGreen;
        private System.Windows.Forms.CheckBox ckLightG;
        private System.Windows.Forms.CheckBox ckYellow;
        private System.Windows.Forms.CheckBox ckDarkYellow;
        private System.Windows.Forms.CheckBox ckBlack;
        private System.Windows.Forms.CheckBox ckGrey;
        private System.Windows.Forms.CheckBox ckPink;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckCryomiston;
        private System.Windows.Forms.CheckBox ckMorigin;
        private System.Windows.Forms.CheckBox ckShantomia;
        private System.Windows.Forms.CheckBox ckMirtain;
        private System.Windows.Forms.CheckBox ckRootinia;
        private System.Windows.Forms.CheckBox ckHarena;
        private System.Windows.Forms.CheckBox ckBarharn;
        private System.Windows.Forms.GroupBox panelBarricade;
        private System.Windows.Forms.GroupBox panelPortal;
    }
}

