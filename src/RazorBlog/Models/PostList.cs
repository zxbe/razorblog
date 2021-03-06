/*
 * Copyright (c) 2018 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * http://github.com/tidyui/razorblog
 * 
 */

namespace RazorBlog.Models
{
    public sealed class PostList
    {
        public sealed class ListPagination
        {
            /// <summary>
            /// Gets/sets if the archive has a prev link.
            /// </summary>
            public bool HasPrev { get; set; }

            /// <summary>
            /// Gets/sets if the archive has a next link.
            /// </summary>
            public bool HasNext { get; set; }

            /// <summary>
            /// Gets/sets the prev link.
            /// </summary>
            public string PrevLink { get; set; }

            /// <summary>
            /// Gets/sets the next link.
            /// </summary>
            public string NextLink { get; set; }
        }

        /// <summary>
        /// Gets/sets the available posts.
        /// </summary>
        public Post[] Items { get; set; }

        /// <summary>
        /// Gets/sets the optional selected category.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Gets/sets the optional selected tag.
        /// </summary>
        public Tag Tag { get; set; }

        /// <summary>
        /// Gets/sets the optional selected year.
        /// </summary>
        public int? Year { get; set; }

        /// <summary>
        /// Gets/sets the optional selected month.
        /// </summary>
        public int? Month { get; set; }

        /// <summary>
        /// Gets/sets the current page.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets/set the total page count.
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// Gets/sets the current pagination.
        /// </summary>
        public ListPagination Pagination { get; set; } = new ListPagination();
    }
}