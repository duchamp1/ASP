//アップロードされたファイルを簡単に保存する方法
//http://aspnet.keicode.com/controls/fileupload-save-file.php
//20200124 アップロードによりタイムスタンプが更新されてしまうため、ファイルコピー処理に変更 
//         「終了」ボタン追加 
//20200508 Gitにアップ・コメント削除
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm1 : System.Web.UI.Page
{
    const string SAVEPATH = "C:\\UploadedFiles";
    const string MSG = "The uploaded files was saved as ";
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //「送信」ボタン
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            //アップロード先
            string path = SAVEPATH;
            //ファイル名の取得
            string oldFileName = FileUpload1.PostedFile.FileName;
            string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            //パスとファイル名の連結
            string filePath = Path.Combine(path, fileName);
            //ファイルコピー
            File.Copy(oldFileName, filePath);
            Label1.Text = MSG + filePath;
        }
        else
        {
            Response.Write("<H3><font color='red'>ファイルを選択してください。</font></H3>");
        }
    }

    //「終了」ボタン
    protected void btnEnd_Click(object sender, EventArgs e)
    {
        Response.Write("<script language='javascript'> { window.close();}</script>");
    }
}