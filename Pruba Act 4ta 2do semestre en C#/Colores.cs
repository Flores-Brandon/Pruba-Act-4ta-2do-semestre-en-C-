using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruba_Act_4ta_2do_semestre_en_C_

    {
        public abstract class Colores
        {
            public abstract void SeleccionarColor();
        }

        public class Azul : Colores, Icolores
        {
            public override void SeleccionarColor()
            {
                MessageBox.Show("Has seleccionado el color azul");
            }

            public void Elejir()
            {
                MessageBox.Show("Que bello color!!");
            }
        }

        public class Rojo : Colores, Icolores
        {
            public override void SeleccionarColor()
            {
                MessageBox.Show("Has seleccionado el color Rojo");
            }

            public void Elejir()
            {
                MessageBox.Show("Que bello color!!");
            }
        }

        public interface Icolores
        {
            void Elejir();
        }
    }

