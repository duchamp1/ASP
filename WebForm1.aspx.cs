//アップロードされたファイルを簡単に保存する方法
//http://aspnet.keicode.com/controls/fileupload-save-file.php
//20200124 アップロードによりタイムスタンプが更新されてしまうため、ファイルコピー処理に変更 
//         「終了」ボタン追加 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm1 : System.Web.UI.Page
{
    //20180629 UPDATE START
    const string SAVEPATH = "C:\\UploadedFiles";
    const string MSG = "The uploaded files was saved as ";
    //20180629 UPDATE END

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            //アップロード先
            string path = SAVEPATH;
            //string path = "C:\\UploadedFiles";
            //ファイル名の取得
            string oldFileName = FileUpload1.PostedFile.FileName; //20200124 ADD 
            string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            //パスとファイル名の連結
            string filePath = Path.Combine(path, fileName);
            //20200124 UPDATE START 
            //FileUpload1.SaveAs(filePath);
            File.Copy(oldFileName, filePath);//ファイルコピー
            //20200124 UPDATE END
            Label1.Text = MSG + filePath;
//            Label1.Text = "The uploaded files was saved as " + filePath;
        }
    }

    //20200124 ADD 
    protected void btnEnd_Click(object sender, EventArgs e)
    {
        Response.Write("<script language='javascript'> { window.close();}</script>");
    }
}