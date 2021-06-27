using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMORPG
{
    public partial class MainForm : Form
    {
        private int id;
        PrivateFontCollection fontCol;
        bool isSettingClick = false;
        bool isConsoleClick = false;

        Dictionary<string, Control> mainFormControl = new Dictionary<string, Control>();
        Dictionary<string, Control> settingFormControl = new Dictionary<string, Control>();
        Dictionary<string, Control> specFormControl = new Dictionary<string, Control>();
        Dictionary<string, Control> talantFormControl = new Dictionary<string, Control>();
        Dictionary<string, Control> acvivFormControl = new Dictionary<string, Control>();
        Dictionary<string, Control> bestiaryFormControl = new Dictionary<string, Control>();
        Dictionary<string, Control> consoleFormControl = new Dictionary<string, Control>();
        public MainForm(int identity, PrivateFontCollection font)
        {
            InitializeComponent();

            id = identity;
            fontCol = font;

            //MainForm
            mainFormControl.Add("Setting", settingButton);
            mainFormControl.Add("Specification", specButton);
            mainFormControl.Add("Talants", talantButton);
            mainFormControl.Add("Achivments", achivButton);
            mainFormControl.Add("Bestiary", bestiaryButton);
            mainFormControl.Add("Nickname", nickLabel);
            mainFormControl.Add("Class", classLabel);
            mainFormControl.Add("Race", raceLabel);
            mainFormControl.Add("Level", levelLabel);
            mainFormControl.Add("Inventory", inventoryGridView); 
            mainFormControl.Add("InventoryLabel", label1);
            mainFormControl.Add("ClassLabel", label2);
            mainFormControl.Add("RaceLabel", label3);
            mainFormControl.Add("LevelLabel", label4);

            //SettingForm
            settingFormControl.Add("Panel", panelSetting);
            settingFormControl.Add("Option", optionButton);
            settingFormControl.Add("LogOut", logOutButton);
            settingFormControl.Add("Exit", exitButton);

            //Specification
            specFormControl.Add("Panel", panelSpecification);
            specFormControl.Add("Title",label5);
            specFormControl.Add("Str", strLabel);
            specFormControl.Add("StrUp", strUpLabel);
            specFormControl.Add("Dex", dexLabel);
            specFormControl.Add("DexUp", dexUpLabel);
            specFormControl.Add("Vigor", vigorLabel);
            specFormControl.Add("VigorUp", vigUpLabel);
            specFormControl.Add("Int",intLabel);
            specFormControl.Add("IntUp", intUpLabel);
            specFormControl.Add("Faith", faithLabel);
            specFormControl.Add("FaithUp", faithUpLabel);
            specFormControl.Add("Luck", luckLabel);
            specFormControl.Add("LuckUp", luckUpLevel);

            //Console
            consoleFormControl.Add("Panel", consolePanel);
            consoleFormControl.Add("Console", consoleBox);
            consoleFormControl.Add("AnswerConsole", answerLabel);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelSetting.Visible = false;
            consolePanel.Visible = false;
            panelSpecification.Visible = false;

            Font fontText = new Font(fontCol.Families[1], 17, FontStyle.Bold);
            foreach (var item in mainFormControl.Keys)
            {
                mainFormControl[item].Font = fontText;
            }
            foreach(var item in settingFormControl.Keys)
            {
                settingFormControl[item].Font = fontText;
            }
            foreach(var item in specFormControl.Keys)
            {
                specFormControl[item].Font = fontText;
            }
            nickLabel.Font = new Font(fontCol.Families[1], 22, FontStyle.Bold);
            
            inventoryGridView.Columns.Add("inv1", "");
            inventoryGridView.Columns.Add("inv2", "");
            inventoryGridView.Columns.Add("inv3", "");
            
            Update();
        }
        private void Update()
        {
            person.UpdateDataPerson();

            List<string> items = person.Items;
            int[] specification = person.Specification;
            string[] personInf = person.PersonInf;

            specFormControl["Str"].Text = specification[0].ToString();
            specFormControl["Dex"].Text = specification[1].ToString();
            specFormControl["Vigor"].Text = specification[2].ToString();
            specFormControl["Int"].Text = specification[3].ToString();
            specFormControl["Faith"].Text = specification[4].ToString();
            specFormControl["Luck"].Text = specification[5].ToString();

            nickLabel.Text = personInf[0];
            levelLabel.Text = personInf[2];
            classLabel.Text = personInf[3];
            raceLabel.Text = personInf[4];
            for (int i = 0; i < items.Count; i++)
            {
                
            }
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            if(!isSettingClick)
            {
                panelSetting.Visible = true;
                isSettingClick = true;
            }
            else
            {
                panelSetting.Visible = false;
                isSettingClick = false;
                consoleBox.Clear();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Program.isEnd = false;
            Close();
        }

        private void optionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это приложение даже не во все окно... Какие настройки???");
        }

        private void specButton_Click(object sender, EventArgs e)
        {
            panelSpecification.Visible = true;
        }

        private void talantButton_Click(object sender, EventArgs e)
        {

        }

        private void achivButton_Click(object sender, EventArgs e)
        {

        }

        private void bestiaryButton_Click(object sender, EventArgs e)
        {

        }

        private void strUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void dexUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void vigUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void intUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void faithUpLevel_Click(object sender, EventArgs e)
        {

        }

        private void luckUpLevel_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (!isConsoleClick)
                {
                    consolePanel.Visible = true;
                    isConsoleClick = true;
                }
                else
                {
                    consolePanel.Visible = false;
                    isConsoleClick = false;
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            panelSpecification.Visible = false;
        }
    }
}
