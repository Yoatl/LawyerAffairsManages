﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="User_Edit.aspx.cs" Inherits="LawyerAffairsManages.SYS_Mananges.User_Edit" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <script type="text/javascript">
        function showDatePicker(v) {
            var inputs = v.getElementsByTagName("input");
            if (inputs[1].checked != true) {
                $("#time").hide();
            } else {
                $("#time").show();
            }
        }
    </script>

       <table class="table-form">
           <tr class="caption">
               <td colspan="2">用户信息 </td>
           </tr>
           <tr>
               <td class="table-td-name" width="25%">用户名：</td>
               <td class="table-td-content">
                   <telerik:RadTextBox ID="RadTextBox1" Runat="server" Skin="Office2010Blue" Text="ls_zy">
                   </telerik:RadTextBox>
               </td>
           </tr>
           <tr>
               <td class="table-td-name" width="25%">密码：</td>
               <td class="table-td-content">
                   <telerik:RadTextBox ID="RadTextBox2" Runat="server" Skin="Office2010Blue">
                   </telerik:RadTextBox>
               </td>
           </tr>
           <tr>
               <td class="table-td-name">姓名：</td>
               <td class="table-td-content">
                   <telerik:RadTextBox ID="RadTextBox3" Runat="server" Skin="Office2010Blue" Text="张律师">
                   </telerik:RadTextBox>
               </td>
           </tr>
           <tr>
            <td class="auto-style1">电话：</td>
            <td class="auto-style2">
                <telerik:RadTextBox ID="RadTextBox4" runat="server" Skin="Office2010Blue" Text="15252984115">
                </telerik:RadTextBox>
            </td>
           </tr>
           <tr>
            <td class="table-td-name">角色：</td>
            <td class="table-td-content">
                <telerik:RadDropDownList ID="RadDropDownList1" runat="server" SelectedText="请选择" SelectedValue="请选择" Skin="Office2010Blue">
                    <Items>
                        <telerik:DropDownListItem runat="server" Text="请选择" Value="请选择" />
                        <telerik:DropDownListItem runat="server" Text="管理员" />
                        <telerik:DropDownListItem runat="server" Selected="True" Text="资深律师" />
                        <telerik:DropDownListItem runat="server" Text="文员" />
                    </Items>
                </telerik:RadDropDownList>
            </td>
           </tr>
           <tr>
               <td class="table-td-name">用户类型：</td>
               <td class="table-td-content">
                   <div style="border:none">
                       <asp:RadioButtonList ID="Rbrole" runat="server" BorderStyle="None" onclick="showDatePicker(this)" RepeatDirection="Horizontal">
                           <asp:ListItem Selected="True" Value="普通用户">普通用户</asp:ListItem>
                           <asp:ListItem Value="临时用户">临时用户</asp:ListItem>
                       </asp:RadioButtonList>
                   </div>
               </td>
           </tr>
           <tr id="time" style="display:none">
               <td class="table-td-name">有效时间： </td>
               <td>

                <telerik:RadDatePicker ID="RadDatePicker" runat="server" Skin="Office2010Blue">
                    <Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" EnableWeekends="True" Culture="zh-CN" FastNavigationNextText="&amp;lt;&amp;lt;" Skin="Office2010Blue"></Calendar>

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
               <td class="table-td-name">启用状态：</td>
               <style type="text/css">

                .c table td {
                    FONT-SIZE: 9pt;
                    TEXT-ALIGN: LEFT;
                    border: none;
                }
                   .auto-style1 {
                       FONT-SIZE: 9pt;
                       width: 15%;
                       TEXT-ALIGN: RIGHT;
                       height: 29px;
                   }
                   .auto-style2 {
                       FONT-SIZE: 9pt;
                       width: 30%;
                       TEXT-ALIGN: LEFT;
                       height: 29px;
                   }
            </style>
               <td class="c">
                   <asp:RadioButtonList ID="Rbrole0" runat="server" BorderStyle="None" RepeatDirection="Horizontal">
                       <asp:ListItem Value="启用">启用</asp:ListItem>
                       <asp:ListItem Selected="True" Value="不启用">不启用</asp:ListItem>
                   </asp:RadioButtonList>
               </td>
           </tr>
           <tr class="caption">
               <td colspan="2">
                <telerik:RadButton ID="RadButton1" runat="server" OnClientClicked="bthCanel_Clicked" AutoPostBack="false" Skin="Office2010Blue" Style="float: right; position: relative;" Text="取消" Width="80px">
                </telerik:RadButton>
                <telerik:RadButton ID="RadButton2" runat="server" Style="float: right; margin-right: 5px;" Text="确定" Width="80px" Skin="Office2010Blue">
                </telerik:RadButton>
               </td>
           </tr>
       </table>

</asp:Content>
