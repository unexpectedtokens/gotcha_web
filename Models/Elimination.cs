using System.ComponentModel.DataAnnotations;
using System;
namespace gotcha_web.Models
{
    public class Elimination
    {
        public int Id{get;set;}
        public string Description {get;set;}
        [DataType(DataType.DateTime)]
        public DateTime EliminatedAt{get;set;}
    }
}