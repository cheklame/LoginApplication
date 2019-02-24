using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApp
{
    public interface ILocalFileHelper
    {
        string GetLocalPath(string path);
    }
}
