using System;

namespace EFCoreSnapshotCorruptionDemo
{
    public class Blogpost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public DateTime PublishDate { get; set; }
        public string Text { get; set; }
    }
}
