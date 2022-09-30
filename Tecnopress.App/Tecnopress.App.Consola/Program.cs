using System;
using Tecnopress.App.Dominio;
using Tecnopress.App.Persistencia;

namespace Tecnopress.App.Consola
{
    class Program
    {
        //INSTANCIAMOS REPOSITORIO
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(
            new Tecnopress.App.Persistencia.ApplicationContext()
        );
        private static IRepositorioCategoria _repoCategoria = new RepositorioCategoria(
            new Tecnopress.App.Persistencia.ApplicationContext()
        );
        private static IRepositorioProyecto _repoProyecto = new RepositorioProyecto(
            new Tecnopress.App.Persistencia.ApplicationContext()
        );

        static void Main(string[] args)
        {
            Console.WriteLine("Tecnopress App");
            //AQUI SE LLAMAN LOS METODOS A UTILIZAR
            //
            // METODOS ENTIDAD CLIENTE

            // AgregarCliente();
            // modificarCliente();
            // BorrarCliente();
            // BuscarCliente();
            //ObtenerClientes();
            //******************//
            //     metodos entidad categoria    //
            //AgregarCategoria();
            //modificarCategoria();
            // BuscarCategoria();
            //BorrarCategoria();
            // ObtenerCategorias();
            /////
            /***************/
            //  METODOS DE ENTIDAD PROYECTO  //
            //agregarProyecto();
            //BuscarProyecto();
            //modificarProyecto();
           // BorrarProyecto();
          // ObtenerProyectos();
        }

        //
        //
        //crear metodos  RFERENTE A LA ENTIDAD CLIENTE

        //Metodo MODIFICAR Cliente
        public static void modificarCliente()
        {
            //pedir el id del cliente a Modificar
            Console.WriteLine("Ingrese el id del Cliente a Modificar");
            int idCliente = int.Parse(Console.ReadLine());
            //llamamos en el repositorio btener id
            Cliente cliente = _repoCliente.OptenerPorId(idCliente);
            //Solicitar Nuevos Datos
            Console.WriteLine("Ingrese el nuevo Nit del CLiente");
            cliente.nit = Console.ReadLine();
            Console.WriteLine("Ingrese el Nuevo Nombredel Cliente");
            cliente.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo Teléfono del CLiente");
            cliente.telefono = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo Correo del CLiente");
            cliente.email = Console.ReadLine();
            Console.WriteLine("Ingrese la Nueva Dirección del CLiente");
            cliente.direccion = Console.ReadLine();
            Console.WriteLine("Ingrese la Nueva Nacionalidad del CLiente");
            cliente.nacionalidad = Console.ReadLine();
            //llamamos el repositorio actualizar
            _repoCliente.UpdateCliente(cliente);
        }

        // Metodo Agregar Cliente
        public static void AgregarCliente()
        {
            Console.WriteLine("Agregar un Cliente");
            //Instanciar la entidad Cliente
            Cliente clienteNuevo = new Cliente();
            //obtener datos del cliente__solicitarlos por consola
            Console.WriteLine("Escriba el Nit del Cliente: ");
            clienteNuevo.nit = Console.ReadLine();
            Console.WriteLine("Escriba el  Nombre del Cliente: ");
            clienteNuevo.nombre = Console.ReadLine();
            Console.WriteLine("Escriba el Teléfono del Cliente: ");
            clienteNuevo.telefono = Console.ReadLine();
            Console.WriteLine("Escriba el Correo del Cliente: ");
            clienteNuevo.email = Console.ReadLine();
            Console.WriteLine("Escriba la Dirección del Cliente: ");
            clienteNuevo.direccion = Console.ReadLine();
            Console.WriteLine("Escriba la Nacionalidad del Cliente: ");
            clienteNuevo.nacionalidad = Console.ReadLine();

            //cuando es genero
            //Console.WriteLine("Escriba escriba el genero del cliente: (0 mas 1 fem) ");
            //utilizamos el int.Parse para atributo q reciba entero
            //clienteNuevo.genero=int.Parse( Console.ReadLine());

            // Invocamos el Repositorio
            _repoCliente.AddCliente(clienteNuevo);
        }

        //CREAMOS METODO DE ELIMINAR UN CLIENTE
        private static void BorrarCliente()
        {
            //pedir el id del cliente a eliminar
            Console.WriteLine("Ingrese el Id del Cliete a Eliminar: ");
            int idCliente = int.Parse(Console.ReadLine());
            _repoCliente.DeleteCliente(idCliente);
        }

