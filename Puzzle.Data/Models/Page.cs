using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle.Data.Models
{
    /// <summary>
    /// Holds the content of a single Page of a Website.
    /// Can be a child of a <see cref="Website"/> or another <see cref="Page"/>.
    /// </summary>
    [Table]
    public class Page
    {
        /// <summary>
        /// ID.
        /// </summary>
        [Column, PrimaryKey, Identity]
        public Guid ID { get; set; }

        /// <summary>
        /// The name of the <see cref="Page"/> which will be used in the URL.
        /// </summary>
        [Column]
        public string Name { get; set; }

        /// <summary>
        /// HTML content of the <see cref="Page"/>.
        /// </summary>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string HTML { get; set; }

        /// <summary>
        /// CSS content of the <see cref="Page"/>.
        /// </summary>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string CSS { get; set; }

        /// <summary>
        /// JavaScript content of the <see cref="Page"/>.
        /// </summary>
        [Column(DataType = LinqToDB.DataType.Text)]
        public string JS { get; set; }

        /// <summary>
        /// Foreign key to <see cref="Website"/>.
        /// </summary>
        [Column]
        public Guid WebsiteID { get; set; }

        /// <summary>
        /// Foreign key to <see cref="Page"/>.
        /// </summary>
        [Column]
        public Guid ParentPageID { get; set; }

        /// <summary>
        /// Foreign key to <see cref="Models.Layout"/>.
        /// </summary>
        [Column]
        public Guid LayoutID { get; set; }

        /// <summary>
        /// The parent <see cref="Website"/> if it exists.
        /// </summary>
        [Association(ThisKey = nameof(WebsiteID), OtherKey = nameof(Website.ID), CanBeNull = false, Relationship = Relationship.ManyToOne)]
        public Website ParentWebsite { get; set; }

        /// <summary>
        /// The parent <see cref="Page"/> if it exists.
        /// </summary>
        [Association(ThisKey = nameof(ParentPageID), OtherKey = nameof(ID), CanBeNull = true, Relationship = Relationship.ManyToOne)]
        public Page ParentPage { get; set; }

        /// <summary>
        /// Pages this <see cref="Page"/> is the direct parent of.
        /// </summary>
        [Association(ThisKey = nameof(ID), OtherKey = nameof(ParentPageID), CanBeNull = true, Relationship = Relationship.OneToMany)]
        public List<Page> Pages { get; set; }

        /// <summary>
        /// The Layout this <see cref="Page"/> is based on.
        /// </summary>
        [Association(ThisKey = nameof(LayoutID), OtherKey = nameof(Models.Layout.ID), CanBeNull = true, Relationship = Relationship.ManyToOne)]
        public Layout Layout { get; set; }

        /// <summary>
        /// HTML content of the <see cref="Page"/> rendered within the <see cref="Models.Layout"/>.
        /// If the <see cref="Models.Layout"/> is not defined, only the HTML of the <see cref="Page"/> will be returned.
        /// </summary>
        [NotColumn]
        public string CombinedHTML => Layout?.HTML?.Replace("<puzzle-render-page/>", HTML) ?? HTML;
    }
}
