<%@ Page Title="TP3 Promo Web" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_PROMO_WEB_GRUPO_10A._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Tienda de Promo Web</h1>
            <p class="lead">Texto ....... Texto... bla bla bla</p>
        </section>
        <asp:GridView ID="dgvArticulos" runat="server" CssClass="table table-striped" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Producto" DataField="Nombre" />
                <asp:BoundField HeaderText="Categoria" DataField="IdCategoria.Descripcion" />
                <asp:BoundField HeaderText="Marca" DataField="IdMarca.Descripcion" />
                <asp:BoundField HeaderText="Precio" DataField="Precio" />


            </Columns>
            <%--CARD--%>
        </asp:GridView>
        <div class="row row-cols-2 row-cols-md-3 g-4">
            <%--            <% foreach (Dominio.Articulos articulo in listarPokemon)
                { %>
            <div class="col">
                <div class="card h-100">
                    <img class="card-img-top" width="100" height="250" src="<%: articulo.listImagenes[0].ImagenUrl %>" alt="Card image cap">
                    <div class="card-body">
                        <h5 class="card-title"><%: articulo.Nombre %></h5>
                        <p class="card-text"><%: articulo.Descripcion %>></p>
                    </div>
                    <div class="card-footer">
                        <div class="d-grid gap-2 d-md-flex justify-content-md-end">
                            <button class="btn btn-outline-primary me-md-2" type="button">Detalle</button>
                            <button class="btn btn-outline-success me-md-2" type="button">Agregar</button>                            
                        </div>
                    </div>
                </div>
            </div>
            <%  }%>--%>
            <asp:Repeater ID="repRepitidor" runat="server">
                <ItemTemplate>
                    <div class="col">
                        <div class="card h-100">
                            <img class="card-img-top" width="100" height="250" src="<%#Eval("listImagenes[0].ImagenUrl") %>" alt="Card image cap">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("Nombre")%></h5>
                                <p class="card-text"><%#Eval("Descripcion")%>></p>
                            </div>
                            <div class="card-footer">
                                <div class="d-grid gap-2 d-md-flex justify-content-md-end">
                                    <asp:Button ID="btnDetalle" runat="server" Text="Detalle"  cssclass="btn btn-outline-primary me-md-2" CommandArgument='<%#Eval("Id") %>' CommandName="ArticuloID" OnClick ="btnDetalle_Click"/>
                                   <<asp:Button ID="btnComprar" runat="server" Text="Comprar"  cssclass="btn btn-outline-success me-md-2" CommandArgument='<%#Eval("Id") %>' CommandName="ArticuloID" OnClick ="btnComprar_Click"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>





        <%--FIN CARD--%>
    </main>

</asp:Content>
