namespace sistemaVentas.Vista
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
            Application.Run(new RolVistas.RolInsertarVistas());
            Application.Run(new TipoProdVistas.TipoProdInsertarVistas());
            Application.Run(new MarcaVistas.MarcaInsertarVista());
            Application.Run(new ProveedorVistas.ProveedorListarVista());
            Application.Run(new UsuarioVistas.UsuarioListarVista());
            Application.Run(new UsuarioRolVistas.UsuarioRolListarVista());
            Application.Run(new ClienteVistas.ClienteInsertarVista());
            Application.Run(new IngresoVistas.IngresoListarVista());
            Application.Run(new VentaVistas.VentaListarVista());
            Application.Run(new ProductoVistas.ProductoListarVista());
            Application.Run(new ProveeVistas.ProveeListarVista());
            Application.Run(new DetalleVentaVistas.DetalleVentaListarVista());
            Application.Run(new DetalleingVistas.DetalleingInsertarVistas());

        }
    }
}
