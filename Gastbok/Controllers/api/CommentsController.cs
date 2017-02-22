using Gastbok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Gastbok.Controllers.api
{
    public class CommentsController : ApiController
    {
        private ApplicationDbContext _context;

        public CommentsController() {
            _context = new ApplicationDbContext();
        }

        //GET /api/comments
        public IEnumerable<Comment> GetComments() {
            return _context.Comments.ToList();
        }
    }
}
