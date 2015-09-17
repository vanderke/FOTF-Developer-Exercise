<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AboutAuthors.aspx.cs" Inherits="AboutAuthors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<div class="panel panel-default ">
    <div class="panel-heading clearfix" >                     
    </div>
    <div class="panel-body">
        <div class="row">
            <div class="form-group col-lg-2 col-md-2 col-sm-12 col-xs-12 text-center">
               <img src="Images/Dr.GregandErinSmalley.png" />
            </div>
        </div>     
        <div class="row">
            <div class="form-group col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center">
                <strong><asp:Label ID="HelpLine4" runat="server" class="control-label input-lg text-primary"></asp:Label></strong>           
            </div>
            <div class="form-group col-lg-12 col-md-12 col-sm-12 col-xs-12 text-left">
                <strong><asp:Label ID="HelpLine5" runat="server" class="control-label input-lg text-primary"></asp:Label></strong>
            </div>
        </div>
    </div>
</div>
</asp:Content>

