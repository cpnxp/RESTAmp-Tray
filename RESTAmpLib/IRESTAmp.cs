using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RESTAmpLib
{
    [ServiceContract(Name = "RESTAmp")]
    public interface IRESTAmp
    {
        [OperationContract]
        [WebGet(UriTemplate = Routing.PlayRoute, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        int Play();
        [WebGet(UriTemplate = Routing.PauseRoute, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        int Pause();
        [WebGet(UriTemplate = Routing.NextRoute, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        int Next();
        [WebGet(UriTemplate = Routing.PrevRoute, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        int Prev();
        [WebGet(UriTemplate = Routing.StatusRoute, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json)]
        String Status();
    }
}
