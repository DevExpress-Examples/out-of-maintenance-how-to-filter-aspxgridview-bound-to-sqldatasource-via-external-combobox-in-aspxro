Option Infer On

Imports DevExpress.Web
Imports DevExpress.Web.ASPxEditors
Imports System
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub ASPxComboBoxCategoriesInHeader_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim cb = DirectCast(sender, ASPxComboBox)
        Dim controlParameter As ControlParameter = CType(SqlDataSourceProducts.SelectParameters(0), ControlParameter)
        controlParameter.ControlID = cb.UniqueID
    End Sub
End Class