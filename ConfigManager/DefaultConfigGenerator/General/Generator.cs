using System.Text;

namespace DefaultConfigGenerator.General
{
    abstract class Generator
    {
        public abstract StringBuilder Generate(string pathEmpty, string pathFull);
    }
}
