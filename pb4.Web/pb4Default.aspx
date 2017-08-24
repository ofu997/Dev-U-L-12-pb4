﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pb4Default.aspx.cs" Inherits="pb4.Web.pb4Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="page-header">
                <h1> Pabst Blue Pizza </h1>
                <p class="lead">Pizza to code by ~!*</p>
            </div>

            <div class="form-group">
                <label> Size: </label>
                <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>

            <div class="form-group">
                <label> Crust: </label>
                <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
        
            <div class="checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server" />Sausage</label></div>
            <div class="checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server" />Pepperoni</label></div>
            <div class="checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server" />Onions</label></div>
            <div class="checkbox"><label><asp:CheckBox ID="greenPeppersCheckBox" runat="server" />Green Peppers</label></div>

            <h3> Deliver to: </h3>
            <div class="form-group">
                <label>Name: </label>
                <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Address: </label>
                <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Zip code: </label>
            <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Phone number: </label>
            <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <h3>Payment:</h3>

            <div class="radio">
                <label>
                    <asp:RadioButton ID="cashRadioButton" runat="server" GroupName="PaymentGroup"/>
                    Cash
                </label>
            </div>
  
            <div class="radio">
                <label>
                    <asp:RadioButton ID="creditRadioButton" runat="server" GroupName="PaymentGroup"/>
                    Credit
                </label>
            </div>
            
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <asp:Button ID="orderButton" runat="server" Text=" ~ Order ~ " CssClass="btn btn-lg btn-primary"/>

            <h3>Total cost: <asp:Label ID="totalLabel" runat="server" Text=""></asp:Label></h3>
            <!--
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
            -->
        </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
