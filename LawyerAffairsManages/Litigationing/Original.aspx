<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Original.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Original" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var id = -1;
        var pageset = {
            "_addurl": "Original_Add.aspx",
            "_ismax": 0,
            "_addset": {
                "_w": "640",
                "_h": "480"

            },
            "_editurl": "Original_Edit.aspx",
            "_editset": {
                "_w": "840",
                "_h": "480"
            }
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
        <tr>
            <td class="table-title" colspan="7">原件管理</td>
        </tr>
        <tr>
            <td colspan="7" class="caption">查询条件：</td>
        </tr>
        <tr>
            <td class="table-td-name" style="width: 12%">合同号码：</td>
            <td class="table-td-content" style="width: 16%">
                <telerik:RadTextBox ID="RadTextBox1" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name" style="width: 12%">借用人：</td>
            <td class="table-td-content" style="width: 16%">
                <telerik:RadTextBox ID="RadTextBox2" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name" style="width: 12%">时间段：</td>
            <td class="table-td-content" style="width: 16%">
                <telerik:RadDropDownList ID="RadDropDownList2" runat="server" SelectedText="请选择" SelectedValue="请选择" Skin="Silk">
                    <Items>
                        <telerik:DropDownListItem runat="server" Selected="True" Text="请选择" Value="请选择" />
                        <telerik:DropDownListItem runat="server" Text="最近三天" />
                        <telerik:DropDownListItem runat="server" Text="最近三个月" />
                        <telerik:DropDownListItem runat="server" Text="最近一年" />
                    </Items>
                </telerik:RadDropDownList>
            </td>

            <td class="table-td-content" style="width: 16%">
                <telerik:RadButton ID="RadButton3" runat="server" Skin="Silk" AutoPostBack="false" Width="80px" Text="查询">
                </telerik:RadButton>
            </td>
        </tr>
        <tr>
            <td class="caption" colspan="7">列表信息：</td>
        </tr>
        <tr>
            <td class="table-td-content" colspan="7">
                <telerik:RadGrid ID="RadGrid" runat="server" Culture="zh-CN" DataSourceID="XmlDataSource1" GroupPanelPosition="Top" Skin="Silk">
                    <ClientSettings EnableRowHoverStyle="True">
                        <Selecting AllowRowSelect="True" />
                        <ClientEvents OnRowClick="GetID" />
                        <Resizing AllowColumnResize="true" />
                    </ClientSettings>
                    <MasterTableView AutoGenerateColumns="False" ClientDataKeyNames="合同号码" DataSourceID="XmlDataSource1">
                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" Visible="True">
                            <HeaderStyle Width="20px" />
                        </RowIndicatorColumn>
                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" Visible="True">
                            <HeaderStyle Width="20px" />
                        </ExpandCollapseColumn>
                        <Columns>
                            <telerik:GridBoundColumn DataField="合同号码" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 合同号码 column" HeaderText="合同号码" SortExpression="合同号码" UniqueName="合同号码">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="客户名称" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 客户名称 column" HeaderText="客户名称" SortExpression="客户名称" UniqueName="客户名称">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="文件名称" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 文件名称 column" HeaderText="文件名称" SortExpression="文件名称" UniqueName="文件名称">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="文件类型" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 文件类型 column" HeaderText="文件类型" SortExpression="文件类型" UniqueName="文件类型">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="状态" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 状态 column" HeaderText="状态" SortExpression="状态" UniqueName="状态">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="借出时间" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 借出时间 column" HeaderText="借出时间" SortExpression="借出时间" UniqueName="借出时间">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="是否过期" FilterControlAltText="Filter 是否过期 column" HeaderText="是否过期" SortExpression="是否过期" UniqueName="是否过期">
                            </telerik:GridBoundColumn>
                        </Columns>
                    </MasterTableView>
                </telerik:RadGrid>
            </td>
        </tr>
        <tr>
            <td class="bottom"  colspan="7">

                <telerik:RadButton ID="RadButton2" runat="server" Skin="Silk" Text="添加借出" Width="80px" OnClientClicked="btn_Add_Clicking" AutoPostBack="False" >
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton1" runat="server" Skin="Silk" Text="编辑" Width="80px" OnClientClicked="btn_Edit_Clicking" AutoPostBack="False">
                </telerik:RadButton>
            </td>
        </tr>
    </table>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XML/Original.xml"></asp:XmlDataSource>
    <telerik:RadAjaxManager ID="Ajax1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Behavior="Close" Behaviors="Close" Modal="True" Skin="Silk">
        <Localization Close="关闭" />
    </telerik:RadWindowManager>
</asp:Content>
