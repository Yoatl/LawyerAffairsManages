<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Entrusteds_Import.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Entrusteds_Import" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js">
            </asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
    <table class="table-form">
        <tr class="caption">
            <td class="auto-style1" colspan="2">导入委托</td>
        </tr>
        <tr>
            <td class="table-td-name" >文件上传：</td>
            <td class="table-td-content">
                <telerik:RadAsyncUpload ID="RadAsyncUpload1" MaxFileInputsCount="1" runat="server" Culture="zh-CN" runat="server" Skin="Silk">
                    <Localization Cancel="返回" DropZone="拖动文件上传" Remove="删除" Select="选择" />
                </telerik:RadAsyncUpload>
            </td>
        </tr>
        <tr class="caption">
            <td colspan="2">
                <telerik:RadButton ID="RadButton1" runat="server" OnClientClicked="bthCanel_Clicked" AutoPostBack="false" Skin="Silk" Style="float: right; position: relative;" Text="取消" Width="80px">
                </telerik:RadButton>
                <telerik:RadButton ID="bth_Import" runat="server"  Style="float: right; margin-right: 5px;" Text="确定" Width="80px" Skin="Silk"  OnClick="RadButton2_Click">
                </telerik:RadButton>
            </td>
        </tr>
    </table>
    <telerik:RadAjaxManager ID="Ajax12" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="bth_Import">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="bth_Import" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>

</asp:Content>
