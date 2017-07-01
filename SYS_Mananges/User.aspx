<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="LawyerAffairsManages.SYS_Mananges.User" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var id = -1;
        var pageset = {
            "_addurl": "User_Add.aspx",
            "_ismax": 0,
            "_addset": {
                "_w": "640",
                "_h": "380"

            },
            "_editurl": "User_Edit.aspx",
            "_editset": {
                "_w": "640",
                "_h": "380"
            }
        }
        function GetID(sender, args) {
            id = args.getDataKeyValue("管理号");
        }
        function refreshGrid(args) {
            $find("<%= Ajax1.ClientID %>").ajaxRequest("Rebind");
            id = -1;
        }
    </script>
        <table class="table-form">
        <tr>
            <td colspan="5" class="table-title">用户管理</td>
        </tr>
        <tr>
            <td  colspan="5" class="caption">查询条件：</td>
        </tr>
        <tr>
            <td class="table-td-name">姓名：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox1" Runat="server" Skin="Office2010Blue">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name">用户类型</td>
            <td class="table-td-content">
                <telerik:RadDropDownList ID="RadDropDownList1" runat="server" SelectedText="请选择" SelectedValue="请选择" Skin="Office2010Blue">
                    <Items>
                        <telerik:DropDownListItem runat="server" Selected="True" Text="请选择" Value="请选择" />
                        <telerik:DropDownListItem runat="server" Text="普通用户" />
                        <telerik:DropDownListItem runat="server" Text="临时用户" />
                    </Items>
                </telerik:RadDropDownList>
            </td>
            <td class="table-td-content">
                <telerik:RadButton ID="RadButton3" runat="server" Skin="Office2010Blue" AutoPostBack="false" Width="80px" Text="查询">
                </telerik:RadButton>
            </td>
        </tr>
        <tr >
            <td colspan="5">
                <telerik:RadGrid ID="RadGrid" runat="server" Culture="zh-CN" DataSourceID="XmlDataSource1" GroupPanelPosition="Top" Skin="Office2010Blue">
                    <ClientSettings EnableRowHoverStyle="True">
                        <Selecting AllowRowSelect="True" />
                        <ClientEvents OnRowClick="GetID" />
                        <Resizing AllowColumnResize="true" />
                    </ClientSettings>
                    <MasterTableView AutoGenerateColumns="False" ClientDataKeyNames="管理号" DataSourceID="XmlDataSource1">
                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" Visible="True">
                            <HeaderStyle Width="20px" />
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" Visible="True">
                            <HeaderStyle Width="20px" />
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridBoundColumn DataField="管理号" FilterControlAltText="Filter 管理号 column" HeaderText="管理号" SortExpression="管理号" UniqueName="管理号">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="用户名" FilterControlAltText="Filter 用户名 column" HeaderText="用户名" SortExpression="用户名" UniqueName="用户名">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="姓名" FilterControlAltText="Filter 姓名 column" HeaderText="姓名" SortExpression="姓名" UniqueName="姓名">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="电话" FilterControlAltText="Filter 电话 column" HeaderText="电话" SortExpression="电话" UniqueName="电话">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="角色" FilterControlAltText="Filter 角色 column" HeaderText="角色" SortExpression="角色" UniqueName="角色">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="用户类型" FilterControlAltText="Filter 用户类型 column" HeaderText="用户类型" SortExpression="用户类型" UniqueName="用户类型">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="启用状态" FilterControlAltText="Filter 启用状态 column" HeaderText="启用状态" SortExpression="启用状态" UniqueName="启用状态">
                            </telerik:GridBoundColumn>
                        </Columns>
                    </MasterTableView>
                </telerik:RadGrid>
            </td>
        </tr>
        <tr>
            <td colspan="5" class="bottom">
                <telerik:RadButton ID="RadButton2" runat="server" Skin="Office2010Blue" Text="添加" Width="80px" OnClientClicked="btn_Add_Clicking" AutoPostBack="False" Style="top: 0px; left: -1px; position: relative;">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton1" runat="server" Skin="Office2010Blue" Text="编辑" Width="80px"  OnClientClicked="btn_Edit_Clicking" AutoPostBack="False">
                </telerik:RadButton>
            </td>
        </tr>
    </table>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XML/User.xml"></asp:XmlDataSource>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Behavior="Close" Behaviors="Close" Modal="True" Skin="Office2010Blue">
        <Localization Close="关闭" />
    </telerik:RadWindowManager>

    <telerik:RadAjaxManager ID="Ajax1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    
</asp:Content>
