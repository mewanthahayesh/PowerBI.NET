﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using PowerBIService.Common;
using PowerBIService.Services.Implementation;
using ServiceCommon.Contract;
using WebClientDemo.Models;
using WebGrease.Css.Extensions;
using CloneReportRequest = ServiceCommon.Contract.CloneReportRequest;

namespace WebClientDemo.Controllers
{
    public class ValuesController : ApiController
    {

        private UserCredentials Credential;
        private PowerService service;
        public ValuesController()
        {
            Credential = new UserCredentials
            {
                TenantId = "470cec91-5a0e-47c7-87a9-2fcaf82d5d90",
                SecretId = "82(t[}]Ee+y&+GvT8[tjh+;U9[|x;",
                ApplicationId = "66bec1b2-4684-4a08-9f2b-b67216d4695a",
                Password = "Scala@1234",
                UserName = "bkaluarachchi@assetic.com"
            };
            service = new PowerService();

        }
        // GET api/values
        [HttpGet]
        [Route("api/values/GetWorkSpaceReports/{groupId}", Name = "WorkspaceAllReports")]
        public IEnumerable<PowerReport> GetWorkSpaceReports(string groupId)
        {
            var list = new List<PowerReport>();
            var Result = Task.Run(async () => await service.GetAllReportInWorkSpace(new GetReportRequest { Credential = Credential, WorkSpaceId = groupId })).ConfigureAwait(false);
            var reports = Result.GetAwaiter().GetResult();

            reports.ForEach(s =>
            {
                list.Add(new PowerReport { Id = s.Id, Name = s.Name });
            });
            return list.ToArray();
        }
        [HttpPost]
        [Route("api/values/CloneReport", Name = "CloneReport")]
        public async Task<IEnumerable<CloneReportResponseVM>> CloneReport(CloneReportRequestVM cloneReport)
        {
          
            var cloneReportRequest = new CloneReportRequest
            {
                Credential = Credential,
                ClientWorkSpaceId = cloneReport.ClientWorkSpaceId,
                ParentWorkSpaceId = cloneReport.ParentWorkSpaceId,
                CloneReports = cloneReport.CloneReports.Select(w => new CloneReport { CloneReportName = w.CloneReportName, ParentReportId = w.ParentReportId, WebApiEndPoint = w.WebApiEndPoint }).ToArray()

            };
            var result =  await service.CloneReports(cloneReportRequest);
            var responseData = result;

            var responseList = new List<CloneReportResponseVM>();

            responseData.ForEach(s =>
            {
                responseList.Add(new CloneReportResponseVM
                {
                    CloneReportName = s.CloneReportName,
                    ParentReportName = s.ParentReportName,
                    Success = s.Success

                });
            });
            return responseList.ToArray();
        }
        [HttpPost]
        [Route("api/values/EmbedReport", Name = "EmbedReport")]
        public async Task<EmbedConfig> EmbedReport(EmbedReportRequestVM embedReportRequest)
        {
            var embedRequest=new EmbedReportRequest
            {
                Credential = Credential,
                EmbedRoles = embedReportRequest.EmbedRoles,
                ReportId = embedReportRequest.ReportId,
                EmbedUserName = embedReportRequest.EmbedUserName,
                WorkSpaceId = embedReportRequest.WorkSpaceId,
                EmbedReportUrl = embedReportRequest.EmbedReportUrl,
                ParaMeters = embedReportRequest.ParaMeters.Select(s=> new EmbededReportDataSetParam{ParaType = s.ParaType,ParamName = s.ParamName,ParamValue = s.ParamValue}).ToArray()
            };
           var result =  await service.ClientEmbedReport(embedRequest);
           var responseData = result;
           return responseData;
        }

    }
}
