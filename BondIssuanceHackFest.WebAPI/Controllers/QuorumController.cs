﻿using BondIssuanceHackFest.DLL.DataModels;
using BondIssuanceHackFest.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace BondIssuanceHackFest.WebAPI.Controllers
{
    public class QurorumController : ApiController
    {

        SqlContext db = new SqlContext();

        [Route("QuorumUsers")]
        public IHttpActionResult GetQuorumUsers()
        {

          var users=  db.QuorumUsers.ToList();

            return Ok<IList<QuorumUser>>(users);
        }
        [Route("QuorumNodes")]
        public IHttpActionResult GetQuroumNodes()
        {

            var nodes = db.QuorumNodes.ToList();

            return Ok<IList<QuorumNode>>(nodes);
        }
    }



}