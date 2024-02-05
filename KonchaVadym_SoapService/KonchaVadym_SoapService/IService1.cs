using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace KonchaVadym_SoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]

    public interface IService1
    {
        [OperationContract]
        int F4(int x, int y);
        
        [OperationContract]
        System.Data.DataTable GetAllElements();
        
        [OperationContract]
        System.Data.DataTable GetElementByID(int ID);
    }
}
