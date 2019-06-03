using System;
using System.Collections.Generic;
using System.Text;
using Domain.Data;
using Domain.Repository;
namespace Domain.Business
{
    class PostManagement
    {
        Post post = new Post();
        PostRepository postRep = new PostRepository();
        List<Post> PostList = new List<Post>();
        public void CreateNewPost()
        {
            postRep.CreatePost(post);
        }

        public void ShowPost()
        {
            postRep.ShowPost(post);
        }

        public void DeletePost()
        {
            postRep.DeletePost(post);
        }

        public void EditPost()
        {
            postRep.EditPost(post);
        }
        
    }
}
