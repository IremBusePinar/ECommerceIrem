using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common
{
    public class ImageUploader
    {
        /*
         0=> dosya boş
         1=> "bu görsel daha önce eklenmiş"
         2=> "uymayan bir format"
         3=> "başarılı"
         */



        public static string UploadImage(string serverPath, HttpPostedFileBase file )//nikeAyakkabi.1.new.png
        {
            var fileName = "";
            if (file != null)
            {
                
                var uniqueName = Guid.NewGuid();
                serverPath = serverPath.Replace("~", "");
                var fileArray = file.FileName.Split('.');
                //[0]=nikeAyakkabi
                //[1]=1
                //[2]=new
                //[3]=png
                string extension = fileArray[fileArray.Length - 1];
                fileName = uniqueName + "." + extension;

                if (extension == "png" || extension == "jpg" || extension == "jpeg" || extension == "gif")
                {


                    if (File.Exists(HttpContext.Current.Server.MapPath(serverPath + fileName)))
                    {
                        return "1";
                    }
                    else
                    {
                        try
                        {
                            var filePath = HttpContext.Current.Server.MapPath(serverPath +"\\"+ fileName);
                            file.SaveAs(filePath);
                            return fileName;
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                    }
                }
                else
                {
                    return "2";
                }


            }
            else
            {
                return "0";
            }

        }
    }
}
