using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Authentication.OnlineId;

namespace ExempleHttp.Models
{
    public class Post
    {
        //UserId
        public int UserId { get; set; }
        // Id
        private int id;
        public int Id { get => id; set => id = value; }  
        //Title
        public string Tittle { get; set; }
        //Body
        public string Body { get; set; }
    }
}
