<%@ Page Title="Clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormClientes.aspx.cs" Inherits="TP_PROMO_WEB_GRUPO_10A.FormClientes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Formulario Cliente</h3>

        <%--public int Id { get; set; }
public string Documento { get; set; }
public string Nombre { get; set; }
public string Apellido { get; set; }
public string Email
public string Direccion { get; set; }
public string Ciudad { get; set; }
public int CP { get; set; }--%>
        <div class="row">
            <div class="col-12">
                <div class="mb-3">
                    <asp:Label id="lblDocumento" Text="Documento" runat="server" CssClass="form-label" />                    
                    <asp:TextBox ID="txtDocumento" AutoPostBack="true" runat="server" CssClass="form-control" OnTextChanged="txtDocumento_TextChanged"></asp:TextBox>
                </div>

                <div class="mb-3">
                    <asp:Label id="lblNombre" Text="Nombre" runat="server" CssClass="form-label" />
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"  ></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label id="lblApellido" Text="Apellido" runat="server" CssClass="form-label" />
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label id="lblEmail" Text="Email" runat="server" CssClass="form-label" />
                    <div class="input-group">
                        <span class="input-group-text" id="inputGroupPrepend2" >@</span>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                </div>
                <div class="mb-3">
                    <asp:Label id="lblDireccion" Text="Direccion" runat="server" CssClass="form-label" />
                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label id="lblCiudad" Text="Ciudad" runat="server" CssClass="form-label" />
                    <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label id="lblCP" Text="CP" runat="server" CssClass="form-label" />
                    <asp:TextBox ID="txtCP" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="d-grid gap-1 d-md-block">
                <asp:Button Text="Verificar" ID="btnVerificar" OnClick="btnVerificar_Click" CssClass="btn btn-outline-success" runat="server"   />
                <asp:Button Text="Siguiente" ID="btnSiguiente" OnClick="btnSiguiente_Click" CssClass="btn btn-outline-success" runat="server"   />

                </div>

        </div>
                   
    </main>
</asp:Content>
