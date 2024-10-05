<%@ Page Title="TP3 Promo Web" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_PROMO_WEB_GRUPO_10A._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Tienda de Promo Web</h1>
            <p class="lead"> Texto ....... Texto... bla bla bla</p>   
        </section>
        <asp:GridView ID="dgvArticulos" runat="server" CssClass="table table-striped" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Producto" DataField="Nombre"/> 
                <asp:BoundField HeaderText="Categoria" DataField="IdCategoria.Descripcion"/> 
                <asp:BoundField HeaderText="Marca" DataField="IdMarca.Descripcion"/>                 
                <asp:BoundField HeaderText="Precio" DataField="Precio"/> 


            </Columns>

        </asp:GridView>
        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
            </section>
        </div>
    </main>

</asp:Content>
