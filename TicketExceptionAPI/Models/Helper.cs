using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

using System.Net;
using System.IO;
using System.Configuration;
using System.Data;
using System.Collections;
//using SilcoSedonaCustomApi;

using System.Data.Entity;

using System.Data.SqlClient;
using TicketExceptionAPI.Models;
using System.Globalization;
using TicketExceptionAPI;

namespace TicketExceptionAPI.Models
{

    public class Helper
    {
        public static List<SelectTicketsAcceptedandResolvedPostingStatus_Result> SelectTicketsAcceptedandResolvedPostingStatus<T>(int? serviceticketid)
        where T : class
        {
            var db = new Cust_Silco_ServiceEntities();
            List<SelectTicketsAcceptedandResolvedPostingStatus_Result> tickets = db.SelectTicketsAcceptedandResolvedPostingStatus(serviceticketid).ToList();
            return tickets;
          
        }
        //public static bool CustSilco_SV_Inspection(int inspectionid, DateTime nextdate,  int routeid )

       
        //{
        //    var db = new Silco_FinalEntities1();
        //    bool success;
        //    try
        //    {
        //        var ins = db.CustSilco_SV_Inspection(inspectionid, nextdate, routeid);
        //        success = true;
        //    }
        //    catch
        //    {
        //        success = false;
        //    }
        //    return success;

        //}
        //public static bool CustSilco_EditLog(string user, string inspectiontype, string systemcode , string sitecode , string action , string code, int custno, int routeid, int inspectionid, string sysmsg)

        //{
        //    var db = new Silco_FinalEntities1();
        //    bool success;
        //    try
        //    {
        //        var ins = db.CustSilco_InsertEditLog(user, inspectiontype, systemcode, sitecode, action, code, custno, routeid, inspectionid, sysmsg);
        //        success = true;
        //    }
        //    catch
        //    {
        //        success = false;
        //    }
        //    return success;

        //}
        //public static List<CustSilco_SelectInvoicesForPastDues_Result> CustSilco_Invoices<T>(int siteid, int customerid)

        //{
        //   // var db = new Silco_FinalEntities1();
            
        //  //  db.CustSilco_SelectInvoicesForPastDues
          
        //       //  CustSilco_SelectInvoicesForPastDues_Result inv = db.CustSilco_SelectInvoicesForPastDues<CustSilco_SelectInvoicesForPastDues_Result>(siteid, customerid).ToList();

        //    var db = new Silco_FinalEntities1();
        //    List<CustSilco_SelectInvoicesForPastDues_Result> inv = db.CustSilco_SelectInvoicesForPastDues(siteid, customerid).ToList();
        //    return inv;




            

        //}
        //public static bool CustSilco_UpdateSVTicketUserdef(int ticketnumber, string inreviewflag )

        //{
        //    var db = new Cust_SilcoEntities();
        //    bool success;
        //    try
        //    {
        //        var upd = db.UpdateSvticketuserdef(ticketnumber, inreviewflag);
        //        success = true;
        //    }
        //    catch(Exception ex)
        //    {
        //        success = false;
        //    }
        //    return success;

        //}
        //public static bool CustSilco_insertlog(string exceptiontxt, string usercode)

        //{
        //    var db = new Cust_SilcoEntities();
        //    bool success;
        //    try
        //    {
        //        var ins = db.InsertExceptionAPI(usercode, exceptiontxt);
        //        success = true;
        //    }
        //    catch
        //    {
        //        success = false;
        //    }
        //    return success;

        //}
    }
}