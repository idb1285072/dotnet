using Microsoft.AspNetCore.Mvc;

namespace Day_07_Work_01.Models
{
    public class Book
    {
        //[FromQuery]
        public int BookId { get; set; }
        public string? Author { get; set; }
        public override string ToString()
        {
            return $"Book Object: BookId - {BookId} and Author - {Author}";
        }
    }
}
