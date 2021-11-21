<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="CSIS265PROJ07.Game" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label runat="server" Text="Guess a Random Number Within 7 Tries"></asp:Label>
    </p>
    <p>
        <asp:Label runat="server" Text="Enter your guess:  "></asp:Label>
         <asp:TextBox ID="txtInputValue" runat="server"></asp:TextBox>
        
    </p>
    <p>
        <asp:Label ID="LblMessage" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnNewGame" runat="server" OnClick="btnNewGame_Click" Text="NewGame" />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="SubmitGuess" />
    </p>
    <p>
    </p>
</asp:Content>
