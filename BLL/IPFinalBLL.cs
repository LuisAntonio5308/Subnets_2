using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL {
    public class IPFinalBLL {

        #region Singleton

        private static volatile IPFinalBLL instance = null;
        private static readonly object padlock = new object();
        public IPFinalDAL iPFinalDAL = IPFinalDAL.Instance();

        private IPFinalBLL() {

        }

        public static IPFinalBLL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new IPFinalBLL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public bool Add(IPFinal iPFinal) {
            return iPFinalDAL.Add(iPFinal) > 0;
        }

        public bool Remove(IPFinal iPFinal) {
            return iPFinalDAL.Remove(iPFinal) > 0;
        }

        public bool Update(IPFinal iPFinal) {
            return iPFinalDAL.Update(iPFinal) > 0;
        }

        public IPFinales GetAll() {
            return iPFinalDAL.GetAll();
        }

        public IPFinal GetByID(IPFinal iPFinal) {
            return iPFinalDAL.GetByID(iPFinal);
        }

        public IPFinales GetByPack(IPFinal iPFinal) {
            return iPFinalDAL.GetByPack(iPFinal);
        }
    }
}
