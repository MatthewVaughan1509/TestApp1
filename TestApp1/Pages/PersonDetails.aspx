<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonDetails.aspx.cs" Inherits="TestApp1.Pages.PersonDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group">
        <label for="FullName">Welcome</label>
        <asp:TextBox ID="FirstName" runat="server" CssClass="form-control" placeholder="First Name" Enabled="false"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="FullName">Number Of Vowles In Your First Name</label>
        <asp:TextBox ID="NumberOfVowlesInYourFirstName" runat="server" CssClass="form-control" placeholder="First Name" Enabled="false"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="FullName">Number Of Vowles In Your Full Name</label>
        <asp:TextBox ID="NumberOfVowlesInYourFullName" runat="server" CssClass="form-control" placeholder="First Name" Enabled="false"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="FullName">Age</label>
        <asp:TextBox ID="Age" runat="server" CssClass="form-control" placeholder="First Name" Enabled="false"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="FullName">Number Of Days Until Your Next Birthday</label>
        <asp:TextBox ID="DaysTillNextBirthday" runat="server" CssClass="form-control" placeholder="First Name" Enabled="false"></asp:TextBox>
    </div>


    <div class="form-group">

        <asp:GridView ID="PersonGridView"
            EmptyDataText="No data available."
            AllowPaging="True"
            runat="server"
            OnPageIndexChanging="PersonGridView_PageIndexChanging"
            AutoGenerateColumns="False">

            <PagerSettings Mode="Numeric"
                Position="Bottom"
                PageButtonCount="10" />

            <PagerStyle BackColor="LightBlue"
                Height="30px"
                VerticalAlign="Bottom"
                HorizontalAlign="Center" />

            <Columns>
                <asp:BoundField ItemStyle-Width="200px" DataField="Date" HeaderText="Date"></asp:BoundField>
                <asp:HyperLinkField ItemStyle-Width="500px" DataNavigateUrlFields="Url" DataNavigateUrlFormatString="{0}" DataTextField="Url" />
            </Columns>

        </asp:GridView>

    </div>

</asp:Content>
