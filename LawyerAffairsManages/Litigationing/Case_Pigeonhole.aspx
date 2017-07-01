<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Case_Pigeonhole.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Case_Pigeonhole" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style1 {
            width: 373px;
            height: 127px;
        }
    

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
            <td colspan="2">归档</td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">归档时间：</td>
            <td class="table-td-content">
                <telerik:RadDatePicker ID="RadDatePicker" Runat="server" Skin="Silk">
                    <Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" EnableWeekends="True" Culture="zh-CN" FastNavigationNextText="&amp;lt;&amp;lt;" skin="Silk">
                    </Calendar>
                    <DateInput DisplayDateFormat="yyyy/M/d" DateFormat="yyyy/M/d" LabelWidth="40%">
                        <EmptyMessageStyle Resize="None">
                        </EmptyMessageStyle>
                        <ReadOnlyStyle Resize="None">
                        </ReadOnlyStyle>
                        <FocusedStyle Resize="None">
                        </FocusedStyle>
                        <DisabledStyle Resize="None">
                        </DisabledStyle>
                        <InvalidStyle Resize="None">
                        </InvalidStyle>
                        <HoveredStyle Resize="None">
                        </HoveredStyle>
                        <EnabledStyle Resize="None">
                        </EnabledStyle>
                    </DateInput>
                    <DatePopupButton ImageUrl="" HoverImageUrl="">
                    </DatePopupButton>
                </telerik:RadDatePicker>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">编号：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox1" Runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">归档摘要：</td>
            <td class="table-td-content">
                <textarea id="TextArea1" class="auto-style1" name="S1" cols="20" rows="1"></textarea> </td>
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
