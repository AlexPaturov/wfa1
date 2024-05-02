// Decompiled with JetBrains decompiler
// Type: BaseTerm
// Assembly: wfa1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7ED32045-7058-479A-A9C3-646DCED5C6E6
// Assembly location: D:\repos\cSharp\job\wfa1\wfa1.exe

using JH.CommBase;
using System;
using System.IO;
using System.Windows.Forms;

public class BaseTerm : JH.CommBase.CommBase
{
    public static TermForm frm;
    public static BaseTerm term;
    public static BaseTerm.CommBaseTermSettings settings;
    public static string settingsFileName = "";
    private int lineCount = 0;
    public bool Immediate = false;

    [STAThread]
    private static int Main(string[] args)
    {
        BaseTerm.settings = new BaseTerm.CommBaseTermSettings();
        //----------------------------------------------------------------------------------------------
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
        //-----------------------------------------------------------------------------------------------
        BaseTerm.term = new BaseTerm();
        BaseTerm.frm = new TermForm();
        Application.Run((Form)BaseTerm.frm);
        return 0;
    }

    public void SendChar(byte c)
    {
        try
        {
            if (this.Immediate)
                this.SendImmediate(c);
            else
                this.Send(c);
        }
        catch (CommPortException ex)
        {
            BaseTerm.frm.ShowException(ex);
        }
    }

    public void SendFile(FileStream fs)
    {
        byte[] numArray = new byte[fs.Length];
        fs.Read(numArray, 0, (int)fs.Length);
        this.Send(numArray);
    }

    public bool SendCtrl(string s)
    {
        JH.CommBase.CommBase.ASCII ascii = JH.CommBase.CommBase.ASCII.NULL;
        JH.CommBase.CommBase.ASCII c;
        try
        {
            c = (JH.CommBase.CommBase.ASCII)Enum.Parse(ascii.GetType(), s, true);
        }
        catch
        {
            return false;
        }
        this.SendChar((byte)c);
        return true;
    }

    //public void setOPTicks(CheckBox chk)
    //{
    //    switch (int.Parse(chk.Tag.ToString()))
    //    {
    //        case 0:
    //            chk.Enabled = this.RTSavailable;
    //            chk.Checked = this.RTS;
    //            break;
    //        case 1:
    //            chk.Enabled = this.DTRavailable;
    //            chk.Checked = this.DTR;
    //            break;
    //        case 2:
    //            chk.Enabled = true;
    //            chk.Checked = this.Break;
    //            break;
    //    }
    //}

    public void OPClick(CheckBox chk)
    {
        try
        {
            switch (int.Parse(chk.Tag.ToString()))
            {
                case 0:
                    this.RTS = chk.Checked;
                    break;
                case 1:
                    this.DTR = chk.Checked;
                    break;
                case 2:
                    this.Break = chk.Checked;
                    break;
            }
        }
        catch (CommPortException ex)
        {
            BaseTerm.frm.ShowException(ex);
        }
    }

    public new JH.CommBase.CommBase.QueueStatus GetQueueStatus() => base.GetQueueStatus();

    public new bool IsCongested() => base.IsCongested();

    protected override JH.CommBase.CommBase.CommBaseSettings CommSettings() => (JH.CommBase.CommBase.CommBaseSettings)BaseTerm.settings;

    protected override void OnRxChar(byte c)
    {
        bool nl = false;
        JH.CommBase.CommBase.ASCII ascii = (JH.CommBase.CommBase.ASCII)c;
        if (BaseTerm.settings.charsInLine > 0)
            nl = ++this.lineCount >= BaseTerm.settings.charsInLine;
        if (BaseTerm.settings.breakLineOnChar && ascii == BaseTerm.settings.lineBreakChar)
            nl = true;
        if (nl)
            this.lineCount = 0;
        string s;
        if (BaseTerm.settings.showAsHex)
        {
            s = c.ToString("X2");
            if (!nl)
                s += " ";
        }
        else
            s = c >= (byte)32 && c <= (byte)126 ? new string((char)c, 1) : "<" + ascii.ToString() + ">";
        BaseTerm.frm.ShowChar(s, nl);
    }

    protected override void OnBreak() => BaseTerm.frm.ShowMsg(">>>> BREAK");

    protected override bool AfterOpen()
    {
        BaseTerm.frm.OnOpen();
        JH.CommBase.CommBase.ModemStatus modemStatus = this.GetModemStatus();
        BaseTerm.frm.SetIndics(modemStatus.cts, modemStatus.dsr, modemStatus.rlsd, modemStatus.ring);
        return true;
    }

    protected override void BeforeClose(bool e)
    {
        if (BaseTerm.settings.autoReopen && e)
        {
            BaseTerm.frm.OnOpen();
        }
        else
        {
            BaseTerm.frm.OnClose();
            BaseTerm.frm.ShowMsg(">>>> OFFLINE");
        }
    }

    protected override void OnStatusChange(JH.CommBase.CommBase.ModemStatus c, JH.CommBase.CommBase.ModemStatus v) => BaseTerm.frm.SetIndics(v.cts, v.dsr, v.rlsd, v.ring);

    public class CommBaseTermSettings : JH.CommBase.CommBase.CommBaseSettings
    {
        public bool showAsHex = false;
        public bool breakLineOnChar = false;
        public JH.CommBase.CommBase.ASCII lineBreakChar = JH.CommBase.CommBase.ASCII.NULL;
        public int charsInLine = 0;

        public static BaseTerm.CommBaseTermSettings LoadFromXML(Stream s) => 
            (BaseTerm.CommBaseTermSettings)JH.CommBase.CommBase.CommBaseSettings.LoadFromXML(s, typeof(BaseTerm.CommBaseTermSettings));
    }
}
