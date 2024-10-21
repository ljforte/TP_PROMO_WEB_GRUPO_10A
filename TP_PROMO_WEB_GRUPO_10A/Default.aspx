<%@ Page Title="TP3 Promo Web" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_PROMO_WEB_GRUPO_10A._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="default">
        <link rel="stylesheet" type="text/css" href="~/Content/Site.css" />
        <div class="word-container">
            <div class="word">Good luck</div>
            <div class="word">好运 </div>
            <div class="word">शुभकामनाएँ </div>
            <div class="word">Suerte</div>
            <div class="word">Bonne chance</div>
            <div class="word">حظ سعيد</div>
            <div class="word">শুভকামনা </div>
            <div class="word">Удачи </div>
            <div class="word">Boa sorte</div>
            <div class="word">اچھی قسمت</div>
        </div>
        <div class="card">
            <h5 class="card-header"></h5>
            <div class="card-body">
                <p class="card-text">Ingrese el Codigo </p>
                <asp:TextBox ID="txtCodigoVoucher" runat="server" CssClass="custom-textbox"></asp:TextBox>
                <div class="valid-feedback">
                    <div class="card-footer">
                        <div class="d-grid gap-2 d-md-block">
                            <asp:Button ID="btnValidar" runat="server" Text="Validar" CssClass="btn btn-custom" OnClick="btnValidar_Click" />
                        </div>
                        <asp:Label ID="lblResultado" runat="server" CssClass="text-danger"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </main>
</asp:Content>
