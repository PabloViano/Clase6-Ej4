using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Ascensor
    {
        public int Piso = 0;
        public EventHandler<AscensorEventArgs> pisoNuevoAsignado;
        public void DefinirPiso(int pisoNuevo)
        {
            if (pisoNuevo > this.Piso)
            {
                while (this.Piso != pisoNuevo) { this.subirPiso(); Thread.Sleep(1000); }
            }
            else
            {
                while (this.Piso != pisoNuevo) { this.bajarPiso(); Thread.Sleep(1000); }
            }
        }
        private void subirPiso()
        {
            this.Piso = this.Piso + 1;
            if (pisoNuevoAsignado != null)
            {
                this.pisoNuevoAsignado(this, new AscensorEventArgs { Piso = this.Piso });
            }
        }
        private void bajarPiso()
        {
            this.Piso = this.Piso - 1;
            if (pisoNuevoAsignado != null)
            {
                this.pisoNuevoAsignado(this, new AscensorEventArgs { Piso = this.Piso });
            }
        }
        public void LlamarAscensor(int pisoActual)
        {
            if (pisoActual > this.Piso)
            {
                while (this.Piso != pisoActual) { this.subirPiso(); Thread.Sleep(1000); }
            }
            else
            {
                while (this.Piso != pisoActual) { this.bajarPiso(); Thread.Sleep(1000); }
            }
        }
    }
}
