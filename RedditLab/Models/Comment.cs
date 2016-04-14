using System;
using System.ComponentModel.DataAnnotations;

namespace RedditLab.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public virtual Post ParentPost { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public DateTime Posted { get; set; }
    }
}