<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Original_Add.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Original_Add" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 325px;
            height: 122px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table-form">
        <tr class="caption">
            <td colspan="2">原件添加 </td>
        </tr>
                <tr>
            <td class="table-td-name" width="25%">合同号：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox2" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">原件名称：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox1" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name">文件类型：</td>
            <td class="table-td-content">
                <telerik:RadDropDownList ID="RadDropDownList1" runat="server" SelectedText="DropDownListItem1" Skin="Silk">
                    <Items>
                        <telerik:DropDownListItem runat="server" Selected="True" Text="请选择" />
                        <telerik:DropDownListItem runat="server" Text="原件" />
                        <telerik:DropDownListItem runat="server" Text="扫描件" />
                    </Items>
                </telerik:RadDropDownList>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">到所时间：</td>
            <td class="table-td-content">
                <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" Skin="Silk">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" EnableWeekends="True" Culture="zh-CN" FastNavigationNextText="&amp;lt;&amp;lt;" Skin="Silk"></Calendar>

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
            <td class="table-td-name" width="25%">备注：</td>
            <td class="table-td-content">
                <textarea id="TextArea1" class="auto-style3" name="S1"></textarea></td>
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
