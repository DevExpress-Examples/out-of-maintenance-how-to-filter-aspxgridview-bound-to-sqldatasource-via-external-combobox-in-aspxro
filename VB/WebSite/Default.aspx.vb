Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxEditors

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private comboBoxCategoriesInHeader As ASPxComboBox

	Protected Sub ASPxComboBoxCategoriesInHeader_Load(ByVal sender As Object, ByVal e As EventArgs)
		comboBoxCategoriesInHeader = CType(sender, ASPxComboBox)
	End Sub
	Protected Sub ASPxGridViewProducts_BeforePerformDataSelect(ByVal sender As Object, ByVal e As EventArgs)
		Dim controlParameter As ControlParameter = CType(SqlDataSourceProducts.SelectParameters(0), ControlParameter)
		controlParameter.ControlID = comboBoxCategoriesInHeader.UniqueID
	End Sub
End Class