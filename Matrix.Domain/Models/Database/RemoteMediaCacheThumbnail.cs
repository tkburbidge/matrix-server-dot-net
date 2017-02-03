using System;

namespace Matrix.Domain.Models.Database
{
    public class RemoteMediaCacheThumbnail
    {
        public Guid RemoteMediaCacheThumbnailId { get; set; }
        public string MediaOrigin { get; set; }
        public Guid? MediaId { get; set; }
        public int? ThumbnailWidth { get; set; }
        public int? ThumbnailHeight { get; set; }
        public string ThumbnailMethod { get; set; }
        public string ThumbnailType { get; set; }
        public int? ThumbnailLength { get; set; }
        public Guid? FilesystemId { get; set; }

        public RemoteMediaCacheThumbnail()
        {
            this.RemoteMediaCacheThumbnailId = Guid.NewGuid();
        }
    }
}
