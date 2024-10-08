﻿<%@ Page Title="Clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormClientes.aspx.cs" Inherits="TP_PROMO_WEB_GRUPO_10A.FormClientes" %>

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
                    <asp:TextBox ID="txtDocumento" AutoPostBack="true" runat="server" CssClass="form-control" OnTextChanged="txtDocumento_TextChanged" ></asp:TextBox>
                    <asp:Button ID="ValidarDni" runat="server" Text="Verificar Dni"  CssClass="btn btn-outline-success me-md-2" OnClick="ValidarDni_Click" />
                     
                    <div>
                    <asp:Label ID="lblResultadoDni" runat="server" CssClass="text-danger"></asp:Label>
                    </div>
                </div>


                <div class="mb-3">
                    <asp:Label id="lblNombre" Text="Nombre" runat="server" CssClass="form-label" />
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ></asp:TextBox>
                    <div>
                    <asp:Label id="lblErrorNombre" Text="Este campo es obligatorio" runat="server" forecolor="Red" CssClass="form-label "  />
                    </div>
                </div>
                <div class="mb-3">
                    <asp:Label id="lblApellido" Text="Apellido" runat="server" CssClass="form-label" />
                    <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" ></asp:TextBox>
                    <asp:Label id="lblErrorApellido" Text="Este campo es obligatorio" runat="server" forecolor="Red" CssClass="form-label " />

                </div>
                <div class="mb-3">
                    <asp:Label id="lblEmail" Text="Email" runat="server" CssClass="form-label" />
                    <div class="input-group">
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                        <div>
                         <asp:Label id="lblErrorEmail" Text="Este campo es obligatorio" runat="server" forecolor="Red" CssClass="form-label " />
                        </div>
                </div>
                <div class="mb-3">
                    <asp:Label id="lblDireccion" Text="Direccion" runat="server" CssClass="form-label" />
                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" ></asp:TextBox>
                     <asp:Label id="lblErrorDireccion" Text="Este campo es obligatorio" runat="server" forecolor="Red" CssClass="form-label " />
                </div>
                <div class="mb-3">
                    <asp:Label id="lblCiudad" Text="Ciudad" runat="server" CssClass="form-label" />
                    <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control" ></asp:TextBox>
                     <asp:Label id="lblErrorCiudad" Text="Este campo es obligatorio" runat="server" forecolor="Red" CssClass="form-label " />
                </div>
                <div class="mb-3">
                    <asp:Label id="lblCP" Text="CP" runat="server" CssClass="form-label" />
                    <asp:TextBox ID="txtCP" runat="server" CssClass="form-control" ></asp:TextBox>
                     <asp:Label id="lblErrorCP" Text="Este campo es obligatorio" runat="server" forecolor="Red" CssClass="form-label " />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="d-grid gap-1 d-md-block">
                <asp:Button Text="Siguiente" ID="btnSiguiente" OnClick="btnSiguiente_Click" CssClass="btn btn-outline-success" runat="server"   />

                </div>

        </div>
                   
    </main>
</asp:Content>
