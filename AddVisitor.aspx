<%@ Page Language="C#" MasterPageFile="~/Shared/MuseumMasterPage.master" AutoEventWireup="true" CodeBehind="AddVisitor.aspx.cs" Inherits="Final_Project.AddVisitor" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title></title>
     <link type="text/css" href="App_Themes/Theme1/SiteStyles.css" rel="stylesheet"/>
  
   <%-- <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>--%>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>

            <h1>Visitors</h1>      
        <div class="grid-3-colum">
		    <div>
                <asp:Label ID="nameLable" runat="server" Text="Visitor Name: " CssClass="form-label"></asp:Label>

		    </div> 
            <div>
                <asp:TextBox id="name" CssClass="input" runat="server"></asp:TextBox>

            </div>
            <div>
                <asp:RequiredFieldValidator ID="rfvdName" runat="server"
                     ForeColor="Red" Display="Dynamic"
                     ControlToValidate="name" EnableClientScript="true">Required!</asp:RequiredFieldValidator>
	        </div>
            <br />
            <div>
                <asp:Label ID="LabelType" runat="server" Text="Package Type: " for="drpVisitorType" CssClass="form-label"></asp:Label>

            </div>
            <div>

                <asp:RadioButtonList id="drpVisitorType" runat="server">
                        <asp:ListItem Value="BasicPackage">Basic Package</asp:ListItem>
                            <asp:ListItem Value="PrimePackage">Prime Package</asp:ListItem>
                            <asp:ListItem Value="SupremePackage">Supreme Package</asp:ListItem>
                     </asp:RadioButtonList>
             </div>
             <div>
               <asp:RequiredFieldValidator ID="rfvType" runat="server" 
                    ErrorMessage="Must select one!"
                    ForeColor="Red" ControlToValidate="drpVisitorType" 
                    Display="Dynamic"></asp:RequiredFieldValidator>
	        </div>
		    <br /><br />
       
            <asp:Button CssClass="button" style="color:brown;" ID="Button" Text="Add" runat="server" OnClick="cmdAdd_Click" />
        
            <p><asp:Label runat="server" ID="lblMessage"></asp:Label></p>
    
        </div>
        <asp:Table ID="tblVisitors" runat="server" CssClass="table table-striped"> 
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>ID</asp:TableHeaderCell>
                <asp:TableHeaderCell>Name</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <a href="SelectMuseum.aspx">Select Museum</a>


</div>
   
</asp:Content>

