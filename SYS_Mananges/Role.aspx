<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Role.aspx.cs" Inherits="LawyerAffairsManages.SYS_Mananges.Role" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
.RadButton_Office2010Blue.rbSkinnedButton{background-image:url('mvwres://Telerik.Web.UI.Skins, Version=2015.1.225.45, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Office2010Blue.Common.radFormSprite.png');color:#384e73}.RadButton_Office2010Blue{font-family:"Segoe UI",Arial,Helvetica,sans-serif;font-size:12px}.rbSkinnedButton{padding-left:2px}.RadButton{cursor:pointer}.rbSkinnedButton{vertical-align:middle}.rbSkinnedButton{vertical-align:top}.rbSkinnedButton{display:inline-block;position:relative;background-color:transparent;background-repeat:no-repeat;border:0 none;height:22px;text-align:center;text-decoration:none;white-space:nowrap;background-position:left -525px;padding-left:4px;vertical-align:top}.RadButton{font-size:12px;font-family:"Segoe UI",Arial,Helvetica,sans-serif}.RadButton{box-sizing:content-box;-moz-box-sizing:content-box}.RadButton_Office2010Blue .rbDecorated{background-image:url('mvwres://Telerik.Web.UI.Skins, Version=2015.1.225.45, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Office2010Blue.Common.radFormSprite.png');color:#384e73}.RadButton_Office2010Blue .rbDecorated{font-family:"Segoe UI",Arial,Helvetica,sans-serif;font-size:12px}.rbDecorated{padding-left:8px;padding-right:12px}.rbDecorated{display:block;*display:inline;*zoom:1;height:22px;padding-left:6px;*padding-left:8px;padding-right:10px;border:0;text-align:center;background-position:right -88px;overflow:visible;background-color:transparent;outline:0;cursor:pointer;-webkit-border-radius:0;-webkit-appearance:none;*line-height:22px}.rbDecorated{line-height:20px}.rbDecorated{font-size:12px;font-family:"Segoe UI",Arial,Helvetica,sans-serif}</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var id = -1;
        var pageset = {
            "_addurl": "Role_Add.aspx",
            "_ismax": 1 ,
            "_addset": {
                "_w": "640",
                "_h": "280"

            },
            "_editurl": "Role_Edit.aspx",
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
            <td class="table-title">角色管理</td>
        </tr>
        <tr>
            <td class="caption">角色列表：</td>
        </tr>
        <tr>
            <td class="table-td-content">
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
                            <telerik:GridBoundColumn DataField="角色名称" FilterControlAltText="Filter 角色名称 column" HeaderText="角色名称" SortExpression="角色名称" UniqueName="角色名称">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="角色说明" FilterControlAltText="Filter 角色说明 column" HeaderText="角色说明" SortExpression="角色说明" UniqueName="角色说明">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="角色功能数" FilterControlAltText="Filter 角色功能数 column" HeaderText="角色功能数" SortExpression="角色功能数" UniqueName="角色功能数">
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
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XML/Role.xml"></asp:XmlDataSource>
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
