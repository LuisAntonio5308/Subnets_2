using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL {
    public class IPBroadcastBLL {

        #region Singleton

        private static volatile IPBroadcastBLL instance = null;
        private static readonly object padlock = new object();
        public IPBroadcastDAL iPBroadcastDAL = IPBroadcastDAL.Instance();

        private IPBroadcastBLL() {

        }

        public static IPBroadcastBLL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new IPBroadcastBLL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public bool Add(IPBroadcast iPBroadcast) {
            return iPBroadcastDAL.Add(iPBroadcast) > 0;
        }

        public bool Remove(IPBroadcast iPBroadcast) {
            return iPBroadcastDAL.Remove(iPBroadcast) > 0;
        }

        public bool Update(IPBroadcast iPBroadcast) {
            return iPBroadcastDAL.Update(iPBroadcast) > 0;
        }

        public IPBroadcasts GetAll() {
            return iPBroadcastDAL.GetAll();
        }

        public IPBroadcast GetByID(IPBroadcast iPBroadcast) {
            return iPBroadcastDAL.GetByID(iPBroadcast);
        }

        public IPBroadcasts GetByPack(IPBroadcast iPBroadcast) {
            return iPBroadcastDAL.GetByPack(iPBroadcast);
        }
    }
}
