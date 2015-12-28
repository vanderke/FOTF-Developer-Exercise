<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ViewMainPoints.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

<div class="panel panel-default">
   <div class="panel-heading clearfix">        
   </div>
   <div class="panel-body">
       <div class="row">
           <div class="form-group col-lg-10 col-md-10 col-sm-12 col-xs-12">
              <div id="divMainPoints" runat="server">
                <div class="form-group">
                  <span><strong><asp:Label ID="lblHelpMessage3" runat="server" CssClass="input-lg text-left"></asp:Label><span style="color: #CC3300"></span></strong></span>
                  <asp:DropDownList ID="ddlMainPoint" runat="server" CssClass="form-control input-lg" OnSelectedIndexChanged="ddlMainPoint_SelectedIndexChanged" AutoPostBack="True" OnTextChanged="ddlMainPoint_TextChanged"></asp:DropDownList>
                </div>
              </div>              
           </div>
      </div>
      <div class="row">
        <div class="form-group col-lg-12 col-md-12 col-sm-12 col-xs-12">
             <div id="divMainPointDescription" runat="server"> 
               <div class="input-group">
                   <asp:Label ID="lblMainPointDescription" runat="server" class="input-lg text-center text-primary"></asp:Label>           
               </div>           
             </div>
           </div>
      </div>
   </div>
</div>


</asp:Content>

