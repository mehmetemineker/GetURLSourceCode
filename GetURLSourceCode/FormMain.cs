using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetURLSourceCode
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGetSourceCode_Click(object sender, EventArgs e)
        {
            textBoxSouceCode.Text = GetSourceCode(textBoxUrl.Text);
        }

        static string GetSourceCode(string url)
        {
            //Http Web isteği oluştur
            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(url);

            //İstek sonucu gelen cevabı al
            HttpWebResponse webResp = (HttpWebResponse)webReq.GetResponse();

            //Cevabı gelen veriyi oku
            using (StreamReader sRead = new StreamReader(webResp.GetResponseStream(), Encoding.UTF8))
            {
                return sRead.ReadToEnd();
            }
        }
    }
}
