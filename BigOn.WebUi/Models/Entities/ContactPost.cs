using BigOn.WebUi.AppCode.Infrastructure;
using System;

namespace BigOn.WebUi.Models.Entities
{
    public class ContactPost : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Answer { get; set; }
        public int? AnsweredByUserId { get; set; }
        public DateTime? AnswerDate { get; set; }
    }
}
