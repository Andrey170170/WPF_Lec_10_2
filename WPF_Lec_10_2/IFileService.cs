using System.Collections.Generic;

namespace WPF_Lec_10_2;

public interface IFileService
{
    List<Phone> Open(string filename);
    void Save(string filename, List<Phone> phonesList);
}