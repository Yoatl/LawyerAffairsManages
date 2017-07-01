<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Entrusteds.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Entrusteds" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var id = -1;
        function btn_Import_Clicking(sender, args) {
            var oWnd = radopen("Entrusteds_Import.aspx", "RadWindowManager1");
            oWnd.setSize("640", "250");
            oWnd.center();
        }
        var pageset = {
            "_addurl": "Entrusteds_Add.aspx",
            "_ismax": 0,
            "_addset": {
                "_w": "640",
                "_h": "480"

            },
            "_editurl": "Entrusteds_Edit.aspx",
            "_editset": {
                "_w": "640",
                "_h": "480"
            }
        }
        function GetID(sender, args) {
            id = args.getDataKeyValue("EntrID");
        }
        function refreshGrid(args) {
            $find("<%= Ajax1.ClientID %>").ajaxRequest("Rebind");
            id = -1;
        }
    </script>
    <table class="table-form">
        <tr>
            <td class="table-title" colspan="7">委托管理</td>
        </tr>
        <tr>
            <td colspan="7" class="caption">查询条件：</td>
        </tr>
        <tr>
            <td class="table-td-name" style="width:12%">委托人：</td>
            <td class="table-td-content" style="width:16%">
                <telerik:RadTextBox ID="RadTextBox1" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name" style="width:12%">时间段：</td>
            <td class="table-td-content" style="width:16%">
                <telerik:RadDropDownList ID="RadDropDownList2" runat="server" SelectedText="请选择" SelectedValue="请选择" Skin="Silk">
                    <Items>
                        <telerik:DropDownListItem runat="server" Selected="True" Text="请选择" Value="请选择" />
                        <telerik:DropDownListItem runat="server" Text="最近三天" />
                        <telerik:DropDownListItem runat="server" Text="最近三个月" />
                        <telerik:DropDownListItem runat="server" Text="最近一年" />
                    </Items>
                </telerik:RadDropDownList>
            </td>
            <td class="table-td-name" style="width:12%">处理状态：</td>
            <td class="table-td-content" style="width:16%">
                <telerik:RadDropDownList ID="RadDropDownList1" runat="server" SelectedText="请选择" SelectedValue="请选择" Skin="Silk">
                    <Items>
                        <telerik:DropDownListItem runat="server" Selected="True" Text="请选择" Value="请选择" />
                        <telerik:DropDownListItem runat="server" Text="已处理" />
                        <telerik:DropDownListItem runat="server" Text="未处理" />
                    </Items>
                </telerik:RadDropDownList>
            </td>
            <td class="table-td-content" style="width:16%">
                <telerik:RadButton ID="RadButton3" runat="server" Skin="Silk" AutoPostBack="false" Width="80px" Text="查询">
                </telerik:RadButton>
            </td>
        </tr>
        <tr>
            <td class="caption" colspan="7">委托列表：</td>
        </tr>
        <tr>
            <td class="table-td-content" colspan="7">
                <telerik:RadGrid ID="WTList" runat="server" Culture="zh-CN" GroupPanelPosition="Top" Skin="Silk">
                    <ClientSettings EnableRowHoverStyle="True">
                        <Selecting AllowRowSelect="True" />
                        <ClientEvents OnRowClick="GetID" />
                        <Resizing AllowColumnResize="true" />
                    </ClientSettings>
                    <MasterTableView NoDetailRecordsText="没有数据！" NoMasterRecordsText="没有数据！" AutoGenerateColumns="false" DataKeyNames="EntrID" ClientDataKeyNames="EntrID">
                        <Columns>
                            <telerik:GridBoundColumn DataField="CaseContractNumber" FilterControlAltText="Filter State column" HeaderText="合同号" SortExpression="CaseContractNumber" UniqueName="CaseContractNumber">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="EntrFullName" FilterControlAltText="Filter State column" HeaderText="借出人" SortExpression="EntrFullName" UniqueName="EntrFullName">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="EntrFullPhone" FilterControlAltText="Filter State column" HeaderText="联系方式" SortExpression="EntrFullPhone" UniqueName="EntrFullPhone">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="EntrFullPost" FilterControlAltText="Filter State column" HeaderText="邮编" SortExpression="EntrFullPost" UniqueName="EntrFullPost">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="EntrFullAddress" FilterControlAltText="Filter State column" HeaderText="地址" SortExpression="EntrFullAddress" UniqueName="EntrFullAddress">
                            </telerik:GridBoundColumn>
                        </Columns>
                    </MasterTableView>
                </telerik:RadGrid>
            </td>
        </tr>
        <tr>
            <td class="bottom" colspan="7">
                <telerik:RadButton ID="RadButton4" runat="server" Skin="Silk" Text="导入" Width="80px" OnClientClicked="btn_Import_Clicking" AutoPostBack="False" Style="top: 0px; left: -1px; position: relative;">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton2" runat="server" Skin="Silk" Text="添加" Width="80px" OnClientClicked="btn_Add_Clicking" AutoPostBack="False" Style="top: 0px; left: -1px; position: relative;">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton1" runat="server" Skin="Silk" Text="编辑" Width="80px" OnClientClicked="btn_Edit_Clicking" AutoPostBack="False">
                </telerik:RadButton>
            </td>
        </tr>
    </table>
    <telerik:RadAjaxManager ID="Ajax1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="bth_Import">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="bth_Import" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
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
