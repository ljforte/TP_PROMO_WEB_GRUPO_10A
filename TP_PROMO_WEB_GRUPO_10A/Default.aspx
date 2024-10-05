﻿<%@ Page Title="TP3 Promo Web" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_PROMO_WEB_GRUPO_10A._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Sorteo de Promo Web</h1>
            <p class="lead">Turun ....... Turun...Turun... Turun...</p>
        </section>
        <div class="card">
            <img src="/Content/Sorteo.png" class="card-img-top" alt="...">
            <h5 class="card-header"></h5>
            <div class="card-body">
                <h5 class="card-title">PROMO GANA !!!</h5>
                <p class="card-text">Ingrese el Codigo </p>

              <%--  <input type="text" id="txtCodigoVoucher" class="form-control" value="Ingreso Codigo" required />--%>
                <asp:TextBox ID="txtCodigoVoucher" runat="server" CssClass="form-control"></asp:TextBox>
                <div class="valid-feedback">
                    Looks good!
                </div>
                <div class="card-footer">

                    <div class="d-grid gap-2 d-md-block">
                        <asp:Button ID="btnValidar" runat="server" Text="Validar" CssClass="btn btn-outline-success me-md-2" CommandArgument='txtCodigoVoucher.Text' CommandName="CodigoVoucher" OnClick="btnValidar_Click" />
                    </div>

                </div>
            </div>

            <%--FIN CARD--%>
    </main>

</asp:Content>
