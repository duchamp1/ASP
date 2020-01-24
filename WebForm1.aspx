<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ファイルアップロード</title>
</head>
<body>
    <form id="Form1" method="post" runat="server" enctype="multipart/form-data">
    <p>送信するファイルを指定して、［送信］ボタンを押してください。</p>
    <p>
        <asp:FileUpload ID="FileUpload1" runat="server" Width="703px" />
        </p>
    <p><asp:Button id="btnUpload" runat="server" Text="送信" OnClick="btnUpload_Click" Width="50px" />
       <asp:Button id="btnEnd" runat="server" Text="終了" OnClick="btnEnd_Click" Width="50px" /></p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    
    </form>
</body>
</html>
