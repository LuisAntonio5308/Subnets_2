using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public class TopologiaBLL {

        #region Singleton

        private static volatile TopologiaBLL instance = null;
        private static readonly object padlock = new object();
        public TopologiaDAL topologiaDAL = TopologiaDAL.Instance();

        private TopologiaBLL() {

        }

        public static TopologiaBLL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new TopologiaBLL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public bool Add(Topologia topologia) {
            return topologiaDAL.Add(topologia) > 0;
        }

        public bool Remove(Topologia topologia) {
            return topologiaDAL.Remove(topologia) > 0;
        }

        public bool Update(Topologia topologia) {
            return topologiaDAL.Update(topologia) > 0;
        }

        public bool RemoveAll(Topologia topologia) {
            return topologiaDAL.RemoveAll(topologia) > 0;
        }

        public Topologias GetAll() {
            return topologiaDAL.GetAll();
        }

        public Topologia GetByID(Topologia topologia) {
            return topologiaDAL.GetByID(topologia);
        }

        public Topologia GetByNombre(Topologia topologia) {
            return topologiaDAL.GetByNombre(topologia);
        }

        public Topologias GetByEmpresa(Empresa empresa) {
            return topologiaDAL.GetByEmpresa(empresa);
        }

        
    }
}
