<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Case_Add.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Case_Add" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function display1() {
            $("#ls1").show();
        }
        function hide1() {
            $("#ls1").hide();
        }
    </script>
    <table class="table-form">
        <tr class="caption">
            <td colspan="2">案件添加 </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">合同号：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox1" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">批次：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox2" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">案由：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox5" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">案件类别：</td>
            <td class="table-td-content">
                <telerik:RadDropDownList ID="RadDropDownList1" runat="server" SelectedText="请选择" Skin="Silk">
                    <Items>
                        <telerik:DropDownListItem runat="server" Selected="True" Text="请选择" />
                        <telerik:DropDownListItem runat="server" Text="行政诉讼" />
                        <telerik:DropDownListItem runat="server" Text="民事诉讼" />
                        <telerik:DropDownListItem runat="server" Text="刑事诉讼" />
                    </Items>
                </telerik:RadDropDownList>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">委托律师：</td>
            <td class="table-td-content">
                <telerik:RadDropDownList ID="RadDropDownList2" runat="server" SelectedText="请选择" Skin="Silk">
                    <Items>
                        <telerik:DropDownListItem runat="server" Selected="True" Text="请选择" />
                        <telerik:DropDownListItem runat="server" Text="张律师" />
                        <telerik:DropDownListItem runat="server" Text="吴律师" />
                        <telerik:DropDownListItem runat="server" Text="孙律师" />
                    </Items>
                </telerik:RadDropDownList>
                <a onclick="display1()" style="padding-top: 5px">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/scripts/images/add.jpg" Width="20" Height="20" /></a>

                <div id="ls1" style="display: none">
                    <br />
                    <telerik:RadDropDownList ID="RadDropDownList3" runat="server" SelectedText="请选择" Skin="Silk">
                        <Items>
                            <telerik:DropDownListItem runat="server" Selected="True" Text="请选择" />
                            <telerik:DropDownListItem runat="server" Text="张律师" />
                            <telerik:DropDownListItem runat="server" Text="吴律师" />
                            <telerik:DropDownListItem runat="server" Text="孙律师" />
                        </Items>
                    </telerik:RadDropDownList>
                    <a onclick="display1()" style="padding-top: 5px">
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/scripts/images/add.jpg" Width="20" Height="20" /></a>
                    <a onclick="hide1()">
                        <asp:Image ID="Image3" runat="server" ImageUrl="~/scripts/images/jian.jpg" Width="20" Height="20" /></a>
                </div>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">委托时间：</td>
            <td class="table-td-content">
                <telerik:RadDatePicker ID="RadDatePicker1" runat="server" Skin="Silk">
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
                <textarea id="TextArea1" class="auto-style1" cols="20" name="S1" rows="1"></textarea></td>
        </tr>
        <tr class="caption">
            <td colspan="2">
                <telerik:RadButton ID="RadButton1" runat="server" AutoPostBack="false" OnClientClicked="bthCanel_Clicked" Skin="Silk" Style="float: right; position: relative;" Text="取消" Width="80px">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton2" runat="server" Skin="Silk" Style="float: right; margin-right: 5px;" Text="确定" Width="80px">
                </telerik:RadButton>
            </td>
        </tr>
    </table>
</asp:Content>
