using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class Helpers
    {
        /// <summary>
        /// Check if a value is null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value to check</param>
        /// <param name="parameterName">A name of a parameter to show in exception</param>
        /// <returns>The value whether it is not null</returns>
        public static T Check<T>(T value, string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }
            return value;
        }
    }
}