        //metodo Buscar Cliente
        public static void BuscarCliente()
        {
            //Pedir el Id del cliente a buscar
            Console.WriteLine("Ingrese el Id del Cliente a Buscar: ");
            int idCliente = int.Parse(Console.ReadLine());

            //buscar el cliente
            Cliente cliente = _repoCliente.OptenerPorId(idCliente);
            Console.WriteLine(
                "El cliente es: "
                    + cliente.nombre
                    + " "
                    + cliente.nit
                    + " "
                    + cliente.telefono
                    + " "
                    + cliente.email
                    + " "
                    + cliente.direccion
                    + " "
                    + cliente.nacionalidad
            );
        }

        //metodo para mostrar todos los cliente

        private static void ObtenerClientes()
        {
            //traer todos los clientes
            var clientes = _repoCliente.OptenerTodosCliente();
            //rECORRER Y MOSTRAR LOS CLIENTES
            foreach (var cliente in clientes)
            {
                Console.WriteLine(
                    cliente.nombre
                        + " "
                        + cliente.nit
                        + " "
                        + cliente.telefono
                        + " "
                        + cliente.email
                        + " "
                        + cliente.direccion
                        + " "
                        + cliente.nacionalidad
                );
            }
        }

        ///
        /// METODOS PARA LA ENTIDAD CATEGORIA
        ///


        // METODO INSERTAR
        public static void AgregarCategoria()
        {
            Console.WriteLine("Agregar una Categoría");
            //Instanciar la entidad Cliente
            Categoria categoriaNueva = new Categoria();
            //obtener datos del cliente__solicitarlos por consola
            Console.WriteLine("Escriba el Nombre de la Categoría: ");
            categoriaNueva.nombreCategoria = Console.ReadLine();

            // Invocamos el Repositorio
            _repoCategoria.AddCategoria(categoriaNueva);
        }

        // METODO ACTUALIZAR

        public static void modificarCategoria()
        {
            //pedir el id del cliente a Modificar
            Console.WriteLine("Ingrese el id de la Ctaegoría a Modificar");
            int idCategoria = int.Parse(Console.ReadLine());
            //llamamos en el repositorio btener id
            Categoria categoria = _repoCategoria.GetCategoria(idCategoria);
            //Solicitar Nuevos Datos
            Console.WriteLine("Ingrese el nuevo Nombre de la Categoría");
            categoria.nombreCategoria = Console.ReadLine();

            //llamamos el repositorio actualizar
            _repoCategoria.UpdateCategoria(categoria);
        }

        // METODO BUSCAR
        public static void BuscarCategoria()
        {
            //Pedir el Id del cliente a buscar
            Console.WriteLine("Ingrese el Id de la Categoría a Buscar: ");
            int idCategoria = int.Parse(Console.ReadLine());

            //buscar el cliente
            Categoria categoria = _repoCategoria.GetCategoria(idCategoria);
            Console.WriteLine("La Categoría es: " + categoria.nombreCategoria);
        }

        // METODO ELIMINAR
        private static void BorrarCategoria()
        {
            //pedir el id del cliente a eliminar
            Console.WriteLine("Ingrese el Id del la Categoría a Eliminar: ");
            int idCategoria = int.Parse(Console.ReadLine());
            _repoCategoria.DeleteCategoria(idCategoria);
        }

        // METODO MOSTRAR TODAS LAS CATEGORIAS
        private static void ObtenerCategorias()
        {
            //traer todos los clientes
            var categorias = _repoCategoria.GetALLCategoria();
            //rECORRER Y MOSTRAR LOS CLIENTES
            foreach (var categoria in categorias)
            {
                Console.WriteLine(categoria.nombreCategoria);
            }
        }

        /////////////// metodos de la tabla PROYECTO ////////////

