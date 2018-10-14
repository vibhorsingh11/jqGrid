using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using College.Data.DAL.Class;
using College.Data;
using College.Models;

namespace College.Controllers.WebApi
{
    public class StudentController : ApiController
    {
        UnitOfWork uow = new UnitOfWork();

        [HttpGet]
        public IHttpActionResult GetStudentList()
        {
            try
            {
                IEnumerable<Student> stu;
                stu = uow.StudentRepository.Get().OrderBy(x => x.StudentId);
                IEnumerable<StudentDTO> _DTO; ;
                _DTO = Mapper.Map<IEnumerable<Student>, IEnumerable<StudentDTO>>(stu.ToList());
                return this.Ok(_DTO);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
