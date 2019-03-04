<%@ Page Title="Incredient" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Incredient.aspx.cs" Inherits="RecipeWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>My Recipe -- <%: Title %> </h2>
    <h3>Your saved Incredients.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
