<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Role_Edit.aspx.cs" Inherits="LawyerAffairsManages.SYS_Mananges.Role_Edit" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

                .auto-style1 {
                    FONT-SIZE: 9pt;
                    width: 10%;
                    TEXT-ALIGN: LEFT;
                }
            </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table-form">
        <tr class="caption">
            <td colspan="2">角色信息 </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">角色名称：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="txtName" Runat="server" Text="管理员">
                </telerik:RadTextBox>
            </td>
        </tr>
                        <tr>
            <td class="table-td-name" width="25%">角色说明：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox2" Runat="server" Skin="Office2010Blue" Text="管理系统基本设置">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name">启用状态：</td>
            <style type="text/css">

                .c table td {
                    FONT-SIZE: 9pt;
                    TEXT-ALIGN: LEFT;
                    border: none;
                }
                .auto-style1 {
                    FONT-SIZE: 9pt;
                    width: 10%;
                    TEXT-ALIGN: LEFT;
                }
            </style>
            <td class="c">
                <asp:RadioButtonList ID="Rbrole" runat="server" BorderStyle="None" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="1">可用</asp:ListItem>
                    <asp:ListItem Value="0">不可用</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
    </table>
    <table class="table-form">
        <tr class="caption">
            <td colspan="3">权限设置 </td>
        </tr>
        <tr>
            <td class="table-td-name" rowspan="3">系统功能：</td>
            <td class="auto-style1">角色管理</td>
            <td class="table-td-content">
                <asp:CheckBoxList ID="CheckBoxList3" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">增加</asp:ListItem>
                    <asp:ListItem Selected="True">修改</asp:ListItem>
                    <asp:ListItem Selected="True">删除</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">用户管理</td>
            <td class="table-td-content">
                <asp:CheckBoxList ID="CheckBoxList4" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">增加</asp:ListItem>
                    <asp:ListItem Selected="True">修改</asp:ListItem>
                    <asp:ListItem Selected="True">删除</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">模板管理</td>
            <td class="table-td-content">
                <asp:CheckBoxList ID="CheckBoxList5" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">增加</asp:ListItem>
                    <asp:ListItem Selected="True">修改</asp:ListItem>
                    <asp:ListItem Selected="True">删除</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" rowspan="2">诉讼功能：</td>
            <td class="auto-style1">委托管理</td>
            <td class="table-td-content">
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>增加</asp:ListItem>
                    <asp:ListItem>修改</asp:ListItem>
                    <asp:ListItem>删除</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">案件管理&nbsp;</td>
            <td class="table-td-content">
                <asp:CheckBoxList ID="CheckBoxList2" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>增加</asp:ListItem>
                    <asp:ListItem>修改</asp:ListItem>
                    <asp:ListItem>删除</asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr class="caption">
            <td colspan="3">
                    <telerik:RadButton ID="RadButton1" runat="server" OnClientClicked="bthCanel_Clicked" AutoPostBack="false" Skin="Office2010Blue" Style="float: right; position: relative;" Text="取消" Width="80px">
                    </telerik:RadButton>
                    <telerik:RadButton ID="RadButton2" runat="server" Style="float: right; margin-right: 5px;" Text="确定" Width="80px" Skin="Office2010Blue">
                    </telerik:RadButton>
            </td>
        </tr>
    </table>

</asp:Content>
