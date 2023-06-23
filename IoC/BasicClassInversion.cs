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
            return typeof(T).ToString();
        }

        protected void NotInitialized()
        {
#pragma warning disable S3928 // Parameter names used into ArgumentException constructors should match an existing one 
            throw new ArgumentNullException(nameof(T), $"{WhoAmI()} was not instantiated");
#pragma warning restore S3928 // Parameter names used into ArgumentException constructors should match an existing one 
        }

        public virtual float GetMidGrade()
        {
            throw new NotImplementedException();
        }
    }
}