using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL {
    public class RedPackBLL {

        #region Singleton

        private static volatile RedPackBLL instance = null;
        private static readonly object padlock = new object();
        public RedPackDAL redPackDAL = RedPackDAL.Instance();

        private RedPackBLL() {

        }

        public static RedPackBLL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new RedPackBLL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public bool Add(RedPack redPack) {
            return redPackDAL.Add(redPack) > 0;
        }

        public bool Remove(RedPack redPack) {
            return redPackDAL.Remove(redPack) > 0;
        }

        public bool Update(RedPack redPack) {
            return redPackDAL.Update(redPack) > 0;
        }

        public RedPacks GetAll() {
            return redPackDAL.GetAll();
        }

        public RedPack GetByID(RedPack redPack) {
            return redPackDAL.GetByID(redPack);
        }

        public RedPack GetByIDTopologia(RedPack redPack) {
            return redPackDAL.GetByIDTopologia(redPack);
        }

    }
}
