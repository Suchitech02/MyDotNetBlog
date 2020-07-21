using MyDotNetBlog.Core.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDotNetBlog.Core
{
    public interface IBlogRepository
    {
        IList<Post> Posts(int pageNo, int pageSize);
        int TotalPosts();
    }
}
