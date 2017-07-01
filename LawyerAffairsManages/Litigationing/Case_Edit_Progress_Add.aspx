<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Case_Edit_Progress_Add.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Case_Edit_Progress_Add" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            FONT-SIZE: 9pt;
            width: 15%;
            TEXT-ALIGN: RIGHT;
            height: 26px;
        }

        .auto-style2 {
            FONT-SIZE: 9pt;
            width: 30%;
            TEXT-ALIGN: LEFT;
            height: 26px;
        }

        .auto-style3 {
            width: 257px;
            height: 128px;
        }

        .auto-style4 {
            FONT-SIZE: 9pt;
            width: 15%;
            TEXT-ALIGN: RIGHT;
            height: 19px;
        }

        .auto-style5 {
            FONT-SIZE: 9pt;
            width: 30%;
            TEXT-ALIGN: LEFT;
            height: 19px;
        }

        .auto-style6 {
            FONT-SIZE: 9pt;
            width: 15%;
            TEXT-ALIGN: RIGHT;
            height: 141px;
        }

        .auto-style7 {
            FONT-SIZE: 9pt;
            width: 30%;
            TEXT-ALIGN: LEFT;
            height: 141px;
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
    <script type="text/javascript">
        function check(v) {
            if (1 == v) {
                if ($('#check1').is(':checked')) {
                    $('#yj').show();
                } else {
                    $('#yj').hide();
                }
            } else {
                if ($('#check2').is(':checked')) {
                    $('#sc').show();
                } else {
                    $('#sc').hide();
                }
            }
        }
    </script>

    <table class="table-form">
        <tr class="caption">
            <td colspan="2">添加进展 </td>
        </tr>
        <tr id="jz1">
            <td class="auto-style1" width="25%">进展类别：</td>
            <td class="auto-style2">
                <telerik:RadDropDownList ID="RadDropDownList1" runat="server" Skin="Silk" SelectedText="请选择">
                    <Items>
                        <telerik:DropDownListItem runat="server" Selected="True" Text="请选择" />
                        <telerik:DropDownListItem runat="server" Text="诉前处理" />
                        <telerik:DropDownListItem runat="server" Text="诉讼" />
                        <telerik:DropDownListItem runat="server" Text="其他" />
                    </Items>
                </telerik:RadDropDownList>
            </td>
        </tr>
        <tr id="jz2" runat="server">
            <td class="auto-style1" width="25%">进展名称：</td>
            <td class="auto-style2">
                <telerik:RadTextBox ID="RadTextBox1" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6" width="25%">进展说明：</td>
            <td class="auto-style7">
                <textarea id="TextArea1" class="auto-style3" name="S1"></textarea></td>
        </tr>
        <tr>
            <td class="auto-style4" width="25%">是否邮寄：</td>
            <td class="auto-style5">
                <input type="checkbox" id="check1" onclick="check(1)" />
                <div id="yj" style="display: none">
                    <telerik:RadTextBox ID="RadTextBox2" runat="server" Skin="Silk" Width="100px" Text="请填写运单号" ToolTip="请填写运单号">
                    </telerik:RadTextBox>
                </div>

            </td>
        </tr>
        <tr>
            <td class="table-td-name">文件上传：</td>
            <td class="table-td-content">
                <input type="checkbox" id="check2" onclick="check(2)" />
                <div id="sc" style="display: none">
                    <telerik:RadAsyncUpload ID="upload1" runat="server" Culture="zh-CN" MaxFileInputsCount="1" Skin="Silk" >
                        <Localization Cancel="返回" DropZone="拖动文件上传" Remove="删除" Select="选择" />
                    </telerik:RadAsyncUpload>
                </div>

            </td>
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
