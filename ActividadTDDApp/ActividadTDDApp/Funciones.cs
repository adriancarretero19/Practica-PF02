namespace ActividadTDDApp
{
    public class Funciones
    {
        public bool EsContrasenyaValida(string contrasenya)
        {
            for (int i = 0; i < contrasenya.Length; i++)
            {
                if (contrasenya[i] == '#')
                    break;
                if (i == contrasenya.Length - 1)
                    return false;
            }
            return !string.IsNullOrEmpty(contrasenya) && contrasenya.Length >= 8;
        }
    }
}
