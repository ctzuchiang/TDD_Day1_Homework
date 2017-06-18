using System;
using System.Collections.Generic;
using System.Linq;

namespace Product
{
    public static class ProductService
    {
        /// <summary>
        /// Sums the size of the group.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="groupSize">Size of the group.</param>
        /// <param name="groupName">Name of the group.</param>
        /// <returns></returns>
        public static IEnumerable<int> SumGroupSize<TSource>(this IEnumerable<TSource> source, int groupSize, Func<TSource, int> groupName)
        {
            var index = 0;
            while (index <= source.Count())
            {
                yield return source.Skip(index).Take(groupSize).Sum(groupName);
                index += groupSize;
            }
        }
    }

    public class ProductModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        internal int Id { get; set; }
        internal int Cost { get; set; }
        internal int Revenue { get; set; }
        internal int SellPrice { get; set; }
    }
}