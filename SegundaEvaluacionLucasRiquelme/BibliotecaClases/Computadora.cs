using System.Globalization;

namespace BibliotecaClases
{
    public class Computadora
    {
        int capacidadDisco;
        int memoriaRam;
        string procesador;
        List<string> programas;
        string sistemaOperativo;

        public int CapacidadDisco { get => capacidadDisco; }
        public int MemoriaRam { get => memoriaRam; }
        public string Procesador { get => procesador; }
        public List<string> Programas { get { return GetProgramas(); } }
        public string SistemaOperativo { get => sistemaOperativo;}

        private Computadora()
        {
            List<string> programas = new List<string>();
        }
        public Computadora(string procesador, int capacidadDisco , int memoriaRam , string sistemaOperativo) : this()
        {
            this.procesador = procesador;
            this.capacidadDisco = capacidadDisco;
            this.memoriaRam = memoriaRam;
            this.sistemaOperativo = sistemaOperativo;
        }
        public List<string> GetProgramas()
        {
            return programas;
            //esta propiedad retorna un string con todos los nombres de los programas concatenados.
        }
        public void SetPrograma(string programa)
        {
            programas.Add(programa);
        }
        public static List<string> ListadoDeProcesadores()
        {
            List<string> listaProcesadores = new List<string>() {"Procesador 1", "Procesador 2", "Procesador 3", "Procesador 4", "Procesador 5" };
            return listaProcesadores;
        }


    }
}
