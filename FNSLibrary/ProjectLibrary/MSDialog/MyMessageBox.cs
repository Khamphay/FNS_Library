using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLibrary.MSDialog
{
   public static class MyMessageBox
    {
        public static DialogResult ShowMesage(string message, string header, MessageBoxButtons button, MessageBoxIcon icon)
        {
            DialogResult result = DialogResult.None;
            switch (button)
            {
                //OK
                case MessageBoxButtons.OK:
                    using (DialogOK msgOK = new DialogOK())
                    {
                        msgOK.Text = header;
                        msgOK.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgOK.MessageIcon = ProjectLibrary.Properties.Resources.done;
                                break;
                            case MessageBoxIcon.Question:
                                msgOK.MessageIcon = ProjectLibrary.Properties.Resources.question;
                                break;
                            case MessageBoxIcon.Warning:
                                msgOK.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgOK.MessageIcon = Properties.Resources.error;
                                break;
                        }
                        result = msgOK.ShowDialog();
                    }
                    break;

                    //OKCancel
                case MessageBoxButtons.OKCancel:
                    using (DialogOKCancel msgOKCancel = new DialogOKCancel())
                    {
                        msgOKCancel.Text = header;
                        msgOKCancel.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Information:
                                msgOKCancel.MessageIcon = ProjectLibrary.Properties.Resources.info;
                                break;
                            case MessageBoxIcon.Question:
                                msgOKCancel.MessageIcon = ProjectLibrary.Properties.Resources.question;
                                break;
                            case MessageBoxIcon.Warning:
                                msgOKCancel.MessageIcon = Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Error:
                                msgOKCancel.MessageIcon = Properties.Resources.error;
                                break;
                        }
                        result = msgOKCancel.ShowDialog();
                    }
                    break;
                //YesNo
                case MessageBoxButtons.YesNo:
                    using (DialogYesNo msgYseNo = new DialogYesNo())
                    {
                        msgYseNo.Text = header;
                        msgYseNo.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Warning:
                                msgYseNo.MessageIcon = ProjectLibrary.Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Information:
                                msgYseNo.MessageIcon = ProjectLibrary.Properties.Resources.info;
                                break;
                            case MessageBoxIcon.Question:
                                msgYseNo.MessageIcon = Properties.Resources.question;
                                break;
                        }
                      result= msgYseNo.ShowDialog();
                    }
                    break;
                //YesNoCancel
                case MessageBoxButtons.YesNoCancel:
                    using (DialogYesNoCancel msgYseNoCancel = new DialogYesNoCancel())
                    {
                        msgYseNoCancel.Text = header;
                        msgYseNoCancel.Message = message;
                        switch (icon)
                        {
                            case MessageBoxIcon.Warning:
                                msgYseNoCancel.MessageIcon = ProjectLibrary.Properties.Resources.warning;
                                break;
                            case MessageBoxIcon.Question:
                                msgYseNoCancel.MessageIcon = Properties.Resources.question;
                                break;
                        }
                        result = msgYseNoCancel.ShowDialog();
                    }
                    break;
            }
            return result;
        }
    }
}
