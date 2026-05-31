using System;

namespace IoC
{
    /// <summary>
    /// Classe base para classes que precisam fornecer informações e validação sobre o tipo T.
    /// </summary>
    /// <typeparam name="T">O tipo associado à classe.</typeparam>
    public class BasicClassInversion<T> : I4IoC<T>
    {
        /// <summary>
        /// Method to return this class' name
        /// </summary>
        /// <returns>the <code>T</code> class' name</returns>
        public string WhoAmI()
        {
            return typeof(T).Name;
        }

        public override string ToString()
        {
            return typeof(T).ToString();
        }
        public void NotInitialized(T whoIs)
        {
            if (whoIs == null)
            {
                throw new ArgumentNullException(nameof(whoIs), $"{WhoAmI()} was not instantiated");
            }

            throw new InvalidOperationException($"{WhoAmI(whoIs)} was not instantiated");
        }

        public void NotInitialized(Type whoIs)
        {
            if (whoIs == null)
            {
                throw new ArgumentNullException(nameof(whoIs));
            }

            throw new ArgumentNullException(whoIs.Name, $"{whoIs.Name} was not instantiated");
        }

        public virtual float GetMidGrade()
        {
            throw new NotImplementedException();
        }

        public string WhoAmI(T whoIs)
        {
            if (whoIs == null)
            {
                throw new ArgumentNullException(nameof(whoIs));
            }

            return whoIs.GetType().Name;
        }
    }
}