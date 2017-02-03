using System;

namespace Matrix.Domain.Models.Database
{
    public class RemoteMediaCache
    {
        public Guid RemoteMediaCacheId { get; set; }
        public string MediaOrigin { get; set; }
        public Guid? MediaId { get; set; }
        public string MediaType { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public string UploadName { get; set; }
        public int? MediaLength { get; set; }
        public Guid? FilesystemId { get; set; }

        public RemoteMediaCache()
        {
            this.RemoteMediaCacheId = Guid.NewGuid();
            this.CreatedTimestamp = DateTime.UtcNow;
        }
    }
}
