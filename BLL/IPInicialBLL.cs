using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL {
    public class IPInicialBLL {

        #region Singleton

        private static volatile IPInicialBLL instance = null;
        private static readonly object padlock = new object();
        public IPInicialDAL iPInicialDAL = IPInicialDAL.Instance();

        private IPInicialBLL() {

        }

        public static IPInicialBLL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new IPInicialBLL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public bool Add(IPInicial iPInicial) {
            return iPInicialDAL.Add(iPInicial) > 0;
        }

        public bool Remove(IPInicial iPInicial) {
            return iPInicialDAL.Remove(iPInicial) > 0;
        }

        public bool Update(IPInicial iPInicial) {
            return iPInicialDAL.Update(iPInicial) > 0;
        }

        public IPIniciales GetAll() {
            return iPInicialDAL.GetAll();
        }

        public IPInicial GetByID(IPInicial iPInicial) {
            return iPInicialDAL.GetByID(iPInicial);
        }

        public IPIniciales GetByPack(IPInicial iPInicial) {
            return iPInicialDAL.GetByPack(iPInicial);
        }
    }
}
