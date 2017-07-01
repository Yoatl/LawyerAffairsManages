<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Templates.aspx.cs" Inherits="LawyerAffairsManages.SYS_Mananges.Templates" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var id = -1;
        var pageset = {
            "_addurl": "Templates_Add.aspx",
            "_ismax": 0,
            "_addset": {
                "_w": "640",
                "_h": "280"

            },
            "_editurl": "Templates_Edit.aspx",
            "_editset": {
                "_w": "640",
                "_h": "280"
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
            <td class="table-title">模板管理</td>
        </tr>
        <tr>
            <td class="caption">模板列表：</td>
        </tr>
        <tr>
            <td class="table-td-content">
                <telerik:RadGrid ID="RadGrid1" runat="server" Culture="zh-CN" DataSourceID="XmlDataSource1" GroupPanelPosition="Top" Skin="Office2010Blue">
                    <ClientSettings EnableRowHoverStyle="True">
                        <Selecting AllowRowSelect="True" />
                        <ClientEvents OnRowClick="GetID" />
                        <Resizing AllowColumnResize="true" />
                    </ClientSettings>
                    <MasterTableView AutoGenerateColumns="False" DataKeyNames="管理号" ClientDataKeyNames="管理号" DataSourceID="XmlDataSource1">
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
                            <telerik:GridBoundColumn DataField="名称" FilterControlAltText="Filter 名称 column" HeaderText="名称" SortExpression="名称" UniqueName="名称">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="说明" FilterControlAltText="Filter 说明 column" HeaderText="说明" SortExpression="说明" UniqueName="说明">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="启用状态" FilterControlAltText="Filter 启用状态 column" HeaderText="启用状态" SortExpression="启用状态" UniqueName="启用状态">
                            </telerik:GridBoundColumn>
                        </Columns>
                    </MasterTableView>
                </telerik:RadGrid>
            </td>
        </tr>
        <tr>
            <td class="bottom">
                <telerik:RadButton ID="RadButton2" runat="server" Skin="Office2010Blue" Text="添加" Width="80px" OnClientClicked="btn_Add_Clicking" AutoPostBack="False" Style="top: 0px; left: -1px; position: relative;">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton1" runat="server" Skin="Office2010Blue" Text="编辑" Width="80px"  OnClientClicked="btn_Edit_Clicking" AutoPostBack="False">
                </telerik:RadButton>
            </td>
        </tr>
    </table>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XML/Template.xml"></asp:XmlDataSource>
    <telerik:RadAjaxManager ID="Ajax1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Behavior="Close" Behaviors="Close" Modal="True" Skin="Office2010Blue">
        <Localization Close="关闭" />
    </telerik:RadWindowManager>
</asp:Content>
