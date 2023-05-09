<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="TestApp1.Pages.Person" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group">
        <label for="FullName">Full Name</label>
        <asp:TextBox ID="FullName" runat="server" CssClass="form-control" placeholder="Your Name"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="FullName" Display="Static" runat="server" InitialValue="" ValidationGroup="validationGroup">Required</asp:RequiredFieldValidator>
    </div>

     <div class="form-group">
       <label for="FullName">Date Of Birth</label>
        <asp:TextBox ID="DateOfBirth" runat="server" TextMode="Date" class="form-control" placeholder="Your Date Of Birth"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="DateOfBirth" Display="Static" runat="server" InitialValue="" ValidationGroup="validationGroup">Required</asp:RequiredFieldValidator>
     </div>

     <div class="form-group">
        <asp:Button id="Button1" Text="Submit" OnClick="Button1_Click" runat="server" ValidationGroup="validationGroup" />
     </div>

</asp:Content>