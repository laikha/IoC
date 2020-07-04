using System;

namespace IoC
{
    /// <summary>
    /// Class base for all class' that need
    /// </summary>
    /// <typeparam name="T">The class</typeparam>
    /// @author Ricardo Silva
    public class BasicClassInversion<T>: I4IoC<T>
    {
        //use this to get the class that you are working with
        private readonly T _t;

        /// <summary>
        /// A constructor for this class
        /// </summary>
        /// <param name="t">Class to be inicialized</param>
        public BasicClassInversion(T t)
        {
            _t = t;
        }

        public BasicClassInversion()
        {
            
        }

        /// <summary>
        /// Method to return this class' name
        /// </summary>
        /// <returns>the <code>T</code> class' name</returns>
        public virtual string WhoAmI()
        {
            return typeof(T).Name;
        }



        public override string ToString()
        {
            return _t.ToString();
        }

        protected void NotInitialized()
        {
#pragma warning disable S3928 // Parameter names used into ArgumentException constructors should match an existing one 
            throw new ArgumentNullException(nameof(T), $"{WhoAmI()} was not instantiated");
#pragma warning restore S3928 // Parameter names used into ArgumentException constructors should match an existing one 
        }
    }
}