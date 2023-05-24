namespace Atleta
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
       
            static void Main(string[] args)
            {
                // Criando instâncias das classes
                Atleta atleta = new Atleta();
                Ciclista ciclista = new Ciclista();
                Corredor corredor = new Corredor();
                Nadador nadador = new Nadador();
                Triatleta triatleta = new Triatleta();

                // Chamando os métodos de habilidade
                atleta.VerHabilidade();    // Atleta genérico
                ciclista.VerHabilidade();  // Ciclista: Pedalar
                corredor.VerHabilidade();  // Corredor: Correr
                nadador.VerHabilidade();   // Nadador: Nadar
                triatleta.VerHabilidade(); // Triatleta: Pedalar, Correr e Nadar

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}