using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxEditors;

public partial class _Default : System.Web.UI.Page {
    ASPxComboBox comboBoxCategoriesInHeader;

    protected void ASPxComboBoxCategoriesInHeader_Load(object sender, EventArgs e) {
        comboBoxCategoriesInHeader = (ASPxComboBox)sender;
    }
    protected void ASPxGridViewProducts_BeforePerformDataSelect(object sender, EventArgs e) {
        ControlParameter controlParameter = (ControlParameter)SqlDataSourceProducts.SelectParameters[0];
        controlParameter.ControlID = comboBoxCategoriesInHeader.UniqueID;
    }
}