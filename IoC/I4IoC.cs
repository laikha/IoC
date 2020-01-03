using System;
using System.Collections.Generic;
using System.Text;

namespace IoC
{
    /// <summary>
    /// A interface to use in classes
    /// </summary>
    /// @author Ricardo Silva
    public interface I4IoC<T>
    {
        string WhoAmI();

        T GetInstantiatedClass();

        int Total();

    }
}
