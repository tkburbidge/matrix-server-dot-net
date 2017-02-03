using System;

namespace Matrix.Domain.Models.Database
{
    public class LocalMediaRepository
    {
        public Guid LocalMediaRepositoryId { get; set; }
        public Guid? MediaId { get; set; }
        public string MediaType { get; set; }
        public int? MediaLength { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public string UploadName { get; set; }
        public Guid? UserId { get; set; }

        public LocalMediaRepository()
        {
            this.LocalMediaRepositoryId = Guid.NewGuid();
            this.CreatedTimestamp = DateTime.UtcNow;
        }
    }
}
