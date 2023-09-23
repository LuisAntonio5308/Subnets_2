using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public class MascaraBLL {

        #region Singleton

        private static volatile MascaraBLL instance = null;
        private static readonly object padlock = new object();
        public MascaraDAL mascaraDAL = MascaraDAL.Instance();

        private MascaraBLL() {

        }

        public static MascaraBLL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new MascaraBLL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public bool Add(Mascara mascara) {
            return mascaraDAL.Add(mascara) > 0;
        }

        public bool Remove(Mascara mascara) {
            return mascaraDAL.Remove(mascara) > 0;
        }

        public bool Update(Mascara mascara) {
            return mascaraDAL.Update(mascara) > 0;
        }

        public Mascaras GetAll() {
            return mascaraDAL.GetAll();
        }

        public Mascara GetByID(Mascara mascara) {
            return mascaraDAL.GetByID(mascara);
        }

        public Mascaras GetByPack(Mascara mascara) {
            return mascaraDAL.GetByPack(mascara);
        }

    }
}
