<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Original_Edit.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Original_Edit" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 325px;
            height: 122px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function btn_Add_Clicking1(sender, args) {

            var oWnd = radopen("Original_Back.aspx", "RadWindowManager2");
            oWnd.setSize(600, 300);


            oWnd.center();
        }
                function GetID(sender, args) {
            id = args.getDataKeyValue("合同号码");
        }
        function refreshGrid(args) {
            $find("<%= Ajax1.ClientID %>").ajaxRequest("Rebind");
            id = -1;
        }
    </script>
    <table class="table-form">
        <tr class="caption">
            <td colspan="2" class="table-td-name">原件详细 </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">合同号：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox1" Text="XX-25165001" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">原件名称：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox2" Text="XX公司" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name">文件类型：</td>

            <td class="table-td-content">
                <telerik:RadDropDownList ID="RadDropDownList1" runat="server" SelectedText="DropDownListItem1" Skin="Silk">
                    <Items>
                        <telerik:DropDownListItem runat="server" Text="请选择" />
                        <telerik:DropDownListItem runat="server" Selected="True" Text="原件" />
                        <telerik:DropDownListItem runat="server" Text="扫描件" />
                    </Items>
                </telerik:RadDropDownList>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">到所时间：</td>
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
                <textarea id="TextArea1" class="auto-style1" name="S1">借的时间比较短</textarea></td>
        </tr>

        <tr class="">
            <td colspan="2">
                <telerik:RadButton ID="RadButton1" runat="server" OnClientClicked="bthCanel_Clicked" AutoPostBack="false" Skin="Silk" Style="float: right; position: relative;" Text="取消" Width="80px">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton2" runat="server" Style="float: right; margin-right: 5px;" Text="确定" Width="80px" Skin="Silk">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton3" runat="server" Style="float: right; margin-right: 5px;" Text="归还" Width="80px" Skin="Silk" OnClientClicked="btn_Add_Clicking1" AutoPostBack="False">
                </telerik:RadButton>
            </td>
        </tr>
        <tr class="caption">
            <td colspan="2">原件借出记录 </td>
        </tr>
        <tr>
            <td colspan="2">

                <telerik:RadGrid ID="RadGrid" runat="server" Culture="zh-CN" DataSourceID="XmlDataSource1" GroupPanelPosition="Top" Skin="Silk">
                    <ClientSettings EnableRowHoverStyle="True">
                        <Selecting AllowRowSelect="True" />
                        <ClientEvents OnRowClick="GetID" />
                        <Resizing AllowColumnResize="true" />
                    </ClientSettings>
                    <MasterTableView AutoGenerateColumns="False" ClientDataKeyNames="记录时间" DataSourceID="XmlDataSource1">
                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" Visible="True">
                            <HeaderStyle Width="20px" />
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" Visible="True">
                            <HeaderStyle Width="20px" />
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridBoundColumn DataField="记录时间" FilterControlAltText="Filter 记录时间 column" HeaderText="记录时间" SortExpression="记录时间" UniqueName="记录时间">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="借用人" FilterControlAltText="Filter 借用人 column" HeaderText="借用人" SortExpression="借用人" UniqueName="借用人">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="目的"  FilterControlAltText="Filter 目的 column" HeaderText="目的" SortExpression="目的" UniqueName="目的">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="状态"  FilterControlAltText="Filter 状态 column" HeaderText="状态" SortExpression="状态" UniqueName="状态">
                            </telerik:GridBoundColumn>
                        </Columns>
                    </MasterTableView>
                </telerik:RadGrid>

            </td>
        </tr>
                <tr class="">
            <td colspan="2">
                <telerik:RadButton ID="RadButton4" runat="server" OnClientClicked="bthCanel_Clicked" AutoPostBack="false" Skin="Silk" Style="float: right; position: relative;" Text="编辑" Width="80px">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton5" runat="server" Style="float: right; margin-right: 5px;" Text="添加" Width="80px" Skin="Silk">
                </telerik:RadButton>
            </td>
        </tr>
    </table>
    <telerik:RadWindowManager ID="RadWindowManager2" runat="server" Behavior="Close" Behaviors="Close" Modal="True" Skin="Silk">
        <Localization Close="关闭" />
    </telerik:RadWindowManager>

                <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XML/OriginalProgress.xml"></asp:XmlDataSource>

    <telerik:RadAjaxManager ID="Ajax1" runat="server">
    </telerik:RadAjaxManager>

</asp:Content>
