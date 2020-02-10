using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishyNotes
{
    class NoteData : INotes, INoteText
    {
        private IDictionary<Guid, String> _noteText = new Dictionary<Guid, String>();
        

        public void AddNote(Guid pID)
        {
            _noteText.Add(pID, "");
        }

        public void RemoveNote(Guid pID)
        {
            _noteText.Remove(pID);
        }

        public void ReplaceNoteText(Guid pID, String pNewText)
        {
            _noteText[pID] = pNewText;
        }

        public string RetrieveNoteText(Guid pID)
        {
            String NoteText = ""; 

            if (_noteText.Keys.Contains(pID))
            {
                NoteText = _noteText[pID];
            }

            return NoteText;
        }
    }
}
