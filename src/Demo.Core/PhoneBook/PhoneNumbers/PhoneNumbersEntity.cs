using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Demo.PhoneBook.Person;

namespace Demo.PhoneBook.PhoneNumbers
{
    public class PhoneNumbersEntity:Entity<long>,IHasCreationTime
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [Required]
        [Phone]
        public string Number { get; set; }
        /// <summary>
        /// 号码类型
        /// </summary>
        public virtual PhoneType Type { get; set; }
        public virtual Guid PersonId { get; set; }
        [ForeignKey("PersonId")]
        public virtual PersonEntity Person { get; set; }
        public DateTime CreationTime { get; set; }
    }
}