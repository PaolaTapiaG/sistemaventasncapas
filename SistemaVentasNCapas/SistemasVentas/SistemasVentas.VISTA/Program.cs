namespace SistemasVentas.VISTA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PersonaVistas.PersonaInsertarVista());
            Application.Run(new RolVistas.RolInsertarVista());
            Application.Run(new TipoProdVistas.TipoProdInsertarVista());
            Application.Run(new MarcaVistas.MarcaInsertarVista());
            Application.Run(new ProveedorVistas.ProveedorInsertarVista());
            Application.Run(new UsuarioVistas.UsuarioInsertarVista());
            Application.Run(new UsuarioRolVistas.UsuarioRolInsertarVista());
            Application.Run(new ClienteVistas.ClienteInsertarVista());
            Application.Run(new IngresoVistas.IngresoInsertarVista());
            Application.Run(new VentaVistas.VentaInsertarVista());
            Application.Run(new ProductoVistas.ProductoInsertarVista());
            Application.Run(new ProveeVistas.ProveeInsertarVista());
            Application.Run(new DetalleVentaVistas.DetalleVentasInsertarVista());
            Application.Run(new DetalleIngVistas.DetalleIngInsertarVista());
        }
    }
}