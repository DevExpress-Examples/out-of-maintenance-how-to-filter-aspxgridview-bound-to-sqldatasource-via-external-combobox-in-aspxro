using DevExpress.Web;
using DevExpress.Web.ASPxEditors;
using System;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {    
    protected void ASPxComboBoxCategoriesInHeader_Init(object sender, EventArgs e) {
        var cb = (ASPxComboBox)sender;
        ControlParameter controlParameter = (ControlParameter)SqlDataSourceProducts.SelectParameters[0];
        controlParameter.ControlID = cb.UniqueID;
    }
}