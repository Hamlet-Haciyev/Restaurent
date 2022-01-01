using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
using DirectList__Backend_Project_.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public BlogController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index(string searchData)
        {
            Setting setting = _appDbContext.Settings.FirstOrDefault();
            List<Social> socials = _appDbContext.Socials.ToList();
            List<Blog> popularBlogs = _appDbContext.Blogs.OrderByDescending(o => o.CreatedDate).Take(3).ToList();
            Banner banner = _appDbContext.Banners.FirstOrDefault(b => b.Page.ToLower() == "blog");

            List<Blog> blogs= _appDbContext.Blogs.Where(b=>(searchData !=null ? b.Title.Contains(searchData): true)).ToList();
            VmBlog vmBlog = new VmBlog()
            {
                Blogs = blogs,
                Socials = socials,
                Setting = setting,
                PopularPosts = popularBlogs,
                Banner = banner
            };

            return View(vmBlog);
        }
        public IActionResult Detail(int? id)
        {
            Blog blog = null;
            Setting setting = _appDbContext.Settings.FirstOrDefault();
            List<Social> socials = _appDbContext.Socials.ToList();
            Banner banner = _appDbContext.Banners.FirstOrDefault(b => b.Page.ToLower() == "blog detail");
            List<BlogComment> blogComments = _appDbContext.BlogComments.OrderByDescending(bc=>bc.CreatedDate).Where(i=>i.BlogId==id).ToList();
            if (id != null)
            {
                blog = _appDbContext.Blogs.Find(id);
            }

            VmBlog vmBlog = new VmBlog()
            {
                Socials =  socials,
                Setting = setting,
                Blog = blog,
                BlogComments= blogComments,
                Banner= banner
            };
            return View(vmBlog);
        }
        
        [HttpPost]
        public IActionResult Comment(VmBlog vmBlog)
        {
            Setting setting = _appDbContext.Settings.FirstOrDefault();
            List<Social> socials = _appDbContext.Socials.ToList();
            List<Blog> blogs = _appDbContext.Blogs.ToList();

            if (ModelState.IsValid)
            {
                vmBlog.BlogComment.CreatedDate = DateTime.Now;
                _appDbContext.BlogComments.Add(vmBlog.BlogComment);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            VmBlog vmBlog1 = new VmBlog()
            {
                Socials = socials,
                Setting = setting,
                BlogComment = vmBlog.BlogComment,
                Blog = vmBlog.Blog,
                Blogs = blogs
            };

            

            return View("Index",vmBlog1);
        }


    }
}
