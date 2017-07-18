using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GW_Launcher
{
    public partial class MainForm : Form
    {
        private bool debugMode()
        {
            if (this.checkBoxDebug.Checked == true) { return true; }
            return false;
        }
        private void doDebug()
        {
            if (debugMode())
            {
                #region UI Changes.
                // 
                // MainForm
                // 
                this.MaximumSize = new System.Drawing.Size(620, 270);
                this.MinimumSize = new System.Drawing.Size(620, 270);
                this.ClientSize = new System.Drawing.Size(620, 270);
                // 
                // debugModeOutput
                //
                this.debugModeOutput.Enabled = true;
                this.debugModeOutput.Text = "Debug Output:\r\n";
                #endregion

                #region Use this area below for debugging functions.
                /*string astring = "foo, are, foo";
                debug(astring);*/

                /*object[] test = new object[99];
                test[0] = "you";
                test[1] = "are";
                test[2] = "foo";*/
                //debug(test);

                /*object[][] test2 = new object[99][];
                test2[0] = test;
                test2[1] = test;
                test2[2] = test;
                debug(test2);*/
                #endregion
            }
            else
            {
                // 
                // MainForm
                // 
                this.MaximumSize = new System.Drawing.Size(308, 270);
                this.MinimumSize = new System.Drawing.Size(308, 270);
                this.ClientSize = new System.Drawing.Size(308, 270);
                // 
                // debugModeOutput
                //
                this.debugModeOutput.Enabled = false;
            }
        }
        #region Debug cases
        /// <summary>
        /// Usage:  
        /// <para>&#160;&#160;&#160;&#160;debug(thing_to_debug);</para>
        ///  </summary>
        private void debug(object[][] senderarray)
        {
            this.debugModeOutput.Text += "\r\n2 dimensional object array received.\r\n   |\r";
            if (debugMode())
            {
                int x = 1;
                foreach (Object[] subarray in senderarray)
                {
                    if (subarray == null) { break; }
                    this.debugModeOutput.Text += String.Format("\r\n   |__ SubArray {0}.\r\n         |\r\n", x);
                    foreach (var value in subarray)
                    {
                        if (value == null) { break; }
                        this.debugModeOutput.Text += "         |__ " + value.ToString();
                        this.debugModeOutput.Text += "\r\n";
                    }
                    x++;
                }
            }
        }
        private void debug(object[] senderarray)
        {
            this.debugModeOutput.Text += "\r\n1 dimensional object array received.\r\n   |\r";
            if (debugMode())
            {
                foreach (var value in senderarray)
                {
                    if(value == null) { break; }
                    this.debugModeOutput.Text += "\r\n   |__ " + value.ToString();
                    this.debugModeOutput.Text += "\r\n";
                }
            }
        }
        private void debug(object sender)
        {
            this.debugModeOutput.Text += "\r\nSingle object received.\r\n   |\r";
            if (debugMode())
            {
                this.debugModeOutput.Text += "\r\n   |__ " + sender.ToString();
                this.debugModeOutput.Text += "\r\n";
            }
        }
        private void debug(List<object> senderlist)
        {
            this.debugModeOutput.Text += "\r\n1 dimensional list array received.\r\n   |\r";
            if (debugMode())
            {
                foreach (var value in senderlist)
                {
                    this.debugModeOutput.Text += "\r\n   |__ " + value.ToString();
                    this.debugModeOutput.Text += "\r\n";
                }
            }
        }
        private void debug(string sender)
        {
            this.debugModeOutput.Text += "\r\nSingle string received.\r\n   |\r";
            if (debugMode())
            {
                this.debugModeOutput.Text += "\r\n   |__ " + sender;
                this.debugModeOutput.Text += "\r\n";
            }
        }
        private void debug(int sender)
        {
            this.debugModeOutput.Text += "\r\nSingle int received.\r\n   |\r";
            if (debugMode())
            {
                this.debugModeOutput.Text += "\r\n   |__ " + sender.ToString();
                this.debugModeOutput.Text += "\r\n";
            }
        }
        private void debug(bool sender)
        {
            this.debugModeOutput.Text += "\r\nSingle bool received.\r\n   |\r";
            if (debugMode())
            {
                this.debugModeOutput.Text += "\r\n   |__ " + sender.ToString();
                this.debugModeOutput.Text += "\r\n";
            }
        }
        #endregion
    }
}