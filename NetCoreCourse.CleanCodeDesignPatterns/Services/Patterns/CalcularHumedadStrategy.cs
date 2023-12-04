using System;
using System.Collections.Generic;

namespace NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns
{

    // Interfaz para las estrategias de cálculo de humedad
    public interface ICalcularHumedadStrategy
    {
        string CalcularHumedad(int humedadRelativa);
    }

    // Implementación de la estrategia para calcular humedad baja
    public class CalculadorHumedadBaja : ICalcularHumedadStrategy
    {
        public string CalcularHumedad(int humedadRelativa)
        {
            if (humedadRelativa < 30)
            {
                return "Sensación de sequedad.";
            }
            else
            {
                return "Condiciones normales.";
            }
        }
    }

    // Implementación de la estrategia para calcular humedad moderada
    public class CalculadorHumedadModerada : ICalcularHumedadStrategy
    {
        public string CalcularHumedad(int humedadRelativa)
        {
            if (humedadRelativa < 40)
            {
                return "Humedad moderada.";
            }
            else
            {
                return "Condiciones normales.";
            }
        }
    }

    // Contexto que utiliza el patrón Strategy con un Dictionary
    public class CalculadoraHumedad
    {
        private Dictionary<string, ICalcularHumedadStrategy> estrategias;
        private ICalcularHumedadStrategy calcularHumedadStrategy;
        public CalculadoraHumedad()
        {
            estrategias = new Dictionary<string, ICalcularHumedadStrategy>
        {
            { "Baja", new CalculadorHumedadBaja() },
            { "Moderada", new CalculadorHumedadModerada() }
        };
        }

        public void CambiarEstrategia(string nombreEstrategia)
        {
            if (estrategias.ContainsKey(nombreEstrategia))
            {
                estrategias.TryGetValue(nombreEstrategia, out var nuevaEstrategia);
                if (nuevaEstrategia != null)
                {
                    calcularHumedadStrategy = nuevaEstrategia;
                }
            }
            else
            {
                Console.WriteLine($"La estrategia '{nombreEstrategia}' no existe. Se mantendrá la estrategia actual.");
            }
        }

        public string CalcularHumedadParaHumedadRelativa(int humedadRelativa)
        {
            return calcularHumedadStrategy.CalcularHumedad(humedadRelativa);
        }
    }

}
