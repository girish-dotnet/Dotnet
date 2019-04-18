<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPL._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>GuestPhoneBook</title>
    <style type="text/css">
        .style1 {
            text-align: center;
        }
        .style2
        {
            width: 100%;
        }
        .style3
        {
            text-align: center;
        }
        .style4
        {
            text-align: right;
            width: 140px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 class="style1">
            Guest Phone book Application</h1>

    </div>
    
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" DataSourceID="ObjectDataSource1" BackColor="White" 
            BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
            <RowStyle BackColor="White" ForeColor="#330099" />
            <Columns>
                <asp:BoundField DataField="GuestID" HeaderText="GuestID" 
                    SortExpression="GuestID" ReadOnly="True" />
                <asp:BoundField DataField="GuestName" HeaderText="GuestName" 
                    SortExpression="GuestName" />
                <asp:BoundField DataField="GuestContactNumber" HeaderText="GuestContactNumber" 
                    SortExpression="GuestContactNumber" />
                <asp:CommandField ShowEditButton="True" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        </asp:GridView>
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            DataObjectTypeName="Entities.Guest" 
            DeleteMethod="DeleteGuestBL" InsertMethod="AddGuestBL" 
            SelectMethod="GetAllGuestsBL" TypeName="BL.GuestBL" 
            UpdateMethod="UpdateGuestBL">
            <DeleteParameters>
                <asp:Parameter Name="deleteGuestID" Type="Int32" />
            </DeleteParameters>
        </asp:ObjectDataSource>
        <br />
        <br />
        <b>Insert Guest<br />
        </b>
        <asp:FormView ID="FormView1" runat="server" BackColor="White" 
            BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
            DataSourceID="ObjectDataSource1" DefaultMode="Insert" GridLines="Both">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <EditItemTemplate>
                <table class="style2">
                    <tr>
                        <td class="style4">
                            GuestID</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Height="21px" 
                                Text='<%# Bind("GuestID") %>' Width="337px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            Name</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" Height="26px" 
                                Text='<%# Bind("GuestName") %>' Width="335px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            ContactNumber</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" Height="23px" 
                                Text='<%# Bind("GuestContactNumber") %>' Width="334px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3" colspan="2">
                            <asp:Button ID="Button1" runat="server" CommandName="Insert" Text="Insert" />
                            &nbsp;<asp:Button ID="Button2" runat="server" CommandName="Cancel" 
                                style="text-align: center" Text="Cancel" />
                        </td>
                    </tr>
                </table>
            </EditItemTemplate>
            <InsertItemTemplate>
                GuestID:
                <asp:TextBox ID="GuestIDTextBox" runat="server" Text='<%# Bind("GuestID") %>' />
                <br />
                GuestName:
                <asp:TextBox ID="GuestNameTextBox" runat="server" 
                    Text='<%# Bind("GuestName") %>' />
                <br />
                GuestContactNumber:
                <asp:TextBox ID="GuestContactNumberTextBox" runat="server" 
                    Text='<%# Bind("GuestContactNumber") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                    CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                    CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <EditRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        </asp:FormView>
    </div>
    </form>
</body>
</html>
