using System;

namespace Matrix.Domain.Models.Database
{
    public class LocalMediaRepositoryThumbnail
    {
        public Guid LocalMediaRepositoryThumbnailId { get; set; }
        public Guid? MediaId { get; set; }
        public int? ThumbnailWidth { get; set; }
        public int? ThumbnailHeight { get; set; }
        public string ThumbnailType { get; set; }
        public string ThumbnailMethod { get; set; }
        public int? ThumbnailLength { get; set; }

        public LocalMediaRepositoryThumbnail()
        {
            this.LocalMediaRepositoryThumbnailId = Guid.NewGuid();
        }
    }
}
