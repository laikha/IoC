
using System;

namespace IoC
{
    /// <summary>
    /// A interface to use in classes
    /// </summary>
    /// @author Ricardo Silva
    public interface I4IoC<in T>
    {
        string WhoAmI();

        string WhoAmI(dynamic whoIs);

        float GetMidGrade();

        void NotInitialized(dynamic whoIs);
    }
}
