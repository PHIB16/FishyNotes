using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyNotes
{
    interface INoteText
    {
        string RetrieveNoteText(Guid ID);
        void ReplaceNoteText(Guid ID, String pNewText);
    }
}
