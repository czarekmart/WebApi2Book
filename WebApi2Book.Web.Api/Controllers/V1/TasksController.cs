using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2Book.Web.Api.Models;
using WebApi2Book.Web.Common.Routing;

namespace WebApi2Book.Web.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("tasks")]
    public class TasksController : ApiController
    {
        [Route("")]
        [HttpGet]
        public Task Foo(HttpRequestMessage req)
        {
            return new Task
            {
                Subject = "In v1, newTaskSubject = foo"
            };
        }


        [Route("", Name = "AddTaskRoute")]
        [HttpPost]
        public Task AddTask(HttpRequestMessage req, Task newTask)
        {
            return new Task
            {
                Subject = "In v1, newTaskSubject = " + newTask.Subject
            };
        }
    }
}
