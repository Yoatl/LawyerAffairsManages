<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Case_Edit.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Case_Edit" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 80%;
            height: 118px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var id = -1;
        var pageset = {
            "_addurl": "Case_Add.aspx",
            "_ismax": 0,
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
        function GetID1(sender, args) {
            id = args.getDataKeyValue("进展名称");
        }
        function GetID2(sender, args) {
            id = args.getDataKeyValue("文书类别");
        }
        function GetID3(sender, args) {
            id = args.getDataKeyValue("文件名称");
        }
        function refreshGrid(args) {
            $find("<%= Ajax1.ClientID %>").ajaxRequest("Rebind");
            id = -1;
        }

        function btn_End_Clicking(sender, args) {

            var oWnd = radopen("Case_End.aspx", "RadWindowManager1");
            oWnd.setSize("640", "380");
            oWnd.center();
        }
        function btn_Pige_Clicking(sender, args) {

            var oWnd = radopen("Case_Pigeonhole.aspx", "RadWindowManager1");
            oWnd.setSize("640", "380");
            oWnd.center();
        }

        function btn_Add1_Clicking(sender, args) {

            var oWnd = radopen("Case_Edit_Progress_Add.aspx", "RadWindowManager1");
            oWnd.setSize("640", "480");
            oWnd.center();
        }
        function btn_Add2_Clicking(sender, args) {

            var oWnd = radopen("Case_Edit_Doc_Add.aspx", "RadWindowManager1");
            oWnd.setSize("640", "480");
            oWnd.center();
        }
        function btn_Add3_Clicking(sender, args) {
            var oWnd = radopen("Case_Edit_File_Add.aspx", "RadWindowManager1");
            oWnd.setSize("640", "480");
            oWnd.center();
        }
        function btn_Edit1_Clicking(sender, args) {
            if (id == -1) {
                alert("请选择1条数据！");
            } else {
                var oWnd = radopen("Case_Edit_Progress_Edit.aspx?id=" + id, "RadWindowManager1");
                oWnd.Maximize();
                oWnd.center();
            }
        }
        function btn_Edit2_Clicking(sender, args) {
            if (id == -1) {
                alert("请选择1条数据！");
            } else {
                var oWnd = radopen("Case_Edit_Doc_Edit.aspx?id=" + id, "RadWindowManager1");
                oWnd.setSize(680, 420);
                oWnd.center();
            }
        }
        function btn_Edit3_Clicking(sender, args) {
            if (id == -1) {
                alert("请选择1条数据！");
            } else {
                var oWnd = radopen("Case_Edit_File_Edit.aspx?id=" + id, "RadWindowManager1");
                oWnd.setSize(680, 420);
                oWnd.center();
            }
        }
    </script>
    <table class="table-form">
        <tr class="caption">
            <td colspan="4">基本信息 </td>
        </tr>
        <tr>
            <td class="table-td-name">合同号：</td>
            <td>
                <telerik:RadTextBox ID="RadTextBox1" Text="IP153293" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name">批次：</td>
            <td>
                <telerik:RadTextBox ID="RadTextBox3" Text="第三批" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name">当事人：</td>
            <td>
                <telerik:RadTextBox ID="RadTextBox2" Text="冯利凤" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
            <td class="table-td-name">委托时间</td>
            <td>
                <telerik:RadTextBox ID="RadTextBox4" Text="2013/6/3" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name">备注：</td>
            <td colspan="3">
                <textarea id="TextArea1" class="auto-style1" cols="20" name="S1" rows="1">这个案子比较的重要，请尽快处理</textarea></td>
        </tr>
        <tr>
            <td colspan="4">
                <telerik:RadButton ID="RadButton1" runat="server" OnClientClicked="bthCanel_Clicked" Style="float: right; margin-right: 5px;" AutoPostBack="false" Skin="Silk" Text="取消" Width="80px">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton3" runat="server" Style="float: right; margin-right: 5px;" Text="保存" Width="80px" Skin="Silk">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton4" runat="server" Style="float: right; margin-right: 5px;" Text="归档" Width="80px" Skin="Silk" AutoPostBack="False" OnClientClicked="btn_Pige_Clicking">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton2" runat="server" Style="float: right; margin-right: 5px;" Text="结案" Width="80px" Skin="Silk" AutoPostBack="False" OnClientClicked="btn_End_Clicking">
                </telerik:RadButton>
            </td>
        </tr>
    </table>
    <br />
    <table class="table-form">
        <tr>
            <td class="caption">
                <telerik:RadTabStrip RenderMode="Lightweight" ID="TabStrip1" runat="server" EnableDragToReorder="True" Skin="Bootstrap" MultiPageID="RadMultiPag1" SelectedIndex="0">
                    <Tabs>
                        <telerik:RadTab Text="案件进展"></telerik:RadTab>
                        <telerik:RadTab Text="文书公函"></telerik:RadTab>
                        <telerik:RadTab Text="案件文档"></telerik:RadTab>
                    </Tabs>
                </telerik:RadTabStrip>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadMultiPage ID="RadMultiPag1" Width="100%" runat="server" CssClass="RadMultiPage" SelectedIndex="0">
                    <telerik:RadPageView ID="RadPageView1" runat="server" Style="overflow: hidden">
                        <table class="table-form">
                            <tr>
                                <td>
                                    <telerik:RadGrid ID="RadGrid1" runat="server" Skin="Silk" Culture="zh-CN" DataSourceID="XmlDataSource1" GroupPanelPosition="Top">
                                        <ClientSettings EnableRowHoverStyle="True">
                                            <Selecting AllowRowSelect="True" />
                                            <ClientEvents OnRowClick="GetID1" />
                                            <Resizing AllowColumnResize="true" />
                                        </ClientSettings>
                                        <MasterTableView AutoGenerateColumns="False" DataSourceID="XmlDataSource1">
                                            <Columns>
                                                <telerik:GridBoundColumn DataField="进展名称" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 进展名称 column" HeaderText="进展名称" SortExpression="进展名称" UniqueName="进展名称">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="时间" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 时间 column" HeaderText="时间" SortExpression="时间" UniqueName="时间">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="进展内容" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 进展内容 column" HeaderText="进展内容" SortExpression="进展内容" UniqueName="进展内容">
                                                </telerik:GridBoundColumn>
                                            </Columns>
                                        </MasterTableView>
                                    </telerik:RadGrid>
                                    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XML/CaseProgress.xml"></asp:XmlDataSource>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" class="caption" style="text-align: right">
                                    <telerik:RadButton ID="RadButton13" runat="server" Style="top: 0px; left: -1px; position: relative;" Text="添加" Width="80px" Skin="Silk" AutoPostBack="False" OnClientClicked="btn_Add1_Clicking">
                                    </telerik:RadButton>
                                    <telerik:RadButton ID="RadButton14" runat="server" AutoPostBack="False" OnClientClicked="btn_Edit1_Clicking" Skin="Silk" Text="编辑" Width="80px">
                                    </telerik:RadButton>
                                </td>
                            </tr>
                        </table>
                    </telerik:RadPageView>
                    <telerik:RadPageView ID="RadPageView2" runat="server" Style="overflow: hidden">

                        <table class="table-form">
                            <tr>
                                <td>
                                    <telerik:RadGrid ID="RadGrid2" runat="server" Culture="zh-CN" DataSourceID="XmlDataSource2" GroupPanelPosition="Top" Skin="Silk">
                                        <ClientSettings EnableRowHoverStyle="True">
                                            <Selecting AllowRowSelect="True" />
                                            <ClientEvents OnRowClick="GetID2" />
                                            <Resizing AllowColumnResize="true" />
                                        </ClientSettings>
                                        <MasterTableView AutoGenerateColumns="False" DataSourceID="XmlDataSource2">
                                            <Columns>
                                                <telerik:GridBoundColumn DataField="文书类别" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 文书类别 column" HeaderText="文书类别" SortExpression="文书类别" UniqueName="文书类别">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="文书编号" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 文书编号 column" HeaderText="文书编号" SortExpression="文书编号" UniqueName="文书编号">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="文书时间" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 文书时间 column" HeaderText="文书时间" SortExpression="文书时间" UniqueName="文书时间">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="发出人" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 发出人 column" HeaderText="发出人" SortExpression="发出人" UniqueName="发出人">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridButtonColumn CommandName="Delete" ButtonType="ImageButton" ImageUrl="~/scripts/images/fj.png" HeaderText="附件">
                                                </telerik:GridButtonColumn>
                                            </Columns>
                                        </MasterTableView>
                                    </telerik:RadGrid>
                                    <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="~/XML/CaseDoc.xml"></asp:XmlDataSource>
                                </td>
                            </tr>
                            <tr>
                                <td class="caption" colspan="2" style="text-align: right">

                                    <telerik:RadButton ID="RadButton9" runat="server" AutoPostBack="False" OnClientClicked="btn_Add2_Clicking" Skin="Silk" Style="top: 0px; left: -1px; position: relative;" Text="添加" Width="80px">
                                    </telerik:RadButton>
                                    <telerik:RadButton ID="RadButton10" runat="server" AutoPostBack="False" OnClientClicked="btn_Edit2_Clicking" Skin="Silk" Text="编辑" Width="80px">
                                    </telerik:RadButton>

                                </td>
                            </tr>
                        </table>

                    </telerik:RadPageView>
                    <telerik:RadPageView ID="RadPageView3" runat="server" Style="overflow: hidden">
                        <table class="table-form">
                            <tr>
                                <td>
                                    <telerik:RadGrid ID="RadGrid3" runat="server" Culture="zh-CN" DataSourceID="XmlDataSource3" GroupPanelPosition="Top" Skin="Silk">
                                        <ClientSettings EnableRowHoverStyle="True">
                                            <Selecting AllowRowSelect="True" />
                                            <ClientEvents OnRowClick="GetID3" />
                                            <Resizing AllowColumnResize="true" />
                                        </ClientSettings>
                                        <MasterTableView AutoGenerateColumns="False" DataSourceID="XmlDataSource3">
                                            <Columns>
                                                <telerik:GridBoundColumn DataField="文件名称" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 文件名称 column" HeaderText="文件名称" SortExpression="文件名称" UniqueName="文件名称">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="创建人" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 创建人 column" HeaderText="创建人" SortExpression="创建人" UniqueName="创建人">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="创建时间" HeaderStyle-Height="35px" ItemStyle-Height="35px" FilterControlAltText="Filter 创建时间 column" HeaderText="创建时间" SortExpression="创建时间" UniqueName="创建时间">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridButtonColumn CommandName="Delete" HeaderStyle-Height="35px" ItemStyle-Height="35px" ButtonType="ImageButton" ImageUrl="~/scripts/images/fj.png" HeaderText="附件">
                                                </telerik:GridButtonColumn>
                                            </Columns>
                                        </MasterTableView>
                                    </telerik:RadGrid>
                                    <asp:XmlDataSource ID="XmlDataSource3" runat="server" DataFile="~/XML/CaseFile.xml"></asp:XmlDataSource>
                                </td>
                            </tr>
                            <tr>
                                <td class="caption" colspan="2" style="text-align: right">

                                    <telerik:RadButton ID="RadButton11" runat="server" Skin="Silk" AutoPostBack="False" Style="top: 0px; left: -1px; position: relative;" Text="添加" Width="80px" OnClientClicked="btn_Add3_Clicking">
                                    </telerik:RadButton>
                                    <telerik:RadButton ID="RadButton12" runat="server" AutoPostBack="False" OnClientClicked="btn_Edit3_Clicking" Skin="Silk" Text="编辑" Width="80px">
                                    </telerik:RadButton>
                                </td>
                            </tr>
                        </table>
                    </telerik:RadPageView>
                </telerik:RadMultiPage>
            </td>
        </tr>
    </table>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Behavior="Close" Behaviors="Close" Modal="True" Skin="Silk">
        <Localization Close="关闭" />
    </telerik:RadWindowManager>
    <br />
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
