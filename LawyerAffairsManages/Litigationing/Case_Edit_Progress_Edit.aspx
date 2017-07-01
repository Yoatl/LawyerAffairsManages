<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Case_Edit_Progress_Edit.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Case_Edit_Progress_Edit" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 257px;
            height: 128px;
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
            <td colspan="2">进展详情 </td>
        </tr>
        <tr id="jz1">
            <td class="table-td-name" width="25%">进展类别：</td>
            <td class="">
                <telerik:RadDropDownList ID="RadDropDownList1" runat="server" Skin="Silk" SelectedText="请选择">
                    <Items>
                        <telerik:DropDownListItem runat="server"  Text="请选择" />
                        <telerik:DropDownListItem runat="server" Text="诉前处理" />
                        <telerik:DropDownListItem runat="server" Text="诉讼" Selected="True" />
                        <telerik:DropDownListItem runat="server" Text="其他" />
                    </Items>
                </telerik:RadDropDownList>
            </td>
        </tr>
        <tr id="jz2" runat="server">
            <td class="table-td-name" width="25%">进展名称：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox1" Text="邮寄传票" runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">进展说明：</td>
            <td class="table-td-content">
                <textarea id="TextArea1" class="auto-style3" name="S1" cols="20" rows="1">邮寄传票中</textarea></td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">邮寄信息：</td>
            <td class="table-td-content">
                <ul>
                    <li><span class="date">2017-03-06</span><span class="week">周一</span><span class="time">09:10:47<span style="color: rgb(51, 51, 51); font-family: tahoma, arial, &quot; hiragino sans gb&quot; , simsun, sans-serif; font-size: 12px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(243, 243, 243); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">由【江苏无锡中转部】发往【江苏镇江公司】</span></span></li>
                    <li><span class="date">2017-03-06</span><span class="week">周一</span><span class="time">09:10:47</span><span style="color: rgb(51, 51, 51); font-family: tahoma, arial, &quot; hiragino sans gb&quot; , simsun, sans-serif; font-size: 12px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(243, 243, 243); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">快件已到达【江苏镇江公司】 扫描员是【操作员17】</span></li>
                    <li><span class="date">2017-03-06</span><span class="week">周一</span><span class="time">09:10:47</span><span style="color: rgb(51, 51, 51); font-family: tahoma, arial, &quot; hiragino sans gb&quot; , simsun, sans-serif; font-size: 12px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(243, 243, 243); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">已签收,签收人是南校区报亭代签</span></li>

                </ul>
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
