<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navicat.aspx.cs" Inherits="LawyerAffairsManages.Navicat" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="scripts/css/BaseStyle.css" type="text/css" rel="Stylesheet" />
</head>
<script language="javascript">
    function back() {
        window.parent.frames.location.href = "login.html";
    }
</script>
<body>
    <form style="width: 180px" id="form1" runat="server">
        <div>
            <div style="float: left; width: 180px; height: 64px; font-size: 24px; margin-left: 0px; text-align: center;" class="main_top_span">
                律师事务<br />
                业务系统
            </div>
            <div style="float: left; width: 180px; height: 32px; font-size: 12px; margin-left: 0px; text-align: center;">欢迎登陆！&nbsp<a onclick="back()" style="cursor: pointer;">[登出]</a></div>
            <div style="float: left; border: 0px solid #e5e5e5; height: 100%; width: 180px; text-align: center;">
                <div id="left">
                    <a href="SYS_Mananges/Templates.aspx" target="main">
                        <img src="scripts/images/nav/mbgl.png" alt="" />
                    </a>
                    <a href="SYS_Mananges/User.aspx" target="main">
                        <img src="scripts/images/nav/yhgl.png" alt="" />
                    </a>
                    <a href="SYS_Mananges/Role.aspx" target="main">
                        <img src="scripts/images/nav/jsgl.png" alt="" />
                    </a>
                    <a href="Litigationing/Entrusteds.aspx" target="main">
                        <img src="scripts/images/nav/wtgl.png" alt="" />
                    </a>
                    <a href="Litigationing/Case.aspx" target="main">
                        <img src="scripts/images/nav/ajgl.png" alt="" />
                    </a>
                    <a href="Litigationing/Original.aspx" target="main">
                        <img src="scripts/images/nav/yjgl.png" alt="" />
                    </a>
                    <div style="height: 20px; width: 100%; clear: both;">&nbsp;</div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
