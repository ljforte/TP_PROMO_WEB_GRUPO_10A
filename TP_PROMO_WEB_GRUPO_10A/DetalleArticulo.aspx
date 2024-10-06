
<%@ Page Title="Detalle Articulos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="TP_PROMO_WEB_GRUPO_10A.DetalleArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lista de Artículos</h1>
    <asp:Repeater ID="RepeaterArticulos" runat="server">
        <HeaderTemplate>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Código</th>
                        <th>Nombre</th>
                        <th>Descripción</th>
                        <th>Marca</th>
                        <th>Categoría</th>
                        <th>Precio</th>
                        <th>Imágenes</th>
                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("Id") %></td>
                <td><%# Eval("Codigo") %></td>
                <td><%# Eval("Nombre") %></td>
                <td><%# Eval("Descripcion") %></td>
                <td><%# Eval("IdMarca.Descripcion") %></td>
                <td><%# Eval("IdCategoria.Descripcion") %></td>
                <td><%# Eval("Precio", "{0:C}") %></td>
                <td>
                    <!-- Carrusel -->
                    <div id="carousel<%# Container.ItemIndex %>" class="carousel slide carousel-fade" data-bs-ride="carousel">
                        <div class="carousel-inner">
                            <asp:Repeater ID="RepeaterImagenes" runat="server" DataSource='<%# Eval("listImagenes") %>'>
                                <ItemTemplate>
                                    <div class="carousel-item <%# Container.ItemIndex == 0 ? "active" : "" %>">
                                        <img src='<%# Eval("ImagenUrl") %>' class="d-block w-100" alt="Imagen del Artículo">
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <button class="carousel-control-prev" type="button" data-bs-target="#carousel<%# Container.ItemIndex %>" data-bs-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Previous</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-bs-target="#carousel<%# Container.ItemIndex %>" data-bs-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Next</span>
                        </button>
                    </div>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
                </tbody>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
