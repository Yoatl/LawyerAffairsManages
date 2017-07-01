<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Case_Edit_File_Edit.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Case_Edit_File_Edit" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .auto-style8 {
            float: right;
            position: relative;
            left: 0px;
            top: 0px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table class="table-form">
        <tr class="caption">
            <td colspan="2">文件详细</td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">文件标题：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox1" Text="管辖权异议裁定书" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">附件：</td>
            <td class="table-td-content">
                <telerik:RadAsyncUpload ID="upload1" runat="server" Culture="zh-CN" MaxFileInputsCount="1" Skin="Silk">
                    <Localization Cancel="返回" DropZone="拖动文件上传" Remove="删除" Select="选择" />
                </telerik:RadAsyncUpload>
            </td>
        </tr>
        <tr class="caption">
            <td colspan="2">
                <telerik:RadButton ID="RadButton1" runat="server" OnClientClicked="bthCanel_Clicked" AutoPostBack="false" Skin="Silk" Text="取消" Width="80px" CssClass="auto-style8">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton2" runat="server" Style="float: right; margin-right: 5px;" Text="确定" Width="80px" Skin="Silk">
                </telerik:RadButton>
            </td>
        </tr>
    </table>

</asp:Content>
