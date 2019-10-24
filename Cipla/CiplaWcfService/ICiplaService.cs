using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CiplaWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICiplaService" in both code and config file together.
    [ServiceContract]
    public interface ICiplaService
    {
        [OperationContract]
        bool AddOrder(Order order);
    }

    [DataContract]
    public class Order
    {
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public string MedicineType { get; set; }
        [DataMember]
        public string MedicineName { get; set; }
        [DataMember]
        public int Quantity { get; set; }
    }
}
