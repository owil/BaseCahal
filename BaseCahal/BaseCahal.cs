/* Iris Xu
 * Base Cahal (Game)
 * 
 * Program lets user explore Cahal cave system and battle opponents
 * Can let opponents fight each other; use opponents to battle after defeating them.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseCahal
{
    public partial class BaseCahal : Form
    {
        public BaseCahal()
        {
            InitializeComponent();
        }
        const int P_HEALTH = 100; //default player health
        const int MOB_HEALTH = 100; //default mob health, not including dragon
        const int DRAGON_HEALTH = 150; //default Dragon health
        const string DEFAULT_ATTACK = "Attack (";

        //Whether an opponent creature is defeated
        //(Default Player)-0, Ghost-1, Zombie-2, Jalepeno-3, Naturral Fairy-4, Godly-5, Torrented-6,
        //Drez Demon-7, Rage-8, Hydra-9, Dragon-10, Stone Golem-11
        Boolean[] defeated = new Boolean[12] { true, false, false, false, false, false, false, false, false, false, false, false };
        int[] atkNumber = new int[12] { 3, 1, 1, 1, 1, 1, 1, 1, 1, 3, 1, 1 }; //number of attacks for a particular opponent/creature
        Boolean[] spDefNumber = new Boolean[12] { true, false, false, false, false, false, false, false, false, false, true, true }; //Whether opponent/creature has special defense.
        Boolean[] atkRangeYes = new Boolean[12] { true, true, true, true, true, true, true, true, true, false, true , true }; //Whether the opponent/creature has attack range (e.g. 5-15)

        //List of mobs
        String[] mobNames = new String[12] {"(Default Player)","Ghost","Zombie","Jalepeno","Naturral Fairy","Godly","Torrented",
        "Drez Demon","Rage","Hydra","Dragon","Stone Golem"};

        char[] previousLocation = new char[] { 'A', 'A' }; //Starting point for going backwards
        char currentLocation = 'A'; //Current location, default at Starting point A

        //health, defense min/max, (sp.defense min/max), attacks min/max
        int[][] stats = {
                         new int[] {P_HEALTH,5,20,10,25,5,20,10,25,15,30}, //(Default Player), has sp.defense, 3 attacks "Java" "C Sharp" "HTML"
                         new int[] {MOB_HEALTH,5,10,2,7}, //Ghost, 1 attack
                         new int[] {MOB_HEALTH,5,15,5,10}, //Zombie, 1 attack
                         new int[] {MOB_HEALTH,2,10,5,15}, //Jalepeno, 1 attack
                         new int[] {MOB_HEALTH,5,20,10,15}, //Naturral Fairy, 1 attack
                         new int[] {MOB_HEALTH,5,15,10,15}, //Godly, 1 attack
                         new int[] {MOB_HEALTH,2,7,5,10}, //Torrented, 1 attack "Drown"
                         new int[] {MOB_HEALTH,5,15,10,15}, //Drez Demon, 1 attack
                         new int[] {MOB_HEALTH,5,10,5,12}, //Rage, 1 attack
                         new int[] {MOB_HEALTH,7,10,30,25,4}, //Hydra, 3 attacks "Fireball" "Flamethrower" "Toxic", "Toxic" can poison 2 damage (5 turns)
                         new int[] {DRAGON_HEALTH,10,15,5,10,10,15}, //Dragon, has sp.defense, 1 attack
                         new int[] {MOB_HEALTH,15,20,5,10,10,20}}; //Stone Golem, has sp.defense, 1 attack

        /* Zombies are weak to fire (def & sp.def max/min -2)
         * Hydra uses 2 fire moves, has sp.attack
         * If no specified sp.defense, use reg defense 
        */

        //Attack Names
        string[] atkNames = new string[7] {
            "Java (5-20 damage; default)", "C Sharp (10-25 damage; hP<60)", "HTML (15-30 damage; hP<30)", //(Default Player)
            "Fireball (30 damage)", "Flamethrower (25 damage)","Toxic (4 damage + 2 poison/5 turns)", //Hydra
            "Drown (5-10 damage)"}; //Torrented

        //used with creatureSelectionAvailability(bool battleInProgress)
        Boolean gameOngoing = false; //If currently battling opponent (used to disable creature selection screen)

        Random mobChance = new Random(); //Used to generate random number for mob type to appear

        int numMoves = 0; //counts number of moves taken from going through the cave
        int numMobs = 12; //total number of creatures, including default player
        
        int numTurnsMob = 0; //counts number of turns taken while mob is poisoned
        int numTurnsPl = 0; //counts number of turns taken while player is poisoned
        bool plPoisoned = false; //whether player is poisoned
        bool mobPoisoned = false; //whether mob is poisoned


        int playerIs = 0; //Default = (Default Player)
        int mobIs = 1; //Default = Ghost
        int[] health = new int[]{MOB_HEALTH,P_HEALTH}; //Keeps track of mob-0 and player-1 health

        //===================================================================================================
        private void startGameButton_Click(object sender, EventArgs e)
        {
            //Starts Game at Cave Room: Start A
            moveRight.Visible = true;
            moveLeft.Visible = true;
            startGameButton.Visible = false; //Makes invisible unless player starts new game.
            creaturePic.Visible = true;
            showPlayerStats(0);

            gameOngoing = false;
            creatureSelectionAvailability(gameOngoing); //Hides or shows creature selection menu
        }

        private void isDefeated()
        {
            for (int i = 0; i < numMobs; ++i)
            {
                if (i == 1) //Ghost
                    useGhost.Visible = defeated[i];
                else if (i == 2) //Zombie
                    useZombie.Visible = defeated[i];
                else if (i == 3) //Jalepeno
                    useJalepeno.Visible = defeated[i];
                else if (i == 4) //Naturral Fairy
                    useNaturralFairy.Visible = defeated[i];
                else if (i == 5) //Godly
                    useGodly.Visible = defeated[i];
                else if (i == 6) //Torrented
                    useTorrented.Visible = defeated[i];
                else if (i == 7) //Drez Demon
                    useDrezDemon.Visible = defeated[i];
                else if (i == 8) //Rage
                    useRage.Visible = defeated[i];
                else if (i == 9) //Hydra
                    useHydra.Visible = defeated[i];
                else if (i == 10) //Dragon
                    useDragon.Visible = defeated[i];
                else if (i == 11) //Stone Golem
                    useStoneGolem.Visible = defeated[i];
            }
        }

        private void creatureSelectionAvailability(bool battleInProgress)
        {
            if (battleInProgress) //If true
            {
                creatureMenu.Visible = false; //Hides creature selection menu
            }
            else //If false
            {
                creatureMenu.Visible = true; //Shows creature selection menu
            }
        }

        private char CaveSystemMove(char moveWhere, char currentLoc)
        {
            //For calculating next location
            //Need array
            char nextLoc = 'A'; //next place to go, default Start A

            gameOngoing = false; //Stops battle
            creatureSelectionAvailability(gameOngoing); //Hides or shows creature selection menu
            numTurnsMob = 0; //Resets number of turns taken while mob is poisoned
            numTurnsPl = 0; //Resets number of turns taken while player is poisoned
            mobPoisoned = false;
            plPoisoned = false;
            creaturePic.Image = Properties.Resources.Mist_BaseCahal; //Changes picture to mist
            creaturePic.Enabled = true; //Enables user to click on image to attack again.
            creaturePic.Visible = true; //Makes picture visible again.

            /* moveWhere
             * 'B' ==> Back
             * 'P' ==> Proceed
             * 'R' ==> Right
             * 'L' ==> Left
            */

            /* Start A ==> Right F, Left B
             * Right F ==> Right G, Left H
             * Right G & Left H ==> Proceed I
             * Left B ==> Proceed C
             * Proceed C -> Right D, Left E
             * Right D & Left E ==> Proceed K
             * Proceed I & Proceed K ==> End J
            */

            switch (currentLoc)
            {
                case 'B': //Left B
                    if (moveWhere == 'B')
                    {
                        nextLoc = 'A';
                    }
                    else //moveWhere == 'P'
                    {
                        nextLoc = 'C';
                    }
                    break;
                case 'C': //Proceed C
                    if (moveWhere == 'R')
                    {
                        nextLoc = 'D';
                    }
                    else if (moveWhere == 'L')
                    {
                        nextLoc = 'E';
                    }
                    else
                    {
                        nextLoc = 'B';
                    }
                    break;
                case 'D': //Right D
                case 'E': //Left E
                    if (moveWhere == 'B')
                    {
                        nextLoc = 'C';
                    }
                    else //moveWhere == 'P'
                    {
                        nextLoc = 'K';
                    }
                    if (currentLoc == 'D')
                        previousLocation[0] = 'D';
                    else
                        previousLocation[0] = 'E';
                    break;
                case 'F': //Right F
                    if (moveWhere == 'R')
                    {
                        nextLoc = 'G';
                    }
                    else if (moveWhere == 'L')
                    {
                        nextLoc = 'H';
                    }
                    else
                    {
                        nextLoc = 'A';
                    }
                    break;
                case 'G': //Right G
                case 'H': //Left H
                    if (moveWhere == 'B')
                    {
                        nextLoc = 'F';
                    }
                    else //moveWhere == 'P'
                    {
                        nextLoc = 'I';
                    }
                    if (currentLoc == 'G')
                        previousLocation[0] = 'G';
                    else
                        previousLocation[0] = 'H';

                    break;
                case 'I': //Proceed I
                case 'K': //Proceed K
                    if (moveWhere == 'B')
                    {
                        nextLoc = previousLocation[0];
                    }
                    else //moveWhere == 'P'
                    {
                        nextLoc = 'J';
                    }
                    if (currentLoc == 'I')
                        previousLocation[1] = 'I';
                    else
                        previousLocation[1] = 'K';

                    break;
                case 'J': //currentLocation = End J
                    if (moveWhere == 'B')
                        nextLoc = previousLocation[1];
                    break;
                default: //currentLocation = Start A
                    if (moveWhere == 'R')
                    {
                        nextLoc = 'F';
                    }
                    else //moveWhere == 'L'
                    {
                        nextLoc = 'B';
                    }
                    break;
            }
            return nextLoc;
        }

        private void displayMoveButtons(char currentLoc)
        {
            //Changes display of move buttons as you go through cave rooms
            //Changes bgPic background image.

            if (currentLoc == 'B') //Left B
            {
                bgPic.Image = Properties.Resources.CaveB;
                moveBack.Visible = true;
                moveForward.Visible = true;
                moveLeft.Visible = false;
                moveRight.Visible = false;
            }
            else if (currentLoc == 'C') //Proceed C
            {
                bgPic.Image = Properties.Resources.CaveC;
                moveBack.Visible = true;
                moveForward.Visible = false;
                moveLeft.Visible = true;
                moveRight.Visible = true;
            }
            else if (currentLoc == 'D' || currentLoc == 'E') //Right D, Left E
            {
                if (currentLoc == 'D')
                    bgPic.Image = Properties.Resources.CaveD;
                else
                    bgPic.Image = Properties.Resources.CaveE;
                moveBack.Visible = true;
                moveForward.Visible = true;
                moveLeft.Visible = false;
                moveRight.Visible = false;
            }
            else if (currentLoc == 'F') //Right F
            {
                bgPic.Image = Properties.Resources.CaveF;
                moveBack.Visible = true;
                moveForward.Visible = false;
                moveLeft.Visible = true;
                moveRight.Visible = true;
            }
            else if (currentLoc == 'G' || currentLoc == 'H') //Right G, Left H
            {
                if (currentLoc == 'G')
                    bgPic.Image = Properties.Resources.CaveG;
                else
                    bgPic.Image = Properties.Resources.CaveH;
                moveBack.Visible = true;
                moveForward.Visible = true;
                moveLeft.Visible = false;
                moveRight.Visible = false;
            }
            else if (currentLoc == 'I' || currentLoc == 'K') //Proceed I, Proceed K
            {
                if (currentLoc == 'I')
                    bgPic.Image = Properties.Resources.CaveI;
                else
                    bgPic.Image = Properties.Resources.CaveK;
                moveBack.Visible = true;
                moveForward.Visible = true;
                moveLeft.Visible = false;
                moveRight.Visible = false;
            }
            else if (currentLoc == 'J') //currentLocation = End J
            {
                bgPic.Image = Properties.Resources.CaveJ;
                moveBack.Visible = true;
                moveForward.Visible = false;
                moveLeft.Visible = false;
                moveRight.Visible = false;
            }
            else //currentLocation = Start A
            {
                bgPic.Image = Properties.Resources.CaveA;
                moveBack.Visible = false;
                moveForward.Visible = false;
                moveLeft.Visible = true;
                moveRight.Visible = true;
            }
            statDisplay.Text = ""; //Resets Turn Summary text
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            ++numMoves;
            currentLocation = CaveSystemMove('L', currentLocation);
            displayMoveButtons(currentLocation);
            currentLocationMessage(currentLocation);

            creaturePic.Visible = true;
            displayReset(); //Resets attackButton Visibility + Opponent stat display
            showPlayerStats(playerIs);
            health = new int[] { MOB_HEALTH, P_HEALTH };
            attack1.Checked = true; //Default player attack radio button 1 is selected
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            ++numMoves;
            currentLocation = CaveSystemMove('R', currentLocation);
            displayMoveButtons(currentLocation);
            currentLocationMessage(currentLocation);

            creaturePic.Visible = true;
            displayReset(); //Resets attackButton Visibility + Opponent stat display
            showPlayerStats(playerIs);
            health = new int[] { MOB_HEALTH, P_HEALTH };
            attack1.Checked = true; //Default player attack radio button 1 is selected
        }

        private void moveForward_Click(object sender, EventArgs e)
        {
            ++numMoves;
            currentLocation = CaveSystemMove('P', currentLocation);
            displayMoveButtons(currentLocation);
            currentLocationMessage(currentLocation);

            creaturePic.Visible = true;
            displayReset(); //Resets attackButton Visibility + Opponent stat display
            showPlayerStats(playerIs);
            health = new int[] { MOB_HEALTH, P_HEALTH };
            attack1.Checked = true; //Default player attack radio button 1 is selected
        }

        private void moveBack_Click(object sender, EventArgs e)
        {
            ++numMoves;
            currentLocation = CaveSystemMove('B', currentLocation);
            displayMoveButtons(currentLocation);
            currentLocationMessage(currentLocation);

            creaturePic.Visible = true;
            displayReset(); //Resets attackButton Visibility + Opponent stat display
            showPlayerStats(playerIs);
            health = new int[] { MOB_HEALTH, P_HEALTH };
            attack1.Checked = true; //Default player attack radio button 1 is selected
        }

        private void currentLocationMessage(char loc)
        {
            string message = "You have moved to Cave Room " + Convert.ToString(loc) +
                ". Num Moves " + Convert.ToString(numMoves) + ".";
            MessageBox.Show(message, "Your New Location");
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            //Resets Values
            numMoves = 0;
            numTurnsMob = 0; //Resets number of turns taken while mob is poisoned
            numTurnsPl = 0; //Resets number of turns taken while player is poisoned
            mobPoisoned = false;
            plPoisoned = false;
            playerIs = 0; //Default = (Default Player)
            mobIs = 1; //Default = Ghost
            health = new int[] { MOB_HEALTH, P_HEALTH };
            attack1.Checked = true; //Default player attack radio button 1 is selected

            gameOngoing = false;
            creatureSelectionAvailability(true); //Hides or shows creature selection menu (True = Hide; hides before starting game)
            creaturePic.Enabled = true; //If false, stops user from changing mob type by clicking the image again.

            previousLocation = new char[] { 'A', 'A' };
            currentLocation = 'A';
            defeated = new Boolean[12] { true, false, false, false, false, false, false, false, false, false, false, false };
            isDefeated(); //Fixes visibility of creature selection

            creaturePic.Visible = false;
            creaturePic.Image = Properties.Resources.Mist_BaseCahal;
            bgPic.Image = Properties.Resources.CaveA;

            //==========================
            moveRight.Visible = false;
            moveLeft.Visible = false;
            moveForward.Visible = false;
            moveBack.Visible = false;

            startGameButton.Visible = true;
            displayReset(); //Resets attackButton Visibility + Opponent stat display

            creatureInUse.Text = mobNames[0];
            plHealthOutput.Text = "";
            plDefOutput.Text = "";
            plSpDefOutput.Text = "";
            plAtkOutput.Text = "";

            statDisplay.Text = "";
        }

        //Resets visibility of certain commonly used settings
        private void displayReset()
        {
            attackButton.Visible = false;

            if (playerIs == 0) //Resets (Default Player) attack visibility
            {
                attack2.Visible = false;
                attack3.Visible = false;
            }
            //==========================
            oppNameDisplay.Text = "";
            oppHealthOutput.Text = "";
            oppDefOutput.Text = "";
            oppSpDefOutput.Text = "";
            oppAtkOutput.Text = "";
        }

        private void creaturePic_Click(object sender, EventArgs e)
        {
            int attackingMob = mobChance.Next(0, 39);
            attack1.Checked = true; //Default player attack radio button 1 is selected
            gameOngoing = true;
            creatureSelectionAvailability(gameOngoing); //Hides or shows creature selection menu
            creaturePic.Enabled = false; //If false, stops user from changing mob type by clicking the image again.

            if (attackingMob > 2) //If mob is not empty (i.e. not 0,1, or 2)
                attackButton.Visible = true;

            string mobName = ""; //to be used to label name of mob, mobNames[]

            //================================================================
            if (attackingMob <= 2) //No Mob (0,1,2)
            {
                mobName = "nothing";
                creaturePic.Visible = false;
            }
            else if (attackingMob <= 7) //Ghost (4,5,6,7)
            {
                showOppStats(1);
                mobName = mobNames[1];
                creaturePic.Image = Properties.Resources.GhostSprite;
                mobIs = 1;
            }
            else if (attackingMob <= 11) //Zombie (8,9,10,11)
            {
                showOppStats(2);
                mobName = mobNames[2];
                creaturePic.Image = Properties.Resources.ZombieSprite;
                mobIs = 2;
            }
            else if (attackingMob <= 15) //Jalepeno (12,13,14,15)
            {
                showOppStats(3);
                mobName = mobNames[3];
                creaturePic.Image = Properties.Resources.JalepenoSprite;
                mobIs = 3;
            }
            else if (attackingMob <= 19) //Naturral Fairy (16,17,18,19)
            {
                showOppStats(4);
                mobName = mobNames[4];
                creaturePic.Image = Properties.Resources.NaturralFairySprite;
                mobIs = 4;
            }
            else if (attackingMob <= 23) //Godly (20,21,22,23)
            {
                showOppStats(5);
                mobName = mobNames[5];
                creaturePic.Image = Properties.Resources.GodlySprite;
                mobIs = 5;
            }
            else if (attackingMob <= 27) //Torrented (24,25,26,27)
            {
                showOppStats(6);
                mobName = mobNames[6];
                creaturePic.Image = Properties.Resources.TorrentedSprite;
                mobIs = 6;
            }
            else if (attackingMob <= 31) //Drez Demon (28,29,30,31)
            {
                showOppStats(7);
                mobName = mobNames[7];
                creaturePic.Image = Properties.Resources.DrezDemonSprite;
                mobIs = 7;
            }
            else if (attackingMob <= 35) //Rage (32,33,34,35)
            {
                showOppStats(8);
                mobName = mobNames[8];
                creaturePic.Image = Properties.Resources.RageSprite;
                mobIs = 8;
            }
            else if (attackingMob == 36) //Hydra, lesser chance (36)
            {
                showOppStats(9);
                mobName = mobNames[9];
                creaturePic.Image = Properties.Resources.HydraSprite;
                mobIs = 9;
            }
            else if (attackingMob <= 38) //Dragon (37,38)
            {
                showOppStats(10);
                mobName = mobNames[10];
                creaturePic.Image = Properties.Resources.DragonSprite;
                mobIs = 10;
            }
            else if (attackingMob == 39) //Stone Golem, lesser chance (39)
            {
                showOppStats(11);
                mobName = mobNames[11];
                creaturePic.Image = Properties.Resources.StoneGolemSprite;
                mobIs = 11;
            }
            //=============================================================
            if (currentLocation == 'J')
            {
                showOppStats(11);
                mobName = mobNames[11]; //Stone Golem 100% for End J
                creaturePic.Image = Properties.Resources.StoneGolemSprite;
                mobIs = 11;
            }
            //=============================================================
            MessageBox.Show("You encounter " + Convert.ToString(mobName), "Mob Type");
        }

        private void showOppStats(int mobID)
        {
            //ID# of mob, number of attacks, has special defense, has no attack range (e.g. 25, as opposed to 5-10)
            int arrayLength = stats[mobID].Length; //length of particular jagged array
            int numAtk = atkNumber[mobID]; //Number of attacks for the particular mob
            bool spDef = spDefNumber[mobID]; //Whether mob has special defense.
            bool hasAtkRange = atkRangeYes[mobID]; //Whether the mob has attack range (e.g. 5-15)
 
            oppNameDisplay.Text = mobNames[mobID];
            oppHealthOutput.Text = Convert.ToString(stats[mobID][0]);
            oppDefOutput.Text = Convert.ToString(stats[mobID][1]) + "-" + Convert.ToString(stats[mobID][2]);

            //===================================================================================================
            if(spDef) //displays if special defense is listed (true)
                oppSpDefOutput.Text = Convert.ToString(stats[mobID][3]) + "-" + Convert.ToString(stats[mobID][4]);
            else //if not listed, use regular defense
                oppSpDefOutput.Text = Convert.ToString(stats[mobID][1]) + "-" + Convert.ToString(stats[mobID][2]);

            //===================================================================================================
            oppAtkOutput.Text = ""; //Reset Attack Output before adding
            if(hasAtkRange == true) //Has attack range (e.g. 5-15)
            {
                if (numAtk > 1) //adds on move stats
                {
                    for(int i = numAtk; i >= 1; --i) //E.g.)3, 2--arrayLength=12
                    {
                        oppAtkOutput.Text += Convert.ToString(stats[mobID][arrayLength-(i*2)])+"-"+
                            Convert.ToString(stats[mobID][arrayLength-(i*2-1)])+". ";
	                }		
	                //E.g.)3: 12-6=6, 12-5=7. 2: 12-4=8, 12-3=9. 1: 12-2=10, 12-1=11.
                }
                else //numAtk = 1
                {
                    oppAtkOutput.Text += Convert.ToString(stats[mobID][arrayLength - 2])+"-"+
                        Convert.ToString(stats[mobID][arrayLength-1]);
                }
            }
            else //No attack range (e.g. 24)
            {
                if (numAtk > 1) //adds on move stats
                {
	                for(int i = numAtk; i >= 1; --i) //E.g.) 3, 2--arrayLength=12
	                {
		                oppAtkOutput.Text += Convert.ToString(stats[mobID][arrayLength-i])+". ";
	                }
	            //E.g.)3: 12-3=9. 2: 12-2=10. 1: 12-1=11.
                }
                else //numAtk = 1
                {
		            oppAtkOutput.Text += Convert.ToString(stats[mobID][arrayLength - 1]);
                }
            }
            //===================================================================================================
        }

        private void showPlayerStats(int mobID)
        {
            //ID# of mob, number of attacks, has special defense, has no attack range (e.g. 25, as opposed to 5-10)
            int arrayLength = stats[mobID].Length; //length of particular jagged array
            int numAtk = atkNumber[mobID]; //Number of attacks for the player
            bool spDef = spDefNumber[mobID]; //Whether player has special defense.
            bool hasAtkRange = atkRangeYes[mobID]; //Whether the player has attack range (e.g. 5-15)

            creatureInUse.Text = mobNames[mobID];
            plHealthOutput.Text = Convert.ToString(stats[mobID][0]);
            plDefOutput.Text = Convert.ToString(stats[mobID][1]) + "-" + Convert.ToString(stats[mobID][2]);

            //===================================================================================================
            if(spDef) //displays if special defense is listed (true)
                plSpDefOutput.Text = Convert.ToString(stats[mobID][3]) + "-" + Convert.ToString(stats[mobID][4]);
            else //if not listed, use regular defense
                plSpDefOutput.Text = Convert.ToString(stats[mobID][1]) + "-" + Convert.ToString(stats[mobID][2]);

            //===================================================================================================
            plAtkOutput.Text = ""; //Reset Attack Output before adding
            if(hasAtkRange == true) //Has attack range (e.g. 5-15)
            {
                if (numAtk > 1) //adds on move stats
                {
                    for(int i = numAtk; i >= 1; --i) //E.g.)2, 3--arrayLength=11
                    {
                        plAtkOutput.Text += Convert.ToString(stats[mobID][arrayLength-(i*2)])+"-"+
                            Convert.ToString(stats[mobID][arrayLength-(i*2-1)])+". ";
	                }		
	                //E.g.)1: 12-1-5=6, 12-1-4=7. 2: 12-2-2=8, 12-2-1=9. 3: 12-3+1=10, 12-3+2=11.
                }
                else //numAtk = 1
                {
                    plAtkOutput.Text += Convert.ToString(stats[mobID][arrayLength - 2])+"-"+
                        Convert.ToString(stats[mobID][arrayLength-1]);
                }
            }
            else //No attack range (e.g. 24)
            {
                if (numAtk > 1) //adds on move stats
                {
	                for(int i = numAtk; i >= 1; --i) //E.g.) 3, 2--arrayLength=12
	                {
		                plAtkOutput.Text += Convert.ToString(stats[mobID][arrayLength-i])+". ";
	                }
	            //E.g.)3: 12-3=9. 2: 12-2=10. 1: 12-1=11.
                }
                else //numAtk = 1
                {
		            plAtkOutput.Text += Convert.ToString(stats[mobID][arrayLength - 1]);
                }
            }
            //===================================================================================================
        }

        private int[] battle(int mobAtkNum, int plAtkNum)
        {
            //Mob Health, Player Health
            int[] hp = new int[2] { health[0], health[1]};

            int mobDefType = 1; //Default array location for regular defense,
            //can be used in place of special defense or replaced with location of special defense
            int plDefType = 1; //Default array location for regular defense,
            //can be used in place of special defense or replaced with location of special defense
            
            //Calculates Defense and Attack values for this turn.
            int mobDef = 0;
            int plDef = 0;
            int mobAtk = 1;
            int plAtk = 1;

            if (atkRangeYes[mobIs] == true)
            {
                mobAtk = mobChance.Next(
                    stats[mobIs][stats[mobIs].Length - (mobAtkNum * 2)],
                    stats[mobIs][stats[mobIs].Length - (mobAtkNum * 2 - 1)]); //Mob Attack
            }
            else if(atkRangeYes[mobIs] == false) //no attack range Mob
                mobAtk = stats[mobIs][stats[mobIs].Length - (mobAtkNum)];
            if (atkRangeYes[playerIs] == true)
            {
                plAtk = mobChance.Next(
                    stats[playerIs][stats[playerIs].Length - (plAtkNum * 2)],
                    stats[playerIs][stats[playerIs].Length - (plAtkNum * 2 - 1)]); //Player Attack
            }
            else if (atkRangeYes[playerIs] == false) //no attack range Player
                plAtk = stats[playerIs][stats[playerIs].Length - (plAtkNum)];

            mobDef = mobChance.Next(stats[mobIs][mobDefType], stats[mobIs][mobDefType + 1]); //Mob Defense
            plDef = mobChance.Next(stats[playerIs][plDefType], stats[playerIs][plDefType + 1]); //Player Defense

            if (playerIs == 9) //Using Hydra
            {
                if (spDefNumber[mobIs])
                    mobDef = mobChance.Next(stats[mobIs][mobDefType + 2], stats[mobIs][mobDefType + 3]); //Mob Defense
                else //no special defense, use regular defense
                    mobDef = mobChance.Next(stats[mobIs][mobDefType], stats[mobIs][mobDefType + 1]);
            }
            if (mobIs == 9) //Dealing with Hydra
            {
                if (spDefNumber[playerIs])
                    plDef = mobChance.Next(stats[playerIs][plDefType + 2], stats[playerIs][plDefType + 3]); //Player Defense
                else //no special defense, use regular defense
                    plDef = mobChance.Next(stats[playerIs][plDefType], stats[playerIs][plDefType + 1]);
            }

            int mobHpDecrease = 0; //Decrease to Mob Health
            int plHpDecrease = 0; //Decrease to Player Health

            //Special Circumstance: Fire Weakness
            if (playerIs == 2 && mobIs == 9 && mobAtkNum > 1) //Player: Zombie | Mob: Hydra (using Fireball or Flamethrower)
                plDef -= 2; //Fire weakness, player health takes extra 2 damage
            else if (mobIs == 2 && playerIs == 9 && plAtkNum > 1) //Mob: Zombie | Player: Hydra (using Fireball or Flamethrower)
                mobDef -= 2; //Fire weakness, mob health takes extra 2 damage

            //Calculates Outcome on Health.
            if (mobDef < plAtk)
                mobHpDecrease += plAtk - mobDef;
            else
                mobHpDecrease += 0;
            if (plDef < mobAtk)
                plHpDecrease += mobAtk - plDef;
            else
                plHpDecrease += 0;
            
            //===POISON==================================================================================================
            if (numTurnsMob >= 5) //Reset counter for Mob poisoned
            {
                MessageBox.Show("Mob is no longer poisoned.");
                numTurnsMob = 0; //Resets number of turns taken while mob is poisoned
                mobPoisoned = false;
            }
            if (numTurnsPl >= 5) //Reset counter for Player poisoned
            {
                MessageBox.Show("Player is no longer poisoned.");
                numTurnsPl = 0; //Resets number of turns taken while player is poisoned
                plPoisoned = false;
            }

            //Special Circumstance: Hydra uses "Toxic"
            //"Toxic" has poison +2 damage for 5 turns (numTurns: 0,1,2,3,4) including turn when toxic is selected.
            //If already poisoned, effects do not compound
            if (plPoisoned == true && numTurnsPl < 5)
            {
                MessageBox.Show("Player Poisoned! Turn: " + Convert.ToString(numTurnsPl));
                plHpDecrease += 2;
                ++numTurnsPl;
            }
            if (mobPoisoned == true && numTurnsMob < 5)
            {
                MessageBox.Show("Mob Poisoned! Turn: " + Convert.ToString(numTurnsMob));
                mobHpDecrease += 2;
                ++numTurnsMob;
            }
            //===========================================================================================================

            hp[0] -= mobHpDecrease; //Health of Mob after player attack
            hp[1] -= plHpDecrease; //Health of Player after mob attack

            statDisplay.Text = "Damage to Player: " + Convert.ToString(plHpDecrease) + ". Damage to Mob: " + Convert.ToString(mobHpDecrease) + ".";
            return hp;
        }

        //For number of Attacks = 1, Player options
        private void displayAttackType(bool hasAtkRange)
        {
            attack1.Visible = true;
            attack2.Visible = false;
            attack3.Visible = false;

            int arrayLength = stats[playerIs].Length;
            if (hasAtkRange) //true
            {
                attack1.Text = DEFAULT_ATTACK +
                    Convert.ToString(stats[playerIs][arrayLength - 2]) + "-" +
                    Convert.ToString(stats[playerIs][arrayLength - 1]) + " damage)";
            }
            else //does not have attack range
                attack1.Text = DEFAULT_ATTACK + Convert.ToString(stats[playerIs][arrayLength - 1]) + " damage)";
        }

        //Selecting Default Player
        private void useDefaultPlayer_Click(object sender, EventArgs e)
        {
            showPlayerStats(0);
            attack1.Visible = true;
            attack2.Visible = false;
            attack3.Visible = false;
            playerIs = 0;

            attack1.Text = atkNames[0];
            attack2.Text = atkNames[1];
            attack3.Text = atkNames[2];
        }

        private void useGhost_Click(object sender, EventArgs e)
        {
            showPlayerStats(1);;
            playerIs = 1;
            displayAttackType(atkRangeYes[1]); //For number of Attacks = 1
        }

        private void useZombie_Click(object sender, EventArgs e)
        {
            showPlayerStats(2);
            playerIs = 2;
            displayAttackType(atkRangeYes[2]); //For number of Attacks = 1
        }

        private void useJalepeno_Click(object sender, EventArgs e)
        {
            showPlayerStats(3);
            playerIs = 3;
            displayAttackType(atkRangeYes[3]); //For number of Attacks = 1
        }

        private void useNaturralFairy_Click(object sender, EventArgs e)
        {
            showPlayerStats(4);
            playerIs = 4;
            displayAttackType(atkRangeYes[4]); //For number of Attacks = 1
        }

        private void useGodly_Click(object sender, EventArgs e)
        {
            showPlayerStats(5);
            playerIs = 5;
            displayAttackType(atkRangeYes[5]); //For number of Attacks = 1
        }

        private void useTorrented_Click(object sender, EventArgs e)
        {
            showPlayerStats(6);
            playerIs = 6;
            attack1.Text = atkNames[6];
            displayAttackType(atkRangeYes[6]); //For number of Attacks = 1
        }

        private void useDrezDemon_Click(object sender, EventArgs e)
        {
            showPlayerStats(7);
            playerIs = 7;
            displayAttackType(atkRangeYes[7]); //For number of Attacks = 1
        }

        private void useRage_Click(object sender, EventArgs e)
        {
            showPlayerStats(8);
            playerIs = 8;
            displayAttackType(atkRangeYes[8]); //For number of Attacks = 1
        }

        private void useHydra_Click(object sender, EventArgs e)
        {
            showPlayerStats(9);
            attack1.Visible = true;
            attack2.Visible = true;
            attack3.Visible = true;
            playerIs = 9;

            attack1.Text = atkNames[3];
            attack2.Text = atkNames[4];
            attack3.Text = atkNames[5];
        }

        private void useDragon_Click(object sender, EventArgs e)
        {
            showPlayerStats(10);
            playerIs = 10;
            displayAttackType(atkRangeYes[10]); //For number of Attacks = 1
        }

        private void useStoneGolem_Click(object sender, EventArgs e)
        {
            showPlayerStats(11);
            playerIs = 11;
            displayAttackType(atkRangeYes[11]); //For number of Attacks = 1
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            int plAtkNum = 1; //Default number of attacks for player
            int mobAtkNum = mobChance.Next(1,atkNumber[mobIs]); //Randomly choses one of a mob's attack (from descending order)
                                                                //For atkNumber[mobIs] > 1, attack1 ==> 3, attack2 ==> 2, attack3 ==> 1
            //======FOR PLAYER HAVING MORE THAN ONE ATTACK=========
            if (atkNumber[playerIs] > 1 && attack1.Checked)
                plAtkNum = 3;
            else if (atkNumber[playerIs] > 1 && attack2.Checked)
                plAtkNum = 2;
            else if (atkNumber[playerIs] > 1 && attack3.Checked)
                plAtkNum = 1;

            //===============Hydra uses "Toxic"====================
            if (playerIs == 9 && attack3.Checked == true) //Player is Hydra and uses "Toxic"
                mobPoisoned = true;
            if (mobIs == 9 && mobAtkNum == 1) //Mob is Hydra and uses "Toxic"
                plPoisoned = true;

            //Calculates Mob Health-0 and Player Health-1
            health = battle(mobAtkNum,plAtkNum);

            //=======SPECIAL CIRCUMSTANCES=======
            if (playerIs == 0 && health[1] < 60)
                attack2.Visible = true;
            if (playerIs == 0 && health[1] < 30)
                attack3.Visible = true;
            //===================================

            //Note: if both health <= 0, winner is the one with greater health.
            if ((health[0] <= 0) && (health[1] <= 0)) //Both Mob and Player health <= 0
            {
                gameOngoing = false;
                plPoisoned = false; //whether player is poisoned
                mobPoisoned = false; //whether mob is poisoned
                creatureSelectionAvailability(gameOngoing); //Hides or shows creature selection menu
                creaturePic.Visible = false;
                attackButton.Visible = false;
                showPlayerStats(playerIs); //Resets player stat display

                if (health[0] < health[1]) //Mob health < Player Health
                {
                    statDisplay.Text = "Player wins.";
                    defeated[mobIs] = true;
                    isDefeated();
                }
                else if (health[0] > health[1]) //Mob health > Player Health
                {
                    statDisplay.Text = mobNames[mobIs] + " wins.";
                }
                else
                    statDisplay.Text = "Tied game.";
            }
            else if ((health[0] <= 0) && (health[1] > 0)) //Mob health <= 0, Player health > 0
            {
                gameOngoing = false;
                plPoisoned = false; //whether player is poisoned
                mobPoisoned = false; //whether mob is poisoned
                creaturePic.Visible = false;
                attackButton.Visible = false;
                showPlayerStats(playerIs); //Resets player stat display
                statDisplay.Text = "Player wins.";
                defeated[mobIs] = true;
                isDefeated();
            }
            else if ((health[0] > 0) && (health[1] <= 0)) //Mob health > 0, Player health <= 0
            {
                gameOngoing = false;
                plPoisoned = false; //whether player is poisoned
                mobPoisoned = false; //whether mob is poisoned
                creaturePic.Visible = false;
                attackButton.Visible = false;
                showPlayerStats(playerIs); //Resets player stat display
                statDisplay.Text = mobNames[mobIs] + " wins.";
            }
            //Otherwise, Mob and Player health both > 0

            oppHealthOutput.Text = Convert.ToString(health[0]);
            plHealthOutput.Text = Convert.ToString(health[1]);
        }

    }
}
