using System;

namespace Asp_.NetCore.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Dirección { get; set; }

        public ObjetoEscuelaBase()
        {
            
        }

        public override string ToString()
        {
            return $"{Nombre},{Id},{Dirección}";
        }
    }
}