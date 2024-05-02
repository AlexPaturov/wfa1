// Decompiled with JetBrains decompiler
// Type: TermForm
// Assembly: wfa1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7ED32045-7058-479A-A9C3-646DCED5C6E6
// Assembly location: D:\repos\cSharp\job\wfa1\wfa1.exe

using JH.CommBase;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class TermForm : Form
{
    private bool inEscape = false;
    private string esc;
    private string mark;
    private TextBox textBoxS;
    private Button offlineOnline;
    private Button buttonSet;
    private RichTextBox textBoxR;
    private Button buttonClr;
    private GroupBox groupBox1;
    private RadioButton radioButtonRLSD;
    private RadioButton radioButtonDSR;
    private RadioButton radioButtonCTS;
    private CheckBox checkBoxBK;
    private CheckBox checkBoxDTR;
    private CheckBox checkBoxRTS;
    private ToolTip toolTip;
    private RadioButton radioButtonRng;
    private Button buttonImm;
    private Button btnComandSend;
    private IContainer components;

    public TermForm() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            BaseTerm.term.Close();
            if (this.components != null)
                this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.offlineOnline = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.RichTextBox();
            this.buttonClr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRng = new System.Windows.Forms.RadioButton();
            this.checkBoxBK = new System.Windows.Forms.CheckBox();
            this.checkBoxDTR = new System.Windows.Forms.CheckBox();
            this.checkBoxRTS = new System.Windows.Forms.CheckBox();
            this.radioButtonRLSD = new System.Windows.Forms.RadioButton();
            this.radioButtonDSR = new System.Windows.Forms.RadioButton();
            this.radioButtonCTS = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonImm = new System.Windows.Forms.Button();
            this.btnComandSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxS
            // 
            this.textBoxS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxS.BackColor = System.Drawing.Color.White;
            this.textBoxS.CausesValidation = false;
            this.textBoxS.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxS.Location = new System.Drawing.Point(8, 8);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.ReadOnly = true;
            this.textBoxS.Size = new System.Drawing.Size(356, 22);
            this.textBoxS.TabIndex = 0;
            this.textBoxS.TabStop = false;
            this.toolTip.SetToolTip(this.textBoxS, "Type character to send, or type \'<\' then ASCII control name or number 0..255, the" +
        "n \'>\' to send. Type \'<\' twice for that character");
            // 
            // offlineOnline
            // 
            this.offlineOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.offlineOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offlineOnline.Location = new System.Drawing.Point(8, 230);
            this.offlineOnline.Name = "offlineOnline";
            this.offlineOnline.Size = new System.Drawing.Size(75, 23);
            this.offlineOnline.TabIndex = 3;
            this.offlineOnline.TabStop = false;
            this.offlineOnline.Tag = "0";
            this.offlineOnline.Text = "Offline";
            this.toolTip.SetToolTip(this.offlineOnline, "Press to change between Offline and Online");
            this.offlineOnline.Click += new System.EventHandler(this.offlineOnline_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSet.Location = new System.Drawing.Point(8, 198);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 12;
            this.buttonSet.TabStop = false;
            this.buttonSet.Text = "Settings";
            this.toolTip.SetToolTip(this.buttonSet, "Press to show the settings dialog");
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxR.BackColor = System.Drawing.Color.LightGray;
            this.textBoxR.DetectUrls = false;
            this.textBoxR.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxR.HideSelection = false;
            this.textBoxR.Location = new System.Drawing.Point(8, 38);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.ShowSelectionMargin = true;
            this.textBoxR.Size = new System.Drawing.Size(438, 150);
            this.textBoxR.TabIndex = 13;
            this.textBoxR.Text = "";
            // 
            // buttonClr
            // 
            this.buttonClr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClr.Location = new System.Drawing.Point(344, 198);
            this.buttonClr.Name = "buttonClr";
            this.buttonClr.Size = new System.Drawing.Size(75, 23);
            this.buttonClr.TabIndex = 14;
            this.buttonClr.TabStop = false;
            this.buttonClr.Text = "Clear";
            this.toolTip.SetToolTip(this.buttonClr, "Press to clear the send and receive text boxes");
            this.buttonClr.Click += new System.EventHandler(this.buttonClr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.radioButtonRng);
            this.groupBox1.Controls.Add(this.checkBoxBK);
            this.groupBox1.Controls.Add(this.checkBoxDTR);
            this.groupBox1.Controls.Add(this.checkBoxRTS);
            this.groupBox1.Controls.Add(this.radioButtonRLSD);
            this.groupBox1.Controls.Add(this.radioButtonDSR);
            this.groupBox1.Controls.Add(this.radioButtonCTS);
            this.groupBox1.Location = new System.Drawing.Point(90, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 61);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonRng
            // 
            this.radioButtonRng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonRng.AutoCheck = false;
            this.radioButtonRng.Enabled = false;
            this.radioButtonRng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonRng.Location = new System.Drawing.Point(184, 13);
            this.radioButtonRng.Name = "radioButtonRng";
            this.radioButtonRng.Size = new System.Drawing.Size(56, 19);
            this.radioButtonRng.TabIndex = 15;
            this.radioButtonRng.Text = "Ring";
            this.toolTip.SetToolTip(this.radioButtonRng, "Ringing detection input");
            // 
            // checkBoxBK
            // 
            this.checkBoxBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxBK.Enabled = false;
            this.checkBoxBK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxBK.Location = new System.Drawing.Point(160, 37);
            this.checkBoxBK.Name = "checkBoxBK";
            this.checkBoxBK.Size = new System.Drawing.Size(56, 16);
            this.checkBoxBK.TabIndex = 14;
            this.checkBoxBK.Tag = "2";
            this.checkBoxBK.Text = "Break";
            this.toolTip.SetToolTip(this.checkBoxBK, "Break condition on transmission output");
            this.checkBoxBK.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxDTR
            // 
            this.checkBoxDTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxDTR.Enabled = false;
            this.checkBoxDTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDTR.Location = new System.Drawing.Point(96, 37);
            this.checkBoxDTR.Name = "checkBoxDTR";
            this.checkBoxDTR.Size = new System.Drawing.Size(56, 16);
            this.checkBoxDTR.TabIndex = 13;
            this.checkBoxDTR.Tag = "1";
            this.checkBoxDTR.Text = "DTR";
            this.toolTip.SetToolTip(this.checkBoxDTR, "Data Terminal Ready output");
            this.checkBoxDTR.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxRTS
            // 
            this.checkBoxRTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxRTS.Enabled = false;
            this.checkBoxRTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRTS.Location = new System.Drawing.Point(32, 37);
            this.checkBoxRTS.Name = "checkBoxRTS";
            this.checkBoxRTS.Size = new System.Drawing.Size(56, 16);
            this.checkBoxRTS.TabIndex = 12;
            this.checkBoxRTS.Tag = "0";
            this.checkBoxRTS.Text = "RTS";
            this.toolTip.SetToolTip(this.checkBoxRTS, "Request To Send output");
            this.checkBoxRTS.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // radioButtonRLSD
            // 
            this.radioButtonRLSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonRLSD.AutoCheck = false;
            this.radioButtonRLSD.Enabled = false;
            this.radioButtonRLSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonRLSD.Location = new System.Drawing.Point(123, 13);
            this.radioButtonRLSD.Name = "radioButtonRLSD";
            this.radioButtonRLSD.Size = new System.Drawing.Size(56, 19);
            this.radioButtonRLSD.TabIndex = 10;
            this.radioButtonRLSD.Text = "RLSD";
            this.toolTip.SetToolTip(this.radioButtonRLSD, "Receive Line Signal Detect input");
            // 
            // radioButtonDSR
            // 
            this.radioButtonDSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonDSR.AutoCheck = false;
            this.radioButtonDSR.Enabled = false;
            this.radioButtonDSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonDSR.Location = new System.Drawing.Point(67, 13);
            this.radioButtonDSR.Name = "radioButtonDSR";
            this.radioButtonDSR.Size = new System.Drawing.Size(56, 19);
            this.radioButtonDSR.TabIndex = 9;
            this.radioButtonDSR.Text = "DSR";
            this.toolTip.SetToolTip(this.radioButtonDSR, "Data Set Ready input");
            // 
            // radioButtonCTS
            // 
            this.radioButtonCTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonCTS.AutoCheck = false;
            this.radioButtonCTS.Enabled = false;
            this.radioButtonCTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonCTS.Location = new System.Drawing.Point(11, 13);
            this.radioButtonCTS.Name = "radioButtonCTS";
            this.radioButtonCTS.Size = new System.Drawing.Size(56, 19);
            this.radioButtonCTS.TabIndex = 8;
            this.radioButtonCTS.Text = "CTS";
            this.toolTip.SetToolTip(this.radioButtonCTS, "Clear To Send input");
            // 
            // buttonImm
            // 
            this.buttonImm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImm.Location = new System.Drawing.Point(372, 8);
            this.buttonImm.Name = "buttonImm";
            this.buttonImm.Size = new System.Drawing.Size(75, 23);
            this.buttonImm.TabIndex = 16;
            this.buttonImm.Tag = "0";
            this.buttonImm.Text = "Queued";
            this.toolTip.SetToolTip(this.buttonImm, "Press to change between Queued and Immediate transmission.");
            this.buttonImm.Click += new System.EventHandler(this.buttonImm_Click);
            // 
            // btnComandSend
            // 
            this.btnComandSend.Location = new System.Drawing.Point(344, 230);
            this.btnComandSend.Name = "btnComandSend";
            this.btnComandSend.Size = new System.Drawing.Size(75, 23);
            this.btnComandSend.TabIndex = 17;
            this.btnComandSend.Text = "F#1";
            this.btnComandSend.UseVisualStyleBackColor = true;
            this.btnComandSend.Click += new System.EventHandler(this.btnComandSend_Click);
            // 
            // TermForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(454, 260);
            this.Controls.Add(this.btnComandSend);
            this.Controls.Add(this.buttonImm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClr);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.offlineOnline);
            this.Controls.Add(this.textBoxS);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(434, 180);
            this.Name = "TermForm";
            this.Text = "BaseTerm: Offline";
            this.Load += new System.EventHandler(this.BaseTermForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void Form_KeyPress(object sender, KeyPressEventArgs e)
    {
        byte c = (byte)e.KeyChar;
        if (c == (byte)13 && !this.inEscape)
        {
            this.textBoxS.AppendText("<CR>");
            BaseTerm.term.SendCtrl("CR");
        }
        else
        {
            if (c < (byte)32 || c > (byte)126)
                return;
            if (this.inEscape)
            {
                switch (c)
                {
                    case 60:
                        BaseTerm.term.SendChar(c);
                        this.textBoxS.Text = this.mark;
                        this.inEscape = false;
                        this.textBoxS.BackColor = Color.White;
                        goto label_15;
                    case 62:
                        if (!BaseTerm.term.SendCtrl(this.esc))
                        {
                            this.textBoxS.Text = this.mark;
                            c = (byte)0;
                        }
                        this.inEscape = false;
                        this.textBoxS.BackColor = Color.White;
                        break;
                    default:
                        this.esc += ((char)c).ToString();
                        break;
                }
            }
            else if (c == (byte)60)
            {
                this.inEscape = true;
                this.esc = "";
                this.mark = this.textBoxS.Text;
                this.textBoxS.BackColor = Color.Yellow;
            }
            else
                BaseTerm.term.SendChar(c);
            label_15:
            if (c >= (byte)32)
                this.textBoxS.AppendText(e.KeyChar.ToString());
            e.Handled = true;
        }
    }

    private void Form_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Back)
        {
            this.textBoxS.Text = "";
            e.Handled = true;
        }
        if (e.KeyCode != Keys.Delete)
            return;
        this.textBoxS.Text = "";
        this.textBoxR.Text = "";
        e.Handled = true;
    }

    private void offlineOnline_Click(object sender, EventArgs e)
    {
        if (this.offlineOnline.Tag.ToString() == "1")
        {
            BaseTerm.term.Close();
            this.offlineOnline.Tag = (object)"0";
            this.offlineOnline.Text = "Offline";
        }
        else
        {
            try
            {
                if (BaseTerm.term.Open())
                {
                    this.ShowMsg(">>>> ONLINE");
                    this.offlineOnline.Tag = (object)"1";
                    this.offlineOnline.Text = "Online";
                }
                else
                    this.ShowMsg(">>>> PORT UNAVAILABLE");
            }
            catch (CommPortException ex)
            {
                this.ShowException(ex);
            }
        }
        this.textBoxS.Focus();
    }

    public void ShowException(CommPortException e)
    {
        Color selectionColor = this.textBoxR.SelectionColor;
        this.textBoxR.SelectionColor = Color.Red;
        this.textBoxR.AppendText("\r\n>>>> EXCEPTION\r\n");
        this.textBoxR.SelectionColor = Color.Red;
        this.textBoxR.AppendText(e.Message);
        if (e.InnerException != null)
        {
            this.textBoxR.AppendText("\r\n");
            this.textBoxR.SelectionColor = Color.Red;
            this.textBoxR.AppendText(e.InnerException.Message);
        }
        this.textBoxR.SelectionColor = Color.Red;
        this.textBoxR.AppendText("\r\n>>>> END EXCEPTION\r\n");
        this.textBoxR.SelectionColor = selectionColor;
    }

    public void ShowChar(string s, bool nl)
    {
        object[] objArray = new object[2];
        int t = nl ? 1 : 2;
        objArray[0] = (object)s;
        objArray[1] = (object)t;
        if (this.InvokeRequired)
            this.BeginInvoke((Delegate)new TermForm.InvokeDelegate(this.InvokeFunction), objArray);
        else
            this.InvokeFunction(s, t);
    }

    public void ShowMsg(string s)
    {
        object[] objArray = new object[2];
        int t = 3;
        objArray[0] = (object)s;
        objArray[1] = (object)t;
        if (this.InvokeRequired)
            this.BeginInvoke((Delegate)new TermForm.InvokeDelegate(this.InvokeFunction), objArray);
        else
            this.InvokeFunction(s, t);
    }

    public void SetIndics(bool CTS, bool DSR, bool RLSD, bool Rng)
    {
        object[] objArray = new object[2];
        string s = (CTS ? "1" : "0") + (DSR ? "1" : "0") + (RLSD ? "1" : "0") + (Rng ? "1" : "0");
        int t = 4;
        objArray[0] = (object)s;
        objArray[1] = (object)t;
        if (this.InvokeRequired)
            this.BeginInvoke((Delegate)new TermForm.InvokeDelegate(this.InvokeFunction), objArray);
        else
            this.InvokeFunction(s, t);
    }

    private void InvokeFunction(string s, int t)
    {
        switch (t)
        {
            case 1:
                this.textBoxR.AppendText(s);
                this.textBoxR.AppendText("\r\n");
                break;
            case 2:
                this.textBoxR.AppendText(s);
                break;
            case 3:
                Color selectionColor = this.textBoxR.SelectionColor;
                this.textBoxR.SelectionColor = Color.Green;
                this.textBoxR.AppendText("\r\n" + s + "\r\n");
                this.textBoxR.SelectionColor = selectionColor;
                break;
            case 4:
                this.radioButtonCTS.Checked = s.Substring(0, 1) == "1";
                this.radioButtonDSR.Checked = s.Substring(1, 1) == "1";
                this.radioButtonRLSD.Checked = s.Substring(2, 1) == "1";
                this.radioButtonRng.Checked = s.Substring(3, 1) == "1";
                break;
        }
    }



    private void checkBox_CheckedChanged(object sender, EventArgs e) => BaseTerm.term.OPClick((CheckBox)sender);

    public void OnClose()
    {
        this.textBoxR.BackColor = Color.LightGray;
        this.buttonSet.Enabled = true;
        this.radioButtonCTS.Checked = false;
        this.radioButtonDSR.Checked = false;
        this.radioButtonRLSD.Checked = false;
        this.radioButtonRng.Checked = false;
        this.checkBoxRTS.Checked = false;
        this.checkBoxDTR.Checked = false;
        this.checkBoxBK.Checked = false;
        this.radioButtonCTS.Enabled = false;
        this.radioButtonDSR.Enabled = false;
        this.radioButtonRLSD.Enabled = false;
        this.radioButtonRng.Enabled = false;
        this.checkBoxRTS.Enabled = false;
        this.checkBoxDTR.Enabled = false;
        this.checkBoxBK.Enabled = false;
        this.offlineOnline.Tag = (object)"0";
        this.offlineOnline.Text = "Offline";
        
        if (BaseTerm.settingsFileName == "")
            this.Text = "BaseTerm: Offline";
        else
            this.Text = "BaseTerm: Offline [" + BaseTerm.settingsFileName + "]";
    }

    public void OnOpen()
    {
        this.offlineOnline.Tag = (object)"1";
        this.offlineOnline.Text = "Online";
        this.radioButtonCTS.Enabled = true;
        this.radioButtonDSR.Enabled = true;
        this.radioButtonRLSD.Enabled = true;
        this.radioButtonRng.Enabled = true;
        this.buttonSet.Enabled = false;
        this.textBoxR.BackColor = Color.White;
        this.Text = "BaseTerm Online: " + BaseTerm.settings.port;
    }

    private void buttonSet_Click(object sender, EventArgs e)
    {
        BaseTerm.CommBaseTermSettings settings = BaseTerm.settings;
        settings.port = "COM3";                                     
        settings.baudRate = 115200;                                 
        settings.parity = JH.CommBase.CommBase.Parity.none;        
        settings.dataBits = 8;                                      
        settings.stopBits = JH.CommBase.CommBase.StopBits.one;      
        settings.useRTS = JH.CommBase.CommBase.HSOutput.none;       
        settings.useDTR = JH.CommBase.CommBase.HSOutput.none;       
        settings.XonChar = JH.CommBase.CommBase.ASCII.DC1;          
        settings.XoffChar = JH.CommBase.CommBase.ASCII.DC3;        
        settings.sendTimeoutMultiplier = 0;                        
        settings.sendTimeoutConstant = 0;                           
        settings.rxLowWater = 0;                                    
        settings.rxHighWater = 0;                                   
        settings.rxQueue = 0;                                       
        settings.txQueue = 0;                                       
        settings.checkAllSends = true;                              
        settings.breakLineOnChar = false;                           
        settings.lineBreakChar = JH.CommBase.CommBase.ASCII.NULL;   
        settings.charsInLine = 0;                                   
        settings.showAsHex = false;                                 
    }

    private void buttonClr_Click(object sender, EventArgs e)
    {
        this.textBoxS.Text = "";
        this.textBoxR.Text = "";
        this.inEscape = false;
        this.esc = "";
        this.mark = "";
        this.textBoxS.BackColor = Color.White;
        this.textBoxS.Focus();
    }

    private void BaseTermForm_Load(object sender, EventArgs e) => this.textBoxS.Focus();

    private void buttonImm_Click(object sender, EventArgs e)
    {
        //if (this.buttonImm.Tag.ToString() == "0")
        //{
        //    this.buttonImm.Tag = (object)"1";
        //    this.buttonImm.Text = "Immediate";
        //    BaseTerm.term.Immediate = true;
        //}
        //else
        //{
        //    this.buttonImm.Tag = (object)"0";
        //    this.buttonImm.Text = "Queued";
        //    BaseTerm.term.Immediate = false;
        //}
        
        this.textBoxS.Focus();
        this.buttonImm.Tag = (object)"0";
        this.buttonImm.Text = "Queued";
        BaseTerm.term.Immediate = false;

    }

    private delegate void InvokeDelegate(string s, int t);

    private void btnComandSend_Click(object sender, EventArgs e)
    {
        BaseTerm.term.SendChar((byte) 'F');
        BaseTerm.term.SendChar((byte) '#');
        BaseTerm.term.SendChar((byte) '1');
        BaseTerm.term.SendCtrl("CR");
    }
}
