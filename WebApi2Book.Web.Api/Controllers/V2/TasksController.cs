using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2Book.Web.Api.Models;
using WebApi2Book.Web.Common.Routing;

namespace WebApi2Book.Web.Api.Controllers.V2
{
    [RoutePrefix("api/{apiVersion:ApiVersionConstraint(v2)}/tasks")]
    public class TasksController : ApiController
    {
        [Route("", Name ="FooRoute")]
        [HttpGet]
        public Task Foo(HttpRequestMessage req)
        {
            return new Task
            {
                Subject = "In v2, newTaskSubject = foo"
            };
        }


        [Route("", Name = "AddTaskRouteV2")]
        [HttpPost]
        public Task AddTask(HttpRequestMessage req, Task newTask)
        {
            return new Task
            {
                Subject = "In v2, newTaskSubject = " + newTask.Subject
            };
        }
    }
}
