using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using EFWCoreLib.CoreFrame.Business.AttributeInfo;
using EFWCoreLib.CoreFrame.Init;
using EFWCoreLib.WcfFrame;

namespace EFWCoreLib.WebFrame.WebAPI
{
    [efwplusApiController(PluginName = "coresys")]
    public class WcfPerformanceController: ApiController
    {
        public bool CreateClient(string name)
        {
            ClientLink clientlink = new ClientLink("TestWcfPerformance", "Books.Service");
            return true;
        }
        public bool Request()
        {
            return true;
        }
        public bool CloseClient(string name)
        {
            return true;
        } 
    }
}
