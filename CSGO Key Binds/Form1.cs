using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGO_Buy_Binds_Generator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        string keys = "";
        string primary = "";
        string rifles = "";
        string smgs = "";
        string heavys = "";
        string secondary = "";
        string gear1 = "";
        string gear2 = "";
        string gear3 = "";
        string gear4 = "";
        string grenades = "";
        int riflecost = 0;
        int smgcost = 0;
        int heavycost = 0;
        int secondarycost = 0;
        int armortotalcost = 0;
        int geartotalcost = 0;
        int nadetotalcost = 0;
        int primarytotalcost = 0;
        int secondarytotalcost = 0;
        int totalcost = 0;
        bool otherkeys = false;
        int nadelimit = 0;

        private void generateButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "bind " + keys + "\"" + primary + secondary + gear1 + gear2 + gear3 + gear4 + grenades + "\""; 
        }
        
        private void gearCheck(object sender, EventArgs e)
        {
            int defusercost = 0;
            int zeuscost = 0;    

            if (gearCheck3.Checked)
            {
                gear3 = "buy defuser; ";
                defusercost = 400;
            }  
            else gear3 = "";

            if (gearCheck4.Checked)
            {
                gear4 = "buy taser; ";
                zeuscost = 200;
            }
            else gear4 = "";

            geartotalcost = defusercost + zeuscost;
            totalcost = armortotalcost + geartotalcost + nadetotalcost + primarytotalcost + secondarytotalcost;
            priceLabel.Text = "$" + totalcost;
            resultBox.Text = "bind " + keys + "\"" + primary + secondary + gear1 + gear2 + gear3 + gear4 + grenades + "\"";

        }
        private void kevlarChecked(object sender, EventArgs e)
        {
            int kevlarcost = 0;
            int kevlarhelmcost = 0;

            if (kevlarRadio.Checked)
            {
                gear1 = "buy vest; ";
                kevlarcost = 650;
            }
            else gear1 = "";

            if (kevlarhelmRadio.Checked)
            {
                gear2 = "buy vesthelm; ";
                kevlarhelmcost = 1000;
            }
            else gear2 = "";

            armortotalcost = kevlarcost + kevlarhelmcost;
            totalcost = armortotalcost + geartotalcost + nadetotalcost + primarytotalcost + secondarytotalcost;
            priceLabel.Text = "$" + totalcost;
            resultBox.Text = "bind " + keys + "\"" + primary + secondary + gear1 + gear2 + gear3 + gear4 + grenades + "\"";
        }

        private void nadeCheck(object sender, EventArgs e)
        {
            string decoy = "";
            string flashbang = "";
            string smoke = "";
            string he = "";
            string molotov = "";
            string flashbang2 = "";
            string incendiary = "";
            int decoycost = 0;
            int flashbangcost = 0;
            int smokecost = 0;
            int hecost = 0;
            int molotovcost = 0;
            int flashbang2cost = 0;
            int incendiarycost = 0;

            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                nadelimit += 1;
            }
            else nadelimit -= 1;

            if (nadelimit > 4)
            {
                MessageBox.Show("You can only select up to four grenades.");
                cb.Checked = false;
            }

            // Buys below

            if (nadeCheck7.Checked)
            {
                incendiary = "buy incgrenade; ";
                incendiarycost = 600;
            }
            else incendiary = "";

            if (nadeCheck1.Checked)
            {
                decoy = "buy decoy; ";
                decoycost = 50;
            }
            else decoy = "";

            if (nadeCheck2.Checked)
            {
                flashbang = "buy flashbang; ";
                flashbangcost = 200;
            }
            else flashbang = "";

            if (nadeCheck3.Checked)
            {
                smoke = "buy smokegrenade; ";
                smokecost = 300;
            }
            else smoke = "";

            if (nadeCheck4.Checked)
            {
                he = "buy hegrenade; ";
                hecost = 300;
            }
            else he = "";

            if (nadeCheck5.Checked)
            {
                molotov = "buy molotov; ";
                molotovcost = 400;
            }
            else molotov = "";

            if (nadeCheck6.Checked)
            {
                flashbang2 = "buy flashbang; ";
                flashbang2cost = 200;
            }
            else flashbang2 = "";

            nadetotalcost = decoycost + flashbangcost + flashbang2cost + smokecost + hecost + incendiarycost + molotovcost;
            totalcost = armortotalcost + geartotalcost + nadetotalcost + primarytotalcost + secondarytotalcost;
            priceLabel.Text = "$" + totalcost;
            grenades = decoy + flashbang + smoke + he + molotov + flashbang2 + incendiary;
            resultBox.Text = "bind " + keys + "\"" + primary + secondary + gear1 + gear2 + gear3 + gear4 + grenades + "\"";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            noarmorRadio.Checked = true;
            kevlarRadio.Checked = false;
            kevlarhelmRadio.Checked = false;
            gearCheck3.Checked = false;
            gearCheck4.Checked = false;
            nadeCheck1.Checked = false;
            nadeCheck2.Checked = false;
            nadeCheck3.Checked = false;
            nadeCheck4.Checked = false;
            nadeCheck5.Checked = false;
            nadeCheck6.Checked = false;
            nadeCheck7.Checked = false;
            noneRadio.Checked = true;
            none2Radio.Checked = true;
            keyLabel.Text = "None";
            keys = "";
            primaryList.SelectedIndex = -1;
            smgList.SelectedIndex = -1;
            heavyList.SelectedIndex = -1;
            secondaryList.SelectedIndex = -1;
            noteLabel.Visible = true;
            resultBox.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "")
            {
                return;
            }
            System.Windows.Forms.Clipboard.SetText(resultBox.Text);
        }

        private void primaryChecked(object sender, EventArgs e)
        {
            switch (primaryList.SelectedIndex)
            {
                case 0:
                    rifles = "buy ak47; ";
                    riflecost = 2700;
                    break;
                case 1:
                    rifles = "buy m4a1_silencer; ";
                    riflecost = 3100;
                    break;
                case 2:
                    rifles = "buy m4a4; ";
                    riflecost = 3100;
                    break;
                case 3:
                    rifles = "buy galilar; ";
                    riflecost = 2000;
                    break;
                case 4:
                    rifles = "buy famas; ";
                    riflecost = 2250;
                    break;
                case 5:
                    rifles = "buy sg008; ";
                    riflecost = 1700;
                    break;
                case 6:
                    rifles = "buy g3sg1; ";
                    riflecost = 5000;
                    break;
                case 7:
                    rifles = "buy scar20; ";
                    riflecost = 5000;
                    break;
                case 8:
                    rifles = "buy awp; ";
                    riflecost = 4750;
                    break;
            }
            switch (heavyList.SelectedIndex)
            {
                case 0:
                    heavys = "buy nova; ";
                    heavycost = 1200;
                    break;
                case 1:
                    heavys = "buy xm1014; ";
                    heavycost = 2000;
                    break;
                case 2:
                    heavys = "buy mag7; ";
                    heavycost = 1800;
                    break;
                case 3:
                    heavys = "buy sawedoff; ";
                    heavycost = 1200;
                    break;
                case 4:
                    heavys = "buy m249; ";
                    heavycost = 5200;
                    break;
                case 5:
                    heavys = "buy negev; ";
                    heavycost = 5700;
                    break;
            }
            switch (smgList.SelectedIndex)
            {
                case 0:
                    smgs = "buy mac10; ";
                    smgcost = 1050;
                    break;
                case 1:
                    smgs = "buy mp9; ";
                    smgcost = 1250;
                    break;
                case 2:
                    smgs = "buy mp7; ";
                    smgcost = 1700;
                    break;
                case 3:
                    smgs = "buy ump45; ";
                    smgcost = 1200;
                    break;
                case 4:
                    smgs = "buy p90; ";
                    smgcost = 2350;
                    break;
                case 5:
                    smgs = "buy bizon; ";
                    smgcost = 1400;
                    break;
            }
            resultBox.Text = "bind " + keys + "\"" + primary + secondary + gear1 + gear2 + gear3 + gear4 + grenades + "\"";
            totalcost = armortotalcost + geartotalcost + nadetotalcost + primarytotalcost + secondarytotalcost;
            priceLabel.Text = "$" + totalcost;
            
            if (noneRadio.Checked)
            {
              primarytotalcost = 0;
                primary = "";
            }

            if (riflesRadio.Checked)
            {
                primaryList.Enabled = true;
                primarytotalcost = riflecost;
                primary = rifles;
            }
            else
                primaryList.Enabled = false; 
            
            if (smgsRadio.Checked)
            {
                smgList.Enabled = true;
                primarytotalcost = smgcost;
                primary = smgs;
            }
            else
                smgList.Enabled = false;

            if (heavysRadio.Checked)
            {
                heavyList.Enabled = true;
                primarytotalcost = heavycost;
                primary = heavys;
            }
            else
                heavyList.Enabled = false;

            if (heavyList.Enabled == true)
            {
                primary = heavys;
                heavycost = primarytotalcost;
            }
            if (primaryList.Enabled == true)
            {
                primary = rifles;
                riflecost = primarytotalcost;
            }
            if (smgList.Enabled == true)
            {
                primary = smgs;
                smgcost = primarytotalcost;
            }

        }

        private void secondaryChecked(object sender, EventArgs e)
        {
            switch (secondaryList.SelectedIndex)
            {
                case 0:
                    secondary = "buy glock; ";
                    secondarycost = 200;
                    break;
                case 1:
                    secondary = "buy usp-s; ";
                    secondarycost = 200;
                    break;
                case 2:
                    secondary = "hkp2000; ";
                    secondarycost = 200;
                    break;
                case 3:
                    secondary = "buy p250; ";
                    secondarycost = 300;
                    break;
                case 4:
                    secondary = "buy dual_barettas; ";
                    secondarycost = 500;
                    break;
                case 5:
                    secondary = "buy tec9; ";
                    secondarycost = 500;
                    break;
                case 6:
                    secondary = "buy fiveseven; ";
                    secondarycost = 500;
                    break;
                case 7:
                    secondary = "buy cz75; ";
                    secondarycost = 500;
                    break;
                case 8:
                    secondary = "buy deagle; ";
                    secondarycost = 700;
                    break;
            }


            if (none2Radio.Checked)
            {
                secondarytotalcost = 0;
                secondary = "";
            }

            if (pistolRadio.Checked)
            {
                secondaryList.Enabled = true;
                secondarytotalcost = secondarycost;

            }
            else
                secondaryList.Enabled = false;

            resultBox.Text = "bind " + keys + "\"" + primary + secondary + gear1 + gear2 + gear3 + gear4 + grenades + "\"";
            totalcost = armortotalcost + geartotalcost + nadetotalcost + primarytotalcost + secondarytotalcost;
            priceLabel.Text = "$" + totalcost;
        }

        private void primaryChanged(object sender, EventArgs e)
        {
            switch (heavyList.SelectedIndex)
            {
                case 0:
                    heavys = "buy nova; ";
                    heavycost = 1200;
                    break;
                case 1:
                    heavys = "buy xm1014; ";
                    heavycost = 2000;
                    break;
                case 2:
                    heavys = "buy mag7; ";
                    heavycost = 1800;
                    break;
                case 3:
                    heavys = "buy sawedoff; ";
                    heavycost = 1200;
                    break;
                case 4:
                    heavys = "buy m249; ";
                    heavycost = 5200;
                    break;
                case 5:
                    heavys = "buy negev; ";
                    heavycost = 5700;
                    break;
            }
            switch (smgList.SelectedIndex)
            {
                case 0:
                    smgs = "buy mac10; ";
                    smgcost = 1050;
                    break;
                case 1:
                    smgs = "buy mp9; ";
                    smgcost = 1250;
                    break;
                case 2:
                    smgs = "buy mp7; ";
                    smgcost = 1700;
                    break;
                case 3:
                    smgs = "buy ump45; ";
                    smgcost = 1200;
                    break;
                case 4:
                    smgs = "buy p90; ";
                    smgcost = 2350;
                    break;
                case 5:
                    smgs = "buy bizon; ";
                    smgcost = 1400;
                    break;
            }  
            switch (primaryList.SelectedIndex)
            {
                case 0:
                    rifles = "buy ak47; ";
                    riflecost = 2700;
                    break;
                case 1:
                    rifles = "buy m4a1_silencer; ";
                    riflecost = 3100;
                    break;
                case 2:
                    rifles = "buy m4a4; ";
                    riflecost = 3100;
                    break;
                case 3:
                    rifles = "buy galilar; ";
                    riflecost = 2000;
                    break;
                case 4:
                    rifles = "buy famas; ";
                    riflecost = 2250;
                    break;
                case 5:
                    rifles = "buy sg008; ";
                    riflecost = 1700;
                    break;
                case 6:
                    rifles = "buy g3sg1; ";
                    riflecost = 5000;
                    break;
                case 7:
                    rifles = "buy scar20; ";
                    riflecost = 5000;
                    break;
                case 8:
                    rifles = "buy awp; ";
                    riflecost = 4750;
                    break;
            }
            switch (secondaryList.SelectedIndex)
            {
                case 0:
                    secondary = "buy glock; ";
                    secondarycost = 200;
                    break;
                case 1:
                    secondary = "buy usp-s; ";
                    secondarycost = 200;
                    break;
                case 2:
                    secondary = "hkp2000; ";
                    secondarycost = 200;
                    break;
                case 3:
                    secondary = "buy p250; ";
                    secondarycost = 300;
                    break;
                case 4:
                    secondary = "buy dual_barettas; ";
                    secondarycost = 500;
                    break;
                case 5:
                    secondary = "buy tec9; ";
                    secondarycost = 500;
                    break;
                case 6:
                    secondary = "buy fiveseven; ";
                    secondarycost = 500;
                    break;
                case 7:
                    secondary = "buy cz75; ";
                    secondarycost = 500;
                    break;
                case 8:
                    secondary = "buy deagle; ";
                    secondarycost = 700;
                    break;
            }

            {
            if (secondaryList.Enabled == false)
            {
                secondary = "";
                secondarycost = 0;
            }
            if (heavyList.Enabled == false)
            {
                heavys = "";
                heavycost = 0;
            }
            if (primaryList.Enabled == false)
            {
                rifles = "";
                riflecost = 0;
            }
            if (smgList.Enabled == false)
            {
                smgs = "";
                smgcost = 0;
           }
          }
            primarytotalcost = riflecost + smgcost + heavycost;
            secondarytotalcost = secondarycost;
            totalcost = armortotalcost + geartotalcost + nadetotalcost + primarytotalcost + secondarytotalcost;
            priceLabel.Text = "$" + totalcost;
            primary = rifles + smgs + heavys;
            resultBox.Text = "bind " + keys + "\"" + primary + secondary + gear1 + gear2 + gear3 + gear4 + grenades + "\"";
        }

        private void keysChanged(object sender, EventArgs e)
        {
            noteLabel.Visible = false;
            resultBox.Text = "bind " + keys + "\"" + primary + secondary + gear1 + gear2 + gear3 + gear4 + grenades + "\"";
        }

        private void aboutClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("CSGO Buy Bind Generator v3.3\nCreated by AwesomeAlvin");
        }

        private void selectkeyButton_Click(object sender, EventArgs e)
        {
            selectKeyboard sk = new selectKeyboard(this);
            sk.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void keyChanged(object sender, EventArgs e)
        {
            if (!(keyLabel.Text == "None"))
            {
                noteLabel.Visible = false;
                keyLabel.ForeColor = Color.MidnightBlue;
            }

            otherkeys = false;

            switch (keyLabel.Text)
            {
                case "Numpad 1":
                    keys = "kp_end ";
                    otherkeys = true;
                    break;
                case "Numpad 2":
                    keys = "kp_downarrow ";
                    otherkeys = true;
                    break;
                case "Numpad 3":
                    keys = "kp_pgdn ";
                    otherkeys = true;
                    break;
                case "Numpad 4":
                    keys = "kp_leftarrow ";
                    otherkeys = true;
                    break;
                case "Numpad 5":
                    keys = "kp_5 ";
                    otherkeys = true;
                    break;
                case "Numpad 6":
                    keys = "kp_rightarrow ";
                    otherkeys = true;
                    break;
                case "Numpad 7":
                    keys = "kp_home ";
                    otherkeys = true;
                    break;
                case "Numpad 8":
                    keys = "kp_uparrow ";
                    otherkeys = true;
                    break;
                case "Numpad 9":
                    keys = "kp_pgup ";
                    otherkeys = true;
                    break;
                case "Numpad 0":
                    keys = "kp_ins ";
                    otherkeys = true;
                    break;
                case "Numpad Enter":
                    keys = "kp_enter ";
                    otherkeys = true;
                    break;
                case "Numpad +":
                    keys = "kp_plus ";
                    otherkeys = true;
                    break;
                case "Numpad -":
                    keys = "kp_minus ";
                    otherkeys = true;
                    break;
                case "Numpad *":
                    keys = "kp_multiply ";
                    otherkeys = true;
                    break;
                case "Numpad /":
                    keys = "kp_divide ";
                    otherkeys = true;
                    break;
                case "↑":
                    keys = "uparrow ";
                    otherkeys = true;
                    break;
                case "↓":
                    keys = "downarrow ";
                    otherkeys = true;
                    break;
                case "→":
                    keys = "rightarrow ";
                    otherkeys = true;
                    break;
                case "←":
                    keys = "leftarrow ";
                    otherkeys = true;
                    break;
                case "INSERT":
                    keys = "INS ";
                    otherkeys = true;
                    break;
                case "DELETE":
                    keys = "DEL ";
                    otherkeys = true;
                    break;
                case "PAGE UP":
                    keys = "PGUP ";
                    otherkeys = true;
                    break;
                case "PAGE DOWN":
                    keys = "PGDN ";
                    otherkeys = true;
                    break;
                case "PAUSE-BREAK":
                    keys = "PAUSE ";
                    otherkeys = true;
                    break;
                case "CAPS-LOCK":
                    keys = "CAPSLOCK ";
                    otherkeys = true;
                    break;
                case "SPACE BAR":
                    keys = "SPACE ";
                    otherkeys = true;
                    break;
            }

            if (otherkeys == false)
            {
                keys = keyLabel.Text + " ";
            }
            resultBox.Text = "bind " + keys + "\"" + primary + secondary + gear1 + gear2 + gear3 + gear4 + grenades + "\"";
        }
    }
}
