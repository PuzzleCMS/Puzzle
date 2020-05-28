using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <summary>
    /// Combines multiple <see cref="Page"/>s to one web application,
    /// which has to be served on the specified <see cref="RootPath"/>.
    /// </summary>
    [Table]
    public class Website
    {
        /// <summary>
        /// ID.
        /// </summary>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <summary>
        /// Pages this <see cref="Website"/> is the direct parent of.
        /// </summary>
        [Association(ThisKey = nameof(ID), OtherKey = nameof(Page.WebsiteID), CanBeNull = true, Relationship = Relationship.OneToMany)]
        public List<Page> Pages { get; set; }

        /// <summary>
        /// The URL this <see cref="Website"/> runs on.
        /// </summary>
        [Column]
        public string RootPath { get; set; }

        /// <summary>
        /// If the <see cref="Website"/> should run headless.
        /// </summary>
        [Column]
        public bool HeadlessMode { get; set; }
    }
}