        //
        //metodo insertar
        private static void agregarProyecto()
        {
            Console.WriteLine("Agregar un Proyecto");
            //Instanciar la entidad Proyecto
            Proyecto proyectoNuevo = new Proyecto();
            //obtener datos del proyecto__solicitarlos por consola

            //pedimos al usuario los ID de las Categorias
            Console.WriteLine("Escriba el Id de la Categoría a Relacionar con el Proyecto: ");
            proyectoNuevo.categoriaId = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el Id del Cliente a Relacionar con el Proyecto: ");
            proyectoNuevo.clienteId = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el Nombre del Proyecto: ");
            proyectoNuevo.nombreProyecto = Console.ReadLine();
            Console.WriteLine("Escriba el Código del Proyecto: ");
            proyectoNuevo.codigoProyecto = Console.ReadLine();
            Console.WriteLine("Escriba el Tiempo de Ejecución del Proyecto: ");
            proyectoNuevo.TiempoEjecucion = Console.ReadLine();
            Console.WriteLine("Escriba la Fecha de Ejecucion del Proyecto: ");
            proyectoNuevo.FechaEjecucion = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el Costo del Proyecto: ");
            proyectoNuevo.Costo = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la Descripción del Proyecto: ");
            proyectoNuevo.DescripcionProyecto = Console.ReadLine();
            Console.WriteLine("Escriba el Numero de Vistas del Proyecto: ");
            proyectoNuevo.Visitas = int.Parse(Console.ReadLine());

            // Invocamos el Repositorio
            _repoProyecto.AddProyecto(proyectoNuevo);
        }

        // metodo actulizar

         public static void modificarProyecto()
        {
            //pedir el id del cliente a Modificar
            Console.WriteLine("Ingrese el id del Proyecto a Modificar");
            int idProyecto = int.Parse(Console.ReadLine());
            //llamamos en el repositorio btener id
            Proyecto proyecto = _repoProyecto.GetProyecto(idProyecto);
            //Solicitar Nuevos Datos
            Console.WriteLine("Ingrese el nuevo Nombre del Proyecto");
            proyecto.nombreProyecto = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo Codigo del Proyecto");
            proyecto.codigoProyecto = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo Tiempo de Ejecucion del Proyecto");
            proyecto.TiempoEjecucion = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva fecha de ejecucion del Proyecto");
            proyecto.FechaEjecucion = DateTime.Parse( Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo costo del Proyecto");
            proyecto.Costo = float.Parse (Console.ReadLine());
            Console.WriteLine("Ingrese la nueva descripción del Proyecto");
            proyecto.DescripcionProyecto= Console.ReadLine();
            Console.WriteLine("Ingrese la nueva visita del Proyecto");
            proyecto.Visitas= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nueva Categoria del Proyecto");
            proyecto.categoriaId= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo cliente del Proyecto");
            proyecto.clienteId=int.Parse(Console.ReadLine());
            //llamamos el repositorio actualizar
            
            _repoProyecto.UpdateProyecto(proyecto);
        }

        // metodo buscar
        public static void BuscarProyecto()
        {
            //Pedir el Id del cliente a buscar
            Console.WriteLine("Ingrese el Id de el Proyecto a Buscar: ");
            int idProyecto = int.Parse(Console.ReadLine());

            //buscar el cliente
            Proyecto proyecto = _repoProyecto.GetProyecto(idProyecto);
            Console.WriteLine(
                "El Proyecto es: "
                    + proyecto.nombreProyecto
                    + " "
                    + proyecto.codigoProyecto
                    + " "
                    + proyecto.Costo
                    + " "
                    + proyecto.DescripcionProyecto
                    + " "
                    + proyecto.FechaEjecucion
                    + " "
                    + proyecto.TiempoEjecucion
                  
                    +" "
                    +proyecto.Visitas
                    +" "
                    +proyecto.clienteId //muestra solo el id
                    +" "
                    + proyecto.categoriaId // muestra solo el id
                   
                
            );
        }

        // metodo eliminaR
         private static void BorrarProyecto()
        {
            //pedir el id del cliente a eliminar
            Console.WriteLine("Ingrese el Id del Proyecto a Eliminar: ");
            int idProyecto= int.Parse(Console.ReadLine());
            _repoProyecto.DeleteProyecto(idProyecto);
        }

        // metodo mostrar todos
         private static void ObtenerProyectos()
        {
            //traer todos los clientes
            var proyectos = _repoProyecto.GetALLProyecto(); 
            //rECORRER Y MOSTRAR LOS CLIENTES
            foreach (var proyecto in proyectos)
            {
                Console.WriteLine(
                    proyecto.nombreProyecto
                    + " "
                    + proyecto.codigoProyecto
                    + " "
                    + proyecto.Costo
                    + " "
                    + proyecto.DescripcionProyecto
                    + " "
                    + proyecto.FechaEjecucion
                    + " "
                    + proyecto.TiempoEjecucion
                  
                    +" "
                    +proyecto.Visitas
                    +" "
                    +proyecto.clienteId //muestra solo el id
                    +" "
                    + proyecto.categoriaId 
                );
            }
        }
    }
}
