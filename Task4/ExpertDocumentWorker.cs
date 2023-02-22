using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class ExpertDocumentWorker :ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений у новому форматi");
        }
    }
}
