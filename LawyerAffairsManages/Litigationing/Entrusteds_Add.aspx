<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Entrusteds_Add.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Entrusteds_Add" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table-form">
        <tr class="caption">
            <td colspan="4">基本信息</td>
        </tr>
        <tr>
            <td class="table-td-name">合同号:</td>
            <td class="table-td-content" colspan="3">
                <telerik:RadTextBox ID="txtCCNumber" Width="250px" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name">借出人:</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="txtBName" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name">联系电话:</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="txtBPhone" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name">邮编:</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="txtPost" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name">联系地址:</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox2" runat="server" Width="220px" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>

        <tr class="caption">
            <td colspan="4">共借人信息</td>
        </tr>
        <tr>
            <td class="table-td-name">姓名:</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="txtCName" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name">联系电话:</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="txtCPhone" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name">邮编:</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="txtCPost" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name">联系地址:</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="txtCAddress" runat="server" Width="220px" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>

        <tr class="caption">
            <td colspan="4">担保人信息</td>
        </tr>
        <tr>
            <td class="table-td-name">姓名:</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="txtGName" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name">联系电话:</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="txtGPhone" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name">邮编:</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="txtGPost" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name">联系地址:</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="txtGAddress" runat="server" Width="220px" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr class="caption">
            <td colspan="4">更多信息</td>
        </tr>
        <tr>
            <td class="table-td-name"></td>
            <td class="table-td-content">
                <telerik:RadDatePicker ID="OHTDate" runat="server" Skin="Silk">
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
            <td class="table-td-name">&nbsp;</td>
            <td class="table-td-content">
                <telerik:RadDatePicker ID="AFCSDate" runat="server" Skin="Silk">
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
            <td class="table-td-name">&nbsp;</td>
            <td class="table-td-content">
                <telerik:RadDatePicker ID="ASDate" runat="server" Skin="Silk">
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
        <tr class="caption">
            <td colspan="4">
                <telerik:RadButton ID="RadButton1" runat="server" OnClientClicked="bthCanel_Clicked" AutoPostBack="false" Skin="Silk" Style="float: right; position: relative;" Text="取消" Width="80px">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton2" runat="server" Style="float: right; margin-right: 5px;" Text="确定" Width="80px" Skin="Silk">
                </telerik:RadButton>
            </td>
        </tr>
    </table>
</asp:Content>
