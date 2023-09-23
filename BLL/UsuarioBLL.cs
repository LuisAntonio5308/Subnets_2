using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL {
    public class UsuarioBLL {

        #region Singleton

        private static volatile UsuarioBLL instance = null;
        private static readonly object padlock = new object();
        public UsuarioDAL usuarioDAL = UsuarioDAL.Instance();

        private UsuarioBLL() {

        }

        public static UsuarioBLL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new UsuarioBLL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public bool Add(Usuario usuario) {
            return usuarioDAL.Add(usuario) > 0;
        }

        public bool Remove(Usuario usuario) {
            return usuarioDAL.Remove(usuario) > 0;
        }

        public bool Update(Usuario usuario) {
            return usuarioDAL.Update(usuario) > 0;
        }

        public Usuarios GetAll() {
            return usuarioDAL.GetAll();
        }

        public Usuario GetByID(Usuario usuario) {
            return usuarioDAL.GetByID(usuario);
        }

        public bool Login(Usuario usuario) {
            return usuarioDAL.Login(usuario);
        }

        public Usuario GetByNickname(Usuario usuario) { 
            return usuarioDAL.GetByNickname(usuario);
        }


    }
}
