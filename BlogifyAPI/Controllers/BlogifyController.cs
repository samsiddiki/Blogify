using Microsoft.AspNetCore.Mvc;
using ClassLibraryDAL;
using ClassLibraryModel;
using System;
using System.Collections.Generic;

namespace BlogifyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBlog()
        {
            try
            {
                var blogList = BlogDAL.GetBlog();

                if (blogList.Count > 0)
                {
                    return Ok(blogList);
                }
                else
                {
                    return NotFound("No blogs found");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        //[HttpGet("{username}")]
        //public List<IActionResult> GetUserBlog(string username)
        //{
            //try
            //{
            //    var blogList = GetUserBlog.GetProperties(username);

            //    if (blogList != null)
            //    {
            //        return Ok(blogList);
            //    }
            //    else
            //    {
            //        return NotFound(blogList);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Log the exception for further investigation
            //    Console.WriteLine($"An error occurred: {ex}");

            //    // Return a generic error message
            //    return StatusCode(500);
            //}
        //}


        [HttpPost]
        public IActionResult SaveBlog(Blog cm, string name)
        {
            try
            {
                int result = BlogDAL.SaveBlog(cm, name);

                if (result > 0)
                {
                    return Ok("Blog saved successfully");
                }
                else
                {
                    return BadRequest("Failed to save blog");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpDelete("{blogId}")]
        public IActionResult DeleteBlog(int blogId)
        {
            try
            {
                int result = BlogDAL.DeleteBlog(blogId);

                if (result > 0)
                {
                    return Ok("Blog deleted successfully");
                }
                else
                {
                    return BadRequest("Failed to delete blog");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("register")]
        public IActionResult SaveRegisterUser(User cm)
        {
            try
            {
                int result = UserDAL.SaveRegisterUser(cm);

                if (result > 0)
                {
                    return Ok("User registered successfully");
                }
                else
                {
                    return BadRequest("Failed to register user");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
