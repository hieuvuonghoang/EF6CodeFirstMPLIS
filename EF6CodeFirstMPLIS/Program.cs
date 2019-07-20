namespace EF6CodeFirstMPLIS.Models
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var ctx = new MplisDbContext())
            {
                ctx.SaveChanges();
            }
            Console.WriteLine("Success!!!");
            Console.ReadKey();
        }
    }
}
