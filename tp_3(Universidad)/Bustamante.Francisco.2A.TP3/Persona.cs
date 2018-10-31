using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public enum ENacionalidad
    {
        Argentino,
        Extranjero
    }

    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private int dni;
        #endregion

        #region Properties
        public string Nombre
        {
            get;
            set;
        }

        public string Apellido
        {
            get;
            set;
        }

        public int DNI
        {
            get;
            set;
        }

        public ENacionalidad Nacionalidad
        {
            get;
            set;
        }

        public string StringToDNI
        {
            get;
            set;
        }
        #endregion

        #region Metodos

        #endregion

        #region Constructor
        public Persona()
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : base()
        {

        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : base()
        {

        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base()
        {

        }
        #endregion

        #region Operadores

        #endregion

        #region Sobrecargas

        #endregion
    }
}
