using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using TicketExceptionAPI.Models;
using Newtonsoft.Json;
using System.Web.Http.Description;

namespace TicketExceptionAPI.Controllers
{
    public class SV_TicketController : ApiController
    {
        private Cust_Silco_ServiceEntities db = new Cust_Silco_ServiceEntities();

        [Route("api/Values/SelectTicketAccepted/{serviceticketid}")]
        [Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, Description = "AllApprovedTicketExceptionResult",
                                           Type = typeof(SelectTicketsAcceptedandResolvedPostingStatus_Result))]
      //  [HttpGet]
     //   public Http SelectTicketAcceptedandResolvedPostingStatus(int? serviceticketid) 
       // {
               // GET: api/SV_Inspection/5
        [HttpGet]
        [ResponseType(typeof(SelectTicketsAcceptedandResolvedPostingStatus_Result))]
        public IHttpActionResult SelectTicketAcceptedandResolvedPostingStatus(int? serviceticketid)
        {
            var tickets =
                       Helper.SelectTicketsAcceptedandResolvedPostingStatus<SelectTicketsAcceptedandResolvedPostingStatus_Result>(serviceticketid);


          //  HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
           // string json = JsonConvert.SerializeObject(tickets);
            //response.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return Ok(tickets);


        }


        //[Route("api/Values/FindFEMonthly/{startdate}/{enddate}/{employeeid}")]
        //[Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, Description = "FindPortablesMonthly",
        //                                   Type = typeof(GetPortablesMonthly_Result))]
        //public HttpResponseMessage GetPortablesMonthly(string startdate, string enddate, int employeeid)
        //{

        //    var monthly =
        //               Helper.GetPortablesMonthly<GetPortablesMonthly_Result>(startdate, enddate, employeeid).ToList();


        //    //  return Request.CreateResponse(HttpStatusCode.OK, monthly);
        //    HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
        //    string json = JsonConvert.SerializeObject(monthly);
        //    response.Content = new StringContent(json, Encoding.UTF8, "application/json");
        //    return response;
        //}
        //[Route("api/Values/FindFENew12/{startdate}/{enddate}/{employeeid}")]
        //[Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, Description = "FindPortablesNew12",
        //                                   Type = typeof(GetPortablesNew12_Result))]
        //public HttpResponseMessage GetPortablesNew12(string startdate, string enddate, int employeeid)
        //{

        //    var New12 =
        //               Helper.GetPortablesNew12<GetPortablesNew12_Result>(startdate, enddate, employeeid).ToList();


        //    //  return Request.CreateResponse(HttpStatusCode.OK, New12);
        //    HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
        //    string json = JsonConvert.SerializeObject(New12);
        //    response.Content = new StringContent(json, Encoding.UTF8, "application/json");
        //    return response;
        //}

        //[Route("api/Values/FindFENew3/{startdate}/{enddate}/{employeeid}")]
        //[Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, Description = "FindPortablesNew3",
        //                                   Type = typeof(GetPortablesNew3_Result))]
        //public HttpResponseMessage GetPortablesNew3(string startdate, string enddate, int employeeid)
        //{

        //    var New3 =
        //               Helper.GetPortablesNew3<GetPortablesNew3_Result>(startdate, enddate, employeeid).ToList();


        //    // return Request.CreateResponse(HttpStatusCode.OK, New3);
        //    HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
        //    string json = JsonConvert.SerializeObject(New3);
        //    response.Content = new StringContent(json, Encoding.UTF8, "application/json");
        //    return response;
        //}

        //[Route("api/Values/FindFENew4_5/{startdate}/{enddate}/{employeeid}")]
        //[Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, Description = "FindPortablesNew4_5",
        //                                   Type = typeof(GetPortablesNew4_5_Result))]
        //public HttpResponseMessage GetPortablesNew4_5(string startdate, string enddate, int employeeid)
        //{

        //    var New4_5 =
        //               Helper.GetPortablesNew4_5<GetPortablesNew3_Result>(startdate, enddate, employeeid).ToList();


        //    //  return Request.CreateResponse(HttpStatusCode.OK, New4_5);
        //    HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
        //    string json = JsonConvert.SerializeObject(New4_5);
        //    response.Content = new StringContent(json, Encoding.UTF8, "application/json");
        //    return response;
        //}


        //[Route("api/Values/FindFENew6/{startdate}/{enddate}/{employeeid}")]
        //[Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, Description = "FindPortablesNew6",
        //                                   Type = typeof(GetPortablesNew6_Result))]
        //public HttpResponseMessage GetPortablesNew6(string startdate, string enddate, int employeeid)
        //{

        //    var New6 =
        //               Helper.GetPortablesNew6<GetPortablesNew3_Result>(startdate, enddate, employeeid).ToList();


        //    // return Request.CreateResponse(HttpStatusCode.OK, New6);
        //    HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);
        //    string json = JsonConvert.SerializeObject(New6);
        //    response.Content = new StringContent(json, Encoding.UTF8, "application/json");
        //    return response;
        //}
    
    }
}
