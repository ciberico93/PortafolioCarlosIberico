using PORTAFOLIO.Models;

namespace PORTAFOLIO.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos :IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {

                    new Proyecto
                    {
                        Titulo = "Iber Solutions",
                        Desccripcion = "Página de desarrollo de software ASP.NET Core",
                        Link = "https://iber-solutions.com",
                        ImagenURL = "/IMAGENES/imgIber-solutions.jpg"
                    },
                    new Proyecto

                    {
                        Titulo = "Veterinaria",
                        Desccripcion = "Desarrollo de software ASP.NET Core",
                        Link = "No está en producción",
                        ImagenURL = ""

                    },

                    new Proyecto

                    {

                        Titulo = "Techvip",
                        Desccripcion = "Página de E-commerce",
                        Link = "https://techvipp.com/",
                        ImagenURL = "/IMAGENES/imgTechVipp.jpg"
                    }

            };
        }

    }
}
