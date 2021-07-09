using _1811062489_PhamCongMinh_Tuan3.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _1811062489_PhamCongMinh_Tuan3.DTOs;
namespace _1811062489_PhamCongMinh_Tuan3.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        
            private ApplicationDbContext _dbContext;

            public AttendancesController()
            {
                _dbContext = new ApplicationDbContext();
            }


            [HttpPost]
            public IHttpActionResult Attend(AttendanceDto attendanceDto)
            {
                var userId = User.Identity.GetUserId();
                if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
                {
                    return BadRequest("The attendance already exists!");
                }
                var attendance = new Attendance
                {
                    CourseId = attendanceDto.CourseId,
                    AttendeeId = userId
                };

                _dbContext.Attendances.Add(attendance);
                _dbContext.SaveChanges();

                return Ok();

            }

        }
    }

