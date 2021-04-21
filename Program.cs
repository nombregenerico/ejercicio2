using System;

namespace ejercicio2
{
    public sealed class VariableCapturadExpresionLambda
    {
        public static Func<int> IncrementarContadorLocal()
        {
            int contador = 0;

            // Retorna una expresión lambda que será asignada 
            // a un delegado de naturaleza `Func<TResult>`:
            return () => contador++;
        }

        public static void Main()
        {
            // Creamos un delegado de tipo `Func<TResult>`:
            Func<int> delegadoIncremento;

            // Invocamos a `IncrementarContadorLocal` una 
            // sola vez para obtener la referencia a una expresión lambda:
            delegadoIncremento = IncrementarContadorLocal();

            // Mostremos en pantalla la invocación indirecta de la 
            // expresión lambda retornada por `IncrementarContadorLocal` 
            // y encapsulada en en la instancia `delegadoIncremento`:
            Console.WriteLine(delegadoIncremento());
            Console.WriteLine(delegadoIncremento());
            Console.WriteLine(delegadoIncremento());
        }
    }
}