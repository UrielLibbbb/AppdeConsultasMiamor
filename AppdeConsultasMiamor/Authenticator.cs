using System.Collections.Generic;

namespace AppdeConsultasMiamor
{
    public class Authenticator
    {
        private Dictionary<string, string> usuarios = new Dictionary<string, string>
        {
            { "Uriel", "Vanessa1" },
            { "Vanessa", "Uriel1" }
        };

        public bool AutenticarUsuario(string usuario, string contraseña)
        {
            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == contraseña)
            {
                return true;
            }
            return false;
        }
    }
}
