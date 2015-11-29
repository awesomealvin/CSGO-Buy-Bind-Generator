using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGO_Key_Binds
{
    public partial class selectKeyboard : Form
    {
        private Form1 _parent;
        public selectKeyboard(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
        }   

        string hotkey = "";
        public void hotkeyChanged(object sender, EventArgs e)
        {
          
            RadioButton rr = (RadioButton)sender;

            hotkey = rr.Text;
            /* switch (rr.Name)
             {
                 case ("buttonF1"):
                     hotkey = "F1 ";
                     break;


            }*/

            label1.Text = hotkey;
        }

        public void buttonConfirmKey_Click(object sender, EventArgs e)
        {
            if (hotkey == "")
            {
                MessageBox.Show("You haven't selected a key you, yet nugget.");
                return;

            }

            _parent.keyLabel.Text = hotkey;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hotkeyNumChanged(object sender, EventArgs e)
        { 
            RadioButton rr = (RadioButton)sender;
            
            switch (rr.Name)
            {
                case "buttonNum0":
                    hotkey = "Numpad 0";
                    break;
                case "buttonNum1":
                    hotkey = "Numpad 1";
                    break;
                case "buttonNum2":
                    hotkey = "Numpad 2";
                    break;
                case "buttonNum3":
                    hotkey = "Numpad 3";
                    break;
                case "buttonNum4":
                    hotkey = "Numpad 4";
                    break;
                case "buttonNum5":
                    hotkey = "Numpad 5";
                    break;
                case "buttonNum6":
                    hotkey = "Numpad 6";
                    break;
                case "buttonNum7":
                    hotkey = "Numpad 7";
                    break;
                case "buttonNum8":
                    hotkey = "Numpad 8";
                    break;
                case "buttonNum9":
                    hotkey = "Numpad 9";
                    break;
                case "buttonNumFSlash":
                    hotkey = "Numpad /";
                    break;
                case "buttonNumMultiply":
                    hotkey = "Numpad *";
                    break;
                case "buttonNumMinus":
                    hotkey = "Numpad -";
                    break;
                case "buttonNumPlus":
                    hotkey = "Numpad +";
                    break;
                case "buttonNumEnter":
                    hotkey = "Numpad Enter";
                    break;
                case "buttonNumDot":
                    hotkey = "Numpad .";
                    break;
                case "buttonPause":
                    hotkey = "PAUSE-BREAK";
                    break;
   

            }
            label1.Text = hotkey;




        }
    }
}
