using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace E_Commerce_Cobro_Interfaz
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            Pedido pedido = DeserializarCarritoDTO();
            Usuario usuario = DeserializarUsuarioDTO();
            pedido.Usuarios = usuario;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            
        }

        static Pedido DeserializarCarritoDTO()
        {
            var carritoDTO = File.ReadAllText("carritoDTO.txt");
            var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy HH:mm:ss" };
            var pedido = JsonConvert.DeserializeObject<Pedido>(carritoDTO, dateTimeConverter);

            return pedido;
        }

        static Usuario DeserializarUsuarioDTO()
        {
            var usuarioDTO = File.ReadAllText("UsuarioDTO.txt");
            var usuario = JsonConvert.DeserializeObject<Usuario>(usuarioDTO);

            return usuario;
        }

        
    }
}