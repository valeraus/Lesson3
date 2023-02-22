using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ вiдредаговано");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматi, збереження в iнших форматах є у версiї Експерт");
        }
    }
}
