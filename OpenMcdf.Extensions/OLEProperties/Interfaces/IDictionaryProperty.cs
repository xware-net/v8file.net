using System.IO;

namespace OpenMcdf.Extensions.OLEProperties.Interfaces
{
    public interface IDictionaryProperty : IProperty
    {
        new void Read(BinaryReader br);
        new void Write(BinaryWriter bw);
    }
}