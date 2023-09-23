using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL {
    public class EmpresaBLL {

        #region Singleton

        private static volatile EmpresaBLL instance = null;
        private static readonly object padlock = new object();
        public EmpresaDAL empresaDAL = EmpresaDAL.Instance();

        private EmpresaBLL() {

        }

        public static EmpresaBLL Instance() {
            if (instance == null) {
                lock(padlock) {
                    if (instance == null) {
                        instance = new EmpresaBLL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public bool Add(Empresa empresa) {
            return empresaDAL.Add(empresa) > 0;
        }

        public bool Remove(Empresa empresa) {
            return empresaDAL.Remove(empresa) > 0;
        }

        public bool Update(Empresa empresa) {
            return empresaDAL.Update(empresa) > 0;
        }

        public Empresas GetAll() {
            return empresaDAL.GetAll();
        }

        public Empresa GetByID(Empresa empresa) {
            return empresaDAL.GetByID(empresa);
        }

        public bool RemoveAll(Empresa empresa) {
            return empresaDAL.RemoveAll(empresa) > 0;
        }
    }

    

}
