//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KryptoniteGaming.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Batch
    {
        public int Id { get; set; }
        public string Outcome { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Pos1 { get; set; }
        public Nullable<int> Pos2 { get; set; }
        public Nullable<int> Pos3 { get; set; }
        public Nullable<int> GameId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public int Processed { get; set; }
        public Nullable<System.DateTime> ProcessedDate { get; set; }
    }
}