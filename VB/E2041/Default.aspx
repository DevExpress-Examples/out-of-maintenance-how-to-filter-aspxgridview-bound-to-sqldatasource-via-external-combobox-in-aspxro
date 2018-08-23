<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxRoundPanel ID="ASPxRoundPanelContainer" runat="server" Width="200px" HeaderText="Naming Container">
            <HeaderTemplate>
                <dx:ASPxLabel ID="ASPxLabelCaption" runat="server" Text="Select Category">
                </dx:ASPxLabel>
                <dx:ASPxComboBox ID="ASPxComboBoxCategoriesInHeader" runat="server" ValueField="CategoryID"
                    TextField="CategoryName" ValueType="System.Int32" DataSourceID="SqlDataSourceCategories"
                    AutoPostBack="True" OnInit="ASPxComboBoxCategoriesInHeader_Init">
                </dx:ASPxComboBox>
            </HeaderTemplate>
            <PanelCollection>
                <dx:PanelContent ID="MainPanelContent" runat="server">
                    <dx:ASPxGridView ID="ASPxGridViewProducts" runat="server" 
                        DataSourceID="SqlDataSourceProducts">
                    </dx:ASPxGridView>
                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxRoundPanel>
    </div>
    <asp:SqlDataSource ID="SqlDataSourceCategories" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>"
        SelectCommand="SELECT [CategoryID], [CategoryName] FROM [Categories]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceProducts" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>"
        SelectCommand="SELECT [ProductID], [ProductName], [CategoryID], [UnitPrice], [Discontinued] FROM [Products] WHERE ([CategoryID] = @CategoryID)">
        <SelectParameters>
            <asp:ControlParameter Name="CategoryID" PropertyName="Value" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>