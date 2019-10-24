using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CiplaAppClient.CiplaWcfService;

namespace CiplaAppClient
{
    public partial class OrderOnline : System.Web.UI.Page
    {
        CiplaServiceClient client = new CiplaServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            txt_OrderDate.Text = Convert.ToString(System.DateTime.Now);
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order();               
                order.OrderDate = System.DateTime.Now;
                order.MedicineType = DropDownListMedicineType.SelectedItem.Value;
                order.MedicineName = txt_MedicineName.Text;
                order.Quantity = Convert.ToInt32(txt_Quantity.Text);

                bool status = client.AddOrder(order);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        
    }
}