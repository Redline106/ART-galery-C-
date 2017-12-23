using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGI;

namespace GalerieArtSGIWin { 
   public class EventListner
    {
        private Conservateur cons;

        public EventListner(Conservateur strcons)
        {
            cons= strcons;
            
            cons.Changed += CommissionChangeé;
        }

        public void CommissionChangeé(object o, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(" Event  commission change");
        }
        public void detacher()
        {
            cons.Changed-= new ComissionPayeHandler(CommissionChangeé);
            cons = null;
        }

    }
}
