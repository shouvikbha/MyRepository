using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CiplaWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CiplaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CiplaService.svc or CiplaService.svc.cs at the Solution Explorer and start debugging.
    public class CiplaService : ICiplaService
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["OrderCon"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        public bool AddOrder(Order order)
        {
            bool OrderAdded = false;

            try
            {
                cmd = new SqlCommand("sp_InsertOrderMedicine", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@orderdate", order.OrderDate);
                cmd.Parameters.AddWithValue("@medicinetype", order.MedicineType);
                cmd.Parameters.AddWithValue("@medicinename", order.MedicineName);
                cmd.Parameters.AddWithValue("@quantity", order.Quantity);

                con.Open();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                    OrderAdded = true;
             
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return OrderAdded;
        }
    }
}
