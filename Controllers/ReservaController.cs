﻿using PSI_DA_PL1_F.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_DA_PL1_F.Controllers
{
    internal class ReservaController
    {
        public ReservaController() 
        {

        
        }

        public List<Prato> GetPratos()
        {
            using (var db = new CantinaContext())
            {
                return db.Pratos.Where(p => p.Ativo).ToList();
            }
        }

        
        public List<Extra> GetExtras()
        {
            using (var db = new CantinaContext())
            {
                return db.Extras.ToList();
            }
        }
    }
}