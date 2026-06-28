using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Entity
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

        public string? Link { get; set; }

        public DateTime PublishedOn { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}