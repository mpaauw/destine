using System;
using System.Collections.Generic;
using System.Text;

namespace Destine.Api.Models
{
    public class Item
    {
        /// <summary>
        /// The Item's unique id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Indicates whether or not the Item has been deleted.
        /// True if the Item is deleted, false if otherwise.
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// The type of Item.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The username of the Item's author.
        /// </summary>
        public string By { get; set; }

        /// <summary>
        /// Creation date of the Item, in Unix Time.
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// The Comment, Story, or Poll text.
        /// HTML.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Indicates whether or not the Item is dead.
        /// True if the Item is dead, false if otherwise.
        /// </summary>
        public bool Dead { get; set; }

        /// <summary>
        /// The Comment's parent; either another Comment or the relevant Story.
        /// </summary>
        public int Parent { get; set; }

        /// <summary>
        /// The Pollopt's associated poll.
        /// </summary>
        public string Poll { get; set; }

        /// <summary>
        /// The Ids of the Item's Comments, in ranked display order.
        /// </summary>
        public int[]  Kids { get; set; }

        /// <summary>
        /// The URL of the Story.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The Story's score, or the votes for a Pollopt.
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// The title of the Story, Poll or Job.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A list of related Pollopts, in display order.
        /// </summary>
        public int[] Parts { get; set; }

        /// <summary>
        /// In the case of Stories or Polls, the total comment count.
        /// </summary>
        public int Descendants { get; set; }
    }
}
