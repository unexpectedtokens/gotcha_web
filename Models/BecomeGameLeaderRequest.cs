
using System;
namespace gotcha_web.Models
{
    public class BecomeGameLeaderRequest
    {
        public Player Player {get;set;}
        public DateTime Date{get;set;}
        public string Text {get;set;}
    }



}