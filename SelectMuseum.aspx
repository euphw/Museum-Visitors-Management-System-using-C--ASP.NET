<%@ Page Language="C#" MasterPageFile="~/Shared/MuseumMasterPage.master" AutoEventWireup="true" CodeBehind="SelectMuseum.aspx.cs" Inherits="Final_Project.SelectMuseum" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title></title>
     <link type="text/css" href="App_Themes/Theme1/SiteStyles.css" rel="stylesheet"/>
  
   <%-- <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>--%>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>
            <h1>Select Museums</h1>
            <asp:Label ID="LabelType" runat="server" Text="Visitor: " for="drpVisitor" CssClass="form-label" ></asp:Label>
            
            <%--Visitor dropdown list--%>
            <asp:DropdownList ID="drpVisitor" runat="server"  CssClass="dropdown" AutoPostBack="true" OnSelectedIndexChanged="nameChanged">
                <asp:ListItem Value ="-1" Text="Select ..."></asp:ListItem>    
            </asp:DropdownList>
            
            <%--Visitor validator--%>
            <asp:RequiredFieldValidator ID="rfvVisitor" runat="server" 
                    ErrorMessage="Must select one!"
                    ForeColor="Red" ControlToValidate="drpVisitor" 
                    InitialValue="-1" Display="Dynamic"></asp:RequiredFieldValidator>
            <br /><br />
            <%--summary--%>
            <asp:Label ID="summary" runat="server" Visible="false" style="color:saddlebrown; font-size:larger;"/>
            <br />

            <%--error message--%>
            
            <asp:Label runat="server" ID="lblErrorMsg" style="color:red;" Visible="false"/>

            <%--courses checkbox list--%>
            <asp:CheckBoxList ID="CheckBoxList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="MuseumChanged" Enabled="false"/>
            <br /><br />

            <asp:Button CssClass="button" style="color:brown;" ID="ButtonSave" Text="Save" runat="server" OnClick="save_Click" />
            <br /><br />
            
            <asp:Table ID="tblMuseums" runat="server" CssClass="table table-striped"> 
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>ID</asp:TableHeaderCell>
                <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                <asp:TableHeaderCell>Museums</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            </asp:Table>
        </div>
 
</asp:Content>