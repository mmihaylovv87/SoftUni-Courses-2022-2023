using System.Collections.Generic;

namespace _07._Military_Elite.Interfaces
{
    public interface ILieutenantGeneral : IPrivate
    {
        public List<IPrivate> Privates { get; set; }
    }
}