<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Original_Back.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Original_Back" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
.rbSkinnedButton{padding-left:2px}.RadButton{cursor:pointer}.rbSkinnedButton{vertical-align:middle}.rbSkinnedButton{vertical-align:top}.rbSkinnedButton{display:inline-block;position:relative;background-color:transparent;background-repeat:no-repeat;border:0 none;height:22px;text-align:center;text-decoration:none;white-space:nowrap;background-position:left -525px;padding-left:4px;vertical-align:top}.RadButton{font-size:12px;font-family:"Segoe UI",Arial,Helvetica,sans-serif}.RadButton{box-sizing:content-box;-moz-box-sizing:content-box}.rbDecorated{padding-left:8px;padding-right:12px}.rbDecorated{display:block;*display:inline;*zoom:1;height:22px;padding-left:6px;*padding-left:8px;padding-right:10px;border:0;text-align:center;background-position:right -88px;overflow:visible;background-color:transparent;outline:0;cursor:pointer;-webkit-border-radius:0;-webkit-appearance:none;*line-height:22px}.rbDecorated{line-height:20px}.rbDecorated{font-size:12px;font-family:"Segoe UI",Arial,Helvetica,sans-serif}
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table-form">
        <tr class="caption">
            <td colspan="2">原件借出归还</td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">归还方:</td>
            <td class="table-td-content">
                <telerik:RadDropDownList ID="RadDropDownList1" runat="server" SelectedText="奔驰方" Skin="Silk">
                    <Items>
                        <telerik:DropDownListItem runat="server" Text="请选择" />
                        <telerik:DropDownListItem runat="server" Selected="True"  Text="奔驰方" />
                        <telerik:DropDownListItem runat="server" Text="代理方" />
                        <telerik:DropDownListItem runat="server" Text="借款人" />
                    </Items>
                </telerik:RadDropDownList>
            </td>
        </tr>

        <tr>
            <td class="table-td-name" width="25%">时间：</td>
            <td class="table-td-content">

                <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" Skin="Silk">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" EnableWeekends="True" Culture="zh-CN" FastNavigationNextText="&amp;lt;&amp;lt;" skin="Silk"></Calendar>

<DateInput DisplayDateFormat="yyyy/M/d" DateFormat="yyyy/M/d" LabelWidth="40%">
<EmptyMessageStyle Resize="None"></EmptyMessageStyle>

<ReadOnlyStyle Resize="None"></ReadOnlyStyle>

<FocusedStyle Resize="None"></FocusedStyle>

<DisabledStyle Resize="None"></DisabledStyle>

<InvalidStyle Resize="None"></InvalidStyle>

<HoveredStyle Resize="None"></HoveredStyle>

<EnabledStyle Resize="None"></EnabledStyle>
</DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl=""></DatePopupButton>
                </telerik:RadDatePicker>
            </td>
        </tr>
        
        <tr>
            <td class="table-td-name" width="25%">凭证：</td>
            <td class="table-td-content">

                <telerik:RadAsyncUpload ID="upload2" MaxFileInputsCount="1" runat="server" Culture="zh-CN" Skin="Silk">
                    <Localization Cancel="返回" DropZone="拖动文件上传" Remove="删除" Select="选择" />
                </telerik:RadAsyncUpload>
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
