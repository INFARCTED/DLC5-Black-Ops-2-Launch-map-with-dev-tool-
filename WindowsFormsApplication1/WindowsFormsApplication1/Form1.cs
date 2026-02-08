using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JRPC_Client;
using XDevkit;
using System.Resources;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public IXboxConsole xbx;
        static IXboxConsole ginterface0_0;
        XDevkit.IXboxConsole RGH;
        public Form1()
        {
            InitializeComponent();
        }

        public void Cbuf_AddText(string buffer)
        {
            xbx.CallVoid(0x82403390, new object[] { 0, buffer });
        }

        public void UI_OpenToastPopup(int LocalClientNum, string toastPopupIconName, string toastPopupTitle, string toastPopupDesc, int toastPopupDuration)
        {
            xbx.CallVoid(0x824577F0, new object[] { LocalClientNum, toastPopupIconName, toastPopupTitle, toastPopupDesc, toastPopupDuration });

        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Cbuf_AddText("wait 250; devmap zm_prototype; r_drawSceneModels 0; r_drawSkinnedmodels 0; r_drawSceneEnts 0;");
                    break;
                case 1:
                    Cbuf_AddText("wait 250; devmap zm_asylum; r_drawSceneModels 0; r_drawSkinnedmodels 0; r_drawSceneEnts 0;");
                    break;
                case 2:
                    Cbuf_AddText("wait 250; devmap zm_sumpf; r_drawSceneModels 0; r_drawSkinnedmodels 0; r_drawSceneEnts 0;");
                    break;
                case 3:
                    Cbuf_AddText("wait 250; devmap zm_factory; r_drawSceneModels 0; r_drawSkinnedmodels 0; r_drawSceneEnts 0;");
                    break;
                case 4:
                    Cbuf_AddText("wait 250; devmap zm_theater; r_drawSceneModels 0; r_drawSkinnedmodels 0; r_drawSceneEnts 0;");
                    break;
                case 5:
                    Cbuf_AddText("wait 250; devmap zm_pentagon; r_drawSceneModels 0; r_drawSkinnedmodels 0; r_drawSceneEnts 0;");
                    break;
                case 6:
                    Cbuf_AddText("wait 250; devmap zm_cosmodrome; r_drawSceneModels 0; r_drawSkinnedmodels 0; r_drawSceneEnts 0;");
                    break;
                case 7:
                    Cbuf_AddText("wait 250; devmap zm_moon; r_drawSceneModels 0; r_drawSkinnedmodels 0; r_drawSceneEnts 0;");
                    break;
                case 8:
                    Cbuf_AddText("wait 250; devmap zm_temple; r_drawSceneModels 0; r_drawSkinnedmodels 0; r_drawSceneEnts 0;");
                    break;
                case 9:
                    Cbuf_AddText("wait 250; devmap zm_tomb; r_drawSceneModels 0; r_drawSkinnedmodels 0; r_drawSceneEnts 0;");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.RGH.Connect(out this.RGH, "default");
                bool flag = this.xbx.Connect(out this.xbx, "default");
                ginterface0_0.Connect(out ginterface0_0, "default");
                if (flag)
                {
                    button3.Text = "Connected";
                    label1.Text = "Connected";
                    label1.ForeColor = Color.ForestGreen;
    
                    UI_OpenToastPopup(0, "menu_mp_killstreak_select", "DLC 5 Build. Dev Tool", "Made by ^2EFK ^7| ^1Youtube.com/^7@INFARCTED-EFKK", 20000);
                    this.xbx.XNotify("Connected.");
                


                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cbuf_AddText(textBox1.Text);
            textBox1.Clear();
        }
    }
}

