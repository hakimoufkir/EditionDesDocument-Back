
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Domain.Common;

    namespace Domain.Entities;

    public class Documents : Base
    {
        public Guid IdModelDocuments { get; set; }
        public string DocumentType { get; set; }
        public string FilePath { get; set; }
        public enum DocumentStatus
        {
            Accepte,
            InProgress,
            Deny
        }
    }