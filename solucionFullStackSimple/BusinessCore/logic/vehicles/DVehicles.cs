using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessCore.logic.vehicles
{
    class DVehicles
    {
        private Dictionary<Guid, Vehicle> vheicles;

        public DVehicles()
        {
            vheicles = new Dictionary<Guid, Vehicle>();
        }

        public bool Member(iConn conn, )
        {
            bool existe = false;
            if (Find(conn, VOIntegrante) != null)
                existe = true;
            return existe;
        }

        public Vehicle Find(iConn conn, )
        {
            Vehicle reponse = null;
        }
    }
}
