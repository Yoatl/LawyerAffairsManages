<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Case_Edit_Doc_Add.aspx.cs" Inherits="LawyerAffairsManages.Litigationing.Case_Edit_Doc_Add" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style8 {
            float: right;
            position: relative;
            left: 0px;
            top: 0px;
        }
        .auto-style9 {
            width: 437px;
            height: 145px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <script type="text/javascript">
        function check(v) {
            if (1 == v) {
                if (!$('#check1').is(':checked')) {
                    $('#sc').show();
                    $('#yj').show();
                } else {
                    $('#sc').hide();
                    $('#yj').hide()
                }
            } else {
                if (!$('#check2').is(':checked')) {
                    $('#sc').show();
                    $('#yj').show();
                } else {
                    $('#sc').hide();
                    $('#yj').hide()
                }
            }
        }
    </script>

    <table class="table-form">
        <tr class="caption">
            <td colspan="2">添加文书</td>
        </tr>
        <tr id="jz1">
            <td class="table-td-name" width="25%">文书类别：</td>
            <td class="">
                <telerik:RadDropDownList ID="RadDropDownList1" runat="server" Skin="Silk" SelectedText="律师函">
                    <Items>
                        <telerik:DropDownListItem runat="server"  Text="请选择" />
                        <telerik:DropDownListItem runat="server" Text="委托书" />
                        <telerik:DropDownListItem runat="server" Text="律师函" Selected="True" />
                        <telerik:DropDownListItem runat="server" Text="委托代理合同" />
                        <telerik:DropDownListItem runat="server" Text="其他" />
                    </Items>
                </telerik:RadDropDownList>
            </td>
        </tr>
        <tr id="jz2" runat="server">
            <td class="table-td-name" width="25%">发文日期：</td>
            <td class="table-td-content">
                <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" Skin="Silk">
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
            <td class="table-td-name" width="25%">文书编号：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox1" Runat="server" Skin="Silk">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">文书标题：</td>
            <td class="table-td-content">
                <telerik:RadTextBox ID="RadTextBox2" runat="server" Skin="Silk" Width="284px">
                </telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td class="table-td-name" width="25%">附件：</td>
            <td class="table-td-content">

                <telerik:RadAsyncUpload ID="upload1" runat="server" Culture="zh-CN" MaxFileInputsCount="1" Skin="Silk">
                    <Localization Cancel="返回" DropZone="拖动文件上传" Remove="删除" Select="选择" />
                </telerik:RadAsyncUpload>
            </td>
        </tr>
                <tr>
            <td class="table-td-name" width="25%">备注：</td>
            <td class="table-td-content">
                <textarea id="TextArea1" class="auto-style9"></textarea>
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
