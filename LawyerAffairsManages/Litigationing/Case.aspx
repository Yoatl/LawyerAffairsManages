<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Case.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Case" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
.rbSkinnedButton{padding-left:2px}.RadButton{cursor:pointer}.rbSkinnedButton{vertical-align:middle}.rbSkinnedButton{vertical-align:top}.rbSkinnedButton{display:inline-block;position:relative;background-color:transparent;background-repeat:no-repeat;border:0 none;height:22px;text-align:center;text-decoration:none;white-space:nowrap;background-position:left -525px;padding-left:4px;vertical-align:top}.RadButton{font-size:12px;font-family:"Segoe UI",Arial,Helvetica,sans-serif}.RadButton{box-sizing:content-box;-moz-box-sizing:content-box}.rbSkinnedButton{padding-left:2px}.RadButton{cursor:pointer}.rbSkinnedButton{vertical-align:middle}.rbSkinnedButton{vertical-align:top}.rbSkinnedButton{display:inline-block;position:relative;background-color:transparent;background-repeat:no-repeat;border:0 none;height:22px;text-align:center;text-decoration:none;white-space:nowrap;background-position:left -525px;padding-left:4px;vertical-align:top}.RadButton{font-size:12px;font-family:"Segoe UI",Arial,Helvetica,sans-serif}.RadButton{box-sizing:content-box;-moz-box-sizing:content-box}.rbDecorated{padding-left:8px;padding-right:12px}.rbDecorated{display:block;*display:inline;*zoom:1;height:22px;padding-left:6px;*padding-left:8px;padding-right:10px;border:0;text-align:center;background-position:right -88px;overflow:visible;background-color:transparent;outline:0;cursor:pointer;-webkit-border-radius:0;-webkit-appearance:none;*line-height:22px}.rbDecorated{line-height:20px}.rbDecorated{font-size:12px;font-family:"Segoe UI",Arial,Helvetica,sans-serif}.rbDecorated{padding-left:8px;padding-right:12px}.rbDecorated{display:block;*display:inline;*zoom:1;height:22px;padding-left:6px;*padding-left:8px;padding-right:10px;border:0;text-align:center;background-position:right -88px;overflow:visible;background-color:transparent;outline:0;cursor:pointer;-webkit-border-radius:0;-webkit-appearance:none;*line-height:22px}.rbDecorated{line-height:20px}.rbDecorated{font-size:12px;font-family:"Segoe UI",Arial,Helvetica,sans-serif}
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var id = -1;
        var pageset = {
            "_addurl": "Case_Add.aspx",
            "_ismax": 1,
            "_addset": {
                "_w": "640",
                "_h": "280"

            },
            "_editurl": "Case_Edit.aspx",
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
            <td class="table-title" colspan="7">案件管理</td>
        </tr>
        <tr>
            <td colspan="7" class="caption">查询条件：</td>
        </tr>
        <tr>
            <td class="table-td-name" style="width: 12%">合同号：</td>
            <td class="table-td-content" style="width: 16%">
                <telerik:RadTextBox ID="RadTextBox2" Runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name" style="width: 12%">客户：</td>
            <td class="table-td-content" style="width: 16%">
                <telerik:RadTextBox ID="RadTextBox1" Runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>

            <td class="table-td-name" style="width: 12%">委托批次：</td>
            <td class="table-td-content" style="width: 16%">
                <telerik:RadDropDownList ID="RadDropDownList1" runat="server" SelectedText="请选择" Skin="Silk">
                    <Items>
                        <telerik:DropDownListItem runat="server" Selected="True" Text="请选择" />
                        <telerik:DropDownListItem runat="server" Text="2017年1月委托" />
                        <telerik:DropDownListItem runat="server" Text="2017年2月委托" />
                        <telerik:DropDownListItem runat="server" Text="2017年3月委托" />
                    </Items>
                </telerik:RadDropDownList>
            </td>
            <td class="table-td-content" style="width: 16%">
                <telerik:RadButton ID="RadButton3" runat="server" Skin="Silk" AutoPostBack="false" Width="80px" Text="查询">
                </telerik:RadButton>
            </td>
        </tr>
        <tr>
            <td class="caption" colspan="7">案件列表：</td>
        </tr>
        <tr>
            <td class="table-td-content" colspan="7">
                <telerik:RadGrid ID="RadGrid" runat="server" Culture="zh-CN" DataSourceID="XmlDataSource1" GroupPanelPosition="Top" Skin="Silk">
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
                            <telerik:GridBoundColumn DataField="合同号" FilterControlAltText="Filter 合同号 column" HeaderText="合同号" SortExpression="合同号" UniqueName="合同号">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="当事人" FilterControlAltText="Filter 当事人 column" HeaderText="当事人" SortExpression="当事人" UniqueName="当事人">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="批次" FilterControlAltText="Filter 批次 column" HeaderText="批次" SortExpression="批次" UniqueName="批次">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="委托日期" FilterControlAltText="Filter 委托日期 column" HeaderText="委托日期" SortExpression="委托日期" UniqueName="委托日期">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="进展" FilterControlAltText="Filter 进展 column" HeaderText="进展" SortExpression="进展" UniqueName="进展">
                            </telerik:GridBoundColumn>
                            <telerik:GridBoundColumn DataField="备注" FilterControlAltText="Filter 备注 column" HeaderText="备注" SortExpression="备注" UniqueName="备注">
                            </telerik:GridBoundColumn>
                        </Columns>
                    </MasterTableView>
                </telerik:RadGrid>
            </td>
        </tr>
        <tr>
            <td class="bottom" colspan="7">
                <telerik:RadButton ID="RadButton2" runat="server" Skin="Silk" Text="添加" Width="80px" OnClientClicked="btn_Add_Clicking" AutoPostBack="False" Style="top: 0px; left: -1px; position: relative;">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton1" runat="server" Skin="Silk" Text="编辑" Width="80px" OnClientClicked="btn_Edit_Clicking" AutoPostBack="False">
                </telerik:RadButton>
            </td>
        </tr>
    </table>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XML/Case.xml"></asp:XmlDataSource>
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
