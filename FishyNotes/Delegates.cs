using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishyNotes
{
   
    public delegate void DeleteNoteDelegate(Guid pID);

    public delegate void AddNoteDelegate(Guid Key);


    public delegate void ReplaceTextDelegate(Guid key, String Text);

    public delegate String RetrieveTextDelegate(Guid key);

    



        




    
}
