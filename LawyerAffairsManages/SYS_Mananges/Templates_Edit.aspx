<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Templates_Edit.aspx.cs" Inherits="LawyerAffairsManages.SYS_Mananges.Templates_Edit" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table class="table-form">
        <tr class="caption">
            <td colspan="2">模板信息 </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">模板名称：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox2" Runat="server" Skin="Silk" Text="撤诉申请">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name">模板说明：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox3" Runat="server" Skin="Silk" Text="撤诉申请书模板文件">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name">模板文件：</td>
            <td class="table-td-content">
                        <telerik:RadAsyncUpload ID="upload1"  MaxFileInputsCount="1" runat="server" Culture="zh-CN" Skin="Silk">
                             <Localization Cancel="返回" DropZone="拖动文件上传" Remove="删除" Select="选择" />
                        </telerik:RadAsyncUpload>
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
            </style>
            <td class="c">
                <asp:RadioButtonList ID="Rbrole" runat="server" BorderStyle="None" RepeatDirection="Horizontal">
                    <asp:ListItem Value="1" Selected="True">可用</asp:ListItem>
                    <asp:ListItem Value="0">不可用</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr class="caption">
            <td colspan="2">
                    <telerik:RadButton ID="RadButton1" runat="server" OnClientClicked="bthCanel_Clicked" AutoPostBack="false" Skin="Silk" Style="float: right; position: relative;" Text="取消" Width="80px">
                    </telerik:RadButton>
                    <telerik:RadButton ID="RadButton2" runat="server" Style="float: right; margin-right: 5px;" Text="确定" Width="80px" Skin="Silk">
                    </telerik:RadButton>
            </td>
        </tr>
    </table>
    
</asp:Content>
