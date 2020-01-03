﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IoC
{
    /// <summary>
    /// Class base for all class' that need
    /// </summary>
    /// <typeparam name="T">The class</typeparam>
    /// @author Ricardo Silva
    public class BasicClassInjection<T>: I4IoC<T>
    {
        //use this to get the class that you are working with
        private T _t;

        /// <summary>
        /// A constructor for this class
        /// </summary>
        /// <param name="t">Class instantiated</param>
        public BasicClassInjection(T t)
        {
            _t = t;
        }

        public BasicClassInjection()
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
        /// <returns>Class instantiated in T</returns>
        public virtual T GetInstantiatedClass()
        {
            //If the class to inject was not initialized, then raise an exception
            if(_t == null){
                throw new NotImplementedException($"You need instantiate a new class of {WhoAmI()} using BasicClassInjection(T t) constructor");
            }
            return _t;
        }

        /// <summary>
        /// Just a method
        /// </summary>
        /// <returns>integer</returns>
        public virtual int Total()
        {
            throw new NotImplementedException();
        }
    }
}