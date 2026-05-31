
using System;

namespace IoC
{
    /// <summary>
    /// Contrato básico para classes que expõem informações sobre o tipo genérico T.
    /// </summary>
    public interface I4IoC<in T>
    {
        string WhoAmI();

        string WhoAmI(T whoIs);

        float GetMidGrade();

        void NotInitialized(T whoIs);
    }
}
