using agsXMPP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMPP_Study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            teste();

        }
        public void teste()
        {
            XmppClientConnection xmpp = new XmppClientConnection("3TECNOS10");
            xmpp.Open("felipemsx", "123456@!");
            // xmpp.OnLogin += delegate (object o) { xmpp.Send(new Message("test@jabber.org", MessageType.chat, "Hello, how are you?")); };

        }
    }

 
}
