using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace WebAPI.Utils
{
    public class QueryUtils
    {
        //private readonly DataContext _context;

        //public QueryUtils(DataContext context)
        //{
        //    _context = context;
        //}

        //// Helper method to retrieve Id by name
        //private int GetId(string tableName, string name)
        //{
        //    var resultId = _context.Set<YourEntity>()
        //                           .Where(e => e.Name == name)
        //                           .Select(e => e.Id)
        //                           .FirstOrDefault();
        //    if (resultId == null)
        //    {
        //        throw new Exception($"{name} Name is not found in {tableName}.");
        //    }
        //    else
        //    {
        //        return resultId;
        //    }
        //}
    }
}
