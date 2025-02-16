﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Validation;

namespace Bcvp.Blog.Core.BlogCore.Posts
{
    public class CreatePostDto
    {
        public Guid BlogId { get; set; }

        [Required]
        [DynamicStringLength(typeof(PostConsts), nameof(PostConsts.MaxTitleLength))]
        public string Title { get; set; }

        [Required]
        public string CoverImage { get; set; }

        [Required]
        [DynamicStringLength(typeof(PostConsts), nameof(PostConsts.MaxUrlLength))]
        public string Url { get; set; }

        [Required]
        [DynamicStringLength(typeof(PostConsts), nameof(PostConsts.MaxContentLength))]
        public string Content { get; set; }

        public string Tags { get; set; }

        [DynamicStringLength(typeof(PostConsts), nameof(PostConsts.MaxDescriptionLength))]
        public string Description { get; set; }

    }
}
