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

        /// <summary>
        /// Method to return the instantianted class
        /// </summary>
        /// <returns>Class instantiated in BasicClassInversion</returns>
        public virtual T GetInstantiatedClass()
        {
            //If the class to inject was not initialized, then raise an exception
            if(_t == null){
                throw new NullReferenceException($"You need instantiate a new class of {WhoAmI()} using BasicClassInversion({WhoAmI()} t) constructor");
            }
            return _t;
        }


        public override string ToString()
        {
            return _t.ToString();
        }
    }
}