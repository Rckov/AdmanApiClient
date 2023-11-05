using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdmanApiClient.Intefaces;
public interface IAdmanClient
{
    Task<bool> VpsReboot(string orderID);
}
