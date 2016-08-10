﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evbpc.Framework.Utilities.Extensions
{
    /// <summary>
    /// Provides general extensions on <code>IEnumerable{T}</code> types.
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Removes all elements from the source <code>IEnumerable{T}</code> that are present in the exceptions <code>IEnumerable{T}</code>.
        /// </summary>
        /// <typeparam name="T">The type of the source and exception parameters.</typeparam>
        /// <param name="source">The <code>IEnumerable{T}</code> containing the elements to be excepted.</param>
        /// <param name="exceptions">The <code>IEnumerable</code> containing the elements to except out.</param>
        /// <returns>An <code>IEnumerable{T}</code> that is the source <code>IEnumerable{T}</code> remove the exceptions <code>IEnumerable{T}</code>.</returns>
        /// <remarks>
        /// If an element appears multiple times in the exceptions <code>IEnumerable{T}</code>, that many copies of it will be removed from the source <code>IEnumerable{T}</code>.
        /// 
        /// Example:
        /// 
        /// Source: { 2, 2, 2, 6 }
        /// Exceptions: { 2, 2, 3, 4, 5 }
        /// Result: { 2, 6 }
        /// 
        /// Neither of the <code>IEnumerable{T}</code>s need be ordered in any particular manner. The order of the resultant <code>IEnumerable{T}</code> will be identical to the order of the <code>source</code> parameter, excepting exactly the <code>exceptions</code> parameter.
        /// </remarks>
        public static IEnumerable<T> ExceptExact<T>(this IEnumerable<T> source, IEnumerable<T> exceptions)
        {
            var tExceptions = exceptions.ToList();

            foreach (var el in source)
            {
                var index = tExceptions.IndexOf(el);

                if (index >= 0)
                {
                    tExceptions.RemoveAt(index);
                    continue;
                }

                yield return el;
            }
        }
    }
}