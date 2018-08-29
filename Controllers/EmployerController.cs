using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SeniorDevops.Models;

namespace SeniorDevops.Controllers
{
    [Route("api/[controller]")]
    public class EmployerController : Controller
    {
        // GET: api/Employer/
        [HttpGet]
        public string Get()
        {
            var dt = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection("Data Source=mydbinstance.ck7gykhkgxji.us-east-1.rds.amazonaws.com;Initial Catalog=SeniorDevOps;User ID=ryandines;Password=Rfd362436!"))
            {
                string sql = "dbo.usp_employer_get_all";
                using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                {
                    Console.WriteLine("Did stuff");
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlConn.Open();
                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                    {
                        sqlAdapter.Fill(dt);
                    }
                }
            }
            return JsonConvert.SerializeObject(dt);
        }

        // GET api/Employee/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var dt = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection("Data Source=mydbinstance.ck7gykhkgxji.us-east-1.rds.amazonaws.com;Initial Catalog=SeniorDevOps;User ID=ryandines;Password=Rfd362436!"))
            {
                string sql = "dbo.usp_employer_get_by_id";
                using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@employee_id", id);
                    sqlConn.Open();
                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                    {
                        sqlAdapter.Fill(dt);
                    }
                }
            }
            return JsonConvert.SerializeObject(dt);
        }

        // POST api/Employee/
        [HttpPost]
        public void Post([FromBody]Employer employer)
        {
            var dt = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection("Data Source=mydbinstance.ck7gykhkgxji.us-east-1.rds.amazonaws.com;Initial Catalog=SeniorDevOps;User ID=ryandines;Password=Rfd362436!"))
            {
                string sql = "dbo.usp_employer_insert";
                using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@company_name", employer.company_name);
                    sqlCmd.Parameters.AddWithValue("@position", employer.position);
                    sqlCmd.Parameters.AddWithValue("@salary", employer.salary);
                    sqlCmd.Parameters.AddWithValue("@status", employer.status);
                    sqlCmd.Parameters.AddWithValue("@contact", employer.contact);
                    sqlCmd.Parameters.AddWithValue("@phone", employer.phone);
                    sqlConn.Open();
                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                    {
                        sqlAdapter.Fill(dt);
                    }
                }
            }
            dt.AcceptChanges();
            return;
        }

        // PUT api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Employer employer)
        {
            var dt = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection("Data Source=mydbinstance.ck7gykhkgxji.us-east-1.rds.amazonaws.com;Initial Catalog=SeniorDevOps;User ID=ryandines;Password=Rfd362436!"))
            {
                string sql = "dbo.usp_employer_update";
                using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@employee_id", id);
                    sqlCmd.Parameters.AddWithValue("@company_name", employer.company_name);
                    sqlCmd.Parameters.AddWithValue("@position", employer.position);
                    sqlCmd.Parameters.AddWithValue("@salary", employer.salary);
                    sqlCmd.Parameters.AddWithValue("@status", employer.status);
                    sqlCmd.Parameters.AddWithValue("@contact", employer.contact);
                    sqlCmd.Parameters.AddWithValue("@phone", employer.phone);
                    sqlConn.Open();
                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                    {
                        sqlAdapter.Fill(dt);
                    }
                }
            }
        }
        // DELETE api/Employee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var dt = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection("Data Source=mydbinstance.ck7gykhkgxji.us-east-1.rds.amazonaws.com;Initial Catalog=SeniorDevOps;User ID=ryandines;Password=Rfd362436!"))
            {
                string sql = "dbo.usp_employer_delete";
                using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@employee_id", id);
                    sqlConn.Open();
                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                    {
                        sqlAdapter.Fill(dt);
                    }
                }
            }
            dt.AcceptChanges();
            return;
        }
    }
}
