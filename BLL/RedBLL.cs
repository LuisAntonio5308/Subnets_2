using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL {
    public class RedBLL {

        #region Singleton

        private static volatile RedBLL instance = null;
        private static readonly object padlock = new object();
        public RedDAL redDAL = RedDAL.Instance();

        private RedBLL() {

        }

        public static RedBLL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new RedBLL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public bool Add(Red red) {
            return redDAL.Add(red) > 0;
        }

        public bool Remove(Red red) {
            return redDAL.Remove(red) > 0;
        }

        public bool Update(Red red) {
            return redDAL.Update(red) > 0;
        }

        public Redes GetAll() {
            return redDAL.GetAll();
        }

        public Red GetByID(Red red) {
            return redDAL.GetByID(red);
        }

        public Redes GetByPack(Red red) {
            return redDAL.GetByPack(red);
        }

    }
}
