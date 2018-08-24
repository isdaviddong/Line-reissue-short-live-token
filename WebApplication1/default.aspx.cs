using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        const string Channel_ID = "!!!請換成你的Channel_ID!!!"; //例如 -->  160XXXXX37
        const string Channel_Secret = "!!!請換成你的Channel_Secret!!!";  //例如 -->  9d6e49bxxxxxxxxxx90xxxx863bd69e7
        const string AdminUserId = "!!!請換成你的AdminUserId!!!"; //例如 -->  U6bXXXXXXXXX3422XXXX341bXX6b8XXXX

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //重新issue一個 short-lived token
            var token = isRock.LineBot.Utility.IssueChannelAccessToken(Channel_ID, Channel_Secret);
            //顯示在TextBox1中
            this.TextBox1.Text = token.access_token;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //用TextBox1中的新token發送訊息
            var token = this.TextBox1.Text;
            var bot = new Bot(token);
            //發貼圖給admin
            bot.PushMessage(AdminUserId, 1, 2);
        }
    }
}