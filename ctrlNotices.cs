using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace wfBiblio
{
    public partial class ctrlNotices : UserControl
    {
        public ctrlNotices()
        {
            InitializeComponent();
        }

        public void SetNotice(Notice notice)
        {
            timer1.Stop();
            pictureBox1.Image = null;

            if (notice != null)
            {
                noticeBindingSource.DataSource = new List<Notice>() { notice };
                noticeBindingSource.Position = 0;
                timer1.Start();
            }
            else
                noticeBindingSource.Clear();
        }

        public Notice GetNotice()
        {
            if (noticeBindingSource.Count == 0)
                return null;

            noticeBindingSource.EndEdit();
            return ((List<Notice>)noticeBindingSource.DataSource)[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            var notice = GetNotice();
            string search = notice.isbn;
            if (search.Length < 8)
                search = notice.titre;
            try
            {
                var req = HttpWebRequest.Create("https://www.googleapis.com/books/v1/volumes?q=" + WebUtility.UrlDecode(search));
                using (var resp = req.GetResponse())
                {
                    var results = new System.IO.StreamReader(resp.GetResponseStream()).ReadToEnd();
                    dynamic result = Newtonsoft.Json.Linq.JObject.Parse(results);
                    if (result.items.Count > 0)
                    {
                        string tmp = result.items[0].volumeInfo.imageLinks.smallThumbnail;
                        pictureBox1.Load(tmp);
                    }
                }
            }
            catch { }
        }
    }
}
