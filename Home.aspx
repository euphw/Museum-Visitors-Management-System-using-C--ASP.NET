<%@ Page Language="C#" MasterPageFile="~/Shared/MuseumMasterPage.master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Final_Project.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title></title>
     <link type="text/css" href="App_Themes/Theme1/SiteStyles.css" rel="stylesheet"/>
    <link href="/App_Themes/css/bootstrap.min.css" rel="stylesheet" />
     <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="row w-80 py-0 bg-light" id="features">
        <div class="col-lg-6 col-img">
                    <img src="App_Themes/images/unsplash.jpg" style="width:300px" />
                </div>
        <div class="col-lg-6 py-5">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-10 offset-md-1">
                                <h1>Museum Visitors Management System</h1>
                                <p>
                                    This system is used to upload visitor information</p>
                                 <p>And it canchoose museums for them based on the various packages they have purchased.
                                </p>
                                 <a href="AddVisitor.aspx" style="color:brown;" class="button">Start</a>
                            </div>
                        </div>
                    </div>
          </div>        

            </section>
    </asp:Content>