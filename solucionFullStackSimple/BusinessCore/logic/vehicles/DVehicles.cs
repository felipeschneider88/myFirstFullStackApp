using BusinessCore.value_objects;
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

        //TODO: Need to add the Connegtion manager
        //TODO: See if going with the Abstrac Factory or for now go directly to a SQL Connection and after make the refactoring
        public bool Member(iConn conn, VOVheicle auxVheicle)
        {
            bool existe = false;
            if (Find(conn, auxVheicle) != null)
                existe = true;
            return existe;
        }

        public Vehicle Find(iConn conn, VOVheicle auxVheicle )
        {
            Vehicle reponse = null;

            return response;
        }
    }
}
