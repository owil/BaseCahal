namespace BaseCahal
{
    partial class BaseCahal
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
            this.useZombie = new System.Windows.Forms.ToolStripMenuItem();
            this.alannaBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.useNaturralFairy = new System.Windows.Forms.ToolStripMenuItem();
            this.useGodly = new System.Windows.Forms.ToolStripMenuItem();
            this.useTorrented = new System.Windows.Forms.ToolStripMenuItem();
            this.useDrezDemon = new System.Windows.Forms.ToolStripMenuItem();
            this.useRage = new System.Windows.Forms.ToolStripMenuItem();
            this.useJalepeno = new System.Windows.Forms.ToolStripMenuItem();
            this.plAtkOutput = new System.Windows.Forms.TextBox();
            this.plDefOutput = new System.Windows.Forms.TextBox();
            this.creatureInUse = new System.Windows.Forms.Label();
            this.atkLabel = new System.Windows.Forms.Label();
            this.spDefLabel = new System.Windows.Forms.Label();
            this.defLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.oppAtkOutput = new System.Windows.Forms.TextBox();
            this.oppHealthOutput = new System.Windows.Forms.TextBox();
            this.oppDefOutput = new System.Windows.Forms.TextBox();
            this.useStoneGolem = new System.Windows.Forms.ToolStripMenuItem();
            this.useDragon = new System.Windows.Forms.ToolStripMenuItem();
            this.useHydra = new System.Windows.Forms.ToolStripMenuItem();
            this.plHealthOutput = new System.Windows.Forms.TextBox();
            this.alvinBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.plSpDefOutput = new System.Windows.Forms.TextBox();
            this.oppSpDefOutput = new System.Windows.Forms.TextBox();
            this.oppSpDefLabel = new System.Windows.Forms.Label();
            this.oppHealthLabel = new System.Windows.Forms.Label();
            this.oppDefLabel = new System.Windows.Forms.Label();
            this.oppAtkLabel = new System.Windows.Forms.Label();
            this.oppNameDisplay = new System.Windows.Forms.TextBox();
            this.statDisplay = new System.Windows.Forms.TextBox();
            this.oppNameLabel = new System.Windows.Forms.Label();
            this.statLabel = new System.Windows.Forms.Label();
            this.creaturePic = new System.Windows.Forms.PictureBox();
            this.moveBack = new System.Windows.Forms.Button();
            this.attackList = new System.Windows.Forms.GroupBox();
            this.attack3 = new System.Windows.Forms.RadioButton();
            this.attack2 = new System.Windows.Forms.RadioButton();
            this.attack1 = new System.Windows.Forms.RadioButton();
            this.attackButton = new System.Windows.Forms.Button();
            this.moveForward = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.gameInfo2 = new System.Windows.Forms.Label();
            this.gameInfo1 = new System.Windows.Forms.Label();
            this.moveRight = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bgPic = new System.Windows.Forms.PictureBox();
            this.gameMenu = new System.Windows.Forms.MenuStrip();
            this.mainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame = new System.Windows.Forms.ToolStripMenuItem();
            this.creatureMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.irisBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.useDefaultPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.useGhost = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.creaturePic)).BeginInit();
            this.attackList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgPic)).BeginInit();
            this.gameMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // useZombie
            // 
            this.useZombie.Name = "useZombie";
            this.useZombie.Size = new System.Drawing.Size(155, 22);
            this.useZombie.Text = "Zombie";
            this.useZombie.ToolTipText = "Def 5-15, Atk 5-10";
            this.useZombie.Visible = false;
            this.useZombie.Click += new System.EventHandler(this.useZombie_Click);
            // 
            // alannaBatch
            // 
            this.alannaBatch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useNaturralFairy,
            this.useGodly,
            this.useTorrented,
            this.useDrezDemon,
            this.useRage});
            this.alannaBatch.Name = "alannaBatch";
            this.alannaBatch.Size = new System.Drawing.Size(152, 22);
            this.alannaBatch.Text = "Alanna\'s Batch";
            // 
            // useNaturralFairy
            // 
            this.useNaturralFairy.Name = "useNaturralFairy";
            this.useNaturralFairy.Size = new System.Drawing.Size(145, 22);
            this.useNaturralFairy.Text = "Naturral Fairy";
            this.useNaturralFairy.ToolTipText = "Def 5-20, Atk 10-15";
            this.useNaturralFairy.Visible = false;
            this.useNaturralFairy.Click += new System.EventHandler(this.useNaturralFairy_Click);
            // 
            // useGodly
            // 
            this.useGodly.Name = "useGodly";
            this.useGodly.Size = new System.Drawing.Size(145, 22);
            this.useGodly.Text = "Godly";
            this.useGodly.ToolTipText = "Def 5-15, Atk 10-15";
            this.useGodly.Visible = false;
            this.useGodly.Click += new System.EventHandler(this.useGodly_Click);
            // 
            // useTorrented
            // 
            this.useTorrented.Name = "useTorrented";
            this.useTorrented.Size = new System.Drawing.Size(145, 22);
            this.useTorrented.Text = "Torrented";
            this.useTorrented.ToolTipText = "Def 2-7, Atk 5-10";
            this.useTorrented.Visible = false;
            this.useTorrented.Click += new System.EventHandler(this.useTorrented_Click);
            // 
            // useDrezDemon
            // 
            this.useDrezDemon.Name = "useDrezDemon";
            this.useDrezDemon.Size = new System.Drawing.Size(145, 22);
            this.useDrezDemon.Text = "Drez Demon";
            this.useDrezDemon.ToolTipText = "Def 5-15, Atk 10-15";
            this.useDrezDemon.Visible = false;
            this.useDrezDemon.Click += new System.EventHandler(this.useDrezDemon_Click);
            // 
            // useRage
            // 
            this.useRage.Name = "useRage";
            this.useRage.Size = new System.Drawing.Size(145, 22);
            this.useRage.Text = "Rage";
            this.useRage.ToolTipText = "Def 5-10, Atk 5-12";
            this.useRage.Visible = false;
            this.useRage.Click += new System.EventHandler(this.useRage_Click);
            // 
            // useJalepeno
            // 
            this.useJalepeno.Name = "useJalepeno";
            this.useJalepeno.Size = new System.Drawing.Size(155, 22);
            this.useJalepeno.Text = "Jalepeno";
            this.useJalepeno.ToolTipText = "Def 2-10, Atk 5-15";
            this.useJalepeno.Visible = false;
            this.useJalepeno.Click += new System.EventHandler(this.useJalepeno_Click);
            // 
            // plAtkOutput
            // 
            this.plAtkOutput.Location = new System.Drawing.Point(92, 360);
            this.plAtkOutput.Name = "plAtkOutput";
            this.plAtkOutput.ReadOnly = true;
            this.plAtkOutput.Size = new System.Drawing.Size(175, 20);
            this.plAtkOutput.TabIndex = 98;
            // 
            // plDefOutput
            // 
            this.plDefOutput.Location = new System.Drawing.Point(92, 315);
            this.plDefOutput.Name = "plDefOutput";
            this.plDefOutput.ReadOnly = true;
            this.plDefOutput.Size = new System.Drawing.Size(100, 20);
            this.plDefOutput.TabIndex = 96;
            // 
            // creatureInUse
            // 
            this.creatureInUse.AutoSize = true;
            this.creatureInUse.Location = new System.Drawing.Point(18, 131);
            this.creatureInUse.Name = "creatureInUse";
            this.creatureInUse.Size = new System.Drawing.Size(79, 13);
            this.creatureInUse.TabIndex = 94;
            this.creatureInUse.Text = "(Default Player)";
            // 
            // atkLabel
            // 
            this.atkLabel.AutoSize = true;
            this.atkLabel.Location = new System.Drawing.Point(12, 363);
            this.atkLabel.Name = "atkLabel";
            this.atkLabel.Size = new System.Drawing.Size(58, 13);
            this.atkLabel.TabIndex = 93;
            this.atkLabel.Text = "Player Atk:";
            // 
            // spDefLabel
            // 
            this.spDefLabel.AutoSize = true;
            this.spDefLabel.Location = new System.Drawing.Point(12, 341);
            this.spDefLabel.Name = "spDefLabel";
            this.spDefLabel.Size = new System.Drawing.Size(78, 13);
            this.spDefLabel.TabIndex = 92;
            this.spDefLabel.Text = "Player Sp. Def:";
            // 
            // defLabel
            // 
            this.defLabel.AutoSize = true;
            this.defLabel.Location = new System.Drawing.Point(12, 318);
            this.defLabel.Name = "defLabel";
            this.defLabel.Size = new System.Drawing.Size(59, 13);
            this.defLabel.TabIndex = 91;
            this.defLabel.Text = "Player Def:";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(12, 295);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(73, 13);
            this.healthLabel.TabIndex = 90;
            this.healthLabel.Text = "Player Health:";
            // 
            // oppAtkOutput
            // 
            this.oppAtkOutput.Location = new System.Drawing.Point(564, 364);
            this.oppAtkOutput.Name = "oppAtkOutput";
            this.oppAtkOutput.ReadOnly = true;
            this.oppAtkOutput.Size = new System.Drawing.Size(212, 20);
            this.oppAtkOutput.TabIndex = 89;
            // 
            // oppHealthOutput
            // 
            this.oppHealthOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.oppHealthOutput.Location = new System.Drawing.Point(393, 364);
            this.oppHealthOutput.Name = "oppHealthOutput";
            this.oppHealthOutput.ReadOnly = true;
            this.oppHealthOutput.Size = new System.Drawing.Size(80, 20);
            this.oppHealthOutput.TabIndex = 88;
            // 
            // oppDefOutput
            // 
            this.oppDefOutput.Location = new System.Drawing.Point(564, 338);
            this.oppDefOutput.Name = "oppDefOutput";
            this.oppDefOutput.ReadOnly = true;
            this.oppDefOutput.Size = new System.Drawing.Size(49, 20);
            this.oppDefOutput.TabIndex = 87;
            // 
            // useStoneGolem
            // 
            this.useStoneGolem.Name = "useStoneGolem";
            this.useStoneGolem.Size = new System.Drawing.Size(152, 22);
            this.useStoneGolem.Text = "Stone Golem";
            this.useStoneGolem.ToolTipText = "Def 15-20, Sp.Def 5-10, Atk 10-20";
            this.useStoneGolem.Visible = false;
            this.useStoneGolem.Click += new System.EventHandler(this.useStoneGolem_Click);
            // 
            // useDragon
            // 
            this.useDragon.Name = "useDragon";
            this.useDragon.Size = new System.Drawing.Size(152, 22);
            this.useDragon.Text = "Dragon";
            this.useDragon.ToolTipText = "150 hP, Def 10-15, Sp. Def 5-10, Atk 10-15";
            this.useDragon.Visible = false;
            this.useDragon.Click += new System.EventHandler(this.useDragon_Click);
            // 
            // useHydra
            // 
            this.useHydra.Name = "useHydra";
            this.useHydra.Size = new System.Drawing.Size(152, 22);
            this.useHydra.Text = "Hydra";
            this.useHydra.ToolTipText = "Def 7-10, Sp. Atk 30 | 25 | 4 + 2 Poison/5 turns";
            this.useHydra.Visible = false;
            this.useHydra.Click += new System.EventHandler(this.useHydra_Click);
            // 
            // plHealthOutput
            // 
            this.plHealthOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.plHealthOutput.Location = new System.Drawing.Point(92, 292);
            this.plHealthOutput.Name = "plHealthOutput";
            this.plHealthOutput.ReadOnly = true;
            this.plHealthOutput.Size = new System.Drawing.Size(100, 20);
            this.plHealthOutput.TabIndex = 95;
            // 
            // alvinBatch
            // 
            this.alvinBatch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useHydra,
            this.useDragon,
            this.useStoneGolem});
            this.alvinBatch.Name = "alvinBatch";
            this.alvinBatch.Size = new System.Drawing.Size(152, 22);
            this.alvinBatch.Text = "Alvin\'s Batch";
            // 
            // plSpDefOutput
            // 
            this.plSpDefOutput.Location = new System.Drawing.Point(92, 338);
            this.plSpDefOutput.Name = "plSpDefOutput";
            this.plSpDefOutput.ReadOnly = true;
            this.plSpDefOutput.Size = new System.Drawing.Size(100, 20);
            this.plSpDefOutput.TabIndex = 97;
            // 
            // oppSpDefOutput
            // 
            this.oppSpDefOutput.Location = new System.Drawing.Point(715, 335);
            this.oppSpDefOutput.Name = "oppSpDefOutput";
            this.oppSpDefOutput.ReadOnly = true;
            this.oppSpDefOutput.Size = new System.Drawing.Size(61, 20);
            this.oppSpDefOutput.TabIndex = 86;
            // 
            // oppSpDefLabel
            // 
            this.oppSpDefLabel.AutoSize = true;
            this.oppSpDefLabel.Location = new System.Drawing.Point(619, 338);
            this.oppSpDefLabel.Name = "oppSpDefLabel";
            this.oppSpDefLabel.Size = new System.Drawing.Size(96, 13);
            this.oppSpDefLabel.TabIndex = 85;
            this.oppSpDefLabel.Text = "Opponent Sp. Def:";
            // 
            // oppHealthLabel
            // 
            this.oppHealthLabel.AutoSize = true;
            this.oppHealthLabel.Location = new System.Drawing.Point(299, 367);
            this.oppHealthLabel.Name = "oppHealthLabel";
            this.oppHealthLabel.Size = new System.Drawing.Size(91, 13);
            this.oppHealthLabel.TabIndex = 84;
            this.oppHealthLabel.Text = "Opponent Health:";
            // 
            // oppDefLabel
            // 
            this.oppDefLabel.AutoSize = true;
            this.oppDefLabel.Location = new System.Drawing.Point(487, 338);
            this.oppDefLabel.Name = "oppDefLabel";
            this.oppDefLabel.Size = new System.Drawing.Size(77, 13);
            this.oppDefLabel.TabIndex = 83;
            this.oppDefLabel.Text = "Opponent Def:";
            // 
            // oppAtkLabel
            // 
            this.oppAtkLabel.AutoSize = true;
            this.oppAtkLabel.Location = new System.Drawing.Point(487, 367);
            this.oppAtkLabel.Name = "oppAtkLabel";
            this.oppAtkLabel.Size = new System.Drawing.Size(76, 13);
            this.oppAtkLabel.TabIndex = 82;
            this.oppAtkLabel.Text = "Opponent Atk:";
            // 
            // oppNameDisplay
            // 
            this.oppNameDisplay.Location = new System.Drawing.Point(393, 338);
            this.oppNameDisplay.Name = "oppNameDisplay";
            this.oppNameDisplay.ReadOnly = true;
            this.oppNameDisplay.Size = new System.Drawing.Size(80, 20);
            this.oppNameDisplay.TabIndex = 81;
            // 
            // statDisplay
            // 
            this.statDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.statDisplay.Location = new System.Drawing.Point(15, 254);
            this.statDisplay.Name = "statDisplay";
            this.statDisplay.ReadOnly = true;
            this.statDisplay.Size = new System.Drawing.Size(281, 20);
            this.statDisplay.TabIndex = 80;
            // 
            // oppNameLabel
            // 
            this.oppNameLabel.AutoSize = true;
            this.oppNameLabel.Location = new System.Drawing.Point(299, 338);
            this.oppNameLabel.Name = "oppNameLabel";
            this.oppNameLabel.Size = new System.Drawing.Size(88, 13);
            this.oppNameLabel.TabIndex = 79;
            this.oppNameLabel.Text = "Opponent Name:";
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.Location = new System.Drawing.Point(13, 238);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(78, 13);
            this.statLabel.TabIndex = 78;
            this.statLabel.Text = "Turn Summary:";
            // 
            // creaturePic
            // 
            this.creaturePic.BackColor = System.Drawing.Color.Transparent;
            this.creaturePic.Image = global::BaseCahal.Properties.Resources.Mist_BaseCahal;
            this.creaturePic.Location = new System.Drawing.Point(466, 118);
            this.creaturePic.Name = "creaturePic";
            this.creaturePic.Size = new System.Drawing.Size(162, 142);
            this.creaturePic.TabIndex = 77;
            this.creaturePic.TabStop = false;
            this.toolTip1.SetToolTip(this.creaturePic, "Click to find opponent.");
            this.creaturePic.Visible = false;
            this.creaturePic.Click += new System.EventHandler(this.creaturePic_Click);
            // 
            // moveBack
            // 
            this.moveBack.Location = new System.Drawing.Point(466, 297);
            this.moveBack.Name = "moveBack";
            this.moveBack.Size = new System.Drawing.Size(60, 23);
            this.moveBack.TabIndex = 76;
            this.moveBack.Text = "Go Back";
            this.moveBack.UseVisualStyleBackColor = true;
            this.moveBack.Visible = false;
            this.moveBack.Click += new System.EventHandler(this.moveBack_Click);
            // 
            // attackList
            // 
            this.attackList.Controls.Add(this.attack3);
            this.attackList.Controls.Add(this.attack2);
            this.attackList.Controls.Add(this.attack1);
            this.attackList.Location = new System.Drawing.Point(15, 147);
            this.attackList.Name = "attackList";
            this.attackList.Size = new System.Drawing.Size(200, 88);
            this.attackList.TabIndex = 75;
            this.attackList.TabStop = false;
            this.attackList.Text = "Available Attacks";
            // 
            // attack3
            // 
            this.attack3.AutoSize = true;
            this.attack3.Location = new System.Drawing.Point(6, 63);
            this.attack3.Name = "attack3";
            this.attack3.Size = new System.Drawing.Size(169, 17);
            this.attack3.TabIndex = 12;
            this.attack3.Text = "HTML (15-30 damage; hP<30)";
            this.attack3.UseVisualStyleBackColor = true;
            this.attack3.Visible = false;
            // 
            // attack2
            // 
            this.attack2.AutoSize = true;
            this.attack2.Location = new System.Drawing.Point(6, 40);
            this.attack2.Name = "attack2";
            this.attack2.Size = new System.Drawing.Size(177, 17);
            this.attack2.TabIndex = 11;
            this.attack2.Text = "C Sharp (10-25 damage; hP<60)";
            this.attack2.UseVisualStyleBackColor = true;
            this.attack2.Visible = false;
            // 
            // attack1
            // 
            this.attack1.AutoSize = true;
            this.attack1.Checked = true;
            this.attack1.Location = new System.Drawing.Point(6, 19);
            this.attack1.Name = "attack1";
            this.attack1.Size = new System.Drawing.Size(157, 17);
            this.attack1.TabIndex = 10;
            this.attack1.TabStop = true;
            this.attack1.Text = "Java (5-20 damage; default)";
            this.attack1.UseVisualStyleBackColor = true;
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(221, 181);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 74;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Visible = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // moveForward
            // 
            this.moveForward.Location = new System.Drawing.Point(532, 297);
            this.moveForward.Name = "moveForward";
            this.moveForward.Size = new System.Drawing.Size(96, 23);
            this.moveForward.TabIndex = 72;
            this.moveForward.Text = "Proceed Forward";
            this.moveForward.UseVisualStyleBackColor = true;
            this.moveForward.Visible = false;
            this.moveForward.Click += new System.EventHandler(this.moveForward_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(302, 297);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(75, 23);
            this.moveLeft.TabIndex = 71;
            this.moveLeft.Text = "Go Left";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Visible = false;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(16, 63);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(75, 23);
            this.startGameButton.TabIndex = 70;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // gameInfo2
            // 
            this.gameInfo2.AutoSize = true;
            this.gameInfo2.Location = new System.Drawing.Point(12, 48);
            this.gameInfo2.Name = "gameInfo2";
            this.gameInfo2.Size = new System.Drawing.Size(232, 13);
            this.gameInfo2.TabIndex = 69;
            this.gameInfo2.Text = "Use defeated creatures to battle new creatures.";
            // 
            // gameInfo1
            // 
            this.gameInfo1.AutoSize = true;
            this.gameInfo1.Location = new System.Drawing.Point(12, 35);
            this.gameInfo1.Name = "gameInfo1";
            this.gameInfo1.Size = new System.Drawing.Size(255, 13);
            this.gameInfo1.TabIndex = 68;
            this.gameInfo1.Text = "Travel through the cave system and defeat enemies.";
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(701, 297);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(75, 23);
            this.moveRight.TabIndex = 73;
            this.moveRight.Text = "Go Right";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Visible = false;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // bgPic
            // 
            this.bgPic.Image = global::BaseCahal.Properties.Resources.CaveA;
            this.bgPic.ImageLocation = "";
            this.bgPic.InitialImage = null;
            this.bgPic.Location = new System.Drawing.Point(302, 35);
            this.bgPic.Name = "bgPic";
            this.bgPic.Size = new System.Drawing.Size(474, 256);
            this.bgPic.TabIndex = 67;
            this.bgPic.TabStop = false;
            // 
            // gameMenu
            // 
            this.gameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu,
            this.creatureMenu});
            this.gameMenu.Location = new System.Drawing.Point(0, 0);
            this.gameMenu.Name = "gameMenu";
            this.gameMenu.Size = new System.Drawing.Size(784, 24);
            this.gameMenu.TabIndex = 66;
            this.gameMenu.Text = "Game Menu";
            // 
            // mainMenu
            // 
            this.mainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGame});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(80, 20);
            this.mainMenu.Text = "Main Menu";
            // 
            // newGame
            // 
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(132, 22);
            this.newGame.Text = "New Game";
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // creatureMenu
            // 
            this.creatureMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irisBatch,
            this.alannaBatch,
            this.alvinBatch});
            this.creatureMenu.Name = "creatureMenu";
            this.creatureMenu.Size = new System.Drawing.Size(197, 20);
            this.creatureMenu.Text = "Choose a Creature to use in battle";
            // 
            // irisBatch
            // 
            this.irisBatch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useDefaultPlayer,
            this.useGhost,
            this.useZombie,
            this.useJalepeno});
            this.irisBatch.Name = "irisBatch";
            this.irisBatch.Size = new System.Drawing.Size(152, 22);
            this.irisBatch.Text = "Iris\'s Batch";
            // 
            // useDefaultPlayer
            // 
            this.useDefaultPlayer.Name = "useDefaultPlayer";
            this.useDefaultPlayer.Size = new System.Drawing.Size(155, 22);
            this.useDefaultPlayer.Text = "(Default Player)";
            this.useDefaultPlayer.ToolTipText = "Def 5-20, Sp.Def 10-25, Atk 5-20 | 10-25 | 15-30";
            this.useDefaultPlayer.Click += new System.EventHandler(this.useDefaultPlayer_Click);
            // 
            // useGhost
            // 
            this.useGhost.Name = "useGhost";
            this.useGhost.Size = new System.Drawing.Size(155, 22);
            this.useGhost.Text = "Ghost";
            this.useGhost.ToolTipText = "Def 5-10, Atk 2-7";
            this.useGhost.Visible = false;
            this.useGhost.Click += new System.EventHandler(this.useGhost_Click);
            // 
            // BaseCahal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.plAtkOutput);
            this.Controls.Add(this.plDefOutput);
            this.Controls.Add(this.creatureInUse);
            this.Controls.Add(this.atkLabel);
            this.Controls.Add(this.spDefLabel);
            this.Controls.Add(this.defLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.oppAtkOutput);
            this.Controls.Add(this.oppHealthOutput);
            this.Controls.Add(this.oppDefOutput);
            this.Controls.Add(this.plHealthOutput);
            this.Controls.Add(this.plSpDefOutput);
            this.Controls.Add(this.oppSpDefOutput);
            this.Controls.Add(this.oppSpDefLabel);
            this.Controls.Add(this.oppHealthLabel);
            this.Controls.Add(this.oppDefLabel);
            this.Controls.Add(this.oppAtkLabel);
            this.Controls.Add(this.oppNameDisplay);
            this.Controls.Add(this.statDisplay);
            this.Controls.Add(this.oppNameLabel);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.creaturePic);
            this.Controls.Add(this.moveBack);
            this.Controls.Add(this.attackList);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.moveForward);
            this.Controls.Add(this.moveLeft);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.gameInfo2);
            this.Controls.Add(this.gameInfo1);
            this.Controls.Add(this.moveRight);
            this.Controls.Add(this.bgPic);
            this.Controls.Add(this.gameMenu);
            this.Name = "BaseCahal";
            this.Text = "Base Cahal";
            ((System.ComponentModel.ISupportInitialize)(this.creaturePic)).EndInit();
            this.attackList.ResumeLayout(false);
            this.attackList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgPic)).EndInit();
            this.gameMenu.ResumeLayout(false);
            this.gameMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem useZombie;
        private System.Windows.Forms.ToolStripMenuItem alannaBatch;
        private System.Windows.Forms.ToolStripMenuItem useNaturralFairy;
        private System.Windows.Forms.ToolStripMenuItem useGodly;
        private System.Windows.Forms.ToolStripMenuItem useTorrented;
        private System.Windows.Forms.ToolStripMenuItem useDrezDemon;
        private System.Windows.Forms.ToolStripMenuItem useRage;
        private System.Windows.Forms.ToolStripMenuItem useJalepeno;
        private System.Windows.Forms.TextBox plAtkOutput;
        private System.Windows.Forms.TextBox plDefOutput;
        private System.Windows.Forms.Label creatureInUse;
        private System.Windows.Forms.Label atkLabel;
        private System.Windows.Forms.Label spDefLabel;
        private System.Windows.Forms.Label defLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.TextBox oppAtkOutput;
        private System.Windows.Forms.TextBox oppHealthOutput;
        private System.Windows.Forms.TextBox oppDefOutput;
        private System.Windows.Forms.ToolStripMenuItem useStoneGolem;
        private System.Windows.Forms.ToolStripMenuItem useDragon;
        private System.Windows.Forms.ToolStripMenuItem useHydra;
        private System.Windows.Forms.TextBox plHealthOutput;
        private System.Windows.Forms.ToolStripMenuItem alvinBatch;
        private System.Windows.Forms.TextBox plSpDefOutput;
        private System.Windows.Forms.TextBox oppSpDefOutput;
        private System.Windows.Forms.Label oppSpDefLabel;
        private System.Windows.Forms.Label oppHealthLabel;
        private System.Windows.Forms.Label oppDefLabel;
        private System.Windows.Forms.Label oppAtkLabel;
        private System.Windows.Forms.TextBox oppNameDisplay;
        private System.Windows.Forms.TextBox statDisplay;
        private System.Windows.Forms.Label oppNameLabel;
        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.PictureBox creaturePic;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button moveBack;
        private System.Windows.Forms.GroupBox attackList;
        private System.Windows.Forms.RadioButton attack3;
        private System.Windows.Forms.RadioButton attack2;
        private System.Windows.Forms.RadioButton attack1;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button moveForward;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label gameInfo2;
        private System.Windows.Forms.Label gameInfo1;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.PictureBox bgPic;
        private System.Windows.Forms.MenuStrip gameMenu;
        private System.Windows.Forms.ToolStripMenuItem mainMenu;
        private System.Windows.Forms.ToolStripMenuItem newGame;
        private System.Windows.Forms.ToolStripMenuItem creatureMenu;
        private System.Windows.Forms.ToolStripMenuItem irisBatch;
        private System.Windows.Forms.ToolStripMenuItem useDefaultPlayer;
        private System.Windows.Forms.ToolStripMenuItem useGhost;
    }
}

