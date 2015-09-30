<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="objetos.WebForm2" %>


<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
    <div>

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> 
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        
        
        <asp:DropDownList ID="DDLcambio"
                runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="LBLAceleracion" runat="server" Text="Label"></asp:Label>
             <asp:Button ID="Button2" runat="server" Text="Acelerar" onclick="Button2_Click" />

    </div>
    <div>
        <h3>content</h3>
    </div>
    
    <div>
        <asp:Label ID="Label3" runat="server" Text="Label"> A X</asp:Label>
        <asp:TextBox ID="txtAX" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label4" runat="server" Text="Label"> A Y</asp:Label>
        <asp:TextBox ID="txtAY" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Label"> B X</asp:Label>
        <asp:TextBox ID="txtBX" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label6" runat="server" Text="Label"> B Y</asp:Label>
        <asp:TextBox ID="txtBY" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label7" runat="server" Text="Label"> Mover</asp:Label>
        <asp:TextBox ID="txtMover" runat="server"></asp:TextBox>
    </div>
    <div>
       <asp:Button ID="Button3" runat="server" Text="Derecha" onclick="ButtonDerecha_Click" />
       <asp:Button ID="Button4" runat="server" Text="Izquierda" onclick="ButtonIzquierda_Click" />
       <asp:Button ID="Button5" runat="server" Text="Arriba" onclick="ButtonArriba_Click" />
       <asp:Button ID="Button6" runat="server" Text="Abajo" onclick="ButtonAbajo_Click" />

    </div>

</asp:Content>