namespace Entidades
{
    public interface ISerializarJson
    {
        bool Serializar(string path);
        bool Deserializar(string path, out Usuario datos);

    }
}