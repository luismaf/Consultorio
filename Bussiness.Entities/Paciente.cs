using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{

    public class Paciente : BusinessEntitiy
    {
        #region Enumeradores

        public enum TiposDoc { 
            DNI=0,
            LC=1,
            LE=2,
        }
        public enum GruposSanguineos { 
            A=0,
            B=1,
            AB=2,
            O=3,
        }
        public enum FactoresSanguineos { 
            positivo=0,
            negativo=1,
        }
        #endregion

        #region Propiedades
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<TiposDoc> TipoDoc { get; set; }
        public Nullable<int> NumeroDoc { get; set; }
        public Nullable<DateTime> FechaNac { get; set; }
        public Nullable<GruposSanguineos> GrupoSanguineo { get; set; }
        public Nullable<FactoresSanguineos> Factor { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Problemas { get; set; }
        public string Notas { get; set; }

        //coleccion de Afiliados (obra social + nro de afiliado -Id-)
        public Business.Entities.Afiliados Afiliados { get; set; }
     

        //las obras sociales solo se utilizan para brindar informacion adicional al Médico, por lo tanto simplemente se listan
        //public string ObrasSociales { get; set; }

        #endregion

        #region Constructores

        public Paciente()
        {
            this.Inicializar();
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Inicializa la entidad a los valores por defecto 
        /// </summary>
        public void Inicializar()
        {
            this.Nombre = "" ;
            this.Apellido = "";
            this.TipoDoc = null;
            this.NumeroDoc= null ;
            this.FechaNac = null;
            this.GrupoSanguineo = null;
            this.Factor = null;
            this.Domicilio= "" ;
            this.Telefono= "" ;
            this.Celular= "" ;
            this.Email= "" ;
            this.Problemas= "" ;
            this.Notas= "" ;
            this.Afiliados = null;

        }
        #endregion
    }
}
