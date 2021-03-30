using System;
using System.ComponentModel.DataAnnotations;

namespace EmailDispatcherApi.Infrastructure.Models
{
    public class Entity
    {
        [Key] public Guid Id { get; set; }
    }
}