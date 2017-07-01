<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LawyerAffairsManages.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>

            <table class="table-form">
                <tr>
                    <td class="table-title">模板管理</td>
                </tr>
                <tr>
                    <td class="caption">模板列表：</td>
                </tr>
                <tr>
                    <td class="table-td-content">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="bottom">
                        &nbsp;</td>
                </tr>
            </table>

        </div>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XML/Template.xml"></asp:XmlDataSource>

</asp:Content>
