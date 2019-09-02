using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.MakePost("Patriots Win", "the patriots win another superbowl behind the genius of belicheck and the excellence of tom brady.");
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.GetPost();
        }
    }
}
