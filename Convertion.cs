using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace MATTINE_BOARD
{
    public partial class Convertion : System.Web.UI.Page
    {
    		public string GetImage(object ImageFromDataBase)
        {
            string ImagePath = "http://i.imgbox.com/8TtwNb87.png";
            if (!Convert.IsDBNull(ImageFromDataBase))
            {
                Byte[] ImageStrem = (Byte[])ImageFromDataBase;
                if (ImageStrem != null)
                {
                    string base64String = Convert.ToBase64String(ImageStrem, 0, ImageStrem.Length);
                    ImagePath = "data:image/jpeg;base64," + base64String;
                }
            }
            return ImagePath;
        }
    }
}
