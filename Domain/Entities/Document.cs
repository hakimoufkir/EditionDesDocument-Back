
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Domain.Common;

    namespace Domain.Entities;

    public class Document : Base
    {
        public Guid IdModelDocuments { get; set; }
        public string DocumentType { get; set; }
        public string FilePath { get; set; }

    }